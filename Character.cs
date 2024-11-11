using System;

public class Player{
    private static Player instance;
    private static readonly object Lock = new object();

    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int AttackPower { get; set; }
    private Player (string name, int health, int attackPower){
        this.Name = name;
        this.Health = health;
        this.Level = 1;
        this.AttackPower = attackPower;
    }
    public static Player GetInstance(string name, int health, int atttackPower){
        if (instance == null)
        {
            lock(Lock)
            {
                if (instance == null)
                {
                    instance = new Player(name, health, attackPower);
                }
            }
            
        }
        return instance;
    }

    public void Attack(){
        Console.WriteLine(Name + " is attacking");
    }

    public void Defend(){
        Console.WriteLine(Name + " is defending");
    }

    public void LevelUp(){
        this.Level++;
        this.Health += 10;
        this.AttackPower += 1;
        Console.WriteLine(Name + " has leveled up to level " + Level);
    }


}
