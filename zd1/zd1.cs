using System;

namespace zd1
{
    public class zd1
    {
        // Статический метод для вычисления НОД
        public static int GCD(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                int remainder = denominator;
                denominator = numerator % denominator;
                numerator = remainder;
            }
            return numerator;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите числитель (неотрицательное число): ");
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

