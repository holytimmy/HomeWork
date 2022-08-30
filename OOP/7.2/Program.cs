using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    struct Notebook
    {
        public string model;
        public string production;
        public int price;
        public Notebook(string model, string production, int price)
        {
            this.model = model;
            this.production = production;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"Notebook {model}, {production}, {price}$");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте структуру с именем - Notebook. 
Поля структуры: модель, производитель, цена. 
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода 
содержимого полей на экран. */

            Notebook notebook = new Notebook();
            notebook.model = "L223";
            notebook.production = "Asus";
            notebook.price = 580;

            notebook.Show();
            Console.ReadKey();
        }
    }
}
