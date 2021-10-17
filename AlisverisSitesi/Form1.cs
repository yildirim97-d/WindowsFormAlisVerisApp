using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisSitesi
{
    public partial class Form1 : Form
    {
        Sepet sepet = new Sepet();
       public Buzdolabi buzdolabi;
       public LedTv ledTv;
       public Laptop laptop;
       public CepTel cepTel;
        Random rnd = new Random();
        public int sifirlaTv;
        public int sifirlaTel;
        public int sifirlaLap;
        public int sifirlaBuz;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            
          

               

            Buzdolabi.StokAdedi = rnd.Next(1, 100);
            
            BuzdolabiStokAdet.Text = Buzdolabi.StokAdedi.ToString();
            BuzdolabiNumeric.Maximum = Buzdolabi.StokAdedi;
            sifirlaBuz = Buzdolabi.StokAdedi;

            LedTv.StokAdedi = rnd.Next(1, 100);
            TvStokLabel.Text = LedTv.StokAdedi.ToString();
            TvNumeric.Maximum = LedTv.StokAdedi;
            sifirlaTv = LedTv.StokAdedi;

            Laptop.StokAdedi = rnd.Next(1, 100);
            LaptopStokAdet.Text = Laptop.StokAdedi.ToString();
            LaptopNumeric.Maximum = Laptop.StokAdedi;
            sifirlaLap= Laptop.StokAdedi;

            CepTel.StokAdedi = rnd.Next(1, 100);
            TelStokLabel.Text = CepTel.StokAdedi.ToString();
            TelNumeric.Maximum = CepTel.StokAdedi;
            sifirlaTel = CepTel.StokAdedi;

            


            //BuzdolabiStokAdet.Text = rnd.Next(1, 100).ToString();
            //LaptopStokAdet.Text = rnd.Next(1, 100).ToString();
            //TelStokLabel.Text = rnd.Next(1, 100).ToString();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdetList.Items.Clear();
            UrunlerList.Items.Clear();
            KdvFiyatList.Items.Clear();
            buzdolabi = new Buzdolabi("Buzdolabı", "Vestel", "Çift Kapılı", "Taze sebze tutabilme", 4000, Convert.ToInt32(BuzdolabiNumeric.Value), 400, "A++");
            ledTv = new LedTv("Televizyon", "Samsung", "QLed", "Canlı Renkler", 3500, Convert.ToInt32(TvNumeric.Value), 85, 1080);
            laptop = new Laptop("Laptop", "Monster", "Hızlı", "Hertürlü Oyun Çalıştırma Garantili", 6000, Convert.ToInt32(LaptopNumeric.Value), 32, 1080, 1000, 16, 7200);
            cepTel = new CepTel("Telefon", "Samsung", "Güvenilir", "Güvenli ve Hızlı", 2500, Convert.ToInt32(TelNumeric.Value), 16, 5, 3200);



            //sepet.SepeteUrunEkle(ledTv);
            if (BuzdolabiNumeric.Value > 0 && Buzdolabi.StokAdedi>0 )
            {
                AdetList.Items.Add(buzdolabi.SecilenAdet);
                UrunlerList.Items.Add(buzdolabi.Ad);
                KdvFiyatList.Items.Add(sepet.KdvUygula(buzdolabi).ToString());
                BuzdolabiStokAdet.Text = (Convert.ToInt32(BuzdolabiStokAdet.Text) - BuzdolabiNumeric.Value).ToString();
                Buzdolabi.StokAdedi = Convert.ToInt32(BuzdolabiStokAdet.Text);
            }

            if (TvNumeric.Value > 0 && LedTv.StokAdedi > 0)
            {
                AdetList.Items.Add(ledTv.SecilenAdet);
                UrunlerList.Items.Add(ledTv.Ad);
                KdvFiyatList.Items.Add(sepet.KdvUygula(ledTv).ToString());
                TvStokLabel.Text = (Convert.ToInt32(TvStokLabel.Text) - TvNumeric.Value).ToString();
                LedTv.StokAdedi = Convert.ToInt32(TvStokLabel.Text);
            }

            if (LaptopNumeric.Value > 0 && Laptop.StokAdedi > 0)
            {
                AdetList.Items.Add(laptop.SecilenAdet);
                UrunlerList.Items.Add(laptop.Ad);
                KdvFiyatList.Items.Add(sepet.KdvUygula(laptop).ToString());
                LaptopStokAdet.Text = (Convert.ToInt32(LaptopStokAdet.Text) - LaptopNumeric.Value).ToString();
                Laptop.StokAdedi = Convert.ToInt32(LaptopStokAdet.Text);
            }

            if (TelNumeric.Value > 0 && CepTel.StokAdedi > 0)
            {
                AdetList.Items.Add(cepTel.SecilenAdet);
                UrunlerList.Items.Add(cepTel.Ad);
                KdvFiyatList.Items.Add(sepet.KdvUygula(cepTel).ToString());
                TelStokLabel.Text = (Convert.ToInt32(TelStokLabel.Text) - TelNumeric.Value).ToString();
                CepTel.StokAdedi = Convert.ToInt32(TelStokLabel.Text);
            }

  
            
            KdvToplamFiyatLabel.Text = sepet.KdvToplamFiyat(buzdolabi, ledTv,laptop,cepTel).ToString()+ " TL";


        }


        private void BuzdolabiNumeric_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdetList.Items.Clear();
            UrunlerList.Items.Clear();
            KdvFiyatList.Items.Clear();

            Buzdolabi.StokAdedi = sifirlaBuz;
            BuzdolabiStokAdet.Text = Buzdolabi.StokAdedi.ToString();
            BuzdolabiNumeric.Maximum = Buzdolabi.StokAdedi;

            LedTv.StokAdedi = sifirlaTv;
            TvStokLabel.Text = LedTv.StokAdedi.ToString();
            TvNumeric.Maximum = LedTv.StokAdedi;

            Laptop.StokAdedi = sifirlaLap;
            LaptopStokAdet.Text = Laptop.StokAdedi.ToString();
            LaptopNumeric.Maximum = Laptop.StokAdedi;

            CepTel.StokAdedi = sifirlaTel;
            TelStokLabel.Text = CepTel.StokAdedi.ToString();
            TelNumeric.Maximum = CepTel.StokAdedi;
            KdvToplamFiyatLabel.Text = "0 TL";




        }
    }
}
