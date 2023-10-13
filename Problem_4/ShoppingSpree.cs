class Workplace
{
    static void Main(string[] args)
    {
        try
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] input = Console.ReadLine().Split(';');
            for (int i = 0; i < input.Length; i++)
            {
                string[] people = input[i].Split('=');
                persons.Add(new Person(people[0], int.Parse(people[1])));
            }

            input = Console.ReadLine().Split(';');
            for (int i = 0; i < input.Length; i++)
            {
                string[] supplies = input[i].Split('=');
                products.Add(new Product(supplies[0], int.Parse(supplies[1])));
            }

            while (true)
            {
                if (input[0].ToUpper() == "END") { break; }
                else 
                {
                    input = Console.ReadLine().Split(' ');
                   foreach (Person person in persons) 
                    {
                        foreach (Product product in products)
                        {
                            if (person.Name.ToLower().Equals(input[0].ToLower()) && product.Name.ToLower().Equals(input[1].ToLower()))
                            {
                                Console.WriteLine(person.purchaseAProduct(product));
                                break;
                            }
                        }
                    }
                }
            }
            foreach(Person person in persons)
            {
                Console.WriteLine(person);
            }

        } catch (ArgumentException e) { Console.WriteLine(e.Message); }
    }
}