class Program
{
    static void Main()
    {
        // Приклад використання
        Road road = new Road { Length = 10, Width = 4, NumberOfLanes = 2, TrafficLevel = 3 };

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Type = "Car", Speed = 60, Size = 2 },
            new Vehicle { Type = "Bus", Speed = 40, Size = 4 },
            new Vehicle { Type = "Truck", Speed = 50, Size = 5 }
        };

        TrafficSimulation simulation = new TrafficSimulation();
        simulation.SimulateTraffic(vehicles, road);
    }
}

