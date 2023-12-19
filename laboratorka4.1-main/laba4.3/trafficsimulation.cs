// Клас для імітації руху та зміни руху різних транспортних засобів залежно від дороги
class TrafficSimulation
{
    public void SimulateTraffic(List<Vehicle> vehicles, Road road)
    {
        Console.WriteLine($"Simulating traffic on a road of length {road.Length} km, width {road.Width} m, with {road.NumberOfLanes} lanes, and current traffic level {road.TrafficLevel}.");

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
            // Можна додатково реалізувати зміну руху транспортних засобів в залежності від дороги та рівня трафіку
        }
    }
}