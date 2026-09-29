using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int x, y;
            Console.Write("x=");
            a = Console.ReadLine();
            Console.Write("y=");
            b = Console.ReadLine();
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);
            Console.Write("2x+y=");
            Console.Write(2 * x + y);
            Console.ReadLine();

        }
    }
}
