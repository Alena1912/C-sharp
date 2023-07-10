// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*Console.Write("Введите минимальное допустимое значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное допустимое значение: ");
int max = Convert.ToInt32(Console.ReadLine());*/


int[,,] Array()
{
    int[,,] array = new int[2, 2,2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k=0; k<2; k++)
            {
                array[i,j,k]= new Random().Next(10,100);
            }

        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k< 2; k++)
            {
                Console.Write($"{array[i, j,k]} {(i,j,k)}  " );
            }
            

        }
        Console.WriteLine();

    }
}

int [,,] array = Array();
PrintArray(array);