Console.WriteLine("User 1, enter a number between 0 and 100:");
int number  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User 2, guess the number.");
int guess;

do
{
    guess= Convert.ToInt32(Console.ReadLine());

if (guess > number)
{
    Console.WriteLine("Too high");
}
else  if (guess < number)
{
    Console.WriteLine("Too low");
}
else
{
    Console.WriteLine("You guessed the number!");
}
}
while (number != guess);