using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_sklepowa_test1
{
    internal class productlist
    {
        public class items
        {
            private int barcode { get; set; }
            private string name { get; set; }
            private double price { get; set; }

            // constructor
            public items(int barcode, string  name, double price)
            {
                this.barcode = barcode;
                this.name = name;
                this.price = price;
            }
            
            public int getbarcode
            {
                get { return barcode; }
            }
            public string getname
            {
                get { return name; }
            }
            public double getprice
            {
                get { return price; }
            }
        }
        public static void itemlist()
        {
            // tworzy liste produktow
            List<items> itemList = new List<items>();
            itemList.Add(new items(001,"| Masło extra", 6.50));
            itemList.Add(new items(002,"| Chleb wiejski", 4.50));
            itemList.Add(new items(003,"| Makaron babuni", 9.20));
            itemList.Add(new items(004,"| Dżem truskawkowy", 8.10));
            itemList.Add(new items(005,"| Kiełbasa myśliwska", 29.00));
            itemList.Add(new items(006,"| Szynka konserwowa", 22.00));
            itemList.Add(new items(007,"| Chipsy paprykowe", 6.00));
            itemList.Add(new items(008,"| Serek wiejski", 3.50));
            itemList.Add(new items(009,"| Sól kuchenna", 2.70));
            itemList.Add(new items(010,"| Cukier kryształ", 3.20));


            // wyswietlanie listy
            foreach (var items in itemList)
               Console.WriteLine("{0}, {1}", items.getbarcode, items.getname);
        }
    }
}
