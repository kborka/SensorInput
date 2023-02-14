using Avalonia.ReactiveUI;
using ReactiveUI;
using SensorInput.ViewModels;
using SensorInput.ViewModels.Interfaces;
using System.Threading.Tasks;

namespace SensorInput.Views;
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        this.WhenActivated(d => d(ViewModel!.ShowDataConnectionDialog.RegisterHandler(DoShowDataConnectionDialogAsync)));
    }

    private async Task DoShowDataConnectionDialogAsync(InteractionContext<IDataUplaodConnectionDialogViewModel, IDataUploadConnectionInfoViewModel?> interaction)
    {
        var dialog = new DataUploadConnectionDialogView();
        dialog.DataContext = interaction.Input;

        var result = await dialog.ShowDialog<IDataUploadConnectionInfoViewModel>(this);
        interaction.SetOutput(result);
    }
}
