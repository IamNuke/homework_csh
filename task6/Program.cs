
Console.Clear();

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;

if (n/100 == 0){
    Console.Write("no third digit!");
}
else{
    if (m<0)
        m = -m;
        
    while (m > 1000){
        m = m/10;
    }    
    Console.Write(m%10);
}