using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kagan_Bartu_Eken_MHRS
{
    
    public partial class Kayıt : Form
    {
        private List<Hasta> hastalistesi;
        public Kayıt(List<Hasta> hl)
        {
            InitializeComponent();
            hastalistesi = hl;
        }

        private void yenikayıt_Click(object sender, EventArgs e)
        {
            if (adsoyad.Text == "" || tcno.Text == "" || sıfre.Text == "" || cinsiyet.Text == "" || dogumtarih.Text == "")
            {
                MessageBox.Show("Tüm Bilgilerin Doldurulması Zorunludur");
            }
            else
            {
                string adınız = adsoyad.Text;
                string tcniz = tcno.Text;
                string sifreniz = sıfre.Text;
                string cinsiniz = cinsiyet.Text;
                string dogumunuz = dogumtarih.Text;

                Hasta yenihasta = new Hasta();
                yenihasta.adınız = adınız;
                yenihasta.tcniz = tcniz;
                yenihasta.sifreniz = sifreniz;
                yenihasta.cinsiniz = cinsiniz;
                yenihasta.dogumunuz = dogumunuz;

                hastalistesi.Add(yenihasta);

                MessageBox.Show("Kayıt Başarılı");
                this.Close();
            }
        }

        private void Temizle()
        {
            adsoyad.Text = string.Empty;
            tcno.Text   = string.Empty; 
            sıfre.Text = string.Empty;
            cinsiyet.Text   = string.Empty;
            dogumtarih.Text = string.Empty;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            tcno.MaxLength = 11;
        }
    }
}
