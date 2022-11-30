

Console.Clear();

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int m = 0;
//if (n / 10000 > 0 && n / 10000 <= 9)
//{
//    int n1 = n/10000; 
//    int n2 = (n/1000)%10; 
//    int n4 = (n%100)/10;
//    int n5 = (n%10);

//     if (n1==n5 || n2==n4)
//         Console.Write("yes");        
//     else
//         Console.Write("no");    
//}
//else    
//    Console.Write("wrong parameter!");

while (temp != 0){
    m = m * 10 + temp % 10;
    temp /= 10;
}
if (n == m)
    Console.Write("yes");
else
    Console.Write("no");




