// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool Palindrome(int num)
{
    if(num < 10) return false;

    int initialNum = num;
    int reversNum = 0;

    while(num > 0)
    {
        reversNum = reversNum * 10 + num % 10;
        num /= 10;
    }
    return initialNum == reversNum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = number * -1;

bool palindrome = Palindrome(number);
Console.WriteLine(palindrome ? "Да" : "Нет");

