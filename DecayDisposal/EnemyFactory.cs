public class EnemyFactory
{
    public static Enemy GetEnemy(int playerLevel)
    {
        if (playerLevel < 10)
        {
            int baseHealth = (playerLevel * 10);
            int baseDamage = 3 + (playerLevel * 2);

            if (new System.Random().NextDouble() < 0.5)
                return new Slime(baseHealth, baseDamage);
            else
                return new Mutant(baseHealth, baseDamage);
        }
        else
        {
            return new BossEnemy();
        }
    }
}

public class Slime : Enemy
{
    public Slime(int health, int damage) : base(health, damage) { }
}

public class Mutant : Enemy
{
    public Mutant(int health, int damage) : base(health, damage) { }
}