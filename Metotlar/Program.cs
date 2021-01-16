﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Urunadi1 = "elma";
            double fiyati = 15;
            string aciklama = "Amasya elma";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elmaa";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elma";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

                

            }
            Console.WriteLine("-------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", " Yeşil armut",12, 10);
            sepetManager.Ekle2("Elma", " Yeşil elmat", 12, 10);
            sepetManager.Ekle2("Karpuz", " diyarbakır karpuzu", 12,8);



        }
    }
}
