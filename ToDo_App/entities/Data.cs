internal class Data {
    public static Dictionary<int,string> kisiListesi = new Dictionary<int, string>();

    public Data()
    {
        if(kisiListesi.Count == 0)
        {
            kisiListesi.Add(1,"Ali Yalnız");
            kisiListesi.Add(2,"Emre Özkan");
            kisiListesi.Add(3,"Ahmet Fatih Ak");
            kisiListesi.Add(4,"Nazan Ay");
            kisiListesi.Add(5,"Yalın Çınar");

            Console.WriteLine("Kisi Listesi Oluşturuldu");
        }
        else 
        {
            Console.WriteLine("Kişi Listesi Zaten Oluşturulmuş");
        }
    }
    public static void AddCards(string baslik, string icerik, string uye, EnSize size, string line)
{
    Kart kart1 = new Kart
    {
        baslik = baslik,
        icerik = icerik,
        kisi = uye,
        size = size,
        line = line
    };

    if (line == "1" || line.ToLower() == "todo")
    {
        Board.KartToDo.Add(kart1);
        Console.WriteLine("Kart TODO listesine eklendi: " + kart1.baslik);
    }
    else if (line == "2" || line.ToLower() == "inprogress")
    {
        Board.KartProgress.Add(kart1);
        Console.WriteLine("Kart INPROGRESS listesine eklendi: " + kart1.baslik);
    }
    else if (line == "3" || line.ToLower() == "done")
    {
        Board.KartDone.Add(kart1);
        Console.WriteLine("Kart DONE listesine eklendi: " + kart1.baslik);
    }
    else
    {
        Console.WriteLine("Geçersiz Line değeri: " + line);
    }

    Board.KartAll.Add(kart1);
}

}