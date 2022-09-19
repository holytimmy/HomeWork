using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность 
использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен 
System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром, 
должен включать метод добавления пар элементов, индексатор для получения значения элемента по 
указанному индексу и свойство только для чтения для получения общего количества пар элементов.*/

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "work");
            dic.Add(2, "book");
            dic.Add(3, "flat");

            for (int i = 0; i < dic.Lenght; i++)
            {
                Console.WriteLine(dic);
            }

            Console.ReadKey();
        }
    }
}
