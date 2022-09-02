using System;

namespace _7._1
{
    internal class MyClass
    {
        public string change { get; set; }
        internal static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
            Console.WriteLine(myClass.change);
        }
    }
}