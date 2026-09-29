using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            double x, y;
            Console.Write("x=");
            a = Console.ReadLine();
            x = Convert.ToDouble(a);
            Console.Write("y=");
            b = Console.ReadLine();
            y = Convert.ToDouble(b);
            Console.Write("x/2+3y=");
            Console.Write(x/2 + 3*y);
            Console.ReadLine();
        }
    }
}
