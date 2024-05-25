using System;

public class Arrow
{
    public ArrowHead Head { get; set; }
    public FletchingType Fletching { get; set; }
    public float Length { get; set; }

    public enum ArrowHead
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum FletchingType
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }

    public Arrow(ArrowHead head, FletchingType fletching, float length)
    {
        Head = head;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float headCost = Head switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5,
            _ => 0
        };

        float fletchingCost = Fletching switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeathers => 5,
            FletchingType.GooseFeathers => 3,
            _ => 0
        };

        float lengthCost = Length * 0.05f;

        return headCost + fletchingCost + lengthCost;
    }
}

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Enter Arrow Head (Steel, Wood, Obsidian): ");
        string headInput = Console.ReadLine();

        Console.WriteLine("Enter Fletching Type (Plastic, TurkeyFeathers, GooseFeathers): ");
        string fletchingInput = Console.ReadLine();

        Console.WriteLine("Enter Length of the Arrow (60-100 cm): ");
        if (!float.TryParse(Console.ReadLine(), out float lengthInput) || lengthInput < 60 || lengthInput > 100)
        {
            Console.WriteLine("Invalid Arrow Length. Length must be between 60 and 100 cm.");
            return;
        }


        if (!Enum.TryParse(headInput, true, out Arrow.ArrowHead headEnum))
        {
            Console.WriteLine("Invalid Arrow Head.");
            return;
        }


        if (!Enum.TryParse(fletchingInput, true, out Arrow.FletchingType fletchingEnum))
        {
            Console.WriteLine("Invalid Fletching Type.");
            return;
        }


        Arrow arrow = new Arrow(headEnum, fletchingEnum, lengthInput);

        float cost = arrow.GetCost();
        Console.WriteLine($"The cost of the arrow is: {cost} gold");
    }
}
