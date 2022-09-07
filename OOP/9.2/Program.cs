using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    delegate int MyDelegate();
    delegate double MyDel(MyDelegate[] a);

    internal class Program
    {
        static int GetRandom()
        {
            Random random = new Random();
            int number = random.Next(0, 50);
            return number;
        }

        static void Main(string[] args)
        {
            /*Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает 
среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве. 
Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.*/

            Console.WriteLine("Enter number elements of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandom;
            }

            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]());
            }

            MyDel d = delegate (MyDelegate[] a)
            {
                double sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i]();
                }
                return sum / n;
            };

            Console.WriteLine("Arithmetic mean = {0}", d(array));
            
            Console.ReadKey();
        }
    }
}
