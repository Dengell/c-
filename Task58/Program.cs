// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{

    int row = (matrix1.GetLength(0) >= matrix2.GetLength(0)) ? matrix1.GetLength(0) : matrix2.GetLength(0);
    int col = (matrix1.GetLength(1) >= matrix2.GetLength(1)) ? matrix1.GetLength(1) : matrix2.GetLength(1);

    int[,] multiplyMatrix = new int[row, col];

    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    multiplyMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Не возможно умножить матрицу А на В");
    }
    return multiplyMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] array2d2 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] myltiplyMatrix = MultiplyMatrix(array2d1, array2d2);

Console.WriteLine("Первая Матрица:");
PrintMatrix(array2d1);
Console.WriteLine();

Console.WriteLine("Вторая Матрица:");
PrintMatrix(array2d2);
Console.WriteLine();

Console.WriteLine("Результирующая матрица будет:");
PrintMatrix(myltiplyMatrix);