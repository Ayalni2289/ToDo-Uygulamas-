class KartOzellikleri{
    
    private static List<Kartım> kartlar = new List<Kartım>();
    public static void KartEkle(){
        Kartım yeniKart = new Kartım();
        Console.WriteLine("Başlık Giriniz: ");
        yeniKart.Baslik = Console.ReadLine();

        Console.WriteLine("İçerik Giriniz: ");
        yeniKart.Icerik = Console.ReadLine();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
        yeniKart.buyuklukEnum = (Kartım.BuyuklukEnum)Enum.Parse(typeof(Kartım.BuyuklukEnum), Console.ReadLine());

        Console.WriteLine("Kişi Seçiniz: ");
        
    }
    static public void KartSil(){
        Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz: ");
        string baslik = Console.ReadLine();
        Kartım kart = kartlar.FirstOrDefault(k => k.Baslik == baslik);

        if (kart != null)
        {
            kartlar.Remove(kart);
            Console.WriteLine("Kart Silindi.");
        }
        else
        {
            Console.WriteLine("Kart bulunamadı.");
        }
    }
    static public void KartGuncelle(){

    }
    static public void KartTasi(){
        Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Kart Başlığı Yazınız: ");
        string baslik = Console.ReadLine();
        Kartım kart = kartlar.Find(x => x.Baslik == baslik);
        if(baslik != null){
            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("Başlık: "+kart.Baslik);
            Console.WriteLine("İçerik: "+kart.Icerik);
            Console.WriteLine("Atanan Kişi: "+kart.AtananKisiID);
            Console.WriteLine("Büyüklük: "+ BuyuklukEnum.XS);
            Console.WriteLine("Hangi Board'a taşımak istiyorsunuz?");
            Console.WriteLine("1. Todo");
            Console.WriteLine("2. In Progress");
            Console.WriteLine("3. Done");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    
                    break;
                case 2:
                    kart.Buyukluk = "S";
                    break;
                case 3:
                    kart.Buyukluk = "M";
                    break;
            }
        }
        else{
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("1. Taşıma İptal");
            Console.WriteLine("2. Yeniden Dene");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Taşıma İşlemi İptal Edildi.");
                    break;
                case 2:
                    KartTasi();
                    break;
            }
        }
    }
    static public void BoardListele(){

    }

}