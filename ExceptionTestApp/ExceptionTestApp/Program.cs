using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 0, value = 0;
            value = x / y;
            Console.Write($"value = {0}", value);
        }
    }
}
