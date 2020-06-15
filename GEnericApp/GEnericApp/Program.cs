using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnericApp
{
    public class simpleGEneric<T>
    {
        private T[] values;
        private int index;

        public simpleGEneric(int len)
        {
            values = new T[len];
            index = 0;
        }

        public void add(params T[] args)
        {
            foreach (T item in args)
            {
                values[index++] = item;
            }
        }
        public void Print()
        {
            foreach (T e in values)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        class Program
        {
            static void Main(string[] args)
            {
                simpleGEneric<Int32> gInteger = new simpleGEneric<Int32>(10);
                simpleGEneric<Double> gDouble = new simpleGEneric<Double>(10);

                gInteger.add(1, 2);
                gInteger.add(1, 2, 3, 4, 5, 6, 7);
                gInteger.add(10);

                gDouble.add(10.0, 12.4, 37.5);
                gInteger.Print();
                gDouble.Print();
            }
        }
    }
}
