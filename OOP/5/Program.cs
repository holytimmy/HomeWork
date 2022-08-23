using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, 
среднее арифметическое всех элементов, вывести все нечетные значения.*/

            Console.WriteLine("enter number of elements array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-100,100);
                Console.Write($"{array[i]}  ");
            }

            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine($" Max element array:{max}");

            int min = array.Min();
            Console.WriteLine($"Min element array:{min}");

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum elements:{sum}");

            int average = sum / n;
            Console.WriteLine($"Average of array:{average}");

            Console.WriteLine($"Elements odd number");

            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
