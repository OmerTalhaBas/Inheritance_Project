using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    internal class Lisans:Öğrenci
    {
        public string Fakulte { get; set; }
        public int VizeNotu { get; set; }
        public int FinalNotu { get; set; }

        public Lisans(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi, string fakulte, int VizeNotu, int FinalNotu) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {
            Fakulte = fakulte;
            VizeNotu = VizeNotu;
            FinalNotu = FinalNotu;
        }
        public void NotHesapa()
        {
            double ortalama = (VizeNotu + FinalNotu) / 2;
            if (ortalama >= 85 && ortalama <= 100) Console.WriteLine("AA");
            else if (ortalama >= 70 && ortalama <= 85) Console.WriteLine("BB");
            else if (ortalama >= 60 && ortalama <= 70) Console.WriteLine("CC");
            else if (ortalama >= 50 && ortalama <= 60) Console.WriteLine("DD");
            else if (ortalama >= 0 && ortalama <= 50) Console.WriteLine("FF");
            else Console.WriteLine("Hatalı Not");
        }
    }
}
