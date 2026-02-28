

public class Lock : IDevice
{
    private bool _isOn;
    private bool _isLocked;

    public string Name { get; set; }
    public string PinCode { get; private set; }

    public Lock(string name, string pinCode)
    {
        Name = name;
        PinCode = pinCode;
        _isLocked = true; // usually starts locked
        _isOn = false;
    }

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"{Name} lock system is turned ON.");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine($"{Name} lock system is turned OFF.");
    }

    public void LockDoor()
    {
        _isLocked = true;
        Console.WriteLine($"{Name} is now LOCKED.");
    }

    public void UnlockDoor(string pinCode)
    {
        if (!_isOn)
        {
            Console.WriteLine($"{Name} lock system is OFF. Turn it on first.");
            return;
        }

        if (pinCode == PinCode)
        {
            _isLocked = false;
            Console.WriteLine($"{Name} is now UNLOCKED.");
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Door remains locked.");
        }
    }

    public void ChangePin(string oldPin, string newPin)
    {
        if (oldPin != PinCode)
        {
            Console.WriteLine("Incorrect current PIN. PIN was not changed.");
            return;
        }

        PinCode = newPin;
        Console.WriteLine($"{Name} PIN code changed successfully.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Lock: {Name} | Power: {(_isOn ? "On" : "Off")} | State: {(_isLocked ? "Locked" : "Unlocked")}");
    }

}
