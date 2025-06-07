using Microsoft.Data.SqlClient;
using VentasAsync.Model.DataBase;
using VentasAsync.Model.Entities;

namespace VentasAsync.Model.Commands
{
    internal class ClienteCommands
    {
        public async Task<Cliente> GetClienteAsync(int id)
        {
            try
            {
                string query = "SELECT * FROM Clientes WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                return await sqlServer.ReaderAsync<Cliente>(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
