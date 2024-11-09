internal class KartSil
{
    Data db = new Data();  // Varsayılan veri bağlantısı
    public KartSil()
    {
        bool kontrol = true;
        while (kontrol)
        {
            Console.WriteLine("Silmek istediğiniz Kart Başlığını Yazınız: ");
            string silme = Console.ReadLine();
            bool kartBulundu = false;

            foreach (var item in Board.KartAll)  // Tüm kartları dolaşarak arama
            {
                if (item.baslik.ToLower() == silme.ToLower())  // Kart başlığı eşleşirse
                {
                    Board.KartToDo.Remove(item);  // Kartı listeden kaldır
                    Console.WriteLine($"{silme} kartı silindi.");
                    kartBulundu = true;
                    break;
                }
            }

            if (!kartBulundu)
            {
                Console.WriteLine("Aradığınız Kritere Uygun Kart board'da bulunamadı.");
                Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                Console.WriteLine("* Yeniden denemek için (2)");
                
                try
                {
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    
                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış Yapıldı.");
                        kontrol = false;
                    }
                    else if (input1 != 2)
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Tekrar deneyiniz.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen bir sayı girin.");
                }
            }
        }
    }
}
