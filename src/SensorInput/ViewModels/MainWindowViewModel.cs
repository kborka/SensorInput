using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using SensorInput.DependencyInjection;
using SensorInput.ViewModels.Interfaces;
using SensorInput.Views;
using Splat;
using System.Windows.Input;

namespace SensorInput.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
    public ICommand NewInputCommand { get;}

    public ICommand OpenDbConnectionDialogCommand { get;}

    public MainWindowViewModel()
    {
        NewInputCommand = ReactiveCommand.Create(CreateNewInputItem);
        OpenDbConnectionDialogCommand = ReactiveCommand.Create(OpenDbConnectionDialog);
    }

    private void CreateNewInputItem()
    {

    }

    private void OpenDbConnectionDialog()
    {
        var dialog = new DbConnectionDialogView(Locator.Current.GetServiceSafe<IDataUplaodConnectionDialogViewModel>());
        if (Avalonia.Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop
            && desktop.MainWindow is not null)
        {
            dialog.ShowDialog(desktop.MainWindow);
        }
    }
}
