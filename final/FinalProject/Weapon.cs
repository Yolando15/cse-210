public abstract class Weapon
{
    protected bool _inHand;
    
    public  abstract double Attack(int HP, int Sanity, int atunement, int dexterity, int _strength);
}