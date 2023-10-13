class Pizza
{
    private string name;
    public string Name { get { return name; }
        set
        {
            if (value.Length <= 15 || !string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
        }
    }
    public Pizza(string name)
    {
        if (name.Length > 15 || string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
        this.name = name;
        this.listOfToppings = new List<Topping>();
    }

    private Dough dough;
    public void setDought(Dough dough)
    {
        this.dough = dough;
    }

    private List <Topping> listOfToppings;
    public void addTopping(Topping topping)
    {
        if (listOfToppings.Count <= 10)
        {
            listOfToppings.Add(topping);
        } else
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public double totalCalories()
    {
        double sum = dough.caloriesPerGrams();
        foreach (Topping topping in listOfToppings)
        {
            sum = sum + topping.caloriesPerGrams();
        }
        return sum;
    }

    public override string ToString()
    {
        return $"{name} - {totalCalories().ToString("F")} Calories.";
    }
}