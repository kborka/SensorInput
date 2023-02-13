namespace SensorInput.ViewModels.Interfaces;
internal interface IPostgresConnectionInfoViewModel : IDataUploadConnectionInfoViewModel
{
    string Host { get; set; }

    string Database { get; set; }

    string Username { get; set; }

    string Password { get; set; }

}
