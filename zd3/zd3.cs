using System;
using System.Collections.Generic;
using System.Linq;

namespace zd3
{
    internal class zd3
    {
        static void Main()
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int N = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы случайными значениями
            int[,] matrix = new int[N, N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(-50, 51); // Случайные числа от -50 до +50
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix, N);

            // Создание списка строк и их сумм
            var rowsWithSums = new List<(int[] Row, int Sum)>();
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                int[] row = new int[N];
                for (int j = 0; j < N; j++)
                {
                    row[j] = matrix[i, j];
                    sum += matrix[i, j];
                }
                rowsWithSums.Add((row, sum));
            }

            // Сортировка строк по возрастанию суммы элементов
            var sortedRows = rowsWithSums.OrderBy(x => x.Sum).ToList();

            // Заполнение отсортированной матрицы
            int[,] resultMatrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    resultMatrix[i, j] = sortedRows[i].Row[j];
                }
            }

            Console.WriteLine("\nОтсортированная матрица:");
            PrintMatrix(resultMatrix, N);
        }

        // Метод для вывода матрицы
        static void PrintMatrix(int[,] matrix, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
