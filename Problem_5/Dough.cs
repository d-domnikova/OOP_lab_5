class Dough
{
    private flourType flourType { get; set; }
    public flourType FlourType { get { return flourType; }
        set {
            if (Enum.IsDefined(typeof(flourType), value))
            {
                flourType = value;
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
    }
    private backingTechnique backingTechnique;
    public backingTechnique BackingTechnique { get { return backingTechnique; } 
        set {
            if (Enum.IsDefined(typeof(backingTechnique), value))
            {
                backingTechnique = value;
            } else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        } 
    }
    private int weight;
    public int Weight
    {
        get { return weight; }
        set
        {
            if (value >= 1 && value <= 200) { weight = value; }
            else
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
        }
    }

    public Dough(flourType flourType, backingTechnique backingTechnique, int weight)
    {
        if (weight < 1 || weight > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");

        this.flourType = flourType;
        this.backingTechnique = backingTechnique;
        this.weight = weight;
    }

    public double caloriesPerGrams()
    {
        return (double)((2 * weight) * (int)flourType * (int)backingTechnique) / 100;
    }
}