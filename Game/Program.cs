using Game;
using System;

class Program
{
    static void Main(string[] args)
    {
        OyuncuManager oyuncuManager = new OyuncuManager();
        SatışManager satışManager = new SatışManager();
        KampanyaManager kampanyaManager = new KampanyaManager();

        Oyun oyun = new Oyun { Id = 1, Ad = "GTA V", Fiyat = 150 };

        // Yeni oyuncu kaydı oluşturuyoruz
        Oyuncu oyuncu = new Oyuncu { TcNo = 12345678901, Ad = "Ahmet", Soyad = "Yılmaz", DoğumYılı = 1990 };
        oyuncuManager.KayıtOl(oyuncu);

        // E-devlet doğrulaması yapıyoruz
        if (oyuncuManager.Dogrula(oyuncu.TcNo, oyuncu.Ad, oyuncu.Soyad, oyuncu.DoğumYılı))
        {
            // Oyuncuya oyunu satıyoruz
            satışManager.OyunSat(oyuncu, oyun);

            // Yeni bir kampanya oluşturuyoruz
            kampanyaManager.KampanyaEkle(1, 20);

            // Oyuncuya kampanyalı oyunu satıyoruz
            double indirimOrani = kampanyaManager.KampanyaIndirimOrani(1);
            satışManager.KampanyalıOyunSat(oyuncu, oyun, indirimOrani);

            // Kampanyayı güncelliyoruz
            kampanyaManager.KampanyaGuncelle(1, 30);

            // Oyuncuya güncellenmiş kampanyalı oyunu satıyoruz
            indirimOrani = kampanyaManager.KampanyaIndirimOrani(1);
            satışManager.KampanyalıOyunSat(oyuncu, oyun, indirimOrani);

            // Kampanyayı siliyoruz
            kampanyaManager.KampanyaSil(1);

            // Kampanya silindiği için indirim uygulanmadan oyunu satıyoruz
            satışManager.OyunSat(oyuncu, oyun);
        }
        else
        {
            Console.WriteLine("E-devlet doğrulaması başarısız. Satış gerçekleştirilemedi.");
        }
    }
}
