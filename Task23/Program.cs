// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableCube(int num)
{
    int count = 1;
while(count <= num)
    {
    int cube = count * count * count;
    Console.WriteLine($"{count,4}->{cube,8}");
    count++;
    }
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


TableCube(number);
