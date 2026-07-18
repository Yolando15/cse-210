public class Enemy
{
    protected int _hitpoints;
    protected int _damage;
    
    public Enemy(int hitpoints, int damage)
    {
        _hitpoints=hitpoints;
        _damage=damage;
    }
    public void ChangeHP(int damagetaken)
    {
        _hitpoints-=damagetaken;
    }

    public int GetHP() { return _hitpoints; }
    public int GetDamage() { return _damage; }
    public bool IsAlive() { return _hitpoints > 0; }
}
    