using OgrenciMail;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci O1 = new Ogrenci();
            O1.Isim = "Sevda";
            O1.Soyİsim = "Galandarli";
            O1.cinsiyet = 717770002;
            O1.Emailadres = "sevda.galandarli";

            Ogrenci O2 = new Ogrenci();
            O2.Isim = "Arzu";
            O2.Soyİsim = "Galandarli";
            O2.cinsiyet = 717770001;
            O2.Emailadres = "arzu.galandarli";

        }
    }
}
