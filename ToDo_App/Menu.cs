
class Menu:Kartım{
   static public void MenuGoster(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
        Console.WriteLine("1. Board Listele");
        Console.WriteLine("2. Board'a Kart Ekle");
        Console.WriteLine("3. Board'dan Kart Sil");
        Console.WriteLine("4. Kart Taşı");
        Console.WriteLine("0. Çıkış");   
    }
    static public string veri = Console.ReadLine();
    
    static public void Secenek(){
        switch (veri)
        {
            case "1":
            KartOzellikleri.BoardListele();
            case "2":
            KartOzellikleri.KartEkle();
            case "3":
            KartOzellikleri.KartSil();
            case "4":
            KartOzellikleri.KartTasi();
            case "0":
            break;
        }
    }

}