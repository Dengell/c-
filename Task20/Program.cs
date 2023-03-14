// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("точек");
Console.Write("Первая точка A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторач точка A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA,yA,xB,yB);
Console.WriteLine(distance);


double Distance(int x1,int y1,int x2, int y2)
{
    double result = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return resultRound;
}


// double d = Math.Sqrt(x1,x2,y1,y2);
// double res = 5.099987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);