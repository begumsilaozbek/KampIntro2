
namespace KampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarBugün = 16.30;
            double dolarDün = 16.25;

            if (dolarBugün<dolarDün)
            {
                System.Console.WriteLine("artış butonu");
            }
            else if (dolarBugün>dolarDün)
            {
                System.Console.WriteLine("azalış butonu");
            }
            else
            {
                System.Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                System.Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                System.Console.WriteLine("Giriş yap butonu");
            }

            System.Console.WriteLine(kategoriEtiketi); 

           

         
        }
    }
}
