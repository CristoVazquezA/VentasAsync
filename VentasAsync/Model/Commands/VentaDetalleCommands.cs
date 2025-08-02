using Microsoft.Data.SqlClient;
using VentasAsync.Model.DataBase;
using VentasAsync.Model.Entities;

namespace VentasAsync.Model.Commands
{
    internal class VentaDetalleCommands
    {
        public async Task<List<VentaDetalle>> GetVentasDetalleAsync(int ventaId)
        {
            try
            {
                string query = "SELECT * FROM VentasDetalle WHERE VentaId = @VentaId";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@VentaId", ventaId)
                };

                SQLServer sqlServer = new SQLServer();
                List<VentaDetalle> conceptos = await sqlServer.ReaderListAsync<VentaDetalle>(query, parametros);
                return conceptos;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task AddVentaDetalleAsync(VentaDetalle concepto, int ventaId)
        {
            try
            {
                string query = "INSERT INTO VentaDetalle " +
                    "(VentaId, Renglon, ProductoId, Cantidad, ValorUnitario, Descripcion, Importe) " +
                               "VALUES " +
                    "(@VentaId, @Renglon, @ProductoId, @Cantidad, @ValorUnitario, @Descripcion, @Importe);";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@VentaId", ventaId),
                    new SqlParameter("@Renglon", concepto.Renglon),
                    new SqlParameter("@ProductoId", concepto.ProductoId),
                    new SqlParameter("@Cantidad", concepto.Cantidad),
                    new SqlParameter("@ValorUnitario", concepto.ValorUnitario),
                    new SqlParameter("@Descripcion", concepto.Descripcion),
                    new SqlParameter("@Importe", concepto.Importe)
                };
                SQLServer sqlServer = new SQLServer();
                await sqlServer.NonQueryAsync(query, parametros);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
