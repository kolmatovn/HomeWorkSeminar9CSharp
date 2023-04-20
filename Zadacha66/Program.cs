// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Write("Введите M: ");
int a = int.Parse(ReadLine());

Write("Введите N: ");
int b = int.Parse(ReadLine());

SumNumbers(a, b, 0);

void SumNumbers(int a, int b, int sum)
{
    if (a > b)
    {
        Write($"Сумма натуральных чисел от M до N = {sum}");
        return;
    }
    sum += a++;
    SumNumbers(a, b, sum);
}