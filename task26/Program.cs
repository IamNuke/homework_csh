﻿void Swap(ref int firstElement, ref int secondElement)
{    
    int temp = firstElement;
    firstElement = secondElement;
    secondElement = temp;    
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
    for (int i = 0; i < matrix.GetLength(0)/2; i++){        
        for (int j = 0; j < matrix.GetLength(1); j++)
            Swap(ref matrix[i,j], ref matrix[matrix.GetLength(0)-i-1, j]);                
    }    
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
ProcessMatrix(matrix);
PrintMatrix(matrix);

