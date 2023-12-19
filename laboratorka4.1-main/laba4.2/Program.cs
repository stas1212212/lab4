class Program
{
    static void Main()
    {
        Server server = new Server { IPAddress = "192.168.1.1", Power = 1000, OperatingSystem = "Windows", StorageCapacity = 5000 };
        Workstation workstation = new Workstation { IPAddress = "192.168.1.2", Power = 500, OperatingSystem = "Linux", WorkstationType = "Developer" };
        Router router = new Router { IPAddress = "192.168.1.3", Power = 200, OperatingSystem = "RouterOS" };

        Network network = new Network();
        network.SimulateNetworkInteraction(server, router, "Hello from server to router");
        network.SimulateNetworkInteraction(workstation, router, "Hi from workstation to router");
    }
}
