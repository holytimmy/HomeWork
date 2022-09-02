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

            Console.Write($"Enter rows: ");
            int ar = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter columns: ");
            int ac = Convert.ToInt32(Console.ReadLine());

            MyMatrix myMatrix = new MyMatrix(ar, ac);
            MyMatrix.Fill(ar, ac);

            Console.Write($"Enter new rows: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter new columns: ");
            int C = Convert.ToInt32(Console.ReadLine());
            MyMatrix.ChangeDimention(R, C);

            Console.ReadKey();
        }
    }
}
