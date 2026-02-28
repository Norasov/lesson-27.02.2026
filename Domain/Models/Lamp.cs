

public class Lamp : IDevice
{
    private bool isOn;
    private int Brightness;

    public string? Name {get; set;}
    public string? Color {get; set;}
    public Lamp(string name, string color)
    {
        Name = name;
        Color = color;
        Brightness = 50;
        isOn = false;
    }

    public void TurnOn()
    {
        isOn = true;
        System.Console.WriteLine($"{Name} lamp is turned on.");
    }

    public void TurnOff()
    {
        isOn = false;
        System.Console.WriteLine($"{Name} lamp is turned off.");
    }
    public void SetBrightness(int value)
    {
        if(value < 0 || value > 100)
        {
            System.Console.WriteLine("Brightness must be between 0 and 100.");
            return;
        }
        Brightness = value;
        System.Console.WriteLine($"{Name} lamp brightness set to {Brightness}%");
    }

    public void ChangeColor(string color)
    {
        Color = color;
        Console.WriteLine($"{Name} lamp color changed to {Color}.");
    }
    public void ShowStatus()
    {
        Console.WriteLine($"Lamp: {Name} | Power: {(isOn ? "On" : "Off")} | Brightness: {Brightness}% | Color: {Color}");
    }
}
