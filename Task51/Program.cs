// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 3} ");
    }
    Console.WriteLine("|");
    }
}

int MatrixSumDiagonal(int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)   //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //columns
        {
            if(i == j)
            {
               sum = sum + matrix[i, j];
            } 
        }
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 8, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int array2dSumDiagonal = MatrixSumDiagonal(array2d);
Console.WriteLine($"Сумма по диагонали = {array2dSumDiagonal}");

// Альтернатива
// void ChangeToSquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i,j] *= matrix [i,j];
//         }
//     }
// }