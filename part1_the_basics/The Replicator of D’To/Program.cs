int[] arr1 = new int[5];

Console.WriteLine("Enter the numbers");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

int[] arr2 = new int[5];

for (int i = 0;i < arr2.Length; i++)
{
    arr2[i] = arr1[i];
}

for (int i = 0; i<arr1.Length ; i++)
{
    Console.WriteLine($"{arr2[i]}, {arr1[i]}");
}