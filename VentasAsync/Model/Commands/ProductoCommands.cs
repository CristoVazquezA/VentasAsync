using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasAsync.Model.DataBase;
using VentasAsync.Model.Entities;

namespace VentasAsync.Model.Commands
{
    internal class ProductoCommands
    {
        public async Task<Producto> GetProductoAsync(int id)
        {
			try
			{
				string query = "SELECT * FROM Productos Where Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
{
                    new SqlParameter("@Id", id)
};

                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                return await sqlServer.ReaderAsync<Producto>(query, parametros);

            }
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<List<Producto>> GetProductosAsync()
        {
            try
            {
                string query = "SELECT * FROM Productos";
                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                List<Producto> productos = await sqlServer.ReaderListAsync<Producto>(query);
                return productos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> AddProductoAsync (Producto producto)
        {
            try
            {
                string query = "INSERT INTO Productos (SKU, Descripcion, ValorUnitario) " +
                               "VALUES (@SKU, @Descripcion, @ValorUnitario); " +
                               "SELECT SCOPE_IDENTITY();";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@SKU", producto.SKU),
                    new SqlParameter("@Telefono", producto.Descripcion),
                    new SqlParameter("@Domicilio", producto.ValorUnitario)
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

        public async Task<Producto> UpdateProductoAsync(int id)
        {
            try
            {
                string query = "UPDATE Productos SET SKU = @SKU, Descripcion = @Descripcion, ValorUnitario = @ValorUnitario " +
                               "WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@SKU", "Prd1"),
                    new SqlParameter("@Descripcion", "Coca-cola lata"),
                    new SqlParameter("@ValorUnitario", "13.50")
                };
                SQLServer sqlServer = new SQLServer();
                await sqlServer.NonQueryAsync(query, parametros);
                return await GetProductoAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Producto> DeleteProductoAsync(int id)
        {
            try
            {
                string query = "DELETE FROM Productos WHERE Id = @Id";
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
