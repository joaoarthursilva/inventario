public abstract class Weapon : Item
{
    public int damage;

    public override int GetDano()
    {
        return damage;
    }
}