using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSitesi
{
   public class Buzdolabi : Urun
    {
        
        public Buzdolabi()
        {

        }
      

        public Buzdolabi(string ad,string marka,string model,string ozellik, float hamfiyat,int secilenadet,int ichacim,string enerjisinifi)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
         
            HamFiyat = hamfiyat;
            SecilenAdet = secilenadet;
            IcHacim = ichacim;
            EnerjiSinifi = enerjisinifi;


        }
        public int IcHacim { get; set; }
        public string EnerjiSinifi { get; set; }
        public float KdvFiyat;

        
        public float  KdvUygula()
        {
            KdvFiyat = HamFiyat * 1.05f * SecilenAdet;
            return KdvFiyat;

        }

    }
}
