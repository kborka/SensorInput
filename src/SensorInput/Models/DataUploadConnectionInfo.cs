using SensorInput.Models.Interfaces;

namespace SensorInput.Models;
public abstract class DataUploadConnectionInfo : IDataUploadConnectionInfo
{
    public abstract string ConnectionString { get; }
}
