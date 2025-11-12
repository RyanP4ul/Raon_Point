using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Data
{
    public class Database
    {

        private static Database instance = null;
        private string _connectionString;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public void Open()
        {
            var stringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "123",
                Database = "raon_point",
                Port = 9519,
                ConnectionTimeout = 30,
                Pooling = true,
                MinimumPoolSize = 3,
                MaximumPoolSize = 12,
                ConnectionLifeTime = 7200,
                CharacterSet = "utf8mb4",
                SslMode = MySqlSslMode.Disabled
            };

            _connectionString = stringBuilder.ToString();
        }

        public async Task<T> ExecuteWithConnection<T>(Func<IDbConnection, Task<T>> action)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                return await action(connection);
            }
        }

        public async Task ExecuteWithConnection(Func<IDbConnection, Task> action)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                await action(connection);
            }
        }

        public async Task ExecuteWithTransactionAsync(Func<MySqlConnection, MySqlTransaction, Task> action)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        await action(connection, transaction);

                        // CHECK IF CONNECTION IS NOT NULL BEFORE COMMIT
                        if (transaction.Connection != null)
                            await transaction.CommitAsync();
                    }
                    catch (MySqlException ex)
                    {
                        if (transaction.Connection != null)
                            await transaction.RollbackAsync();

                        Console.WriteLine(ex.Message + " | " + ex.StackTrace);
                    }
                }
            }
            
        }

    }
}
