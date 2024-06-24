using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kagan_Bartu_Eken_MHRS
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ilcekombo.Enabled = false;
            klinikcombo.Enabled = false;
            hastanecombo.Enabled = false;
            hekimcombo.Enabled = false;
            dateTimePicker1.Enabled = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void giriş2_Click(object sender, EventArgs e)
        {
            if (ilcombo.Text == "" || ilcekombo.Text == "" || klinikcombo.Text == "" || hastanecombo.Text == "" || hekimcombo.Text == "" || dateTimePicker1.Checked == false)
            {
                MessageBox.Show("Randevu almak için tercihlerinizi doldurunuz");
            }
            else
            {
                MessageBox.Show("Randevunuz alınmıştır");
                Menü form2 = new Menü();
               
                
                form2.listBox1.Items.Add(ilcombo.Text);
             
                form2.listBox2.Items.Add(ilcekombo.Text);
              
                form2.listBox3.Items.Add(klinikcombo.Text);
               
                form2.listBox4.Items.Add(hastanecombo.Text);
               
                form2.listBox5.Items.Add(hekimcombo.Text);
                
                form2.listBox6.Items.Add(dateTimePicker1.Text);
                
                form2.label1.Text = label7.Text;
                form2.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilcombo.Text ="";
            ilcekombo.Text ="";
            ilcekombo.Enabled = false;
            klinikcombo.Text = "";
            klinikcombo.Enabled = false;
            hastanecombo.Text ="";
            hastanecombo.Enabled = false;
            hekimcombo.Text ="";
            hekimcombo.Enabled = false;
            dateTimePicker1.Text = "";
            dateTimePicker1.Enabled = false;
        }

        private void ilcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcekombo.Items.Clear();
            ilcekombo.Text = "";
            klinikcombo.Enabled = false;
            hastanecombo.Enabled = false;
            hekimcombo.Enabled = false;
            dateTimePicker1.Enabled = false;


            if (ilcombo.Text == "İzmir")
            {
                ilcekombo.Enabled = true;
                ilcekombo.Items.Add("Güzelbahçe");
                ilcekombo.Items.Add("Seferihisar");
                ilcekombo.Items.Add("Karabağlar");
                
            }
            if (ilcombo.Text == "İstanbul")
            {
                ilcekombo.Enabled = true;
                ilcekombo.Items.Add("Adalar");
                ilcekombo.Items.Add("Bağcılar");
                ilcekombo.Items.Add("Avcılar");
                
            }
            if (ilcombo.Text == "Antalya")
            {
                ilcekombo.Enabled = true;
                ilcekombo.Items.Add("Akseki");
                ilcekombo.Items.Add("Aksu");
                ilcekombo.Items.Add("Kaş");
                
            }
            if (ilcombo.Text == "Ankara")
            {
                ilcekombo.Enabled = true;
                ilcekombo.Items.Add("Çankaya");
                ilcekombo.Items.Add("Beypazarı");
                ilcekombo.Items.Add("Gölbaşı");
               
            }

     

        }

        private void ilcekombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            klinikcombo.Items.Clear();
            klinikcombo.Text = "";
            hastanecombo.Enabled = false;
            hekimcombo.Enabled = false;
            dateTimePicker1.Enabled = false;

            if (ilcekombo.Text =="Güzelbahçe" || ilcekombo.Text =="Seferihisar" || ilcekombo.Text =="Karabağlar" || ilcekombo.Text =="Adalar" || ilcekombo.Text =="Bağcılar" || ilcekombo.Text == "Esenler" || ilcekombo.Text == "Akseki" || ilcekombo.Text == "Aksu" || ilcekombo.Text == "Kaş" || ilcekombo.Text == "Çankaya" || ilcekombo.Text == "Beypazarı" || ilcekombo.Text == "Gölbaşı")
            {
                klinikcombo.Enabled = true;
                klinikcombo.Items.Add("Aile Hekimliği");
                klinikcombo.Items.Add("Ortopedi ve Travmatoloji");
                klinikcombo.Items.Add("Radyoloji");
                klinikcombo.Items.Add("Üroloji");
                klinikcombo.Items.Add("İç Hastalıkları(Dahiliye)");
                klinikcombo.Items.Add("Göz Hastalıkları");
                klinikcombo.Items.Add("Ağız ve Diş Sağlığı");
            }
        }

        private void klinikcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastanecombo.Items.Clear();
            hastanecombo.Text = "";
            hekimcombo.Enabled = false;
            dateTimePicker1.Enabled = false;

            if (ilcekombo.Text == "Güzelbahçe")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("İZMİR URLA DEVLET HASTANESİ");
               

            }
            if (ilcekombo.Text == "Seferihisar")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("İZMİR NEJAT HEPKON SEFERİHİSAR DEVLET HASTANESİ");
                

            }
            if (ilcekombo.Text == "Karabağlar")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("İZMİR ATATÜRK EĞİTİM VE ARAŞTIRMA HASTANESİ");
                hastanecombo.Items.Add("İZMİR BOZYAKA EĞİTİM VE ARAŞTIRMA HASTANESİ");
                

            }
            if (ilcekombo.Text == "Adalar")
            {
               
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("İSTANBUL - KARTAL ŞEHİR HASTANESİ");
                

            }
            if (ilcekombo.Text == "Bağcılar")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("BAĞCILAR EĞİTİM VE ARAŞTIRMA HASTANESİ");
                

            }
            if (ilcekombo.Text == "Avcılar")
            {
               
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("İSTANBUL AVCILAR MURAT KÖLÜK DEVLET HASTANESİ");
                hastanecombo.Items.Add("İSTANBUL AVCILAR AĞIZ VE DİŞ SAĞLIĞI MERKEZİ");
                

            }
            if (ilcekombo.Text == "Akseki")
            {
               
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("AKSEKİ DEVLET HASTANESİ");
                

            }
            if (ilcekombo.Text == "Aksu")
            {
               
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("ANTALYA EĞİTİM VE ARAŞTIRMA HASTANESİ");
                

            }
            if (ilcekombo.Text == "Kaş")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("ANTALYA KAŞ DEVLET HASTANESİ");
               

            }
            if (ilcekombo.Text == "Çankaya")
            {
                
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("ANKARA BİLKENT ŞEHİR HASTANESİ");
                

            }
            if (ilcekombo.Text == "Beypazarı")
            {
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("ANKARA BEYPAZAR DEVLET HASTANESİ");
               

            }
            if (ilcekombo.Text == "Gölbaşı")
            {
               
                hastanecombo.Enabled = true;
                hastanecombo.Items.Add("ANKARA GÖLBAŞI ŞEHİT AHMET ÖZSOY DEVLET HASTANESİ");
               

            }
        }

        private void hastanecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            hekimcombo.Items.Clear();
            hekimcombo.Text = "";
            hekimcombo.Enabled = true;
            dateTimePicker1.Enabled = false;

            if (ilcombo.Text == "İzmir")
            {
                hekimcombo.Enabled = true;
                hekimcombo.Items.Add("MEHMET AKİF GÖKCE");
                hekimcombo.Items.Add("MARAL TAŞ");
                hekimcombo.Items.Add("MAKBULE SAÇAN");
            }
            if (ilcombo.Text == "İstanbul")
            {
                hekimcombo.Enabled = true;
                hekimcombo.Items.Add("SULTAN GÜNDOĞDU");
                hekimcombo.Items.Add("TEYFİK ONÜŞ");
                hekimcombo.Items.Add("ENVER MUTLU");
            }
            if (ilcombo.Text == "Antalya")
            {
                hekimcombo.Enabled = true;
                hekimcombo.Items.Add("SELİMCAN KARABAY");
                hekimcombo.Items.Add("ÇAĞRI EŞME");
                hekimcombo.Items.Add("DERYA ATAÇ");
            }
            if (ilcombo.Text == "Ankara")
            {
                hekimcombo.Enabled = true;
                hekimcombo.Items.Add("HACI DÖNMEZ");
                hekimcombo.Items.Add("SÜREYYA BURCU AKTOZ");
                hekimcombo.Items.Add("MAHMUT BAKIR TOPCUOĞLU");
            }
        }

        private void muayenecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hekimcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }
    }
}