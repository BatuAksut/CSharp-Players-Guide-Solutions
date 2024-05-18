int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue;

foreach (int i in array)
{
    if (i < currentSmallest)
    {
        currentSmallest = i;
    }
}

Console.WriteLine(currentSmallest);
int total=0;
foreach  (int i in array)
{
    total += i;
}
float avg = (float)total / array.Length;

Console.WriteLine(avg);