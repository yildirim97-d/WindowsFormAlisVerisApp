using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSitesi
{
    public class Laptop:Urun
    {
       
        public int EkranBoyutu { get; set; }
        public int EkranCozunurluk { get; set; }
        public int DahiliHafiza { get; set; }
        public int RamKapasitesi { get; set; }
        public int PilGucu { get; set; }
        public float KdvFiyat;

        public Laptop(string ad, string marka, string model, string ozellik, float hamfiyat, int secilenadet, int ekranboyutu, int ekrancozunurluk, int dahilihafiza, int ramkapasitesi, int pilgucu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
         
            HamFiyat = hamfiyat;
            SecilenAdet = secilenadet;
            EkranBoyutu = ekranboyutu;
            EkranCozunurluk = ekrancozunurluk;
            DahiliHafiza = dahilihafiza;
            RamKapasitesi = ramkapasitesi;
            PilGucu = pilgucu;
        }
        public Laptop()
        {

        }
        
    }
}
