// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаетпроизведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



int Factorial(int num)
{
    int product = 1;
    for(int i = 2; i <= num; i++)
    {
        product = product * i;
        //sum += i;
    }
    return product;
}

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {factorial}");