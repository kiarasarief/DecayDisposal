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

    public virtual void Attack(Player player)
    {
        int finalDamage = Damage;
        Console.WriteLine($"Musuh menyerang!");
        player.TakeDamage(finalDamage);
    }

    public virtual void TakeDamage(int damage)
    {
        if (rand.NextDouble() < 0.1)
        {
            Console.WriteLine("Musuh berhasil menghindar!");
            damage = 0;
        }
        Health -= damage;
        if (damage > 0)
        {
            Console.WriteLine($"Musuh menerima {damage} damage!");
        }
    }
}

public class BossEnemy : Enemy
{
    public BossEnemy() : base(health: 1000, damage: 20)
    {
    }

    public override void Attack(Player player)
    {
        // chance critical 25%
        bool isCritical = rand.NextDouble() < 0.25;
        int finalDamage = isCritical ? 50 : 20;

        Console.WriteLine(isCritical ? "Boss melakukan serangan critical!" : "Boss menyerang!");
        player.TakeDamage(finalDamage);

        // 10% chance bos menyembuhkan diri setelah menyerang
        if (rand.NextDouble() < 0.1)
        {
            Health += 10;
            Console.WriteLine("Boss menyembuhkan dirinya: +10 HP!");
        }
    }

    public override void TakeDamage(int damage)
    {
        if (rand.NextDouble() < 0.1)
        {
            Console.WriteLine("Boss mem-block seranganmu!");
            damage = 0;
        }
        Health -= damage;
        if (damage > 0)
            Console.WriteLine($"Boss menerima {damage} damage. HP sekarang: {Health}");
    }
}