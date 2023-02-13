namespace SensorInput.Services.Interfaces;

public interface IApplicationSettingsService
{
    public IConnectionSettingsService ConnectionSettingsService { get; }
    void SaveSettings();
}
