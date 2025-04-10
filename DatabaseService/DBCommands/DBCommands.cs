namespace DatabaseService.DBCommands;

public class DbCommands
{
    public static string CreateDBCommandWithNotExists(string dbName)
    {
        return $"CREATE DATABASE IF NOT EXISTS {dbName}";
    }
}