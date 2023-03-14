// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = -number;
if(ThirdNumber(number) == -1)
Console.WriteLine("Третья цифра отсутствует");
else
{
Console.WriteLine($"Третья цифра -> {ThirdNumber(number)} ");
}