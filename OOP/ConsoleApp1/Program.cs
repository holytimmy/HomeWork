using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте статический класс с методом void Print (string stroka, int color), который выводит на 
экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных 
пользователю. Ввод строки и выбор цвета предоставьте пользователю.*/

            Console.WriteLine("enter text:");
            string stroka = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter number color for text from 1 to 7:");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(stroka, color);

            Console.ReadKey();
        }
    }
}
