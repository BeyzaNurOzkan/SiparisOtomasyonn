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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public Users User;
        private void checkBox_KrediKarti_CheckedChanged(object sender, EventArgs e)
        {

            groupBox_KrediKarti.Visible = checkBox_KrediKarti.Checked;

        }

        private void checkBox_Cek_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Cek.Visible = checkBox_Cek.Checked;
        }

        private void checkBox_Nakit_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Nakit.Visible = checkBox_Nakit.Checked;
        }
        private bool KrediKartKontrol()
        {
            if (checkBox_KrediKarti.Checked == true)
            {
                string kartno = "1999-1999-1999-1999", skt = "01.19", cvv = "199";
                if (textBox_KartNo.Text == kartno && textBox_SKT.Text == skt && textBox_CVV.Text == cvv)
                {
                    return true;
                }
                else { MessageBox.Show("Kredi Kartı Bilgileri Yanlış"); return false; }
            }

            else return true;
        }
        private bool CekKontrol()
        {
            if (checkBox_Cek.Checked == true)
            {
                string id = "1999", cekteki_isim = "Anonim";

                if (textBox_HesapID.Text == id && textBox_İsim.Text == cekteki_isim)
                {
                    return true;
                }

                else MessageBox.Show("Çekteki Bilgiler Yanlış"); return false;
            }

            else return true;
        }

        private void button_Ödeme_Click(object sender, EventArgs e)
        {
      
        }
    }
}
