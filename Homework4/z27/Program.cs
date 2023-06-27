// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sum(int num)
{
    int sumNumbers = 0;
    int rest = num;

    if (rest / 10 != 0)
    {
        while (rest != 0)
        {
            sumNumbers += (rest % 10);
            rest /= 10;
        }

    }
    else
    {
        sumNumbers += (rest % 10);
    }

    Console.Write("Summ all figures of number : " + sumNumbers);
}

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Sum(number);


