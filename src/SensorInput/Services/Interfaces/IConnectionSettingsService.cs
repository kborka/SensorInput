using SensorInput.Enums;
using SensorInput.Models.Interfaces;

namespace SensorInput.Services.Interfaces;
public interface IConnectionSettingsService
{
    UploadConnectionType UploadConnectionType { get; }

    IDataUploadConnectionInfo DataUploadConnectionInfo { get; }
}
