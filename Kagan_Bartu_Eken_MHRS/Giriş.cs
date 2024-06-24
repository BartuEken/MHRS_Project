using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kagan_Bartu_Eken_MHRS
{
    public partial class Giriş : Form
    {
        private List<Hasta> hastalistesi=new List<Hasta>();

        public Giriş()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tcno.MaxLength = 11;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string adınız = adsoyad.Text;
            string tcniz = tcno.Text;
            string sifreniz = sıfre.Text;

            if (sıfre.Text == "" || tcno.Text == "" || adsoyad.Text == "")
            {
                MessageBox.Show("Tüm Bilgilerin Doldurulması Zorunludur");
                sıfre.Text = "";
                tcno.Text = "";
                adsoyad.Text = "";
            }
            else
            {
                Hasta hastacık = hastalistesi.Find(h => h.adınız == adsoyad.Text && h.sifreniz == sıfre.Text && h.tcniz == tcno.Text);

                if (hastacık != null)
                {

                    Menü form2 = new Menü();
                    form2.label1.Text = adsoyad.Text;
                    form2.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Tekrar Deneyiniz");
                    sıfre.Text = "";
                    tcno.Text = "";
                    adsoyad.Text = "";
                }
            }
        }

        private void adsoyad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void yenikayıt_Click(object sender, EventArgs e)
        {
            Kayıt form5 = new Kayıt(hastalistesi);
            form5.ShowDialog();
        }

        private void giriş1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Temizle()
        {
            adsoyad.Text = string.Empty;
            sıfre.Text = string.Empty;
            tcno.Text = string.Empty;
        }
    }
}
