// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void Polindrom(int number)
{
    int a = number / 10000;
    int b = (number / 1000) % 10;
    int c = (number / 100) % 10;
    int d = (number / 10) % 10;
    int e = number % 10;

    if (number == (e * 10000 + d * 1000 + c * 100 + b * 10 + a))
    {
        Console.Write("Число " + number + " полиндром");
    }
    else
    {
        Console.Write("Число " + number + " не полиндром");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 9999) && (num <= 99999))
{
    Polindrom(num);
}
else
{
    Console.Write("Неверно введено число");
}













