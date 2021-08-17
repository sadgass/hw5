using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwex2
{
    class Program
    {
        static void Main(string[] args)
        {
            replacetest();
        }

        private static void replacetest()
        {
            Console.WriteLine("Введите 1-ю последовательность");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите 2-ю последовательность");
            string s2 = Console.ReadLine();

            bool res = s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));

            if (res)
            {
                Console.WriteLine("Строки состоят из одинаковых букв");
            }
            else
            {
                Console.WriteLine("Строки не состоят из одинаковых букв");
            }
        }
    }
}
