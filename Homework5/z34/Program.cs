// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве

Console.Write("The size of our arrey is ");
int size = Convert.ToInt32(Console.ReadLine());


int [] Arr(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int [] arrayPrint(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] +" ");

    return arr;
}

void evenCount(int [] arrayEv)
{
    int count = 0;
    for (int i = 0; i < arrayEv.Length; i++)
    {
        if (arrayEv[i] % 2 == 0)
            count++;

    }

    Console.WriteLine("Even numbers -> " + count);
}

int [] arr1 = Arr(size);
arrayPrint(arr1);
Console.WriteLine();
evenCount(arr1);

