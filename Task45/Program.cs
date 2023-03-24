// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray (int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int[] CoppyArray (int[] arr)
// {
//     int[] array = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         array[i] = arr[i];
//     }
//     return array;
// }

// int[] array = CreateArrayRndInt(7, 1, 9);
// PrintArray(array);

// int[] coppyArray = CoppyArray(array);
// //coppyArray[0] = 100;     //присвоили значение для проверки
// PrintArray(coppyArray);

int[] ArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];

    }
    return copyArray;
}

int[] array = ArrayRndInt(7, 0, 30);
PrintArray(array);

Console.WriteLine();
int[] copyArr = CopyArray(array);
// copyArr[0] = 32; была бы ссылка был бы такой же результат
PrintArray(copyArr);