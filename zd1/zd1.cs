using System;

namespace zd1
{
    public class zd1
    {
        // Статический метод для вычисления НОД (алгоритм Евклида)
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите числитель: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель (положительное число): ");
            int denominator = int.Parse(Console.ReadLine());

            // Проверка, что знаменатель положительный
            if (denominator <= 0)
            {
                Console.WriteLine("Знаменатель должен быть положительным!");
                return;
            }

            // Вычисление НОД
            int gcd = GCD(numerator, denominator);

            // Сокращение дроби
            int reducedNumerator = numerator / gcd;
            int reducedDenominator = denominator / gcd;

            Console.WriteLine($"Сокращенная дробь: {reducedNumerator}/{reducedDenominator}");
        }
    }
}
