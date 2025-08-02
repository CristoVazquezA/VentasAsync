using Microsoft.Data.SqlClient;
using VentasAsync.Model.DataBase;
using VentasAsync.Model.Entities;

namespace VentasAsync.Model.Commands
{
    internal class VentaCommands
    {
        public async Task<Venta> GetVentaAsync(int id, bool incluirConceptos = false)
        {
            try
            {
                string query = "SELECT * FROM Ventas WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                var venta = await sqlServer.ReaderAsync<Venta>(query, parametros);
                if (venta != null && incluirConceptos)
                {
                    // Obtenemos los detalles de la venta
                    VentaDetalleCommands detalleCommands = new VentaDetalleCommands();
                    venta.Conceptos = await detalleCommands.GetVentasDetalleAsync(venta.Id);
                }
                return venta;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Venta>> GetVentasAsync()
        {
            try
            {
                string query = "SELECT * FROM Ventas";
                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                List<Venta> ventas = await sqlServer.ReaderListAsync<Venta>(query);
                return ventas;
            }
            catch (Exception)
            {

                throw;
            }

        }
        private async Task<int> AddVentaAsync(Venta venta)
        {
            try
            {
                string query = "INSERT INTO Ventas (Fecha, Folio, Total, ClienteId) " +
                               "VALUES (GetDate(), @Folio, @Total, @ClienteId); " +
                               "SELECT CAST (SCOPE_IDENTITY() AS INT);";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Folio", venta.Folio),
                    new SqlParameter("@Total", venta.Total),
                    new SqlParameter("@ClienteId", venta.ClienteID)
                };
                SQLServer sqlServer = new SQLServer();
                int nuevoId = await sqlServer.ScalarAsync<int>(query, parametros);
                return nuevoId;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task SaveVentaAsync(Venta venta)
        {
            try
            {
                int ventaId = await AddVentaAsync(venta);

                foreach (var concepto in venta.Conceptos)
                {
                    VentaDetalleCommands detalleCommands = new VentaDetalleCommands();
                    await detalleCommands.AddVentaDetalleAsync(concepto, ventaId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Venta> UpdateVentaAsync(int id)
        {
            try
            {
                string query = "UPDATE Ventas SET Fecha = @Fecha, Folio = @Folio, Total = @Total, ClienteId = @ClienteId " +
                               "WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Fecha", "20/06/2025"),
                    new SqlParameter("@Folio", "5"),
                    new SqlParameter("@Total", "23.50"),
                    new SqlParameter("@ClienteId", "3")
                };
                SQLServer sqlServer = new SQLServer();
                await sqlServer.NonQueryAsync(query, parametros);
                return await GetVentaAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Venta> DeleteVentaAsync(int id)
        {
            try
            {
                string query = "DELETE FROM Ventas WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                SQLServer sqlServer = new SQLServer();
                await sqlServer.NonQueryAsync(query, parametros);
                return null; // Retornamos null ya que el cliente ha sido eliminado
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
