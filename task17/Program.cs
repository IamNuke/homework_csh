void InputArray(int[] array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(a, b); 
}

int SumOfEvenPositions(int[] array)
{     
    int sum = 0;
    for (int i = 0; i < array.Length; i++)           
       if (i%2 != 0)
        sum+= array[i];
    return sum;        
}

Console.Clear();
Console.Write("Enter number of elements: ");
int n =Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, -100, 101);
Console.WriteLine($"input :[{string.Join(", ", array)}]");
Console.WriteLine($"output :{SumOfEvenPositions(array)}");
