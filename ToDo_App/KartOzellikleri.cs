class KartOzellikleri:Kartım{
    
    private List<Kartım> kartlar = new List<Kartım>();

    static public void KartEkle(){
        Console.WriteLine("Baslik Giriniz: ");
        string baslik = Console.ReadLine();
        Baslik = baslik;
        Console.WriteLine("Icerik Giriniz: ");
        string icerik = Console.ReadLine();
        Icerik = icerik;
        Console.WriteLine("Kişi Seçiniz: ");
        int kisiID = Convert.ToInt32(Console.ReadLine());
        AtananKisiID.Add(kisiID, "Kart Sahibi");
        kartlar.Add(new Kartım(){Baslik = Baslik, Icerik = Icerik, AtananKisiID = AtananKisiID});
    }
    static public void KartSil(){
        Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Kart Başlığı Yazınız: ");
        string baslik = Console.ReadLine();
        Kartım kart = kartlar.Find(x => x.Baslik == baslik);
        if(kart != null){
            kartlar.Remove(kart);
            Console.WriteLine("Kart Silindi.");
        }
        else{
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("1. Silme İptal");
            Console.WriteLine("2. Yeniden Dene");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Silme İşlemi İptal Edildi.");
                    break;
                case 2:
                    KartSil();
                    break;
            }
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