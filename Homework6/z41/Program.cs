// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите, сколько чисел будете вводить: ");
int M = Convert.ToInt32(Console.ReadLine());


int [] Arr(int M)
{
    int [] array = new int [M];
    Console.Write("Введите числа: ");
    int num = 0;
    for (int i = 0; i < M; i++)
    {
        num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
        
    }

    return array;
}

int [] arrayPrint(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] +" ");

    return arr;
}

int biggerZerro(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        count++;
    }
    return count;
}

int [] arr1 = Arr(M);
arrayPrint(arr1);
Console.WriteLine();
Console.Write($" Количество чисел больше нуля {biggerZerro(arr1)}" );
