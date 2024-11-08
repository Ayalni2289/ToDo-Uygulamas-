class Kartım{
    private string baslik;
    private string icerik;
    private Dictionary<int,string> atananKisiID;
    public enum BuyuklukEnum{
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }
    public string Baslik { get => baslik; set => baslik = value; }
    public string Icerik { get => icerik; set => icerik = value ;}
    public Dictionary<int, string> AtananKisiID { get => atananKisiID; set => atananKisiID = value; }
    // 1: Ali
    // 2: Mehmet
}