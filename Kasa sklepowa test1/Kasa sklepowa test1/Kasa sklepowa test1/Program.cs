// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Wybierz opcję: ");
//Console.WriteLine("1 => Lista wszystkich produktów");
//Console.WriteLine("2 => Zakupy");
//Console.WriteLine("3 => Zakończ program");

using Kasa_sklepowa_test1;
using System.ComponentModel.Design;
using System.Numerics;

// tworzymy obiekt typu Message
var messages = new Messages();
messages.WelcomeScreen();

//tworzymy obiekt typu Userchoice
//wyswietla wybor opcji
var Userchoice = new Userchoice();
Userchoice.menu();

// tworzymy obiekt typu productlist
// wyswietla liste produktów
var productlist = new productlist();
productlist.itemlist();







