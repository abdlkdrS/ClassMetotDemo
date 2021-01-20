using System;
using System.Linq;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.FirstName = "Tayfur";
            musteri1.LastName = "Lapsekili";
            musteri1.Job = "Kemantör";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.FirstName = "Vahit";
            musteri2.LastName = "Guetta";
            musteri2.Job = "Orger";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.FirstName = "Pikaçu";
            musteri3.LastName = "Ferhat";
            musteri3.Job = "Sanatçı(!)";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Banka Veritabanında Bulunan Müşreriler Aşağıda Listelenmiştir..");
            Console.WriteLine(" \t \t-------------------------------");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("---->>"+"\t" + musteri.ID);
                Console.WriteLine("Ad --->> " + musteri.FirstName);
                Console.WriteLine("Soyad --->> "+ musteri.LastName);
                Console.WriteLine("Meslek --->>" +musteri.Job);
                Console.WriteLine("******************");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri3);
            musteriManager.Delete(musteri3);
            musteriManager.Update(musteri3);

        }
        
    } 
}
