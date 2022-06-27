// See https://aka.ms/new-console-template for more information

{
    kurs kurs1 = new kurs();
    kurs1.KursAdi = "C#";
    kurs1.egitmen = "engin";
    kurs1.izlenmeorani = 80;

    kurs kurs2 = new kurs();
    kurs2.KursAdi = "C++";
    kurs2.egitmen = "mehmet";
    kurs2.izlenmeorani = 87;

    kurs kurs3 = new kurs();
    kurs3.KursAdi = "java";
    kurs3.egitmen = "bilge";
    kurs3.izlenmeorani = 45;

    kurs[] kurslar = new kurs[] {kurs1 , kurs2, kurs3 };
    foreach (var kurs in kurslar)
    {
        Console.WriteLine(kurs.KursAdi + ":" + kurs.egitmen);
    }
}





class kurs
{
    public string KursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlenmeorani { get; set; }
}
