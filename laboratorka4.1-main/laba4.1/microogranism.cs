// Клас мікроорганізму
public class Microorganism : LivingOrganism, IReproducible
{
    public Microorganism(int energy, int age, int size)
        : base(energy, age, size)
    {
    }

    public override void Interact(LivingOrganism other)
    {
        if (other is IReproducible)
        {
            Reproduce();
        }
    }

    public void Reproduce()
    {
        Console.WriteLine("Microorganism is reproducing");
    }
}