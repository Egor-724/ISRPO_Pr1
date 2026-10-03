using System;

namespace MatrixTask
{
    class Program
    {
        // Функция создания и заполнения матрицы
        static double[,] CreateMatrix(int n, int m)
        {
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Math.Sin((i + 1) + (j + 1) / 2.0);
                }
            }
            return matrix;
        }

        static void Main()
        {

            Console.WriteLine("=== Матрица a_ij = sin(i + j/2) ===\n");

            
            int n;
            while (true)
            {
                Console.Write("Введите количество строк n: ");
                if (int.TryParse(Console.ReadLine(), out n) && (n > 0 && n < 999))
                    break;
                Console.WriteLine("  Ошибка: введите целое число больше 0.И не громадное");
            }

            int m;
            while (true)
            {
                Console.Write("Введите количество столбцов m: ");
                if (int.TryParse(Console.ReadLine(), out m) && (m > 0 && m < 999))
                    break;
                Console.WriteLine("  Ошибка: введите целое число больше 0. И не громадное");
            }

            // Создание матрицы через функцию
            double[,] matrix = CreateMatrix(n, m);

            
            Console.WriteLine("\nСозданная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],8:F4}");
                }
                Console.WriteLine();
            }

            // Подсчёт положительных элементов
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }
            }

            Console.WriteLine($"\nКоличество положительных элементов: {count}");
        }
    }
}