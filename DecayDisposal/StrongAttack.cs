using System;

public class StrongAttack : IPlayerStrategy
{
    public void Execute(Player player, Enemy enemy)
    {
        int damage = 20;
        Random rand = new Random();
        bool isCritical = rand.Next(0, 2) == 1;

        if (isCritical)
        {
            damage *= 2;
            Console.WriteLine("Serangan Kuat Critical Hit!");
        }
        else
        {
            Console.WriteLine("Serangan Kuat!");
        }

        enemy.TakeDamage(damage);
    }
}
