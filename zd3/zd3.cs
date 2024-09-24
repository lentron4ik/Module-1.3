using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Сортировка строк по возрастанию суммы элементов
            var sortedMatrix = matrix.Cast<int>()
                                     .Select((value, index) => new { Row = index / N, Col = index % N, Value = value })
                                     .GroupBy(x => x.Row)
                                     .OrderBy(rowGroup => rowGroup.Sum(x => x.Value))
                                     .SelectMany(rowGroup => rowGroup.Select(x => x.Value))
                                     .ToArray();

            // Преобразование отсортированного массива обратно в матрицу
            int[,] resultMatrix = new int[N, N];
            for (int i = 0; i < N * N; i++)
            {
                resultMatrix[i / N, i % N] = sortedMatrix[i];
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
