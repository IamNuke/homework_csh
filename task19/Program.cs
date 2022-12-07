
bool IsPrime(int n)
{
    if (n < 2) return false; //1 - не простое
    else if (n < 4) return true; //2,3 - простые
    else if (n % 2 == 0) return false; //четные - не простые

    double h = Math.Sqrt(n);
    for (int i = 3; i <= h; i += 2)
        if (n % i == 0) return false;
    return true;
}

void Goldbah(int n)
{
    int h = n / 2 + 1;
    for (int i = 2; i < h; i++)
    {
        if (IsPrime(i))
        {
            for (int j = i; j < n; j++)
            {
                if (IsPrime(j) && i + j == n)
                {
                    Console.WriteLine($"{i} {j}");
                    return;
                }
            }
        }
    }
}

//Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Goldbah(n);
