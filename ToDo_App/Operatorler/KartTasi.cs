internal class KartTasi
{
    public KartTasi()
    {
        Console.WriteLine("Taşımak istediğiniz kartın başlığını yazınız: ");
        string baslik = Console.ReadLine();
        bool kartBulunmadi = true;
        bool cikis = false;

        while (!cikis)
        {
            foreach (var item in Board.KartAll)
            {
                if (item.baslik.ToLower() == baslik.ToLower())
                {
                    kartBulunmadi = false;
                    Console.WriteLine("Bulunan Kart Bilgileri: ");
                    Console.WriteLine("Başlık: " + item.baslik);
                    Console.WriteLine("İçerik: " + item.icerik);
                    Console.WriteLine("Atanan Kişi: " + item.kisi);
                    Console.WriteLine("Büyüklük: " + item.size);
                    Console.WriteLine("Line: " + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Hangi Line'a taşımak istiyorsunuz?");
                    Console.WriteLine("1. Todo");
                    Console.WriteLine("2. In Progress");
                    Console.WriteLine("3. Done");
                    try
                    {
                        int secim = Convert.ToInt32(Console.ReadLine());
                        switch (secim)
                        {
                            case 1:
                                Board.KartToDo.Add(item);
                                Board.KartAll.Remove(item);
                                Console.WriteLine("Kart Todo Line'a taşındı.");
                                break;
                            case 2:
                                Board.KartProgress.Add(item);
                                Board.KartAll.Remove(item);
                                Console.WriteLine("Kart In Progress Line'a taşındı.");
                                break;
                            case 3:
                                Board.KartDone.Add(item);
                                Board.KartAll.Remove(item);
                                Console.WriteLine("Kart Done Line'a taşındı.");
                                break;
                            default:
                                Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 giriniz.");
                                continue;
                        }
                        cikis = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                    }
                    break;
                }
            }
            if (kartBulunmadi)
            {
                Console.WriteLine("Aradığınız kritere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("1. Taşıma İptal");
                Console.WriteLine("2. Yeniden Dene");
                try
                {
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Taşıma İşlemi İptal Edildi.");
                            cikis = true;
                            break;
                        case 2:
                            Console.WriteLine("Yeniden Deneyiniz.");
                            break;
                        default:
                            throw new Exception("Geçersiz seçim.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                }
            }
        }
    }
}
