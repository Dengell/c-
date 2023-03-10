// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultTwoNumbers(int num, int num1, int num2)
{
return num % num1 == 0 && num % num2 == 0;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пермое число на кратность");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число на кратность");
int number2 = Convert.ToInt32(Console.ReadLine());



bool result = MultTwoNumbers(number, number1, number2);

Console.WriteLine("Результат");
Console.WriteLine(result ? "Да" : "Нет");
