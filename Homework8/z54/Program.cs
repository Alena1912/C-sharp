// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


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


int[,] ArrayMinMAx(int[,] array)
{
    //int[,] arr = new int[m, n];
    
    int min = array[0,0];
    for (int i = 0; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            if (array[i,j]<min)
            {
                min=array[i,j];
                array[i,j]=array[i,j-1];  
                array[i,j-1]=min;
                             
            }
                   

        }
    }
    return array;
}


int[,] array = Array();
PrintArray(array);
Console.WriteLine();
ArrayMinMAx(array);
PrintArray(ArrayMinMAx(array));


