using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorInput.Services.Interfaces;

namespace SensorInput.Services;
public class ApplicationSettingsService : IApplicationSettingsService
{
    private readonly string _settingsPath;

    public IConnectionSettingsService ConnectionSettingsService { get; private set; }

    public ApplicationSettingsService(string settingsPath)
    {
        _settingsPath = settingsPath;
    }

    public void SaveSettings()
    {

    }
}
