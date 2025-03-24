using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        public string DodajProdukt;
        public string UsunProdukt;
        public string WyswietlProdukty;
        public string AktualizujProdukty;
        public string ObliczWartośćProduktów;
        public string Wyjście;
        public Program(string dodajProdukt, string usunProdukt, string wyswietlProdukty, string aktualizujProdukty, string obliczWartośćProduktów, string wyjście)
        {
            DodajProdukt = dodajProdukt;
            UsunProdukt = usunProdukt;
            WyswietlProdukty = wyswietlProdukty;
            AktualizujProdukty = aktualizujProdukty;
            ObliczWartośćProduktów = obliczWartośćProduktów;
            Wyjście = wyjście;


        }
    }
}

