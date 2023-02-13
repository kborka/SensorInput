using System;

namespace SensorInput.Models;
internal class SensorData
{
    public DateTime Time { get; set; } = default;

    public string Location { get; set; } = string.Empty;

    public double Temperature { get; set; } = default;

    public double Humidity { get; set; } = default;

    public double Gas { get; set; } = default;

    public double Pressure { get; set; } = default;

    public double AirQuality { get; set; } = default;
}
