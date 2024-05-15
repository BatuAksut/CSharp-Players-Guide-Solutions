Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.Title = "The Defense of Consolas";

Console.WriteLine("Target Row?");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Target Column?");
int column = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("Deploy to:");
Console.WriteLine($"{row},{column-1}");
Console.WriteLine($"{row-1},{column}");
Console.WriteLine($"{row},{column + 1}");
Console.WriteLine($"{row+1},{column}");
Console.Beep();