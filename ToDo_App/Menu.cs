bool devam = true;
while (devam)
{
    // Menü
    Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("1. Board Listesi Görüntüle");
    Console.WriteLine("2. Board'a Kart Ekle");
    Console.WriteLine("3. Board'dan Kart Sil");
    Console.WriteLine("4. Kart Taşı");
    Console.WriteLine("5. Çıkış");
    Console.WriteLine("--------------------------------------------");

    // Kullanıcının seçimi
    string secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            KartListele kartListele = new KartListele();
            break;
        case "2":
            KartEkle kartEkle = new KartEkle();
            break;
        case "3":
            KartSil kartSil = new KartSil();
            break;
        case "4":
            KartTasi kartTasi = new KartTasi();
            break;
        case "5":
            Console.WriteLine("Çıkış yapılıyor...");
            devam = false;  // Çıkış yapıldığında döngüyü sonlandır
            break;
        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }

    // Kullanıcının menüye dönmesini bekle
    if (devam)
    {
        Console.WriteLine("Yine bir işlem yapmak istiyor musunuz? (E/H): ");
        string tekrar = Console.ReadLine().ToUpper();
        if (tekrar != "E")
        {
            devam = false;  // Kullanıcı "E" dışında bir şey girerse döngü sonlanacak
        }
    }
}
