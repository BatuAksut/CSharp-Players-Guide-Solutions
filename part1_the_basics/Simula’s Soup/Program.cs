using System;

public class Program
{
  
    public enum FoodType { Soup, Stew, Gumbo }
    public enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
    public enum Seasoning { Spicy, Salty, Sweet }

    public static void Main(string[] args)
    {
        (FoodType type, MainIngredient ingredient, Seasoning seasoning) soup;

        Console.WriteLine("Choose a type of food:");
        Console.WriteLine("0. Soup");
        Console.WriteLine("1. Stew");
        Console.WriteLine("2. Gumbo");
        FoodType foodType = (FoodType)Enum.Parse(typeof(FoodType), Console.ReadLine());

        Console.WriteLine("Choose a main ingredient:");
        Console.WriteLine("0. Mushrooms");
        Console.WriteLine("1. Chicken");
        Console.WriteLine("2. Carrots");
        Console.WriteLine("3. Potatoes");
        MainIngredient mainIngredient = (MainIngredient)Enum.Parse(typeof(MainIngredient), Console.ReadLine());

        Console.WriteLine("Choose a seasoning:");
        Console.WriteLine("0. Spicy");
        Console.WriteLine("1. Salty");
        Console.WriteLine("2. Sweet");
        Seasoning seasoning = (Seasoning)Enum.Parse(typeof(Seasoning), Console.ReadLine());

        
        soup = (foodType, mainIngredient, seasoning);

        
        Console.WriteLine($"Your food: {soup.seasoning} {soup.ingredient} {soup.type}");
    }
}
