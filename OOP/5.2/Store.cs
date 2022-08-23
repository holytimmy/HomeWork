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

        //public void Print(Article a1, Article a2, Article a3, Article a4)
        //{
        //    Article [] s = {a1, a2, a3, a4};
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        Console.WriteLine(s[i]);
        //    }
        //}
    }
}
