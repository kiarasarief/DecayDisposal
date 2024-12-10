using System;
using System.Collections.Generic;

public class Player
{
    public int Health { get; set; }
    private IPlayerStrategy _strategy;
    public List<Potion> Inventory { get; private set; }
    public int Level { get; private set; }
    public int Exp { get; private set; }
    private Random rand = new Random();

    public Player(int health, int level = 1)
    {
        Health = health;
        Level = level;
        Exp = 0;
        Inventory = new List<Potion>();
    }

    public void SetStrategy(IPlayerStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy(Enemy enemy)
    {
        if (_strategy != null)
            _strategy.Execute(this, enemy);
    }

    public void AddExp(int amount)
    {
        Exp += amount;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        // Misalkan setiap level butuh 100 Exp
        // Anda bisa buat formula lain
        while (Exp >= 100 && Level < 10)
        {
            Exp -= 100;
            Level++;
            Console.WriteLine($"[INFO] Level Up! Level kamu sekarang: Lvl. {Level}.");
        }
    }

    public void AddPotion(Potion potion)
    {
        Inventory.Add(potion);
        Console.WriteLine("Kamu mendapatkan sebuah potion!");
    }

    public void UsePotion()
    {
        if (Inventory.Count > 0)
        {
            Potion p = Inventory[0];
            Inventory.RemoveAt(0);
            Health += p.HealAmount;
            Console.WriteLine($"Kamu menggunakan potion dan menambah {p.HealAmount} HP! HP kamu sekarang: {Health}");
        }
        else
        {
            Console.WriteLine("Kamu tidak punya potion!");
        }
    }

    // Random block
    public void TakeDamage(int damage)
    {
        // 20% chance to block
        if (rand.NextDouble() < 0.2)
        {
            Console.WriteLine("Player berhasil mem-block serangan!");
            damage = 0;
        }
        Health -= damage;
        if (damage > 0)
            Console.WriteLine($"Player menerima {damage} damage. HP sekarang: {Health}");
    }
}
