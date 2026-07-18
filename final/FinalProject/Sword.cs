public class Sword : Weapon
{
    public Sword(bool inhand, int basedamage, string attackword, string revealword)
    {
        _attackword=attackword;
        _basedamage=basedamage;
        _inHand=false;
        _revealword=revealword;
    }
    public override int Attack (int HP, int Sanity, int atunement, int dexterity, int strength)
    {
        if (HP>20 && Sanity >50)
        {
            return dexterity*2+strength+_basedamage;
        }
        else
        {
            return dexterity+_basedamage;
        }
    }
    
}