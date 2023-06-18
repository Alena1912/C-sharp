// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Kub(int num)
{
    int count = 1;
    while (count <= num)
    {
        double result = Math.Pow(count, 3);
        Console.Write($"{result:f0} ");
        count++;

    }

    Console.WriteLine("\b.");
}

void KubOtr(int num)
{
    int count = 1;
    while (count >= num)
    {
        double result = Math.Pow(count, 3);
        Console.Write($"{result:f0} ");
        count--;

    }

    Console.WriteLine("\b.");
}

int number;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());


if (number>0)
{
    Kub(number);
}
else
{
    KubOtr(number);
}

