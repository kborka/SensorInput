using SensorInput.Models.Interfaces;
using SensorInput.ViewModels.Interfaces;
using System;

namespace SensorInput.ViewModels;
public abstract class DataUploadConnectionInfoViewModel : ViewModelBase, IDataUploadConnectionInfoViewModel
{
    public IDataUploadConnectionInfo DatabaseConnectionInfo { get; }

    public DataUploadConnectionInfoViewModel(IDataUploadConnectionInfo connectionInfo)
    {
        DatabaseConnectionInfo = connectionInfo;
    }

    public static IDataUploadConnectionInfoViewModel Create(IDataUploadConnectionInfo dataUploadConnectionInfo)
        => dataUploadConnectionInfo switch
        {
            IPostgresConnectionInfo postgres => new PostgresConnectionInfoViewModel(postgres),
            _ => throw new ArgumentOutOfRangeException($"Unknown connection type {dataUploadConnectionInfo.GetType()}")
        };
}
