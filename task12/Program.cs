Console.Clear();

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Expand the number to the power of: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = n;
for (int i = 1; i < m; i++)
{
    result *=n;
}

Console.WriteLine($" -->{result}");