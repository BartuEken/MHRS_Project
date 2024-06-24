namespace Kagan_Bartu_Eken_MHRS
{
    partial class Kayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ad = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.sıfre = new System.Windows.Forms.TextBox();
            this.tcno = new System.Windows.Forms.TextBox();
            this.dogumtarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.yenikayıt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kagan_Bartu_Eken_MHRS.Properties.Resources.MHRS_Logo_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 115);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.BackColor = System.Drawing.Color.Transparent;
            this.ad.Location = new System.Drawing.Point(95, 207);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(68, 13);
            this.ad.TabIndex = 17;
            this.ad.Text = "Ad ve Soyad";
            // 
            // adsoyad
            // 
            this.adsoyad.BackColor = System.Drawing.SystemColors.Window;
            this.adsoyad.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsoyad.Location = new System.Drawing.Point(98, 223);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(166, 27);
            this.adsoyad.TabIndex = 16;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Location = new System.Drawing.Point(95, 262);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(28, 13);
            this.sifre.TabIndex = 15;
            this.sifre.Text = "Şifre";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.Color.Transparent;
            this.tc.Location = new System.Drawing.Point(95, 154);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(41, 13);
            this.tc.TabIndex = 14;
            this.tc.Text = "T.C No";
            // 
            // sıfre
            // 
            this.sıfre.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sıfre.Location = new System.Drawing.Point(98, 278);
            this.sıfre.Name = "sıfre";
            this.sıfre.PasswordChar = '*';
            this.sıfre.Size = new System.Drawing.Size(166, 27);
            this.sıfre.TabIndex = 13;
            // 
            // tcno
            // 
            this.tcno.BackColor = System.Drawing.SystemColors.Window;
            this.tcno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcno.Location = new System.Drawing.Point(98, 170);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(166, 27);
            this.tcno.TabIndex = 12;
            // 
            // dogumtarih
            // 
            this.dogumtarih.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.dogumtarih.Location = new System.Drawing.Point(98, 391);
            this.dogumtarih.Name = "dogumtarih";
            this.dogumtarih.Size = new System.Drawing.Size(166, 27);
            this.dogumtarih.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(95, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(95, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cinsiyet";
            // 
            // cinsiyet
            // 
            this.cinsiyet.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(98, 333);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(166, 27);
            this.cinsiyet.TabIndex = 21;
            // 
            // yenikayıt
            // 
            this.yenikayıt.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.yenikayıt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenikayıt.Location = new System.Drawing.Point(122, 436);
            this.yenikayıt.Name = "yenikayıt";
            this.yenikayıt.Size = new System.Drawing.Size(116, 38);
            this.yenikayıt.TabIndex = 22;
            this.yenikayıt.Text = "Üye Ol";
            this.yenikayıt.UseVisualStyleBackColor = false;
            this.yenikayıt.Click += new System.EventHandler(this.yenikayıt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "\"Üye Ol\" butonuna basıldığında giriş sayfasına gönderiliceksiniz";
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kagan_Bartu_Eken_MHRS.Properties.Resources.v870_tang_36_1;
            this.ClientSize = new System.Drawing.Size(356, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yenikayıt);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dogumtarih);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.sıfre);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ol";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yenikayıt;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox adsoyad;
        public System.Windows.Forms.TextBox sıfre;
        public System.Windows.Forms.TextBox tcno;
        public System.Windows.Forms.DateTimePicker dogumtarih;
        public System.Windows.Forms.ComboBox cinsiyet;
    }
}