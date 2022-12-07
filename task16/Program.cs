void InputArray(int[] array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(a, b); 
}


int NumOfEvenNumbers(int[] array)
{     
    int count = 0;
    for (int i = 0; i < array.Length; i++)           
       if (array[i]%2 == 0)
        count++;
    return count;        
}

//Console.Clear();
Console.Write("Enter number of elements: ");
int n =Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 100, 1000);
Console.WriteLine($"input :[{string.Join(", ", array)}]");
Console.WriteLine($"output :{NumOfEvenNumbers(array)}");
