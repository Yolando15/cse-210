public abstract class Weapon
{
    protected bool _inHand;
    protected int _basedamage;
    protected string _revealword;
    protected string _attackword;
    
    public  abstract int Attack(int HP, int Sanity, int atunement, int dexterity, int _strength);

    public void RevealWeapon()
    {
        _inHand=true;
    }
    public void ConsealWeapon()
    {
        _inHand=false;
    }

    // Getters needed for building the timed challenge
    public string GetAttackWord()
    {
        return _attackword;
    }
    public bool IsInHand()
    {
        return _inHand;
    }
}