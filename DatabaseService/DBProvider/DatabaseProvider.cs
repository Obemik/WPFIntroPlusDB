using System.Data.SqlClient;
using Dapper;
using DatabaseService.DBCommands;

namespace DatabaseService.DBProvider;

public class DatabaseProvider
{
    public string ConnectionString { get; set; }
    public DatabaseProvider(string connectionString)
    {
        ConnectionString = connectionString;
    }

    [Obsolete("Obsolete")]
    public void CreateDatabase()
    {
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var dbName = "School";
            connection.ExecuteAsync(DbCommands.CreateDBCommandWithNotExists(dbName));
        }
        catch (SqlException e)
        {
            throw new Exception(e.Message);
        }
    }
    
    
}