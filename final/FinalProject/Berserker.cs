public class Berserker : Item
{
    private int _strengthamount;
    public Berserker(int newstrength)
    {
        _strengthamount=newstrength;
    }
    public override void Use(Player player)
    {
        player.ChangeStrength(_strengthamount);
        System.Console.WriteLine($"You drink the potion and feel a surge of power, your strength is now {_strengthamount}!");
    }
}