class Chicken
{
    private string name;
    public string Name { get { return name; } 
        set {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be empty.");
            }
        } 
    }
    private int age;
    public int Age { get { return age; } 
        set {
            if (value >= 0 && value <= 15)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }
        } 
    }

    public Chicken(string name, int age) {
        this.name = name;
        this.age = age;
    }

    private int calculateProductPerDay()
    {
        if(age < 11)
        {
            return 1;
        } else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        int productPerDay = calculateProductPerDay();
        return $"Chicken {name} (age {age}) can produce {productPerDay} egg per day.";
    }
}

class Workspace
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        try
        {
            Chicken chicken = new Chicken(name, age);
            Console.WriteLine(chicken);
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    } 
}