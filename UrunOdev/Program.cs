// See https://aka.ms/new-console-template for more information

Urun urun1 = new Urun();
urun1.UrunAdi = "Telefon";
urun1.UrunMarkasi = "Samsung";
urun1.UrunFiyati = 4500;

Urun urun2 = new Urun();
urun2.UrunAdi = "Laptop";
urun2.UrunMarkasi = "Lenovo";
urun2.UrunFiyati = 6000;


Urun[] Urunler = new Urun[] {urun1, urun2};
foreach (var Urun in Urunler)
{
    Console.WriteLine(Urun.UrunAdi +":"+ Urun.UrunFiyati);
}








class Urun
{
    public string UrunAdi { get; set; }
    public string UrunMarkasi { get; set; }
    public int UrunFiyati { get; set; }
}
