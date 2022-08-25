using System;

namespace _6
{
    static class Calculator
    {
        const int a = 15;
        const int b = 5;

        public static void Sum()
        {
            Console.WriteLine(a + b);
        }
        public static void Difference()
        {
            Console.WriteLine(a - b);
        }
        public static void Product()
        {
            Console.WriteLine(a * b);
        }
        public static void Fraction()
        {
            Console.WriteLine(a / b);
        }
    }
}
