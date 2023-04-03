// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrix(int rows, int columns, int layers, int num)
{
    int[,,] arr3d = new int[rows, columns, layers];

    if (rows * columns * layers < 99)
    {
        for (int i = 0; i < arr3d.GetLength(0); i++)
        {
            for (int j = 0; j < arr3d.GetLength(1); j++)
            {
                for (int k = 0; k < arr3d.GetLength(2); k++)
                {
                    arr3d[i, j, k] = num++;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
    }
    return arr3d;
}

void Print3DArray (int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {arr3d[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix3d = Create3DMatrix(2, 2, 2, 11);
Print3DArray(matrix3d);