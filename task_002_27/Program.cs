// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в этом числе.


int sumDigits(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        sum = sum + numberA % 10;
        numberA = numberA / 10;
    }
    return sum + numberA;
}

Console.Write("Enter a number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumDigits(numberA));

