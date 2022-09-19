using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    internal class CarCollection<T>
    {
        private T[] cars;

        public CarCollection(T[] cars)
        {
            this.cars = cars;
        }

        public T this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }

        public void Show()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        public int sum = 0;
        public void Counter()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                sum+= i;
            }

            Console.WriteLine(sum);
        }

        public void Clear()
        {
            Array.Clear(cars, 0, cars.Length);
        }
    }
}
