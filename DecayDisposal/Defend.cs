using System;

public class Defend : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damageBlocked = 5;
        player.Health += damageBlocked;
        Console.WriteLine($"Bertahan! Pemain memulihkan {damageBlocked} HP.");
    }
}
