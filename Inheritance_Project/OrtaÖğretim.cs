using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    internal class OrtaÖğretim:Öğrenci
    {
        public OrtaÖğretim(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {

        }
    }
}
