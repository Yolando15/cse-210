public class HealingPotion : Item
{
    private int _healAmount;

    public HealingPotion(int healAmount)
    {
        _healAmount = healAmount;
    }

    public override void Use(Player player)
    {
        player.ChangeHitPoints(_healAmount);
        System.Console.WriteLine($"You drink the potion and recover {_healAmount} HP!");
    }
}
