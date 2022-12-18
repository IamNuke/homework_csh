
void FillMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(0, 21);
    }
}

void PrintMatrix(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++){
        for (int i = 0; i < array.GetLength(0); i++){                
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"({i},{j},{k}) {array[i, j, k]} \t");                
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,,] array = new int[coord[0], coord[1], coord[2]];


FillMatrix(array);
PrintMatrix(array);



