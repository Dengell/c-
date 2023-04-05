// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

bool CheckPositivityNumber(int num)
{
    return num >= 0; //меньше 0 идут отрицательные числа
}

int Ackerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num1 > 0 && num2 == 0)
    {
        return Ackerman(num1 - 1, 1);
    }
    else
    {
        return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
    }
}

Console.WriteLine("Введите первое положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(CheckPositivityNumber(number1) && CheckPositivityNumber(number2))
{
    int ackerman = Ackerman(number1, number2);
    Console.WriteLine($"m = {number1}; n = {number2} -> A(m,n) -> {ackerman}");
}
else 
{
    Console.WriteLine("Введенные вами числа - не положительные");
}