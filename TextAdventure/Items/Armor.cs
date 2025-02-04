public class Armor : Item
{
    int protection;

    public Armor(int protection, int durabilty, string name, int goldValue) : base(durabilty, name, goldValue)
    {
        this.protection = protection;
    }

    public int TakeDamage(int incomingDamage)
    {
        return incomingDamage - protection;
    }

    //todo: event item destruction
}