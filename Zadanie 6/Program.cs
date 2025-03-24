while(true)
{
    Console.Clear();
    Console.WriteLine("1. Dodaj produkt");
    Console.WriteLine("2. Usun produkt");
    Console.WriteLine("3. Wyswietl produkty");
    Console.WriteLine("4. Akutalizuj produkt");
    Console.WriteLine("5. Oblicz wartość magazynu");
    Console.WriteLine("6. Wyjście");

    ConsoleKeyInfo key = Console.ReadKey();
    char choice = key.KeyChar;
    switch (choice)
    {
        case '1':
            Console.Clear();
            Console.WriteLine("Podaj nazwę produktu: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj cenę produktu");
            Console.WriteLine("Podaj kod kreskowy produktu");
            Console.WriteLine("Podaj ilość produktu");

    }














}


