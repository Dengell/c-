// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    dif = Math.Round(dif, 1);
    return dif;
}

double[] array = CreateArrayRndDouble(5, 0, 100, 1);
double maxElement = MaxElement(array);
double minElement = MinElement(array);
double differenceMaxMin = DifferenceMaxMin(maxElement, minElement);

//Красивый вывод

// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Максимальный элемент -> {maxElement}");
// Console.WriteLine($"Минимальный элемент -> {minElement}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {differenceMaxMin}");

//Вывод, как дано в условиях:

PrintArray(array);
Console.Write($" -> {differenceMaxMin}");