using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterı müşteri = new Musterı();
            müşteri.Id = 4522;
            müşteri.Ad = "Hakan";
            müşteri.Soyad = "Budak";

            Musterı müşteri2 = new Musterı();
            müşteri2.Id = 1885;
            müşteri2.Ad = "Ebru";
            müşteri2.Soyad = "Budak";

            Musterı müşteri3 = new Musterı();
            müşteri3.Id = 5321;
            müşteri3.Ad = "Gulden";
            müşteri3.Soyad = "Budak";

            Musterı müşteri4 = new Musterı();
            müşteri4.Id = 2121;
            müşteri4.Ad = "Adem";
            müşteri4.Soyad = "Budak";

            Musterı[] musteridizi = new Musterı[] { müşteri, müşteri2, müşteri3, müşteri4 };
            MusterıManager müsterimanager = new MusterıManager();
            foreach (Musterı musteri in musteridizi)
            {
                müsterimanager.MusterıEkle(musteri);
            }

            Console.WriteLine("--------Listeleme--------");
            müsterimanager.Lısteleme(musteridizi);
            Console.WriteLine("--------Silme------------");
            müsterimanager.Musterisilme(müşteri2);

            Console.Read();

        }
    }
}
