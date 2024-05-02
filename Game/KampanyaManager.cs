
namespace Game
{
    public class KampanyaManager
    {
        private Dictionary<int, double> kampanyaIndirimleri = new Dictionary<int, double>();

        public void KampanyaEkle(int kampanyaId, double indirimOrani)
        {
            kampanyaIndirimleri.Add(kampanyaId, indirimOrani);
            Console.WriteLine("Yeni kampanya eklendi. Kampanya ID:" (kampanyaId), "İndirim Oranı:" (indirimOrani));
        }

        public void KampanyaSil(int kampanyaId)
        {
            kampanyaIndirimleri.Remove(kampanyaId);
            Console.WriteLine("Kampanya silindi. Kampanya ID:" ,(kampanyaId));
        }

        public void KampanyaGuncelle(int kampanyaId, double yeniIndirimOrani)
        {
            kampanyaIndirimleri[kampanyaId] = yeniIndirimOrani;
            Console.WriteLine("Kampanya güncellendi. Kampanya ID:", (kampanyaId), "Yeni İndirim Oranı:", (yeniIndirimOrani));
        }

        public double KampanyaIndirimOrani(int kampanyaId)
        {
            return kampanyaIndirimleri.GetValueOrDefault(kampanyaId, 0);
        }
    }
}
