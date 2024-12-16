using System;

public class Defend : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damageBlocked = enemy.Damage / 2;
        player.Health += damageBlocked;
        Console.WriteLine($"Pemain bertahan! Memulihkan {damageBlocked} HP. HP sekarang: {player.Health}");
    }
}
