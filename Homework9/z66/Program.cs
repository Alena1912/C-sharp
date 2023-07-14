// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

int Recursija(int m, int n)
{
    int sum = Math.Min(m, n);

    return sum + Recursija(Math.Min(m, n) + 1, Math.Max(m, n));

}

Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum between M and N: {Recursija(m, n)}");
