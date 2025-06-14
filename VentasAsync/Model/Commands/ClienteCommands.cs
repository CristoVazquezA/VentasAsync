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
        public async Task<List<Cliente>> GetClientesAsync()
        {
            try
            {
                string query = "SELECT * FROM Clientes";
                // Utilizamos la clase SQLServer para ejecutar la consulta y obtener el resultado
                SQLServer sqlServer = new SQLServer();
                List<Cliente> clientes = await sqlServer.ReaderListAsync<Cliente>(query);
                return clientes;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<int> AddClienteAsync(Cliente cliente)
        {
            try
            {
                string query = "INSERT INTO Clientes (Nombre, Telefono, Domicilio) " +
                               "VALUES (@Nombre, @Telefono, @Domicilio); " +
                               "SELECT SCOPE_IDENTITY();";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", cliente.Nombre),
                    new SqlParameter("@Telefono", cliente.Telefono),
                    new SqlParameter("@Domicilio", cliente.Domicilio)
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

        public async Task<Cliente> UpdateClienteAsync(int id)
        {
            try
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Telefono = @Telefono, Domicilio = @Domicilio " +
                               "WHERE Id = @Id";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Nombre", "Jorge"),
                    new SqlParameter("@Telefono", "987654321"),
                    new SqlParameter("@Domicilio", "Calle 456")
                };
                SQLServer sqlServer = new SQLServer();
                await sqlServer.NonQueryAsync(query, parametros);
                return await GetClienteAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Cliente> DeleteClienteAsync(int id)
        {
            try
            {
                string query = "DELETE FROM Clientes WHERE Id = @Id";
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
