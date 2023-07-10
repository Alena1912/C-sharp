// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

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

int [] Sum(int [,] array)
{
    int sum = 0;
    int [] sumarray = new int[array.GetLength(0)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            
        }
        sumarray[i] = sum;
        Console.WriteLine($"Стока {i} имеет  сумму {sum}");
        sum = 0;
        

    } 
    return sumarray;
}

void Sortarray (int [] array)
{
    int index=0;
    int min = array[0];
   
    for (int i=0; i<array.Length; i++)
    {
        
        if (array[i]<min)
        {
            min=array[i];
            index=i;
        }
    }

    Console.WriteLine($"Стока {index} имеет минимальную сумму {min}");
    
    
}

if (n==m)
{
    Console.WriteLine("Количество строк не должно равняться количеству столбцов!");
    
}
else
{
    
    int[,] array = Array();
    PrintArray(array);
    int [] arr = new int[m];
    arr = Sum(array);
    Sortarray(arr);

}



