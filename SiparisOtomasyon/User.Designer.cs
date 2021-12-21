
namespace SiparisOtomasyon
{
    partial class User
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_UrunAcik = new System.Windows.Forms.TextBox();
            this.txt_UrunAg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_fyt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lw_urun = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lw_sepet = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_Adres = new System.Windows.Forms.RichTextBox();
            this.txt_AdresBas = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_AdiSoyadi = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txt_UrunAcik);
            this.tabPage1.Controls.Add(this.txt_UrunAg);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.txt_fyt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_adet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lw_urun);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yeni Sipariş";
            // 
            // txt_UrunAcik
            // 
            this.txt_UrunAcik.Location = new System.Drawing.Point(612, 362);
            this.txt_UrunAcik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UrunAcik.Multiline = true;
            this.txt_UrunAcik.Name = "txt_UrunAcik";
            this.txt_UrunAcik.Size = new System.Drawing.Size(185, 72);
            this.txt_UrunAcik.TabIndex = 13;
            // 
            // txt_UrunAg
            // 
            this.txt_UrunAg.Location = new System.Drawing.Point(612, 278);
            this.txt_UrunAg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UrunAg.Name = "txt_UrunAg";
            this.txt_UrunAg.Size = new System.Drawing.Size(185, 23);
            this.txt_UrunAg.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(459, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Ağırlığı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(612, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_fyt
            // 
            this.txt_fyt.Location = new System.Drawing.Point(612, 198);
            this.txt_fyt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fyt.Name = "txt_fyt";
            this.txt_fyt.Size = new System.Drawing.Size(185, 23);
            this.txt_fyt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(459, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Açıklaması";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(459, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seçilen Ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(459, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(459, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(612, 127);
            this.txt_adet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(185, 23);
            this.txt_adet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Tablosu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lw_urun
            // 
            this.lw_urun.FullRowSelect = true;
            this.lw_urun.GridLines = true;
            this.lw_urun.HideSelection = false;
            this.lw_urun.Location = new System.Drawing.Point(0, 64);
            this.lw_urun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lw_urun.Name = "lw_urun";
            this.lw_urun.ShowItemToolTips = true;
            this.lw_urun.Size = new System.Drawing.Size(453, 448);
            this.lw_urun.TabIndex = 0;
            this.lw_urun.UseCompatibleStateImageBehavior = false;
            this.lw_urun.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparişlerim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lw_sepet);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sepet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(159, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sepet";
            // 
            // lw_sepet
            // 
            this.lw_sepet.HideSelection = false;
            this.lw_sepet.Location = new System.Drawing.Point(3, 66);
            this.lw_sepet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lw_sepet.Name = "lw_sepet";
            this.lw_sepet.Size = new System.Drawing.Size(378, 300);
            this.lw_sepet.TabIndex = 0;
            this.lw_sepet.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_Adres);
            this.tabPage4.Controls.Add(this.txt_AdresBas);
            this.tabPage4.Controls.Add(this.txt_Sifre);
            this.tabPage4.Controls.Add(this.txt_KullaniciAdi);
            this.tabPage4.Controls.Add(this.txt_AdiSoyadi);
            this.tabPage4.Controls.Add(this.btnGüncelle);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(835, 565);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kullanıcı Bilgileri";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(111, 174);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(258, 75);
            this.txt_Adres.TabIndex = 10;
            this.txt_Adres.Text = "";
            // 
            // txt_AdresBas
            // 
            this.txt_AdresBas.Location = new System.Drawing.Point(111, 121);
            this.txt_AdresBas.Name = "txt_AdresBas";
            this.txt_AdresBas.Size = new System.Drawing.Size(258, 23);
            this.txt_AdresBas.TabIndex = 9;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(538, 121);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(267, 23);
            this.txt_Sifre.TabIndex = 8;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(538, 73);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(267, 23);
            this.txt_KullaniciAdi.TabIndex = 7;
            // 
            // txt_AdiSoyadi
            // 
            this.txt_AdiSoyadi.Location = new System.Drawing.Point(111, 73);
            this.txt_AdiSoyadi.Name = "txt_AdiSoyadi";
            this.txt_AdiSoyadi.Size = new System.Drawing.Size(258, 23);
            this.txt_AdiSoyadi.TabIndex = 6;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(707, 214);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(98, 35);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Adres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Adres Başlığı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adı Soyadı:";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "User";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lw_urun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_fyt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_UrunAcik;
        private System.Windows.Forms.TextBox txt_UrunAg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lw_sepet;
        private System.Windows.Forms.RichTextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_AdresBas;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_AdiSoyadi;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}