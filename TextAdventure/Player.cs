public class Player : Character, IFighter
{
    public int maxHealth { get; private set; }
    public int currentHealth { get; private set; }

    public Player(string name, int health) : base(name, health)
    {
        this.maxHealth = health;
        this.currentHealth = health;
    }

   
    public int Attack()
    {
        throw new NotImplementedException();
    }

    public int CalculateAttackDamge()
    {
        throw new NotImplementedException();
    }

    public int CalculateTakenDamage()
    {
        throw new NotImplementedException();
    }

    public int GetDamage(int damageAmount)
    {
        throw new NotImplementedException();
    }

    public int GetHealing(int healingAmount)
    {
        throw new NotImplementedException();
    }

    // public override void TakeDamage(int damage)
    // {
    //     // damage -= Armor.value;
    //     base.TakeDamage(damage);
    //     Console.WriteLine($"You take {damage} damage! {Health} HP left.");
    // }

    int IFighter.Attack()
    {
        return Attack();
    }

    int IFighter.CalculateAttackDamge()
    {
        return CalculateAttackDamge();
    }

    int IFighter.CalculateTakenDamage()
    {
        return CalculateTakenDamage();
    }

    int IFighter.GetDamage(int damageAmount)
    {
        throw new NotImplementedException();
    }

    int IFighter.GetHealing(int healingAmount)
    {
        throw new NotImplementedException();
    }

    public bool isDead()
    {
        throw new NotImplementedException();
    }
}