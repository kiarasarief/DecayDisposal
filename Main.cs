using System;
public class Program{
    static void Main(string[] args){
        Player player1 = Player.GetInstance("Albert", 100, 10);
        player1.Attack();
        player1.Defend();
        player1.LevelUp();

        Enemy slime = EnemyFactory.CreateEnemy("Slime");
        Enemy mutant = EnemyFactory.CreateEnemy("Mutant");

        slime.Attack();
        mutant.Attack();
    }
}