// Клас Маршрутизатор
public class Router : Computer
{
    public List<IConnectable> ConnectedDevices { get; set; }

    public Router()
    {
        ConnectedDevices = new List<IConnectable>();
    }

    public void Connect(IConnectable device)
    {
        base.Connect(device);
        ConnectedDevices.Add(device);
    }

    public void Disconnect(IConnectable device)
    {
        base.Disconnect(device);
        ConnectedDevices.Remove(device);
    }
}