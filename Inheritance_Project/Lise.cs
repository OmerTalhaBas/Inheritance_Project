using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    internal class Lise:Öğrenci
    {
        public int Not1 { get; set; }
        public int Not2 { get; set; }
        public Lise(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi, int not1, int not2) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {
            this.Not1 = not1;
            this.Not2 = not2;
        }
        public void NotHesapla()
        {
            double ortalama = (Not1 + Not2) / 2;
            if (ortalama >=85&&ortalama <=100) Console.WriteLine("Pekiyi");
            else if (ortalama >=70&&ortalama<=85) Console.WriteLine("İyi");
            else if (ortalama >=60&&ortalama<=70) Console.WriteLine("Orta");
            else if (ortalama >=50&&ortalama<=60) Console.WriteLine("Geçer");
            else if (ortalama >=0&&ortalama<=50) Console.WriteLine("Tekrar");
            else Console.WriteLine("Hatalı Not");
        }
    }
}
