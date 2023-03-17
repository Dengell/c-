// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int DegreeNumber(int num1, int num2)
{
    int dnum = num1;
    if(num2 == 0) dnum = 1;
    
    for(int i = 1; i < num2; i++)
    {
        dnum = dnum * num1;
    }
    return dnum;
}

Console.WriteLine("Введите целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени ");
int number2 = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} = {degreeNumber}");