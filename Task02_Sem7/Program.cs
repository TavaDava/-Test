/// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
/// Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 3; // Замените 3 на желаемое значение m
        int n = 2; // Замените 2 на желаемое значение n

        Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
    }
}
