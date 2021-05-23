using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Temel Programlama";
            string kurs3 = "Java Programlama";
            string kurs4 = "Python Programlama";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            // Array- Dizi 
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Temel Programlama", "Java Programlama" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu --> Footer by SuloNC");
        }
    }
}
