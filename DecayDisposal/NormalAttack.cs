using System;

public class NormalAttack : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damage = 20;
        Console.WriteLine("Pemain melakukan Serangan Biasa!");
        enemy.TakeDamage(damage);
    }
}
