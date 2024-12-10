using System;

public class Enemy
{
    public int Health { get; set; }
    public int Damage { get; protected set; }
    protected Random rand = new Random();

    public Enemy(int health, int damage = 8)
    {
        Health = health;
        Damage = damage;
    }

    public void Attack(Player player)
    {
        int damage = 8;
        player.Health -= damage;
        Console.WriteLine($"Musuh menyerang! Pemain menerima {damage} damage.");
    }
}
