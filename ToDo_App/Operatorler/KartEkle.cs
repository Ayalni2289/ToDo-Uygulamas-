internal class KartEkle
{
    Data db = new Data();  // Varsayılan veri bağlantısı
    public KartEkle()
        {
            Console.WriteLine("Başlık Giriniz:  ");
            string baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz:  ");
            string icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            EnSize boyut = (EnSize)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi Seçiniz:    ");
            int kisi = int.Parse(Console.ReadLine());

            Console.WriteLine("Board Seçiniz:   ");
            string line = Console.ReadLine();
            string kim = null;

            if(Data.kisiListesi.ContainsKey(kisi))
            {
                kim = Data.kisiListesi[kisi];
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı");
                return;
            }
        Data.AddCards(baslik, icerik, kim, boyut, line);
    }
}

