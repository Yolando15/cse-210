public class Character
{
    protected int _hitpoints;
    protected int _sanity;
    public void ChangeHP(int damage)
    {
        _hitpoints-=damage;
    }
    public void ChangeSanity(int psychicDamage)
    {
        _sanity-=psychicDamage;
    }
}