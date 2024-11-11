using System;

public class Player
{
    public int Health { get; set; }
    private IPlayerStrategy _strategy;

    public Player(int health)
    {
        Health = health;
    }

    public void SetStrategy(IPlayerStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy(Enemy enemy)
    {
        _strategy.Execute(this, enemy);
    }
}
