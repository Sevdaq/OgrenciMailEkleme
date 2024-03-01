namespace OgrenciMail
{
    public class Ogrenci
    {
        public static string domainAdres;

        public string Isim { get; set; }
        public string Soyİsim { get; set; }

        private string _emailadres;
        public string Emailadres
        {

            get
            {
                return this._emailadres;
            }
            set
            {

                this._emailadres = value.ToLower() + "@" + Ogrenci.domainAdres;

            }
        }
        public int cinsiyet { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("her örneklemede çalışan metod");

        }
        static Ogrenci()
        {
            domainAdres = "okulum.com";
        }



    }
}
