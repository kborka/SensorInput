using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using SensorInput.DependencyInjection;
using SensorInput.ViewModels.Interfaces;
using SensorInput.Views;
using Splat;
using System.Reactive.Linq;
using System.Windows.Input;

namespace SensorInput.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
    public ICommand NewInputCommand { get;}

    public ICommand OpenDataConnectionDialogCommand { get;}

    public Interaction<IDataUplaodConnectionDialogViewModel, IDataUploadConnectionInfoViewModel?> ShowDataConnectionDialog { get; }

    public MainWindowViewModel()
    {
        ShowDataConnectionDialog = new Interaction<IDataUplaodConnectionDialogViewModel, IDataUploadConnectionInfoViewModel?>();
        NewInputCommand = ReactiveCommand.Create(CreateNewInputItem);
        OpenDataConnectionDialogCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var vm = Locator.Current.GetServiceSafe<IDataUplaodConnectionDialogViewModel>();
                var result = await ShowDataConnectionDialog.Handle(vm);
            });
    }

    private void CreateNewInputItem()
    {

    }

    private void OpenDbConnectionDialog()
    {
        var dialog = new DataUploadConnectionDialogView();
        dialog.DataContext = Locator.Current.GetServiceSafe<IDataUplaodConnectionDialogViewModel>();
        if (Avalonia.Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop
            && desktop.MainWindow is not null)
        {
            dialog.ShowDialog(desktop.MainWindow);
        }
    }
}
