using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAsync.Model.DataBase
{
    internal static class SQLServerConfiguration
    {
        private static string _connectionString;
        public static string ConnectionString { 
            get 
            { 
                return _connectionString; 
            } 
        }

        public static void GetConnectionString()
        {
            string filePath = "Model\\DataBase\\ConnectionString.txt";

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("El archivo de conexión no se encontró.", filePath);
            }
            string connectionString = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión está vacía o no es válida.");
            }
            _connectionString = connectionString.Trim();
        }
    }
}
