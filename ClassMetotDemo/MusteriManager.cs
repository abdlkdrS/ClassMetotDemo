using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("----->>"+ musteri.ID +"ID Numaralı Musteri Eklendi!");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("----->>" + musteri.ID + "ID Numaralı Musteri Silindi");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("----->>" + musteri.ID + "ID Numaralı Musteri Guncellendi");
        }
    }
}
