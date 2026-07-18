public class Wand : Weapon{
public Wand(string attackword, string revealword)
    {
        _attackword=attackword;
        _inHand=false;
        _revealword=revealword;
    }

public override int Attack (int HP, int Sanity, int atunement, int dexterity, int _strength)
{
    if  (HP>20 && Sanity>50)
    {
        return Sanity*atunement;

    }
    else
    {
        return Sanity+atunement;
    }
}
}