using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места 
заполнения типом – Т).*/

            MyClass<string> myClass = new MyClass<string>();
            var k = myClass.FactoryMethod();
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
