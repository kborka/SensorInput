using Avalonia.Controls;
using Avalonia.Controls.Templates;
using SensorInput.ViewModels;
using System;

namespace SensorInput;
public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is null) { return new TextBlock { Text = $"Null Param given." }; }

        var name = param.GetType().FullName!.Replace("ViewModel", "View");
        var type = Type.GetType(name);

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }
        else
        {
            return new TextBlock { Text = "Not Found: " + name };
        }
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
