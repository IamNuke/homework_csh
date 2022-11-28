
Console.Clear();

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n / 100 > 0 && n / 100 <= 9)
    Console.Write((n/10)%10);
else
    Console.Write("wrong parameter!");