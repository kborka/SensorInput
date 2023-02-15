using SensorInput.Services.Interfaces;
using SensorInput.ViewModels.Interfaces;

namespace SensorInput.ViewModels;
public class DataUploadConnectionDialogViewModel : ViewModelBase, IDataUploadConnectionDialogViewModel
{
    public IDataUploadConnectionInfoViewModel DataUploadConnectionInfo { get; } = null!;

    public DataUploadConnectionDialogViewModel(IApplicationSettingsService applicationSettings)
    {
        this.DataUploadConnectionInfo = DataUploadConnectionInfoViewModel.Create(applicationSettings.ConnectionSettingsServices[applicationSettings.PreferredConnectionType]);
    }
}
