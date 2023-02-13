using SensorInput.Models.Interfaces;

namespace SensorInput.Models;
public sealed class PostgresConnectionInfo : DataUploadConnectionInfo, IPostgresConnectionInfo
{
    public override string ConnectionString => $"Host={Host};Username={Username};Database={Database};Password={Password}";

    public string Host { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Database { get; set; } = null!;

    public string Password { get; set; } = null!;

    public PostgresConnectionInfo() { }

    public PostgresConnectionInfo(string host, string username, string database, string password)
    {
        Host = host;
        Username = username;
        Database = database;
        Password = password;
    }
}
