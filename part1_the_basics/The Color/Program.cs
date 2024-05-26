internal class Program
{
    private static void Main(string[] args)
    {
        Color color1 = new Color(255,10,22);
        Color color2 = new Color();
        Color color3 = Color.White;

        Console.WriteLine($"({color1.red},{color1.green},{color1.blue})");
        Console.WriteLine($"({color2.red},{color2.green},{color2.blue})");
        Console.WriteLine($"({color3.red},{color3.green},{color3.blue})");
    }
}

class Color
{
    public short red;
    public short green;
    public short blue;

    public Color(short red,short green,short blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }
    public Color()
    {
        red = 0;
        green = 0;
        blue = 0;
    }
    public static Color Black { get { return new Color(0, 0, 0); } }
    public static Color White { get { return new Color(255, 255, 255); } }
    public static Color RedColor { get { return new Color(255, 0, 0); } }
    public static Color GreenColor { get { return new Color(0, 255, 0); } }
    public static Color BlueColor { get { return new Color(0, 0, 255); } }
    public static Color Yellow { get { return new Color(255, 255, 0); } }
    public static Color Cyan { get { return new Color(0, 255, 255); } }
    public static Color Magenta { get { return new Color(255, 0, 255); } }

}