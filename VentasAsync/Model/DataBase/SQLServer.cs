using Microsoft.Data.SqlClient;
using System.Data;

namespace VentasAsync.Model.DataBase
{
    internal class SQLServer
    {
        private readonly string _connectionString;
        public SQLServer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<T> ReaderAsync<T>(string query, SqlParameter[] parametros = null) where T : class, new()
        {
            // Implementación del método ReaderAsync
            // Aquí se debe realizar la conexión a la base de datos y ejecutar el comando SQL
            // utilizando SqlDataReader para leer los resultados y mapearlos a la entidad T.

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    await con.OpenAsync();

                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if(await reader.ReadAsync())
                    {
                        T result = new T();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var property = typeof(T).GetProperty(reader.GetName(i));
                            if (property != null && !reader.IsDBNull(i))
                            {
                                property.SetValue(result, reader.GetValue(i));
                            }
                        }
                        return result;
                    }
                }
                return null; // Si no se encontró ningún resultado, retornamos null
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> ScalarAsync<T>(string query, SqlParameter[] parametros = null)
        {
            // Implementación del método ScalarAsync
            // Aquí se debe realizar la conexión a la base de datos y ejecutar el comando SQL
            // utilizando ExecuteScalar para obtener un valor único.
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    await con.OpenAsync();
                    object result = await cmd.ExecuteScalarAsync();
                    return result != null ? (T)Convert.ChangeType(result, typeof(T)) : default;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> NonQueryAsync<T>(string query, SqlParameter[] parametros = null)
        {
            // Implementación del método NonQueryAsync
            // Aquí se debe realizar la conexión a la base de datos y ejecutar el comando SQL
            // utilizando ExecuteNonQuery para realizar operaciones que no devuelven resultados.
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    await con.OpenAsync();
                    object result = await cmd.ExecuteNonQueryAsync();
                    return result != null ? (T)Convert.ChangeType(result, typeof(T)) : default;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

