using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    enum OkulDuzeyi
    {
        İlkOgretim, OrtaOgretim, Lise, Lisans
    }

    internal class Öğrenci
    {
        public string AdSoyad { get; set; }
        public int OkulNumarasi { get; set; }
        public string OkulAdi = "Açıktan Eğitim";
        public OkulDuzeyi OkulDuzeyi;

        public Öğrenci(string adSoyad, int okulNumarasi, string? okulAdi, OkulDuzeyi okulDuzeyi)
        {
            this.AdSoyad = AdSoyad;
            this.OkulDuzeyi = okulDuzeyi;
            this.OkulNumarasi = okulNumarasi;
            if (!string.IsNullOrEmpty(OkulAdi))
            {
                this.OkulAdi = okulAdi;
            }
        }
        
    }

}
