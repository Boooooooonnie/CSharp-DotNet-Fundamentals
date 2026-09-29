using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, f, g, r;
            a = 0b00111100;
            b = 0b00001111;
            c = 0b0000_0011;
            d = 0b0111_1000;
            f = 0b0000_0011;
            g = 0b0111_1000;
            Console.WriteLine("a的值 : "+a);
            Console.WriteLine("b的值 : "+b);
            Console.WriteLine("c的值 : "+c);
            Console.WriteLine("d的值 : "+d);

            r = a & b;
            Console.WriteLine("AND運算(a&b) : "+r);

            r = a | b;
            Console.WriteLine("OR運算(a|b) : "+r);

            r = a ^ b;
            Console.WriteLine("XOR運算(a^b) : "+r);

            Console.WriteLine("f的值 : "+f);
            Console.WriteLine("g的值 : "+g);

            Console.WriteLine("左移運算(f<<1) : "+f);
            Console.WriteLine("左移運算(f<<2) : "+f);

            Console.WriteLine("右移運算(g>>1) : "+g);
            Console.WriteLine("右移運算(g>>2) : "+g);

            Console.Read();
        }
    }
}
