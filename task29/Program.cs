
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{         
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];    
    for (int i = 0; i < matrix1.GetLength(0); i++){                        
        for (int j = 0; j < matrix1.GetLength(1); j++)
            resultMatrix[i,j] = matrix1[i,j] * matrix2[i,j];                    
    }    
    return resultMatrix;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix1 = new int[coord[0], coord[1]];
int[,] matrix2 = new int[coord[0], coord[1]];

FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
PrintMatrix(MultiplyMatrix(matrix1, matrix2));


