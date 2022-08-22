using System;

namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
с возможностью изменения числа строк и столбцов.
            Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных 
порядков.             */

            int n = 0;
            while (n < 3)
            {
                Console.Write($"{n + 1} rows: ");
                int ar = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{n + 1} columns: ");
                int ac = Convert.ToInt32(Console.ReadLine());

                MyMatrix myMatrix = new MyMatrix(ar, ac);
                myMatrix.MethArray(ar, ac);
                myMatrix.Print(ar, ac);
                n++;
            }

            Console.ReadKey();
        }
    }
}
