using SensorInput.Services.Interfaces;
using SensorInput.ViewModels.Interfaces;

namespace SensorInput.ViewModels;
public class DataUploadConnectionDialogViewModel : ViewModelBase, IDataUplaodConnectionDialogViewModel
{
    public IDataUploadConnectionInfoViewModel DatabaseConnectionInfo { get; }

    public DataUploadConnectionDialogViewModel(IApplicationSettingsService applicationSettings)
    {
        this.DatabaseConnectionInfo = DataUploadConnectionInfoViewModel.Create(applicationSettings.ConnectionSettingsService.DataUploadConnectionInfo);
    }
}
