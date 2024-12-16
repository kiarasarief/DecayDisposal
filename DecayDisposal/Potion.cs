public enum PotionType
{
    Red,
    Yellow,
    Green
}

public class Potion
{
    public PotionType Type { get; private set; }
    public int HealAmount { get; private set; }

    public Potion(PotionType type)
    {
        Type = type;
        switch (type)
        {
            case PotionType.Red:
                HealAmount = 100;
                break;
            case PotionType.Yellow:
                HealAmount = 50;
                break;
            case PotionType.Green:
                HealAmount = 25;
                break;
        }
    }

    public override string ToString()
    {
        return Type.ToString() + " Potion (+" + HealAmount + " HP)";
    }
}
