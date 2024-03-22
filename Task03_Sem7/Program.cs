/// Задайте произвольный массив. 
/// Выведете его элементы, начиная с конца. 
/// Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 }; // Замените этот массив на произвольный массив

        Console.Write("Элементы массива в обратном порядке: ");
        PrintArrayReverse(array, array.Length - 1);
    }
}
