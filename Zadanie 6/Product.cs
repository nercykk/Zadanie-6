using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Product
    {
        public string KodKreskowy;
        public string Nazwa;
        public double Cena;
        public float Ilość;

        public Product(string kodKreskowy, string nazwa, double cena, float ilość)
        {
            KodKreskowy = kodKreskowy;
            Nazwa = nazwa;
            Cena = cena;
            Ilość = ilość;
        }
    }
}


