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
    }
}
