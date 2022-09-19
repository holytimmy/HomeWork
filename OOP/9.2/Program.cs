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
        private static Random random = new Random();

        static int GetRandom()
        {
            // при таком подходе - на каждый вызов будет создан новый экземпляр класса.
            // это затратно и не целесообразно.
            // Можно вынести инициализацию на уровень выше (строка 14)
            // и еще - Random реализован на основании времени. Если программа будет
            //      создавать 2 экземпляра за очень короткий промежуток времени - метод Next будет возвращать одно и то же число
            //      если же будет 1 экземпляр - будут генерироваться разные числа
            //Random random = new Random();

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
