using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class MyClass<T>
    {

        public T FactoryMethod()
        {
            T myClass = default;
            return myClass;
        }
    }
}
