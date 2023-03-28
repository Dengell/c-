// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

void MatrixCheckToQuatro(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)   //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //columns
        {
            
            if(i % 2 == 0 && j % 2 == 0 )  // if((i + j) % 2 == 0 )
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            } 
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 5, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

MatrixCheckToQuatro(array2d);
PrintMatrix(array2d);

