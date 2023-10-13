class Box
{
    public double length;
    public double width;
    public double height;

    public Box(double length, double width, double height)
    {
        if (length > 0 && width > 0 && height > 0)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        else if(length <= 0)
        {
            Console.WriteLine("Length cannot be zero or negative.");
        }
        else if (width <= 0)
        {
            Console.WriteLine("Width cannot be zero or negative.");
        }
        else if (height <= 0)
        {
            Console.WriteLine("Height cannot be zero or negative.");
        }
    }

    public double volume()
    {
        return length * width * height;
    }

    public double lateralSurface()
    {
        return (2 * length * height) + (2 * width * height);
    }

    public double surfaceArea()
    {
        return (2 * length * width) + (2 * length * height) + (2 * width * height);
    }

}

class Workspace
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Box box = new Box(length, width, height);

        if (length > 0 && width > 0 && height > 0)
        {
            Console.WriteLine("Surface Area - {0} \nLateral Surface Area - {1} \nVolume - {2}",
                box.surfaceArea(), box.lateralSurface(), box.volume());
        }
     
    }
}