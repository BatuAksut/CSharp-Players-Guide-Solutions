int city = 15;
int manticore = 10;
int distance = 0;
Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
do
{
    distance = Convert.ToInt32(Console.ReadLine());
}
while (distance < 0 || distance > 100);



Console.Clear();
Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("-----------------------------------------------------------");
int round = 1;
int guess = 0;
int damage = 0;
while (manticore >0 && city >0)
{
    
    Console.WriteLine($"STATUS: Round: {round}  City: {city}/15  Manticore: {manticore}/10");
    damageCalculator(round);
    Console.Write("Enter desired cannon range: ");
    guess = Convert.ToInt32(Console.ReadLine()); 
    if (guess >distance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (guess <distance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        manticore -= damage;
        Console.WriteLine("That round was a DIRECT HIT!");
    }
    city--;
    round++;
    Console.WriteLine("-----------------------------------------------------------");
}

if(manticore <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("City has lost!");
}

void damageCalculator(int round)
{
    
    if (round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        damage = 3;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
        Console.ForegroundColor = ConsoleColor.Gray;

    }

    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        damage = 3;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
        Console.ForegroundColor = ConsoleColor.Gray;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        damage = 1;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    }
}