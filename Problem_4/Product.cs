class Product
{
    private string name;
    public string Name { get { return name; } 
        set { 
            if(!string.IsNullOrWhiteSpace(value)) { name = value; } 
            else
            {
                throw new ArgumentException("Product name cannot be empty");
            }
        } 
    }
    private int cost;
    public int Cost { get { return cost; }
        set {
            if (value > 0) { cost = value; }
            else
            {
                throw new ArgumentException("Cost cannot be negative");
            }
        }
    }

    public Product(string name, int cost)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Product name cannot be empty");
        if (cost < 0) throw new ArgumentException("Cost cannot be negative");
        
        this.name = name;
        this.cost = cost;
    }
}

