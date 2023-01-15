// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitOne(int digit)
{
    if (digit > 0)
    {
        while (digit >= 10)
        {
            digit = digit / 10;

        }
    }
    else
    {
        digit = digit * -1;
        while (digit >= 10)
        {
            digit = digit / 10;

        }
    }
    return digit;
}

int DigitOther(int digitother)
{
    int sumCount = 0;
    int count = 0;
    if (digitother > 0)
    {
    while (digitother >= 10)
    {
        count = digitother % 10;
        sumCount = sumCount + count;
        digitother = digitother / 10;
    }
    }
    if (digitother < 0)
    {
        digitother = digitother * -1;
        while (digitother >= 10)
    {
        count = digitother % 10;
        sumCount = sumCount + count;
        digitother = digitother / 10;
    }
    }
    return sumCount;
}

Console.WriteLine("Введите целое число "); // ввели 12345
int number = Convert.ToInt32(Console.ReadLine());

int sumCountOne = DigitOne(number);
int sumCountOther = DigitOther(number);
int sumCountPlus = sumCountOne + sumCountOther;
Console.WriteLine(sumCountPlus);
