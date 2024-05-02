using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SatışManager
    {
        public void OyunSat(Oyuncu oyuncu, Oyun oyun)
        {
            Console.WriteLine($"{oyuncu.Ad} {oyuncu.Soyad} adlı oyuncuya {oyun.Ad} oyunu satıldı. Fiyat: {oyun.Fiyat} TL");
        }

        public void KampanyalıOyunSat(Oyuncu oyuncu, Oyun oyun, double indirimOranı)
        {
            double indirimliFiyat = oyun.Fiyat - (oyun.Fiyat * (indirimOranı / 100));
            Console.WriteLine($"{oyuncu.Ad} {oyuncu.Soyad} adlı oyuncuya {oyun.Ad} oyunu %{indirimOranı} indirimle satıldı. Fiyat: {indirimliFiyat} TL");
        }
    }

}
