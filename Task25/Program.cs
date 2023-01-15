// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void DegreeNumber(int number1, int number2)
{
    int degree = number1;
    for (int i = 1; i < number2; i++)
    {
        degree = degree * number1;
    }
    Console.WriteLine();
    Console.WriteLine(degree);
}

Console.WriteLine("Введите первое целое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

DegreeNumber(numberOne, numberTwo);



