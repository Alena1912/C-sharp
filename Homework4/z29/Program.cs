// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine("Ща все порешаем!!!");

Console.Write("Введите конечную цифру диапазона для рандома: ");
int diapazon = Convert.ToInt32(Console.ReadLine());

int size = 8;


int [] ArrayNew (int size)
{
    int [] arr = new int[size];

    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(0, diapazon);
        Console.Write (arr[i] + " ");
    }
    return arr;
}


int [] array1 = ArrayNew(size);

