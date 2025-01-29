public abstract class Character
{
    protected Guid characterId;
    protected string Name { get; set;}
    protected int Health { get; set;}
    //protected Weapon currentWeapon {get; set; }
    //protected Armor currentArmor {get; set; }

    public Character(string name, int health)
    {
        characterId = Guid.NewGuid();
        Name = name;
        Health = health;
    }

    public Guid GetCharacterId()
    {
        return characterId;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
            if (Health < 0) Health = 0;
        
        Console.WriteLine($"{Name} took {damage} damage. Remaining Health: {Health}");
    }

    public virtual void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name} healed {amount} points. Current Health: {Health}");
    }

    public virtual void Interact(string nameCaller)
    {
        Console.WriteLine($"{nameCaller} trys to interact with {Name}");
        Console.WriteLine($"{Name} does't seem interested");
    }

    public virtual int Attack(Guid targetGuid)
    {
        throw new NotImplementedException();
        return 0;
    }
}