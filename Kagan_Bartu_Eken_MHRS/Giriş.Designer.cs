namespace Kagan_Bartu_Eken_MHRS
{
    partial class Giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.giriş2 = new System.Windows.Forms.Button();
            this.tcno = new System.Windows.Forms.TextBox();
            this.sıfre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yenikayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giriş2
            // 
            this.giriş2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.giriş2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriş2.Location = new System.Drawing.Point(116, 323);
            this.giriş2.Name = "giriş2";
            this.giriş2.Size = new System.Drawing.Size(116, 38);
            this.giriş2.TabIndex = 3;
            this.giriş2.Text = "Giriş";
            this.giriş2.UseVisualStyleBackColor = false;
            this.giriş2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcno
            // 
            this.tcno.BackColor = System.Drawing.SystemColors.Window;
            this.tcno.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcno.Location = new System.Drawing.Point(94, 157);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(166, 27);
            this.tcno.TabIndex = 4;
            this.tcno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sıfre
            // 
            this.sıfre.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sıfre.Location = new System.Drawing.Point(94, 265);
            this.sıfre.Name = "sıfre";
            this.sıfre.PasswordChar = '*';
            this.sıfre.Size = new System.Drawing.Size(166, 27);
            this.sıfre.TabIndex = 6;
            this.sıfre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.Color.Transparent;
            this.tc.Location = new System.Drawing.Point(91, 141);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(41, 13);
            this.tc.TabIndex = 7;
            this.tc.Text = "T.C No";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Location = new System.Drawing.Point(91, 249);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(28, 13);
            this.sifre.TabIndex = 9;
            this.sifre.Text = "Şifre";
            // 
            // adsoyad
            // 
            this.adsoyad.BackColor = System.Drawing.SystemColors.Window;
            this.adsoyad.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsoyad.Location = new System.Drawing.Point(94, 210);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(166, 27);
            this.adsoyad.TabIndex = 10;
            this.adsoyad.TextChanged += new System.EventHandler(this.adsoyad_TextChanged);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.BackColor = System.Drawing.Color.Transparent;
            this.ad.Location = new System.Drawing.Point(91, 194);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(68, 13);
            this.ad.TabIndex = 11;
            this.ad.Text = "Ad ve Soyad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Kagan_Bartu_Eken_MHRS.Properties.Resources.MHRS_Logo_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // yenikayıt
            // 
            this.yenikayıt.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.yenikayıt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenikayıt.Location = new System.Drawing.Point(116, 367);
            this.yenikayıt.Name = "yenikayıt";
            this.yenikayıt.Size = new System.Drawing.Size(116, 38);
            this.yenikayıt.TabIndex = 12;
            this.yenikayıt.Text = "Üye Ol";
            this.yenikayıt.UseVisualStyleBackColor = false;
            this.yenikayıt.Click += new System.EventHandler(this.yenikayıt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Üyeliğiniz yoksa lütfen \"Üye Ol\" butonuna basınız";
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Kagan_Bartu_Eken_MHRS.Properties.Resources.v870_tang_36_1;
            this.ClientSize = new System.Drawing.Size(352, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenikayıt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.sıfre);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.giriş2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button giriş2;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.TextBox sıfre;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yenikayıt;
        private System.Windows.Forms.Label label1;
    }
}

