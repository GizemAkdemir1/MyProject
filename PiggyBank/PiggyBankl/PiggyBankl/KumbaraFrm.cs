using PiggyBankl.Abstract;
using PiggyBankl.Concrete;
using PiggyBankl.Exception_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBankl
{
    public partial class KumbaraFrm : Form
    {

        private readonly List<KagitPara> KagitParalar = new List<KagitPara>();
        private readonly List<BozukPara> BozukParalar = new List<BozukPara>();
        private readonly BindingList<Para> atilanKagitParalar = new BindingList<Para>();
        private readonly BindingList<Para> atilanBozukParalar = new BindingList<Para>();

        Kumbara kumbara;
        Para secilenPara;
        double toplamFazlaHacim = 0;
        double toplamHacim = 0;
        bool katlandiMi = false;
        double minToplamHacim = 0;
        double birikenTutar = 0;
        double katlanmisParaHacmi = 0;
        int kumbaraKirilmaSayisi = 0;
        double fazlaHacim = 0;


        public KumbaraFrm()
        {
            InitializeComponent();

            if (KagitParalar == null)
            {
                KagitParalar = new List<KagitPara>();
            }

            if (BozukParalar == null)
            {
                BozukParalar = new List<BozukPara>();
            }

            if (kumbara == null)
            {
                kumbara = new Kumbara(75000);
            }   
        }

        private void KumbaraFrm_Load(object sender, EventArgs e)
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Deger = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Deger = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Deger = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Deger = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Deger = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Deger = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Deger = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Deger = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Deger = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Deger = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Deger = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Deger = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Seçiniz");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Ad);
            }
            cmbKagitPara.SelectedIndex = 0;

            cmbBozukPara.Items.Add("Seçiniz");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Ad);
            }
            cmbBozukPara.SelectedIndex = 0;
        }

        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara;
            if (cmbKagitPara.SelectedIndex > 0)
            {
                atilacakPara = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara;
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacakPara = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        private void btnKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilenPara;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanmisParaHacmi = katlanacak.Katla(katlanacak.Hacim());
            }
            MessageBox.Show("Para Katlandı. Kumbaraya atabilirsiniz.");
        }

        private void btnParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenPara == null)
                {
                    throw new AtilacakParaSecilmediException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (secilenPara is BozukPara)
            {
                BozukPara bozukPara = (BozukPara)secilenPara;
                try
                {
                    if (toplamHacim + bozukPara.Hacim() + bozukPara.FazladanHacimHesapla(secilenPara.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }

                fazlaHacim = bozukPara.FazladanHacimHesapla(bozukPara.Hacim());
                toplamFazlaHacim += fazlaHacim;
                atilanBozukParalar.Add(bozukPara);
                birikenTutar += bozukPara.Deger;
                minToplamHacim += bozukPara.MinumumHacim(bozukPara.Hacim());
                toplamHacim += bozukPara.Hacim() + fazlaHacim;
                kumbara.ParaEkle(bozukPara.Hacim() + fazlaHacim);
            }

            else if (secilenPara is KagitPara)
            {
                KagitPara kagitPara = (KagitPara)secilenPara;
                try
                {
                    if (toplamHacim + kagitPara.Hacim() + kagitPara.FazladanHacimHesapla(secilenPara.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                try
                {
                    if (katlandiMi == false)
                    {
                        throw new ParaKatlanmadiException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fazlaHacim = kagitPara.FazladanHacimHesapla(kagitPara.Hacim());
                toplamFazlaHacim += fazlaHacim;
                atilanKagitParalar.Add(kagitPara);
                birikenTutar += kagitPara.Deger;
                minToplamHacim += kagitPara.MinumumHacim(katlanmisParaHacmi);
                toplamHacim += kagitPara.Hacim() + fazlaHacim;
                kumbara.ParaEkle(kagitPara.Hacim() + fazlaHacim);

            }

            VerileriSifirla();

            lblParaHacmi.Text = toplamFazlaHacim.ToString();
            lblKumbaraHacmi.Text = toplamHacim.ToString();

        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            toplamFazlaHacim = 0;

            lblParaHacmi.Text = toplamFazlaHacim.ToString();
            lblKumbaraHacmi.Text = minToplamHacim.ToString();
        }

        private void btnKir_Click(object sender, EventArgs e)
        {
            if (kumbaraKirilmaSayisi < 2)
            {
                kumbaraKirilmaSayisi++;
                KumbarayiListele();
                KumbaraSifirla();
            }
            else
            {
                MessageBox.Show("Kumbara kırma limitine geldiniz daha fazla kırılamaz.");
                return;
            }
        }


        private void KumbarayiListele()
        {
            double toplamBozukPara = 0;
            double toplamKagitPara = 0;

            foreach (var item in atilanKagitParalar)
            {
                lbKumbara.Items.Add(item.Ad);
                toplamKagitPara += item.Deger;
            }
            foreach (var item in atilanBozukParalar)
            {
                lbKumbara.Items.Add(item.Ad);
                toplamBozukPara += item.Deger;
            }

            lblToplam.Text = (toplamKagitPara + toplamBozukPara).ToString();
        }

        private void VerileriSifirla()
        {
            cmbBozukPara.SelectedIndex = 0;
            cmbKagitPara.SelectedIndex = 0;
            katlandiMi = false;
            btnKatla.Text = "Katla!";
            btnKatla.Enabled = true;
            secilenPara = null;
            cmbBozukPara.Enabled = true;
            cmbKagitPara.Enabled = true;
        }

        private void KumbaraSifirla()
        {
            birikenTutar = 0;
            kumbara.ToplamParaHacim = 0;
            toplamHacim = 0;
            toplamFazlaHacim = 0;
            atilanBozukParalar.Clear();
            atilanKagitParalar.Clear();
            lblParaHacmi.Text = "0";
            lblKumbaraHacmi.Text = "0";
        }
    }
}