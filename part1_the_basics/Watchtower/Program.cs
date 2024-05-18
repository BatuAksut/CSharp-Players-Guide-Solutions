Console.WriteLine("x?");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y?");
int y = Convert.ToInt32(Console.ReadLine());

if (y > 0)
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is to the north!");
    }
    else
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
}

else if (y == 0)
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the west!");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is here!");
    }
    else
    {
        Console.WriteLine("The enemy is to the east!");
    }
}


else
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the southwest!");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is south!");
    }
    else
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}
