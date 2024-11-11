using System;

public interface IPlayerStrategy
{
    void Execute(Player player, Enemy enemy);
}
