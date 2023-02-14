using SensorInput.Enums;
using SensorInput.Models.Interfaces;
using System.Collections.Generic;

namespace SensorInput.Services.Interfaces;

public interface IApplicationSettingsService
{
    public UploadConnectionType PreferredConnectionType { get; set; }
    
    public Dictionary<UploadConnectionType, IDataUploadConnectionInfo> ConnectionSettingsServices { get; }

    void SaveSettings();
}
