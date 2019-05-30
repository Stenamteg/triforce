using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace old
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Введите размер основания: ");
            string o = Console.ReadLine();
            int a = Convert.ToInt32(o);
            string c = "\r\n";
            Console.WriteLine("Хоба!");
            Console.WriteLine($"{new string(' ', a / 2 + 1)}{symbol}");
            Console.WriteLine(string.Concat(Enumerable.Repeat(c, a / 4)));
            Console.WriteLine($"{symbol}{new string(' ', a)}{symbol}");

            Console.ReadKey();
        }
    }
}
