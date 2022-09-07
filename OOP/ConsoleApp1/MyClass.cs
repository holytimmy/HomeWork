using System;

namespace ConsoleApp1
{
    static class MyClass
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                default: break;
            }
            Console.WriteLine(stroka);
        }
    }
}
