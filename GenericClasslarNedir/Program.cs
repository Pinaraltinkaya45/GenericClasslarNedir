using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();

           List<Musteri> musterilerim =  repositoryMusteri.Getir();

            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "Pınar";
            musteri.soyisim = "Altınkaya";
            musteri.emailAdres = "pinar@gmail.com";

            repositoryMusteri.Ekle(musteri);




            Repository<Urun> repositoryUrun = new Repository<Urun>();

            List<Urun> urunlerim = repositoryUrun.Getir();


            Urun urun = new Urun();
            urun.urunid = 1;
            urun.urunIsmi = "Ram Bellek";
            urun.urunFiyat = 300;

            string cikti = repositoryUrun.Ekle(urun);

            Console.WriteLine(cikti);

            Console.ReadLine();

        }
    }
}
