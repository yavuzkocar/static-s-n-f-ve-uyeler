using System;

namespace static_sınıf_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalısanSayisi);

            Calısan calisan=new Calısan("ayşa", "yılmaz", "İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalısanSayisi);

             Calısan calisan1=new Calısan("yavuz", "kocar", "İK");
             Calısan calisan2=new Calısan("ali", "yılmaz", "İK");

             Console.WriteLine(islemler.topla(122,221));
             Console.WriteLine(islemler.cikar(122,221));
        }
    }
    class Calısan
    {
        private static int calısanSayisi;

        public static int CalısanSayisi { get => calısanSayisi;  }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calısan() //ilk başta static olan çalışır sonra her seferinde public e gider (debug koy dene)
        {
            calısanSayisi = 0;
        }

        public Calısan(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;
            calısanSayisi++;
        }
    }
    static class islemler{

        public static long topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
