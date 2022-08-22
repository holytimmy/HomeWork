using System;

namespace _5._1
{
    internal class MyMatrix
    {
        public int ar { get; set; }
        public int ac { get; set; }
        int[,] a;

        public MyMatrix(int ar, int ac)
        {
            a = new int[ar, ac];
        }

        public void MethArray(int ar, int ac)
        {
            Console.WriteLine($"a: -->");
            for (int i = 0; i < ar; i++)
            {
                for (int j = 0; j < ac; j++)
                {
                    Console.Write($"a[{i},{j}]");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Print(int ar, int ac)
        {
            Console.WriteLine($"a: ");
            for (int i = 0; i < ar; i++)
            {
                for (int j = 0; j < ac; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
