void InputArray(double[] array, double a, double b)
{
    Random random = new Random();    
    for (int i = 0; i < array.Length; i++)
        array[i] = random.NextDouble() * (b - a) + a;
}

double MinMaxВifference(double[] array)
{
    double max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"max :{max}  min :{min}");
    return max - min;
}

Console.Clear();
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array, 0, 10);
Console.WriteLine($"input :[{string.Join("; ", array)}]");
Console.WriteLine($"output :{MinMaxВifference(array)}");
