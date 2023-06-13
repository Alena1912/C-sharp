// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(num1);
    Console.Write("Минимальное число: ");
    Console.Write(num2);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(num2);
    Console.Write("Минимальное число: ");
    Console.Write(num1);
}


