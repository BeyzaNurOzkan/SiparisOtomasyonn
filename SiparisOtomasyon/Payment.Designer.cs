
namespace SiparisOtomasyon
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Nakit = new System.Windows.Forms.GroupBox();
            this.Toplam = new System.Windows.Forms.Label();
            this.groupBox_Cek = new System.Windows.Forms.GroupBox();
            this.textBox_HesapID = new System.Windows.Forms.TextBox();
            this.textBox_İsim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_KrediKarti = new System.Windows.Forms.GroupBox();
            this.textBox_CVV = new System.Windows.Forms.TextBox();
            this.textBox_SKT = new System.Windows.Forms.TextBox();
            this.textBox_KartNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Nakit = new System.Windows.Forms.CheckBox();
            this.checkBox_Cek = new System.Windows.Forms.CheckBox();
            this.checkBox_KrediKarti = new System.Windows.Forms.CheckBox();
            this.button_Ödeme = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Nakit.SuspendLayout();
            this.groupBox_Cek.SuspendLayout();
            this.groupBox_KrediKarti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 23);
            this.textBox3.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(89, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 147);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_Nakit);
            this.groupBox1.Controls.Add(this.groupBox_Cek);
            this.groupBox1.Controls.Add(this.groupBox_KrediKarti);
            this.groupBox1.Controls.Add(this.checkBox_Nakit);
            this.groupBox1.Controls.Add(this.checkBox_Cek);
            this.groupBox1.Controls.Add(this.checkBox_KrediKarti);
            this.groupBox1.Location = new System.Drawing.Point(380, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 438);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Türü";
            // 
            // groupBox_Nakit
            // 
            this.groupBox_Nakit.Controls.Add(this.Toplam);
            this.groupBox_Nakit.Location = new System.Drawing.Point(19, 353);
            this.groupBox_Nakit.Name = "groupBox_Nakit";
            this.groupBox_Nakit.Size = new System.Drawing.Size(428, 72);
            this.groupBox_Nakit.TabIndex = 5;
            this.groupBox_Nakit.TabStop = false;
            this.groupBox_Nakit.Text = "Nakit";
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(8, 37);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(46, 15);
            this.Toplam.TabIndex = 0;
            this.Toplam.Text = "Toplam";
            // 
            // groupBox_Cek
            // 
            this.groupBox_Cek.Controls.Add(this.textBox_HesapID);
            this.groupBox_Cek.Controls.Add(this.textBox_İsim);
            this.groupBox_Cek.Controls.Add(this.label11);
            this.groupBox_Cek.Controls.Add(this.label10);
            this.groupBox_Cek.Controls.Add(this.label9);
            this.groupBox_Cek.Location = new System.Drawing.Point(20, 202);
            this.groupBox_Cek.Name = "groupBox_Cek";
            this.groupBox_Cek.Size = new System.Drawing.Size(427, 120);
            this.groupBox_Cek.TabIndex = 4;
            this.groupBox_Cek.TabStop = false;
            this.groupBox_Cek.Text = "Çek İle Ödeme";
            // 
            // textBox_HesapID
            // 
            this.textBox_HesapID.Location = new System.Drawing.Point(117, 51);
            this.textBox_HesapID.Name = "textBox_HesapID";
            this.textBox_HesapID.Size = new System.Drawing.Size(248, 23);
            this.textBox_HesapID.TabIndex = 4;
            // 
            // textBox_İsim
            // 
            this.textBox_İsim.Location = new System.Drawing.Point(117, 20);
            this.textBox_İsim.Name = "textBox_İsim";
            this.textBox_İsim.Size = new System.Drawing.Size(248, 23);
            this.textBox_İsim.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Toplam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hesap ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "İsim";
            // 
            // groupBox_KrediKarti
            // 
            this.groupBox_KrediKarti.Controls.Add(this.textBox_CVV);
            this.groupBox_KrediKarti.Controls.Add(this.textBox_SKT);
            this.groupBox_KrediKarti.Controls.Add(this.textBox_KartNo);
            this.groupBox_KrediKarti.Controls.Add(this.label8);
            this.groupBox_KrediKarti.Controls.Add(this.label7);
            this.groupBox_KrediKarti.Controls.Add(this.label6);
            this.groupBox_KrediKarti.Controls.Add(this.label5);
            this.groupBox_KrediKarti.Location = new System.Drawing.Point(20, 51);
            this.groupBox_KrediKarti.Name = "groupBox_KrediKarti";
            this.groupBox_KrediKarti.Size = new System.Drawing.Size(427, 120);
            this.groupBox_KrediKarti.TabIndex = 3;
            this.groupBox_KrediKarti.TabStop = false;
            this.groupBox_KrediKarti.Text = "Kredi Kartı İle Ödeme";
            // 
            // textBox_CVV
            // 
            this.textBox_CVV.Location = new System.Drawing.Point(281, 55);
            this.textBox_CVV.Name = "textBox_CVV";
            this.textBox_CVV.Size = new System.Drawing.Size(84, 23);
            this.textBox_CVV.TabIndex = 6;
            // 
            // textBox_SKT
            // 
            this.textBox_SKT.Location = new System.Drawing.Point(127, 55);
            this.textBox_SKT.Name = "textBox_SKT";
            this.textBox_SKT.Size = new System.Drawing.Size(93, 23);
            this.textBox_SKT.TabIndex = 5;
            // 
            // textBox_KartNo
            // 
            this.textBox_KartNo.Location = new System.Drawing.Point(80, 20);
            this.textBox_KartNo.Name = "textBox_KartNo";
            this.textBox_KartNo.Size = new System.Drawing.Size(285, 23);
            this.textBox_KartNo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Toplam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "CVV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Son Kullanma Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kart No:";
            // 
            // checkBox_Nakit
            // 
            this.checkBox_Nakit.AutoSize = true;
            this.checkBox_Nakit.Location = new System.Drawing.Point(19, 328);
            this.checkBox_Nakit.Name = "checkBox_Nakit";
            this.checkBox_Nakit.Size = new System.Drawing.Size(54, 19);
            this.checkBox_Nakit.TabIndex = 2;
            this.checkBox_Nakit.Text = "Nakit";
            this.checkBox_Nakit.UseVisualStyleBackColor = true;
            // 
            // checkBox_Cek
            // 
            this.checkBox_Cek.AutoSize = true;
            this.checkBox_Cek.Location = new System.Drawing.Point(20, 177);
            this.checkBox_Cek.Name = "checkBox_Cek";
            this.checkBox_Cek.Size = new System.Drawing.Size(46, 19);
            this.checkBox_Cek.TabIndex = 1;
            this.checkBox_Cek.Text = "Çek";
            this.checkBox_Cek.UseVisualStyleBackColor = true;
            // 
            // checkBox_KrediKarti
            // 
            this.checkBox_KrediKarti.AutoSize = true;
            this.checkBox_KrediKarti.Location = new System.Drawing.Point(20, 22);
            this.checkBox_KrediKarti.Name = "checkBox_KrediKarti";
            this.checkBox_KrediKarti.Size = new System.Drawing.Size(80, 19);
            this.checkBox_KrediKarti.TabIndex = 0;
            this.checkBox_KrediKarti.Text = "Kredi Kartı";
            this.checkBox_KrediKarti.UseVisualStyleBackColor = true;
            // 
            // button_Ödeme
            // 
            this.button_Ödeme.Location = new System.Drawing.Point(13, 427);
            this.button_Ödeme.Name = "button_Ödeme";
            this.button_Ödeme.Size = new System.Drawing.Size(124, 34);
            this.button_Ödeme.TabIndex = 9;
            this.button_Ödeme.Text = "Ödeme Yap";
            this.button_Ödeme.UseVisualStyleBackColor = true;
            this.button_Ödeme.Click += new System.EventHandler(this.button_Ödeme_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(203, 445);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 15);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Toplam";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 487);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.button_Ödeme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Ödeme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Nakit.ResumeLayout(false);
            this.groupBox_Nakit.PerformLayout();
            this.groupBox_Cek.ResumeLayout(false);
            this.groupBox_Cek.PerformLayout();
            this.groupBox_KrediKarti.ResumeLayout(false);
            this.groupBox_KrediKarti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Nakit;
        private System.Windows.Forms.CheckBox checkBox_Cek;
        private System.Windows.Forms.CheckBox checkBox_KrediKarti;
        private System.Windows.Forms.GroupBox groupBox_Nakit;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.GroupBox groupBox_Cek;
        private System.Windows.Forms.TextBox textBox_HesapID;
        private System.Windows.Forms.TextBox textBox_İsim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_KrediKarti;
        private System.Windows.Forms.TextBox textBox_CVV;
        private System.Windows.Forms.TextBox textBox_SKT;
        private System.Windows.Forms.TextBox textBox_KartNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Ödeme;
        private System.Windows.Forms.Label lbTotal;
    }
}