using System.Reflection.Metadata.Ecma335;

namespace Inheritance_Project
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            List<Öğrenci> ogrenci = new List<Öğrenci>();
            İlkÖğretim ilkÖğretim = new İlkÖğretim("Mahmut Uras", 1, "Mehmet Ali Yılmaz İlk Okulu", OkulDuzeyi.İlkOgretim);
            ogrenci.AddRange(new List<Öğrenci>()
            {
                new Lise("Erkan Türk",3 ,"Atatürk Lisesi",OkulDuzeyi.Lise,100,90),
                new Lisans("Onur Yağız",4 ,"Uludağ Üniversitesi",OkulDuzeyi.Lisans,"Eğitim Fakültesi",70,90 ),
                new İlkÖğretim("Erkan Türk",5 ,"Atatürk Lisesi",OkulDuzeyi.İlkOgretim),
                new OrtaÖğretim("Erkan Türk",6 ,"Atatürk Lisesi",OkulDuzeyi.OrtaOgretim)
            });

            foreach (var ogr in ogrenci)
            {
                Console.WriteLine($"Adsoyad : {ogr.AdSoyad}, Okul No : {ogr.OkulNumarasi}, Düzey : {ogr.OkulDuzeyi}, Okul Adı : {ogr.OkulAdi}");
            }
            Lise lise = new Lise("Erkan Türk", 3, "Atatürk Lisesi", OkulDuzeyi.Lise, 100, 90); // Not bilgileri için.
            lise.NotHesapla();
        }
    }
}
