void countDown(int num =10)
{
    if (num == 0)
    {
        return;
    }
    Console.WriteLine(num);
    num--;
    countDown(num);
}

countDown();