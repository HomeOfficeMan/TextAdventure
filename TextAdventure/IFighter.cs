public interface IFighter
{
    protected Weapon currentWeapon {get; }
    protected Armor currentArmor {get; }
    
    protected int maxHealth { get; }
    protected int currentHealth { get; }

    protected int Attack();
    protected int CalculateAttackDamge();
    public int GetDamage(int damageAmount);
    public int GetHealing(int healingAmount);
    protected int CalculateTakenDamage();
    public bool isDead();
}