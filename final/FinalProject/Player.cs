using System.Diagnostics;
using System.Collections.Generic;

public class Player
{
    private string _name;
    private int _strength;
    private int _atunement;
    private int _dexterity;
    private int _HP;
    private int _sanity;
    private List<Weapon> weapons;
    private Weapon _activeWeapon;

    public Player(string name, int strength, int atunement, int dexterity, int hp, int sanity)
    {
        _name = name;
        _strength = strength;
        _atunement = atunement;
        _dexterity = dexterity;
        _HP = hp;
        _sanity = sanity;
        weapons = new List<Weapon>();
    }

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
    public void ChangeHitPoints(int addthis)
    {
        _HP+=addthis;
    }

    // Getters - needed so Program.cs and Weapon.Attack() can read these values
    public string GetName() { return _name; }
    public int GetStrength() { return _strength; }
    public int GetAtunement() { return _atunement; }
    public int GetDexterity() { return _dexterity; }
    public int GetHP() { return _HP; }
    public int GetSanity() { return _sanity; }
    public bool IsAlive() { return _HP > 0; }

    // Weapon management
    public void AddWeapon(Weapon w)
    {
        weapons.Add(w);
    }
    public void EquipWeapon(Weapon w)
    {
        _activeWeapon = w;
        w.RevealWeapon();
    }
    public Weapon GetActiveWeapon()
    {
        return _activeWeapon;
    }
    public List<Weapon> GetWeapons()
    {
        return weapons;
    }
}
