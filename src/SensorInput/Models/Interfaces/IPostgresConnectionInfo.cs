namespace SensorInput.Models.Interfaces;
public interface IPostgresConnectionInfo : IDataUploadConnectionInfo
{
    string Host { get; set; }

    string Username { get; set; }

    string Database { get; set; }

    string Password { get; set; }
}
