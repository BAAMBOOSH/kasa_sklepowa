using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_sklepowa_test1
{
    internal class Userchoice
    {
        public int menu()
        {
            //sprawdzenie czy user wcisnal liczbe
            var number = 0;
            Console.WriteLine();
            Console.WriteLine("WYBIERZ 1,2 LUB 3:");
            var userText = Console.ReadLine();
            while (!int.TryParse(userText, out number))
            {
                Console.WriteLine();
                Console.WriteLine(" To nie jest liczba.");
                userText = Console.ReadLine();
            }

            return number;
            
        }
    }
}
