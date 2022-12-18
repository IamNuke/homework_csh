int SummOfRow(int[,] matrix, int rowIdex)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ += matrix[rowIdex, i];
    }
    return summ;
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 21);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ProcessMatrix(int[,] matrix)
{         
    int minSummRow = 0, minSumm = SummOfRow(matrix, 0), tmpSumm = 0;
    Console.WriteLine($"Row summ: {minSumm}");
    for (int i = 1; i < matrix.GetLength(0); i++){                        
        tmpSumm = SummOfRow(matrix, i);
        Console.WriteLine($"Row summ: {tmpSumm}");
        if (tmpSumm < minSumm){
            minSumm = tmpSumm;
            minSummRow = i;
        }                               
    }    
    Console.WriteLine($"mininmum summ Row number: {minSummRow + 1}");
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
ProcessMatrix(matrix);


