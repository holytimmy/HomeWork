using System;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)

        /*Создать класс Article, содержащий следующие закрытые поля:
• название товара;
• название магазина, в котором продается товар;
• стоимость товара в гривнах.
Создать класс Store, содержащий закрытый массив элементов типа Article.
Обеспечить следующие возможности:
• вывод информации о товаре по номеру с помощью индекса;
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
нет, выдать соответствующее сообщение;
Написать программу, вывода на экран информацию о товаре.*/

        {
            Article a1 = new Article("milk", "Silpo", 22);
            Article a2 = new Article("cheese", "ATB", 120);
            Article a3 = new Article("broad", "Metro", 15);
            Article a4 = new Article("water", "Silpo", 30);

            Store store = new Store();

            store[0] = a1;
            store[1] = a2;
            store[2] = a3;
            store[3] = a4;

            Console.WriteLine(store[0]);
            Console.WriteLine(store[1]);
            Console.WriteLine(store[2]);
            Console.WriteLine(store[3]);
            //store.Print(a1, a2, a3, a4);

            Console.WriteLine("Enter product name:");
            string productName = Convert.ToString(Console.ReadLine());

            if (productName == "milk")
            {
                Console.WriteLine("milk");
            }
            else if (productName == "cheese")
            {
                Console.WriteLine("cheese");
            }
            else if (productName == "broad")
            {
                Console.WriteLine("broad");
            }
            else if (productName == "water")
            {
                Console.WriteLine("water");
            }
            else
            {
                Console.WriteLine("Don't have product in the store");
            }

            Console.ReadKey();
        }
    }
}
