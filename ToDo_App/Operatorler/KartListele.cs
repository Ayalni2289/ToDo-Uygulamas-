internal class KartListele
{
    public void YazdirKart(Kart kart)
    {
        Console.WriteLine("Başlık: " + kart.baslik);
        Console.WriteLine("İçerik: " + kart.icerik);
        Console.WriteLine("Atanan Kişi: " + kart.kisi);
        Console.WriteLine("Büyüklük: " + kart.size);
        Console.WriteLine("-----------------------------");
    }

    public KartListele()
    {
        Console.WriteLine("********** TODO Line **********");
        if (Board.KartToDo.Count == 0)
        {
            Console.WriteLine("TODO listesinde kart yok.");
        }
        foreach (var item in Board.KartToDo)
        {
            YazdirKart(item);
        }

        Console.WriteLine("********** INPROGRESS Line **********");
        if (Board.KartProgress.Count == 0)
        {
            Console.WriteLine("INPROGRESS listesinde kart yok.");
        }
        foreach (var item in Board.KartProgress)
        {
            YazdirKart(item);
        }

        Console.WriteLine("********** DONE Line **********");
        if (Board.KartDone.Count == 0)
        {
            Console.WriteLine("DONE listesinde kart yok.");
        }
        foreach (var item in Board.KartDone)
        {
            YazdirKart(item);
        }
    }
}
