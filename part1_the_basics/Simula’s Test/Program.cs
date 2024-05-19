using System.Reflection.Metadata.Ecma335;

var chest = Chest.Locked;
var choice = "";
while (true)
{

    Console.WriteLine(GetChestStatus(chest));
    Console.Write("What do you want to do? ");
    choice = Console.ReadLine();
    if(chest == Chest.Locked)
    {
        if (choice == "unlock")
        {
            chest = Chest.Closed;
            continue;
        }
        else
        {
           
            Console.WriteLine("invalid request");
            continue;
        }

    }
    if(chest == Chest.Closed)
    {
        if(choice == "open")
        {
            chest = Chest.Open;
            continue;
        }
        else if(choice == "lock")
        {
            chest= Chest.Locked;
            continue;
        }
        else
        {
           
            Console.WriteLine("invalid request");
            continue;

        }
    }
    if (chest == Chest.Open)
    {
        if (choice == "close")
        {
            chest = Chest.Closed;
        }
        else
        {
            Console.WriteLine("invalid request");
            continue;

        }
    }
}


static string GetChestStatus(Chest chest)
{
    switch (chest)
    {
        case Chest.Locked:
            return "Chest is locked";
        case Chest.Open:
            return "Chest is open";
        case Chest.Closed:
            return "Chest is unlocked";
        default:
            return "Unknown";
    }
}


enum Chest
{
    Locked,
    Open,
    Closed
};

