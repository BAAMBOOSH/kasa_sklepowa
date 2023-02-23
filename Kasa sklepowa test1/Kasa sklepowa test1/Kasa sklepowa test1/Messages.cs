using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_sklepowa_test1
{
    internal class Messages
    {
        //erkan powitalny
        public void WelcomeScreen()
        {
            Console.WriteLine("Wybierz opcję: ");
            Console.WriteLine("1 => Lista wszystkich produktów");
            Console.WriteLine("2 => Zakupy");
            Console.WriteLine("3 => Zakończ program");

        }
        //wybor produktu lub kod kreskowy
        public void SelectProduct()
        {
            Console.WriteLine("KOD KRESKOWY LUB WYDRUK PARAGONU (P): ");
            var productcode = Console.ReadLine();
            Console.WriteLine(productcode);
        }
    }
}
