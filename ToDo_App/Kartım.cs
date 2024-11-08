public class TakimUyesi
{
    public int ID { get; set; }
    public string Adi { get; set; }

    public TakimUyesi(int id, string adi)
    {
        ID = id;
        Adi = adi;
    }
}

public class Kartım
{
    private string baslik;
    private string icerik;
    private TakimUyesi atananKisi;
    private BuyuklukEnum buyukluk;
    public enum BuyuklukEnum
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }
    public string Baslik {get => baslik; set => baslik = value;}
    public string Icerik {get => icerik; set => icerik = value;}
    public TakimUyesi AtananKisiID {get => atananKisi; set => atananKisi = value;}
    public BuyuklukEnum Buyukluk  {get => buyukluk; set => buyukluk = value;}
}
