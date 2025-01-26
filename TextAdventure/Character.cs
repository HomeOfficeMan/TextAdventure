public abstract class Character
{
    string Name { get; set;}
    int Health { get; set;}

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
            if (Health < 0) Health = 0;
        
        Console.WriteLine($"{Name} took {damage} damage. Remaining Health: {Health}");
    }

    public void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name} healed {amount} points. Current Health: {Health}");
    }
}