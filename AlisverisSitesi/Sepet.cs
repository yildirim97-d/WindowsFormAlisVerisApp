using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisSitesi
{
    public class Sepet 
    {
       public ArrayList urunlerList = new ArrayList();
        //Buzdolabi buzdolabi = new Buzdolabi();
        //CepTel ceptel = new CepTel();
        //LedTv ledtv = new LedTv();
        //Laptop laptop = new Laptop();





        public void SepeteUrunEkle(Urun urun)
        {
            
           
            urunlerList.Add(urun.SecilenAdet.ToString());
            urunlerList.Add(urun.Ad);

        }
          





        

        public float KdvToplamFiyat(Buzdolabi buzdolabi,LedTv ledTv,Laptop laptop,CepTel cepTel)
        {
            return KdvUygula(buzdolabi) + KdvUygula(ledTv) + KdvUygula(laptop)+KdvUygula(cepTel);



        }
        public float KdvUygula(Laptop laptop)
        {
           return laptop.HamFiyat * 1.15f * laptop.SecilenAdet;


        }
        public float KdvUygula(LedTv ledTv)
        {
            return ledTv.HamFiyat * 1.15f * ledTv.SecilenAdet;


        }
        public float KdvUygula(CepTel cepTel)
        {
            return cepTel.HamFiyat * 1.15f * cepTel.SecilenAdet;


        }
        public float KdvUygula(Buzdolabi buzdolabi)
        {
            return buzdolabi.HamFiyat * 1.05f * buzdolabi.SecilenAdet;


        }







    }
}
