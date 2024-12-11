using System;

public class Defend : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damageBlocked = 10;
        player.Health += damageBlocked;
        Console.WriteLine($"Pemain bertahan! Memulihkan {damageBlocked} HP. HP sekarang: {player.Health}");
    }
}
