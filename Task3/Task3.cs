public class Point
{
    int _x = 0;
    int _y = 0;

    public Point( int x, int y )
    {
        _x = x;
        _y = y;
    }

    public int y
    {
        get { return _y; }
    }

    public int x
    {
        get { return _x; }
    }

}
public class Figure
{
    Point[] points;
    string name;

    static double LeighthSide( Point A, Point B )
    {
        return Math.Sqrt( (A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y) );
    }

    public Figure( string name, params Point[] points )
    {
        this.name = name;
        this.points = new Point[points.Length];  // Выделяем память под массив ссылок,
                                                 // 32х - 4 бита 64х - 8 бит 
                                                 // Ссылка ни на что не указывает
        for (int i = 0; i < points.Length; i++)
            this.points[i] = new Point( points[i].x, points[i].y );  // Настраиваем ссылку на текущий объект
    }
    public double getPerim()
    {
        double sum = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            sum += LeighthSide( points[i], points[i + 1] );
        }
        sum += LeighthSide( points[0], points[points.Length - 1] );
        return sum;
    }

    static void Main( string[] args )
    {
        Figure fig1 = new Figure("Треугоьник",
        new Point(1, 8), new Point(5, -1),
        new Point(0, -1));
        Console.WriteLine( "P(tr) = {0}", fig1.getPerim() );

        Figure fig2 = new Figure("Прямоугоьник",
        new Point(1, 1), new Point(10, 1),
        new Point(10, 9), new Point(1, 9));
        Console.WriteLine( "P(pr) = {0}", fig2.getPerim() );

        Figure fig3 = new Figure("Пятиугоьник",
        new Point(-1, -1), new Point(-10, 0),
        new Point(5, 10), new Point(10, 0),
        new Point(1, -1));
        Console.WriteLine( "P(pe) = {0}", fig3.getPerim() );
    }

}
