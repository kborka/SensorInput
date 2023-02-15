using ReactiveUI;
using SensorInput.DependencyInjection;
using SensorInput.ViewModels.Interfaces;
using Splat;
using System.Reactive.Linq;
using System.Windows.Input;

namespace SensorInput.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
    public ICommand NewInputCommand { get;}

    public ICommand OpenDataConnectionDialogCommand { get;}

    public Interaction<IDataUploadConnectionDialogViewModel, IDataUploadConnectionInfoViewModel?> ShowDataConnectionDialog { get; }

    public MainWindowViewModel()
    {
        ShowDataConnectionDialog = new Interaction<IDataUploadConnectionDialogViewModel, IDataUploadConnectionInfoViewModel?>();
        NewInputCommand = ReactiveCommand.Create(CreateNewInputItem);
        OpenDataConnectionDialogCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var vm = Locator.Current.GetServiceSafe<IDataUploadConnectionDialogViewModel>();
                var result = await ShowDataConnectionDialog.Handle(vm);
            });
    }

    private void CreateNewInputItem()
    {

    }
}
