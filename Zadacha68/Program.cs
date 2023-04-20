// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

using System;
using static System.Console;

Write("Введите m: ");
int m = int.Parse(ReadLine());

Write("Введите n: ");
int n = int.Parse(ReadLine());

Write($"Значение функции Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
    return n + 1;
    }else if (n == 0){
        return AckermannFunction(m - 1, 1);
    }else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}