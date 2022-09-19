using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    internal class Program
    {
        private static readonly int index;

        static void Main(string[] args)
        {
            /*Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его 
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс 
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для 
получения значения элемента по указанному индексу и свойство только для чтения для получения 
общего количества элементов.*/

            MyList<int> myList = new MyList<int>();
            myList[0] = myList.Add(2);
            myList[1] = myList.Add(5);
            myList[2] = myList.Add(12);

            Console.WriteLine("enter index element:");
            int k = Convert.ToInt32(Console.ReadLine());
            if ((k-1) == index)
            {
                Console.WriteLine(myList[k]);
            }

            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
