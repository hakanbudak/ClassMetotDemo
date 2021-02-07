using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusterıManager
    {
        public void MusterıEkle(Musterı musterı)
        {
            Console.WriteLine(musterı.Ad +musterı.Soyad+" "+"Sisteme Eklenmiştir.");
        }

        public void Lısteleme(Musterı[] müsteriler)
        {
            foreach (Musterı musteri in müsteriler)
            {
                Console.WriteLine(musteri.Ad + ":" + musteri.Id);
            }
        }
        public void Musterisilme(Musterı musterısil)
        {
            Console.WriteLine(musterısil.Id + "Numaralı " + musterısil.Ad + " Lısteden silinmiştir");
        }
        



        
    }
}
        
 