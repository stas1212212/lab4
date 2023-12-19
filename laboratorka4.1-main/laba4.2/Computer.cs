// Базовий клас Комп'ютер
public class Computer : IConnectable
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }

    public void Connect(IConnectable device)
    {
        Console.WriteLine($"Connected to {((Computer)device).IPAddress}");
    }

    public void Disconnect(IConnectable device)
    {
        Console.WriteLine($"Disconnected from {((Computer)device).IPAddress}");
    }

    public void TransferData(IConnectable device, string data)
    {
        Console.WriteLine($"Transferred data to {((Computer)device).IPAddress}: {data}");
    }
}