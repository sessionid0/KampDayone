using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elması";
            product1.Fiyati = 15;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Aciklama = "Has diyarbakır karpuzu";
            product2.Fiyati = 55;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------");

            }

            Console.WriteLine("\n"+"*********METOTLAR********"+ "\n");
            //Instance- Örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12);

        }
    }
}
