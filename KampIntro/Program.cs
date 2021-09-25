using Metotlar;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 6;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler) //var item in tanımlanacak olan method
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Methotlar------------");
            
            //instance (Örnek)
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut" ,"YeşilArmut" , 12, 11);
            sepetManager.Ekle2("Elma" ,"YeşilElma" , 12, 14);
            sepetManager.Ekle2("Karpuz", "YeşilKarpuz", 12, 20);
            

        }
    }
}
