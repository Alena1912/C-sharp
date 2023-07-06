// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Enter number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] Array()
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");

        }
        Console.WriteLine();

    }
}

void AverageArray(int[,] array)
{
    double[] aver = new double[n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            aver[i] += array[i, j];
        }

    }

    for (int i = 0; i < aver.Length; i++)
    {
        aver[i] = aver[i] / aver.Length;
        Console.Write(aver[i] + " ");

    }
}

int[,] array = Array();
PrintArray(array);
AverageArray(array);
