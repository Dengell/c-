// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits(int num)
{
    if (num == 0) return 0;  //
    else return SumDigits(num / 10) + num % 10; //453 - 45 - 4 - 0
}

Console.Clear();
Console.WriteLine("Вводим число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);
Console.WriteLine(sum);