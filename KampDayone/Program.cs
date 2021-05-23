using System;

namespace KampDayone
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do Not Repeat Yourself- Kendini tekrarlama!

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisCheck = false;
            if (sistemGirisCheck == true)
            {
                Console.WriteLine("Ayarlar buton png");
            }
            else
            {
                Console.WriteLine("Kayıt olmak veya giriş yapmak için tıklayın!");
            }
        }
    }
}
