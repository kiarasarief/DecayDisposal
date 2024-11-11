public abstract class Enemy
{
    public abstract string Name { get; }
    public abstract int Health { get; }
    public abstract int AttackPower{ get; }
    public abstract void Attack();
}

public class Slime : Enemy
{
    public override string Name => "Slime";
    public override int Health => 25;
    public override int AttackPower => 3;
    public override void Attack()
    {
        Console.WriteLine("The slime attacks");
    }
}

public class Mutant : Enemy
{
    public override string Name => "Mutant";
    public override int Health => 100;
    public override int AttackPower => 10;
    public override void Attack()
    {
        Console.WriteLine("The mutant attacks");
    }
}