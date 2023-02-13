using Avalonia.Controls;
using SensorInput.ViewModels.Interfaces;

namespace SensorInput.Views;
public partial class DbConnectionDialogView : Window
{
    public DbConnectionDialogView(IDataUplaodConnectionDialogViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}
