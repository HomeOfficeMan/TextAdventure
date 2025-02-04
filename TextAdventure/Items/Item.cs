public abstract class Item
{
    protected int maxDurability;
    protected int currentDurability;
    string name { get; }
    protected int goldValue;


    public Item(int durabilty, string name, int goldValue)
    {
        this.maxDurability = durabilty;
        this.currentDurability = durabilty;
        this.name = name;
        this.goldValue = goldValue;
    }

    public virtual int SellItem()
    {
        double itemDamageInPercent = ((double)currentDurability / maxDurability);

        return (int)(goldValue * itemDamageInPercent);
    }

    //todo: event item destruction

}