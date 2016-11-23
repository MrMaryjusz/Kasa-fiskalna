using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication18
{
    class Aplikacja : Koszyk
    {
        public char klawisz;
        public void WypiszLegende()
        {
            Console.WriteLine("Dzień Dobry!\n");
            Console.WriteLine("Co Chcesz zrobić? Naciśnij odpowiedni klawisz.\n");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartość koszyka");
            Console.WriteLine("2S - pokaz Sumę do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz znać wcześniej numer na liście");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - Zakończ program");
        }
        public void WczytajKlawisz()
        {

            WypiszLegende();
            klawisz = Console.ReadKey().KeyChar;
            WykonajDzialanie();
            Console.ReadKey();
        }
        public void WykonajDzialanie()
        {
            switch (klawisz)
            {
                case 'P':
                    Console.WriteLine("Podaj nazwe produktu: ");
                    nazwa = Console.ReadLine();
                    Console.WriteLine("Podaj cene za jednostke: ");
                    cenaJednostkowa = (double)Console.Read();
                    Console.WriteLine("Podaj ilosc: ");
                    ilosc =Convert Console.ReadLine();
                    zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
                    Console.WriteLine("Dodano: {0}\nIlosc: {1}\n",nazwa,ilosc);
                    break;
                case 'K':

                    break;
                case 'Z':
                    foreach (var z in zakupy)
                    {
                        Console.WriteLine("Nazwa: {0}\nCena: {1}\nIlsoc: {2}", nazwa, cenaJednostkowa, ilosc);
                    }

                    break;
                case 'S':
                    foreach(var z in zakupy)
                    {
                        double suma = 0, suma2 = 0;
                        suma = cenaJednostkowa * ilosc;
                        suma2 =+ suma;
                    }
                    Console.WriteLine("Suma: ");
                    break;
                case 'X':

                    break;
                case 'W':

                    break;
                case 'N':

                    break;
            }
        }
    }
}
