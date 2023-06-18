// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

void Number3(int number)
{
    int three = number % 10;
    Console.Write("Третья цифра: " + three);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.Write(" Третьей цифры нет");
}
else
{

    while (num > 999)
    {
        num = num / 10;
    }
    Number3(num);

}

