﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;
using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine());

WriteNow(number);

void WriteNow(int number)
{
    if (number == 0) return;
    Write(number+", ");
    WriteNow(number - 1);
}