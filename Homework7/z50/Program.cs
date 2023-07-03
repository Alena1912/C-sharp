// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] Array()
{
    int[,] array = new int[7, 7];
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            array[i, j] = new Random().Next(-10, 11);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            Console.Write(array[i, j] + "  ");

        }
        Console.WriteLine();

    }
}

int[,] array = Array();
PrintArray(array);

if (((m > 7) || (m < 0)) || ((n > 7) || (n < 0)))
{
    Console.WriteLine(" Элемента с такими индексами в массиве нет");
}
else
{
    Console.WriteLine();
    Console.Write($"Элемент на позиции [{m},{n}]: " + array[m, n]);
}

