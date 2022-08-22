using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
