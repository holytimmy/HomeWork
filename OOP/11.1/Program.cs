using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    internal class Program
    {
        public static int index { get; private set; }

        static void Main(string[] args)
        {
            /*Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и 
года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство 
только для чтения для получения общего количества элементов. 
Создайте метод удаления всех машин автопарка. */

            CarCollection<string> carsName = new CarCollection<string>(new string[] {"bmw", "opel", "citroen"});
            CarCollection<int> carsYear = new CarCollection<int>(new int[] {2015, 2003, 2018});

            carsName.Show();
            carsYear.Show();

            Console.WriteLine("enter index element:");
            int k = Convert.ToInt32(Console.ReadLine());
            if ((k - 1) == index)
            {
                Console.WriteLine("model: {0}, year: {1}", carsName[k], carsYear [k]);
            }

            carsName.Counter();

            carsName.Clear();
            carsYear.Clear();

            carsName.Show();

            Console.ReadKey();

        }
    }
}
