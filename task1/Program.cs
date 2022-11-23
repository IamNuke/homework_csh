
Console.Clear();

Console.Write("Enter first number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int m = Convert.ToInt32(Console.ReadLine());


if(n > m)
{
    Console.Write($"max = {n}");    
}
else
{
    Console.Write($"max = {m}");    
}

