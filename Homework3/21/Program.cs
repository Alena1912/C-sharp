// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

double Dist(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double result = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
    return result;
}

Console.Write("Введите хА: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите xB: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите yА: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите zА: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distanse = Dist(xA, xB, yA, yB, zA, zB);

Console.Write("Дистанция: " + distanse);