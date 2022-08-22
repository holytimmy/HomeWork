using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Article
    {
        string name;
        string market;
        decimal price;
        public Article(string name, string market, decimal price)
        {
            this.name = name;
            this.market = market;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public string Market
        {
            get { return market; }
        }

        public decimal Price
        {
            get { return price; }
        }
    }
}
