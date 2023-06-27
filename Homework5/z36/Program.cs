// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("The size of our arrey is ");
int size = Convert.ToInt32(Console.ReadLine());


int [] Arr(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,101);
    }

    return array;
}

int [] arrayPrint(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] +" ");

    return arr;
}

void oddCount(int [] arrayEv)
{
    int count = 0;
    for (int i = 0; i < arrayEv.Length; i++)
    {
        if (i % 2 == 1)
            count+=arrayEv[i];

    }

    Console.WriteLine("Summ odd elements of array -> " + count);
}

int [] arr1 = Arr(size);
arrayPrint(arr1);
Console.WriteLine();
oddCount(arr1);




