using Microsoft.Data.SqlClient;
using VentasAsync.Model.Entities;

namespace VentasAsync.Model.DataBase
{
    internal class SQLServer
    {
        private readonly string _connectionString;
        public SQLServer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<T> ReaderAsync<T>(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                
            }
        }
    }
}
