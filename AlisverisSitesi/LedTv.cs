using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisverisSitesi
{
    public class LedTv:Urun
    {
       
        public int EkranBoyutu { get; set; }
        public int EkranCozunurlugu { get; set; }
        public float KdvFiyat;


        public LedTv()
        {

        }



        public LedTv(string ad, string marka, string model, string ozellik, float hamfiyat, int secilenadet, int ekranboyutu, int ekrancozunurlugu)
        {
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
           
            HamFiyat = hamfiyat;
            SecilenAdet = secilenadet;
            EkranBoyutu = ekranboyutu;
            EkranCozunurlugu = ekrancozunurlugu;


        }
        public void KdvUygula()
        {
            KdvFiyat = HamFiyat * 1.18f * SecilenAdet;


        }

    }
}
