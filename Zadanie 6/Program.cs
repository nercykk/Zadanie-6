using System.Data.SqlTypes;
using Zadanie_6;

List<Product> storage = new List<Product>();
{
    
    while (true) {
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
                double Cena = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj kod kreskowy produktu");
                string KodKreskowy = Console.ReadLine();
                Console.WriteLine("Podaj ilość produktu");
                float Ilość = Convert.ToSingle(Console.ReadLine());
                Product newProduct = new Product(KodKreskowy, name, Cena, Ilość);
                storage.Add(newProduct);
                Product p = new Product("123456890",
                                        "Mleko",
                                        2.5,
                                        20);
                storage.Add(p);
                break;
            case '2':
                Console.Clear();
                Console.WriteLine("Podaj nazwę produktu do usunięcia: ");
                string search = Console.ReadLine();
                Product foundProduct = storage.Find(product => product.Nazwa == search);
                storage.Remove(foundProduct);
                break;
            case '3':
                Console.Clear();
                foreach (Product product in storage)
                {
                    Console.WriteLine(" Product o nazwie: " + product.Nazwa +
                        " O kodzie kreskowym: " + product.KodKreskowy +
                        " Kosztuje: " + product.Cena + "zł" +
                        " Ilość: " + product.Ilość);
                }
                break;
            case '4':
                Console.Clear();
                Console.WriteLine("Podaj nazwę produktu do zaktualizowania: ");
                string search2 = Console.ReadLine();
                Product foundProduct2 = storage.Find(product => product.Nazwa == search2);
                Console.WriteLine("Podaj nową cenę produktu");
                double Cena2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(
                    "Podaj nowy kod kreskowy produktu");
                string KodKreskowy2 = Console.ReadLine();
                Console.WriteLine("Podaj nową ilość produktu");
                float Ilość2 = Convert.ToSingle(Console.ReadLine());
                foundProduct2.Cena = Cena2;
                foundProduct2.KodKreskowy = KodKreskowy2;
                foundProduct2.Ilość = Ilość2;
                break;

            case '5':
                Console.Clear();
                double totalValue = 0;
                foreach (Product product in storage)
                {
                    totalValue += product.Cena * product.Ilość;
                }
                Console.WriteLine("Wartość całego magazynu to: " + totalValue + "zl");
                break;
            case '6':
                Environment.Exit(0);
                return;
                break;


        }
    }
}

//        p = new Product("123456891",
//                     "Chleb",
//                     2.0,
//                     10);   
//        storage.Add(p);

//        string search = "Mleko";

//        Product foundProduct = storage.Find(product => product.Nazwa == search);

//        Product foundProduct2 = null;

//        foreach (Product product in storage)
//        {
//            if (product.Nazwa == search)
//            {
//                foundProduct2 = product;
//                break;
//            }
//        }

//        storage.Remove(foundProduct);
//        foundProduct2.Cena = 3.0;
//        foreach (Product product in storage)
//        {
//            Console.WriteLine(" Product o nazwie: " + product.Nazwa + 
//                " O kodzie kreskowym: " + product.KodKreskowy +
//                " Kosztuje: " + product.Cena + "zł");
//        }

//        double totalValue = 0;
//        foreach (Product product in storage)
//        {
//            totalValue += product.Cena * product.Ilość;
//}

//Console.WriteLine("Wartość całego magazynu to: " + totalValue + "zl");










