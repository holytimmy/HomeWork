using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать статический класс Calculator, с методами для выполнения основных арифметических 
операций. 
Написать программу, которая выводит на экран основные арифметические операции.*/

            Console.WriteLine("a+b:");
            Calculator.Sum();
            Console.WriteLine("a-b:");
            Calculator.Difference();
            Console.WriteLine("a*b:");
            Calculator.Product();
            Console.WriteLine("a/b:");
            Calculator.Fraction();

            Console.ReadKey();
        }
    }
}
