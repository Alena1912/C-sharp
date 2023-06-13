// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.WriteLine("Четные числа: ");
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
        count++;
    }
    else
    {
        count++;
    }

}
