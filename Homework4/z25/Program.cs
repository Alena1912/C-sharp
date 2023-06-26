// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int count = 1;
int aStepB(int a, int b)
{
    for (int i = 0; i < b; i++)
    {
        count *= a;

    }
    return count;
}
Console.Write("First number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int b = Convert.ToInt32(Console.ReadLine());

count = aStepB(a, b);

Console.WriteLine("A in B = " + count);