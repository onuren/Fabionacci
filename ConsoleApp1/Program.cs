using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 1;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            for (int i = 0; i < 50; )
            {
                i = sayi1 + sayi2;
                sayi1 = i + sayi2;
                sayi2 = sayi1 + i;
                Console.WriteLine(i);
                Console.WriteLine(sayi1);
                Console.WriteLine(sayi2);
            }
        }
    }
}
