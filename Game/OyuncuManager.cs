using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class OyuncuManager
    {
        private List<Oyuncu> oyuncular = new List<Oyuncu>();

        public void KayıtOl(Oyuncu oyuncu)
        {
            oyuncular.Add(oyuncu);
            Console.WriteLine("Oyuncu kaydedildi.");
        }

        public void BilgileriGüncelle(long tcNo, Oyuncu yeniBilgiler)
        {
            var oyuncu = oyuncular.Find(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {
                oyuncu.Ad = yeniBilgiler.Ad;
                oyuncu.Soyad = yeniBilgiler.Soyad;
                oyuncu.DoğumYılı = yeniBilgiler.DoğumYılı;
                Console.WriteLine("Oyuncu bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine("Belirtilen TcNo'ya sahip oyuncu bulunamadı.");
            }
        }

        public void KayıtSil(long tcNo)
        {
            var oyuncu = oyuncular.Find(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {
                oyuncular.Remove(oyuncu);
                Console.WriteLine("Oyuncu kaydı silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen TcNo'ya sahip oyuncu bulunamadı.");
            }
        }

        public bool Dogrula(long tcNo, string ad, string soyad, int doğumYılı)
        {
            // E-devlet doğrulama işlemi simülasyonu
            // Gerçek bir entegrasyon için uygun servislere bağlanılmalıdır
            // Bu örnekte doğrulama her zaman başarılıdır
            return true;
        }
    }

}
