
public class EnemyFactory
{
    public static Enemy GetEnemy(string enemyType)
    {
        switch (enemyType)
        {
            case "Slime":
                return new Slime();
            case "Mutant":
                return new Mutant();
            default:
                return null;
        }
    }
}
