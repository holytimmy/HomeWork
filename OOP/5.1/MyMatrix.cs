using System;
using System.Data;
using System.Data.SqlClient;

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

        //SqlDataAdapter adapter = new SqlDataAdapter();

        //public void MethodArray(int ar, int ac)
       // {
            //Console.WriteLine($"a: -->");
            public static void Fill<T>(T[] a, T value, int startIndex, int count);
            //for (int i = 0; i < ar; i++)
            //{
            //    for (int j = 0; j < ac; j++)
            //    {
            //        //Console.Write($"a[{i},{j}]");
            //        //a[i, j] = Convert.ToInt32(Console.ReadLine());
            //        //DataSet ds = new DataSet();

            //        //a[i, j] = adapter.Fill(ds);
            //        //a[i, j] = Array.Fill();
            //    }
            //}
        //}

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
