// Клас рослини
public class Plant : LivingOrganism, IReproducible
{
    public Plant(int energy, int age, int size)
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
        Console.WriteLine("Plant is reproducing");
    }
}