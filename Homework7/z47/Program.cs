// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Array()
{
    Console.Write("Enter m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((new Random().Next(min, max + 1) + new Random().NextDouble()), 2);

        }
    }
    return array;
}

void PrintArray(double[,] array)
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

double[,] array = Array();
PrintArray(array);