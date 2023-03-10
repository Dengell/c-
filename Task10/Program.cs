// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num) 
{
    //int firstDigit = num / 100;
    int secondDigit = num / 10;
    int result = secondDigit % 10;
    return result;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <= 999)
{
    int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра -> {secondDigit}");
}
else Console.WriteLine("Вы ввели не трехзначное число!");