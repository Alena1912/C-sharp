// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Second(int number)
    {
        int dec = (number / 10) % 10;
        Console.Write("Вторая цифра: " + dec);
    }

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 999 || num < 100)
{
    Console.WriteLine("Неправильно введенное число!!!");

}
else
{
    Second(num);

}
