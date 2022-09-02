using System;

namespace _5._1
{
    internal class MyMatrix
    {
        private static int ar { get; set; }
        private static int ac { get; set; }
        static int[,] a;

        public MyMatrix(int ar, int ac)
        {
            a = new int[ar, ac];
        }

        public static void Fill(int ar, int ac)
        {
            Random rand = new Random();
            for (int i = 0; i < ar; i++)
                for (int j = 0; j < ac; j++)
                    a[i, j] = rand.Next(-50, 50);

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

        public static void ChangeDimention(int R, int C)
        {
            int[,] new_a = new int[R, C];
            R = Math.Min(a.GetLength(0), R);
            C = Math.Min(a.GetLength(1), C);
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++) new_a[i, j] = a[i, j];
            }
            a = new_a;

            Console.WriteLine($"a new: ");
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

