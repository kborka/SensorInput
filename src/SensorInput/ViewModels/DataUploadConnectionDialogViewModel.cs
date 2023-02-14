using SensorInput.Services.Interfaces;
using SensorInput.ViewModels.Interfaces;

namespace SensorInput.ViewModels;
public class DataUploadConnectionDialogViewModel : ViewModelBase, IDataUplaodConnectionDialogViewModel
{
    public IDataUploadConnectionInfoViewModel DatabaseConnectionInfo { get; } = null!;

    public DataUploadConnectionDialogViewModel(IApplicationSettingsService applicationSettings)
    {
        this.DatabaseConnectionInfo = DataUploadConnectionInfoViewModel.Create(applicationSettings.ConnectionSettingsServices[applicationSettings.PreferredConnectionType]);
    }
}
