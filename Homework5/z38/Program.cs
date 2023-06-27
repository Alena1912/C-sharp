// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("The size of our arrey is ");
int size = Convert.ToInt32(Console.ReadLine());


double [] Arr(int size)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,101);
    }

    return array;
}

double [] arrayPrint(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] +" ");

    return arr;
}

double MaxEl(double [] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        max = arr[i];
    }
    return max;
}

double MinEl(double [] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        min = arr[i];
    }
    return min;
}

double [] arr1 = Arr(size);
arrayPrint(arr1);
Console.WriteLine();
double diff = MaxEl(arr1) - MinEl(arr1);

Console.Write($" Difference between max and min is {diff}" );
