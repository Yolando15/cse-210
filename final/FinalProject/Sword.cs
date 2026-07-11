public class Sword : Weapon
{
    public override double Attack (double HP, int Sanity, int atunement, int dexterity, int strength)
    {
        if (HP>20 && Sanity >50)
        {
            return dexterity* 0.2+strength*0.5;
        }
        else
        {
            return dexterity*0.1+strength*0.35;
        }
    }
}