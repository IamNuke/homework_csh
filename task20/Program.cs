

Console.Clear();
Console.WriteLine("Enter quantity of numbers: ");
int n = Convert.ToInt32(Console.ReadLine());
int tempNum = 0, count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter {i} number: ");
    tempNum = Convert.ToInt32(Console.ReadLine());
    if (tempNum > 0) count++;
}

Console.WriteLine($"Enter quantity of positive numbers: {count}");