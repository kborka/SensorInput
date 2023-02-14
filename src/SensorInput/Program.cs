using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using SensorInput.DependencyInjection;
using SensorInput.Models;
using SensorInput.Models.Interfaces;
using SensorInput.ViewModels;
using SensorInput.ViewModels.Interfaces;
using SensorInput.Services;
using SensorInput.Services.Interfaces;
using Splat;
using System;
using System.IO;

namespace SensorInput;
internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
                      .AddJsonFile("appsettings.json")
                      .AddEnvironmentVariables()
                      .Build();
        
        Locator.CurrentMutable.RegisterConstant(new ApplicationSettingsService(config), typeof(IApplicationSettingsService));
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
        Locator.CurrentMutable.Register(() => new DataUploadConnectionDialogViewModel(
            Locator.Current.GetServiceSafe<IApplicationSettingsService>()
        ), typeof(IDataUplaodConnectionDialogViewModel));
    }
}
