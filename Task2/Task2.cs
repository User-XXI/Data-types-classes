public class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle( double sideA, double sideB )
    {
        if (sideA > 0 && sideB > 0)
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }
        else
        {
            this.side1 = -1;
            this.side2 = 1;
        }
    }

    public Rectangle()
    {
        this.side1 = 0;
        this.side2 = 0;
    }

    private double AreaCalculation()
    { return side1 * side2; }

    public double Area
    {
        get { return AreaCalculation(); }
    }

    private double PerimeterCalculation()
    { return 2 * (side1 + side2); }

    public double Perimeter
    {
        get { return PerimeterCalculation(); }
    }
}

public class Task2
{
    public static void Main( string[] args )
    {
        Console.WriteLine( "Side1 = " );
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty( input )) return;
        double sizeA = double.Parse(input);

        Console.WriteLine( "Side2 = " );
        input = Console.ReadLine();
        if (string.IsNullOrEmpty( input )) return;
        double sizeB = double.Parse(input);

        Rectangle rec = new Rectangle(sizeA, sizeB);

        Console.WriteLine( "Area = {0} \tPerimeter = {1}", rec.Area, rec.Perimeter );
    }
}
