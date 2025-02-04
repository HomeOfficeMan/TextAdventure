public class Weapon : Item
{
    int damage;

    public Weapon(int damage, int durabilty, string name, int goldValue) : base(durabilty, name, goldValue)
    {
        this.damage = damage;
    }

    public int GetDamage(/* targetToughness /**/)
    {
        // todo: calculate damage to weapon through toughnes

        return damage;
    }
}