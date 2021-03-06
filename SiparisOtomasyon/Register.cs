using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public int State { get; private set; }

        private void btnKayitol_Click(object sender, EventArgs e)
        {
            Users User = new Users();
            if (txtKullaniciAdi.Text.Length >= 8)
            {
                if (txtAdiSoyadi.Text != "")
                {
                    if (cbxGörevi.Text!="")
                    {
                        if (txtSifre.Text.Length >= 8)
                        {
                            bool Gorev = true;
                            if (cbxGörevi.Text == "Yönetici")
                                Gorev = false;
                            User.UserAdd(txtAdiSoyadi.Text, txtKullaniciAdi.Text, txtSifre.Text, txtAdresBaslik.Text, txtAdres.Text,Gorev);
                            MessageBox.Show("Hoş Geldiniz " + User.Name, "HOŞ GELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Görevi seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ad Soyad boş bırakılamaz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı 7 karakterden oluşmalıdır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
