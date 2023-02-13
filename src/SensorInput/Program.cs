using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using SensorInput.DependencyInjection;
using SensorInput.Models;
using SensorInput.Models.Interfaces;
using SensorInput.ViewModels;
using SensorInput.ViewModels.Interfaces;
using Splat;
using System;

namespace SensorInput;
internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        RegisterDependencies();
        BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .UseReactiveUI();

    private static void RegisterDependencies()
    {
        //Locator.CurrentMutable.RegisterConstant(() => new )
    }
}
