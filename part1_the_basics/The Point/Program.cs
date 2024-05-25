namespace Point;
internal class Program
{
    public static void Main(string[] args)
    {
        
    Point point1 = new Point(2,3);
    Point point2 = new Point(-4, 0);

        Console.WriteLine($"{point1.x},{point1.y}");
        Console.WriteLine($"{point2.x},{point2.y}");
    }


}
class Point
{
    public float x;
    public float y;

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public Point()
    {
        x = 0;
        y = 0;
    }
}
