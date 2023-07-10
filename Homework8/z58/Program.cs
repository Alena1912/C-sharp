// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// матрицы 2х2

Console.Write("Введите минимальное допустимое значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное допустимое значение: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] Array()
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
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

int [,] SumMAtrix (int [,] array1, int [,] array2)
{
    int [,] array3 = new int [2,2];
    int sum=0;
    
    for (int i=0; i<2; i++)
    {
        for (int j=0; j<2; j++)
        {
            sum += array1[i,j]*array2[j,i];
            
        }
        for (int k=0; k<2; k++)
        {
            array3[i,k]=sum;
        }
        sum=0;
    }
    return array3;
}

int[,] array = Array();
PrintArray(array);
Console.WriteLine();
int[,] arrayA = Array();
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(SumMAtrix(array,arrayA));

