using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Добавляем элементы в массив, пока сумма не превысит maxSum
            while (currentSum < maxSum)
            {
                int newValue = random.Next(1, 10); // Генерация случайного числа от 1 до 9
                if (currentSum + newValue <= maxSum)
                {
                    array.Add(newValue);
                    currentSum += newValue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
            Console.WriteLine("Сумма элементов массива: " + currentSum);
        }
    }
}
