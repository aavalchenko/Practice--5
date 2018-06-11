using System;
using System.Linq;
using InputOutputLib;

namespace Practice__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение заданного выражения равно : {0}.", GetAnswer(GetMatrix()));
            Console.ReadKey();
        }

        private static Double[][] GetMatrix()
        {
            Int32 n = Get.Int32("Введите размер действительной квадратной матрицы: ", 0);
            Double[][] matrix = new Double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new Double[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = Get.Double("Введите значение в ячейке [" + i + "," + j + "]: ");
                }
            }
            return matrix;
        }
        private static Double GetAnswer(Double[][] matrix)
        {
            Double output = 0;
            Int32 count = matrix.Rank;
            for (int i = 0; i < matrix.Rank; i++)
            {
                output += matrix[i].Max() * matrix[count].Max();
                count--;
            }

            return output;
        }
    }
}
