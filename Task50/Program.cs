// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

bool MatrixElementPosition(int [,] matrix, int row, int column)
{
    if(matrix.GetLength(0) >= row && matrix.GetLength(1) >= column && row >= 0 && column >= 0)
    {
        int result = matrix[row, column];
        return true;
    }
    else return false;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите номер строки позиции элемента:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца позиции элемента :");
int n = Convert.ToInt32(Console.ReadLine());

bool elementPosition = MatrixElementPosition(array2d, m, n);

Console.Write($"{m} {n } -> ");
Console.Write(elementPosition ? array2d[m,n] : "Такого элемента нет");