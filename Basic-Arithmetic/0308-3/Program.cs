using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,c;
            double x, y,z;
            Console.Write("A=");
            a=Console.ReadLine();
            x = Convert.ToDouble(a);
            Console.Write("B=");
            b = Console.ReadLine();
            y = Convert.ToDouble(b);
            Console.Write("C=");
            c = Console.ReadLine();
            z = Convert.ToDouble(c);

            Console.Write("ans=");
            Console.Write(Math.Sqrt((Math.Pow(y, 2)) - 4 * x * z));
            Console.ReadLine();
        }
    }
}
