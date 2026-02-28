

public class Thermostat : IDevice
{
    private bool _isOn;

    public string Name { get; set; }
    public double CurrentTemperature { get; private set; }
    public double TargetTemperature { get; private set; }

    public Thermostat(string name, double currentTemperature)
    {
        Name = name;
        CurrentTemperature = currentTemperature;
        TargetTemperature = currentTemperature;
        _isOn = false;
    }

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"{Name} thermostat is turned ON.");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine($"{Name} thermostat is turned OFF.");
    }

    public void SetTargetTemperature(double temperature)
    {
        TargetTemperature = temperature;
        Console.WriteLine($"{Name} target temperature set to {TargetTemperature}°C.");
    }

    public void UpdateCurrentTemperature(double temperature)
    {
        CurrentTemperature = temperature;
        Console.WriteLine($"{Name} current temperature updated to {CurrentTemperature}°C.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Thermostat: {Name} | Power: {(_isOn ? "On" : "Off")} | Current: {CurrentTemperature}°C | Target: {TargetTemperature}°C");
    }

}
