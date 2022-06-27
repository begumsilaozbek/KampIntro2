// See https://aka.ms/new-console-template for more information
{
    //string kurs1 = "yazılım geliştirme kampı";
    //string kurs2 = "programlamaya başlangıç için temel kurs";
   // string kurs3 = "java";


    string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlamaya başlangıç için temel kurs", "java" , "python" };



    for (int i = 0; i < kurslar.Length; i++)
    {
        Console.WriteLine(kurslar[i]);
    }
    Console.WriteLine("For Bitti");

    foreach (string kurs in kurslar)
    {
        Console.WriteLine(kurs);
    }
    Console.WriteLine("sayfa sonu-footer");
}