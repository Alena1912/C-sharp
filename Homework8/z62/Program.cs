// Напишите программу, которая заполнит спирально массив 4 на 4.

void Array()
{
    int[] arr = {01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16};
    for (int i=0; i<4; i++)
    {
        Console.Write(" " + arr[i] + " ");
    }
    Console.WriteLine();
    for (int i=11; i<14; i++)
    {
        Console.Write(arr[i] + " ");
       
    }
    Console.Write(" " + arr[4]);
    Console.WriteLine();
    Console.Write(arr[10]+" ");
    for (int i=15; i>13; i--)
    {
        Console.Write(arr[i]+" ");
    }
    Console.Write(" " +arr[5]);
    Console.WriteLine();
    for (int i=9; i>5; i--)
    {
        Console.Write(" " +arr[i] + " ");
    }
   

}

Array();