using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, 
переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? */

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");
            arrayList.Add(2.5);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadKey();
        }
    }
}
