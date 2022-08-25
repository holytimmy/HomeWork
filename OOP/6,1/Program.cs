using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для 
поиска по книге из примера урока 005_Delegation. При вызове этого метода, производится 
последовательный поиск строки в книге.*/

            string book = "I live in Poland, Warshaw is capital.";
            FindAndReplaceManager.FindNext("Poland");
            Console.WriteLine(book);

            Console.ReadKey();

        }
    }
}
