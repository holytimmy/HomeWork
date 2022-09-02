using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Store
    {
        Article[] s = new Article[4];

        public Article this[int index]
        {
            get { return s[index]; }
            set { s[index] = value; }
        }

        public void ShowName(string productName)
        {
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
        }
    }
}
