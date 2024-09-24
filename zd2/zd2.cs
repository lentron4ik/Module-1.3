using System;
using System.Collections.Generic;

namespace zd2
{
    internal class zd2
    {
        static void Main()
        {
            Console.Write("Введите максимальную сумму элементов массива: ");
            int maxSum = int.Parse(Console.ReadLine());

            Random random = new Random();
            List<int> array = new List<int>();
            int currentSum = 0;

            // Начинаем с максимального значения (9) и добавляем его, если это возможно
            while (currentSum < maxSum)
            {
                // Если оставшаяся сумма больше или равна 9, добавляем 9
                if (currentSum + 9 <= maxSum)
                {
                    array.Add(9);
                    currentSum += 9;
                }
                else
                {
                    // Иначе ищем наибольшее значение, которое можно добавить
                    for (int i = 8; i >= 1; i--)
                    {
                        if (currentSum + i <= maxSum)
                        {
                            array.Add(i);
                            currentSum += i;
                            break; // Выходим из цикла после добавления элемента
                        }
                    }
                }
            }

            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
            Console.WriteLine("Сумма элементов массива: " + currentSum);
        }
    }
}