
Console.Clear();

Console.Write("Enter first number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int k = Convert.ToInt32(Console.ReadLine());

int max = n;
if(m > max)
  max = m;  
if(k > max)
    max = k;


Console.Write($"max = {max}");    
