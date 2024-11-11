using System;

public class Enemy
{
    public int Health { get; set; }

    public Enemy(int health)
    {
        Health = health;
    }

    public void Attack(Player player)
    {
        int damage = 8;
        player.Health -= damage;
        Console.WriteLine($"Musuh menyerang! Pemain menerima {damage} damage.");
    }
}
