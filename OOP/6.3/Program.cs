using System;

namespace _6._3
{
    static class MyClass
    {
        public static void SortMethod(this int []array)
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы 
массива по возрастанию. */

            int[] array = { 5, 8, 6, 5, 3 };
            array.SortMethod();

            Console.ReadKey();
        }
    }
}
