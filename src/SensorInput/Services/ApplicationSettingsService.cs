using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorInput.Enums;
using SensorInput.Services.Interfaces;
using SensorInput.Models;
using SensorInput.Models.Interfaces;

namespace SensorInput.Services;
public class ApplicationSettingsService : IApplicationSettingsService
{
    public UploadConnectionType PreferredConnectionType { get;set; }

    public Dictionary<UploadConnectionType, IDataUploadConnectionInfo> ConnectionSettingsServices { get; }

    public ApplicationSettingsService(IConfigurationRoot configuration)
    {
        PreferredConnectionType = configuration.GetValue<UploadConnectionType>(nameof(PreferredConnectionType));
        ConnectionSettingsServices = new();
        var connectionConfigs = configuration.GetSection("ConnectionConfigurations");
        foreach (var connection in connectionConfigs.GetChildren())
        {
            switch (connection.Key)
            {
                case nameof(UploadConnectionType.Postgres):
                    {
                        string host = connection.GetValue<string>(nameof(PostgresConnectionInfo.Host));
                        string database = connection.GetValue<string>(nameof(PostgresConnectionInfo.Database));
                        string userName = connection.GetValue<string>(nameof(PostgresConnectionInfo.Username));
                        string password = connection.GetValue<string>(nameof(PostgresConnectionInfo.Password));
                        ConnectionSettingsServices.Add(UploadConnectionType.Postgres, new PostgresConnectionInfo(host, userName, database, password));
                        break;
                    }
            }
        }
    }

    public void SaveSettings()
    {

    }
}
