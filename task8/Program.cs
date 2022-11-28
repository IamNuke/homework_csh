

Console.Clear();

Console.WriteLine("Enter number: ");

int n = Convert.ToInt32(Console.ReadLine());
int max1 = n;
int max2 = n;
n = Convert.ToInt32(Console.ReadLine());
if (n > max1)
    max1 = n;
else
    max2 = n;

while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1){
        max2 = max1;
        max1 = n;
    }
    else{
        if (n > max2)        
            max2 = n;        
    }
};

Console.Write(max2);

