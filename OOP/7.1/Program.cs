using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change. 
В классе Program создайте два метода: 
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра
myClass значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
myStruct значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте
полученные результаты.*/

            MyClass myClass = new MyClass();
            myClass.change = "не изменено";
            MyClass.ClassTaker(myClass);
            Console.WriteLine(myClass.change);

            MyStruct myStruct = new MyStruct();
            myStruct.change = "не изменено";
            MyStruct.StructTaker(myStruct);
            Console.WriteLine(myStruct.change);

            Console.ReadKey();
        }
    }
}
