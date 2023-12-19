// Клас Мережа
public class Network
{
    public void SimulateNetworkInteraction(IConnectable device1, IConnectable device2, string data)
    {
        device1.Connect(device2);
        device1.TransferData(device2, data);
        device1.Disconnect(device2);
    }
}