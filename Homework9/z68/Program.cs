// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Enter a positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
int akk = 0;

int Akkerman(int n, int m)
{
    if (n == 0) akk = m + 1;
    if (m == 0) akk = Akkerman(n - 1, 1);
    if (n > 0 && m > 0) akk = Akkerman(n - 1, Akkerman(n, m - 1));

    return akk;
}

Console.Write($"The value of the funktion Akkerman is : {Akkerman(n, m)} ");
