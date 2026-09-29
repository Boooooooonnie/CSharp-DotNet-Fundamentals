using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int x, y;
            Console.Write("x=");
            a=Console.ReadLine();
            x = Convert.ToInt32(a);
            Console.Write("y=");
            b = Console.ReadLine();
            y = Convert.ToInt32(b);
            Console.Write("(x-3)*(y-2)=");
            Console.Write((x - 3) * (y - 2));
            Console.ReadLine();
        }
    }
}
