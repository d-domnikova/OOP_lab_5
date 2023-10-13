class Person
{
    private string name;
    public string Name { get { return name; }
        set {
            if (!string.IsNullOrWhiteSpace(value)) { name = value; }
            else
            {
                throw new ArgumentException("Person name cannot be empty");
            }
        }
    }
    private int money;
    public int Money { get { return money; }
        set {
            if (value > 0) { money = value; }
            else
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
    public List<Product> bagOfProducts;

    public Person(string name, int money)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Person name cannot be empty");
        if (money < 0) throw new ArgumentException("Money cannot be negative"); 

        this.name = name;
        this.money = money;
        this.bagOfProducts = new List<Product>();
    }

    public override string ToString()
    {
        return $"{name} - {(bagOfProducts.Count == 0? "Nothing is bought" : $"{string.Join(", ", bagOfProducts.Select(product => product.Name))}")}";
    }

    public string purchaseAProduct(Product product)
    {
        if(product.Cost > Money)
        {
            return $"{name} can't afford {product.Name}";
        } else
        {
            money = money-product.Cost;
            bagOfProducts.Add(product);
            return $"{name} bought {product.Name}";
        }
    }
}

