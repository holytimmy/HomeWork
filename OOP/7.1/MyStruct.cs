using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    struct MyStruct
    {
        public string change;
        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
            Console.WriteLine(myStruct.change); 
        }
    }
}
