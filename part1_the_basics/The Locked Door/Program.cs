
class Program
{
    static void Main()
    {
        Console.WriteLine("Define password");
        var pass = Convert.ToInt32(Console.ReadLine());
        Door myDoor = new Door(pass);

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Lock the door");
            Console.WriteLine("2. Unlock the door");
            Console.WriteLine("3. Open the door");
            Console.WriteLine("4. Close the door");
            Console.WriteLine("5. Change password");
            Console.WriteLine("6. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myDoor.Lock();
                    break;
                case "2":
                    Console.Write("Enter password to unlock: ");
                    int unlockPassword = Convert.ToInt32(Console.ReadLine());
                    myDoor.Unlock(unlockPassword);
                    break;
                case "3":
                    myDoor.Open();
                    break;
                case "4":
                    myDoor.Close();
                    break;
                case "5":
                    Console.Write("Enter current password: ");
                    int currentPassword = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new password: ");
                    int newPassword = Convert.ToInt32(Console.ReadLine());
                    myDoor.ChangePassword(currentPassword, newPassword);
                    break;
                case "6":
                    continueProgram = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
