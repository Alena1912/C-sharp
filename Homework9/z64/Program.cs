// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

void Recursija(int n)
{
    if (n!=0)
    {
       Console.Write(n + " ");
       Recursija(n-1); 
    }
    
}

Recursija(n);

