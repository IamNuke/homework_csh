
Console.Clear();

Console.Write("Enter number: ");

int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 8){
  if (n == 6 || n == 7) {
    Console.Write("yes");
  }
  else{
    Console.Write("no");
  }  
}
else{
    Console.Write("wrong parameter!");
}