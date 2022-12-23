

int  Spiral(int w, int h, int x, int y)
{
    // это подсмотрел и пока не разобрался 
    int z = y>0 ? w + Spiral(h - 1, w, y - 1, w - x - 1) : x; 
    return z;
}

void recFillMatrix(int[,] matrix)
{       
    for (int i = 0; i < matrix.GetLength(0); i++) 
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i,j] = Spiral(matrix.GetLength(0), matrix.GetLength(1), j, i) + 1;
}
void FillMatrix(int[,] matrix)
{   
    int n = matrix.GetLength(0);
    int i=1,j,k,p = n/2;
    for(k=1; k<=p ; k++)/*Цикл по номеру витка*/
    {
        for (j=k-1; j<n-k+1; j++) matrix[k-1,j] = i++; //верхняя строка
        for (j=k; j<n-k+1; j++) matrix[j,n-k] = i++; // правый столбец
        for (j=n-k-1; j>=k-1; --j) matrix[n-k,j] = i++;// нижняя строка
        for (j=n-k-1;j>=k;j--) matrix[j,k-1] = i++; //левый столбец
    }
    if (matrix.GetLength(0)%2==1) matrix[p,p]=n*n;
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

//Console.Clear();
//Console.WriteLine("Введите размер матрицы: ");
int[] coord = {5,5};//Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
recFillMatrix(matrix);
PrintMatrix(matrix);

FillMatrix(matrix);
PrintMatrix(matrix);



