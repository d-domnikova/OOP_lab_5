class Topping
{
    private toppingType toppingType;
    public toppingType ToppingType { get { return toppingType; }
        set
        {
            if (Enum.IsDefined(typeof(toppingType), value))
            {
                toppingType = value;
            }
            else
            {
                throw new ArgumentException($"Cannot place{value} on top of your pizza.");
            }
        }
    }
    private int weight;
    public int Weight { get { return weight; }
        set
        {
            if (value >= 1 && value <= 50) { weight = value; }
            else
            {
                throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
            }
        }
    }

    public Topping(toppingType toppingType, int weight)
    {
        if (weight < 1 || weight > 50) throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
        this.toppingType = toppingType;
        this.weight = weight;
    }

    public double caloriesPerGrams()
    {
        return (double)((2 * weight) * (int)toppingType) / 10;
    }
}