// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 0) && (num < 8))
{

    if ((num == 6) || (num == 7))
    {
        Console.Write("Выходной день");
    }
    else
    {
        Console.Write("Будний день");
    }
}
else
{
    Console.WriteLine("Неправильно введено число!!!");

}