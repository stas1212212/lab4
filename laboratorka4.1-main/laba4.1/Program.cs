
class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal lion = new Animal(50, 5, 10, 15);
        Animal rabbit = new Animal(20, 2, 5, 8);
        Plant tree = new Plant(10, 10, 30);
        Microorganism bacteria = new Microorganism(5, 1, 1);

        ecosystem.SimulateInteraction(lion, rabbit);
        ecosystem.SimulateInteraction(lion, tree);
        ecosystem.SimulateInteraction(tree, bacteria);

        Console.ReadLine();
    }
}
