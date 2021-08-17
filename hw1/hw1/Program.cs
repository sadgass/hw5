using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string guestlogin = Console.ReadLine();
            string login = "qwe321";

            
            if (guestlogin.Length < 2 || guestlogin.Length > 10)
            {
                Console.WriteLine("Логин не верного формата");
            }
          
            bool correct = true;

            if (Char.IsDigit(guestlogin[0]))
            {
                correct = false;
                return;

            }
            

            if (correct && guestlogin == login)
            {
                Console.WriteLine("Открыт доступ к системе");
            }
            else
            {
                Console.WriteLine("Логин не верный");
            }

        }
    }
}
