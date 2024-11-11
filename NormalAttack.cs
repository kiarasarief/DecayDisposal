using System;

public class NormalAttack : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damage = 10;
        enemy.Health -= damage;
        Console.WriteLine($"Serangan Biasa! Musuh menerima {damage} damage.");
    }
}
