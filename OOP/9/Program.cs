using System;

namespace _9
{
    public delegate int MyDelegate(int a, int b, int c);

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и 
возвращает среднее арифметическое этих аргументов.*/

            int summand1 = 1, summand2 = 2, summand3 = 3, arithmeticMean = 0;

            MyDelegate myDelegate = delegate (int a, int b, int c) { return (a + b + c) / 3; };

            arithmeticMean = myDelegate(summand1, summand2, summand3);

            Console.WriteLine("({0} + {1} + {2})/3 = {3}", summand1, summand2, summand3, arithmeticMean);

            Console.ReadKey();

        }
    }
}
