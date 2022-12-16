void FillMatrix(double[,] matrix, double minValue, double maxValue)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 3);
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ProcessMatrix(double[,] matrix, int index1, int index2)
{
    if (index1 > matrix.GetLength(0) 
        || index1 < 0
        || index2 > matrix.GetLength(1)
        || index2 < 0)
    {
        Console.WriteLine("Такой позициии элемента нет. ");        
    }
    else
        Console.WriteLine(matrix[index1, index2]);        
    
}    


Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();

double[,] matrix = new double[5, 5];

FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
ProcessMatrix(matrix, coord[0], coord[1]);