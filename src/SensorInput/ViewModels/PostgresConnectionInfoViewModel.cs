using SensorInput.Models.Interfaces;
using SensorInput.ViewModels.Interfaces;

namespace SensorInput.ViewModels;
public sealed class PostgresConnectionInfoViewModel : DataUploadConnectionInfoViewModel, IPostgresConnectionInfoViewModel
{
    public string Host { get; set; }
    public string Database { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public PostgresConnectionInfoViewModel(IPostgresConnectionInfo dbConnectionInfo) : base(dbConnectionInfo)
    {
        Host = dbConnectionInfo.Host;
        Database = dbConnectionInfo.Database;
        Username = dbConnectionInfo.Username;
        Password = dbConnectionInfo.Password;
    }
}
