using System.Diagnostics;

public class Player
{
    private string _name;
    private int _strength;
    private int _atunement;
    private int _dexterity;
    private List<action> abilities;
    private List<Weapon> weapons;

    //Here is my CONSTRUCTOR

    //HERE ARE MY METHODS
    public void ChangeStrength(int newstrength)
    {
        _strength=newstrength;
    }
    public void ChangeAtunement(int newatunement)
    {
        _atunement=newatunement;
    }
    public void ChangeDexterity(int newdexterity)
    {
        _dexterity=newdexterity;
    }
}