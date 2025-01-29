public class Player : Character 
{
    // public Weapon currentWeapon {get; set; }
    // public Armor currentArmor {get; set; }

    public Player(string name, int health) : base(name, health)
    {

    }

    public override void TakeDamage(int damage)
    {
        // damage -= Armor.value;
        base.TakeDamage(damage);
        Console.WriteLine($"You take {damage} damage! {Health} HP left.");
    }
}