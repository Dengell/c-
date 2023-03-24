// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string BinaryDigit(int digit)
{
    string result = string.Empty;
    while (digit > 0)
    {
        int a = digit % 2;
        digit = digit / 2;
        result = Convert.ToString(a) + result;
    }
    return result;
}

string rez = BinaryDigit(num);
Console.WriteLine(rez);


// Console.WriteLine(result);


// string DecToBinString(int decimalNumber)
// {
//     if (decimalNumber == 0 || decimalNumber == 1)
//     {
//         return Convert.ToString(decimalNumber);
//     } 

//     string dec = string.Empty;
//     while (decimalNumber > 0)
//     {
//         dec = decimalNumber % 2 + dec;
//         decimalNumber /= 2;                
//     }
//     return dec;
// }

// int DecToBinInt(int decimalNumber)
// {
//     if (decimalNumber == 0 || decimalNumber == 1)
//     {
//         return decimalNumber;
//     } 

//     int dec = 0;
//     int i = 1;
//     while (decimalNumber > 0)
//     {
//         dec = dec + decimalNumber % 2 * i;        
//         decimalNumber /= 2; 
//         i *= 10;               
//     }
//     return dec;
// }