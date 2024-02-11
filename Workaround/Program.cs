namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas(); //instance
            SelamVer("engin");
            SelamVer("erto");
            SelamVer();
            int sonuc = Topla(6, 58);

            //Diziler Arrays

            string ogrenci1 = "Erto";
            string ogrenci2 = "Engin";
            string ogrenci3 = "Berkay";


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Erto";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            //Referans Tipleri
            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //Değer tipi
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            //string referans tiptir fakat değer tip olarak çalışır //char array

            //dizi formatındaki yapılar dönülür
            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //generic collections 
            List<string> yeniSehirler1 = new List<string> { "Mersin", "Yozgat", "Çorum" };
            yeniSehirler1.Add(item: "Çankırı");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person() { FirstName = "Ertuğrul", LastName = "Tüfek" };


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }



        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc.ToString());
            return sonuc;
        }
    }


    // Pascal Casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
