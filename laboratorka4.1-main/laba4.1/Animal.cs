// Клас тварини
public class Animal : LivingOrganism, IPredator
{
    public int PredatorAbility { get; set; }

    public Animal(int energy, int age, int size, int predatorAbility)
        : base(energy, age, size)
    {
        PredatorAbility = predatorAbility;
    }

    public override void Interact(LivingOrganism other)
    {
        if (other is Animal animal && PredatorAbility > animal.Size)
        {
            Hunt(animal);
        }
        else if (other is IReproducible)
        {
            Reproduce();
        }
    }

    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine($"Animal with size {Size} is hunting animal with size {prey.Size}");
        Energy += prey.Size;
        prey.Energy -= prey.Size;
    }

    public void Reproduce()
    {
        Console.WriteLine($"Animal with size {Size} is reproducing");
    }
}