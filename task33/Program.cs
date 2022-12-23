int rec(int m, int n)
{
    if (m == 0)
        return n+1;
    else{        
        if (m > 0 && n == 0)    
            return rec(m-1, 1);
        else  //(m > 0 && n > 0)    
            return rec(m-1, rec(m, n-1));
    }
}

Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(m, n));
