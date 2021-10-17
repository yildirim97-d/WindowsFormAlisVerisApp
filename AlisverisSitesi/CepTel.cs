using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSitesi
{
    public class CepTel: Urun
    {
        
        public int DahiliHafiza { get; set; }
        public int RamKapasitesi { get; set; }
        public int PilGucu { get; set; }
        public float KdvFiyat;
        public CepTel()
        {

        }

        public CepTel(string ad, string marka, string model, string ozellik, float hamfiyat, int secilenadet,int dahilihafiza,int ramkapasitesi,int pilgucu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
          
            HamFiyat = hamfiyat;
            SecilenAdet = secilenadet;
            DahiliHafiza = dahilihafiza;
            RamKapasitesi = ramkapasitesi;
            PilGucu = pilgucu;


        }

        public float KdvUygula()
        {
            KdvFiyat = HamFiyat * 1.20f * SecilenAdet;
            return KdvFiyat;

        }

    }
}
