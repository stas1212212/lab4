// Клас екосистеми
public class Ecosystem
{
    public void SimulateInteraction(LivingOrganism organism1, LivingOrganism organism2)
    {
        organism1.Interact(organism2);
        organism2.Interact(organism1);
    }
}
