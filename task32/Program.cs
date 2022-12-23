int rec(int a, int b)
{
    if (a == b)
        return b;
    return rec(a+1, b) + a;
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(n,m));
