using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            //type safety - tip güvenligi

            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarimDun = 7.55;
            double dolarinBugun = 7.5;

            if (dolarimDun>dolarinBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarimDun<dolarinBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("degişmedi butonu");
            }





            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(KategoriEtiketi);

          



        }
    }
}
