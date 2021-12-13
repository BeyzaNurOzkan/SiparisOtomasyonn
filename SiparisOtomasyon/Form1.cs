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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if ((txtKullaniciAdi.Text == "Musteri" && txtSifre.Text == "1234") || (txtKullaniciAdi.Text == "Yonetici" && txtSifre.Text == "1234"))
            {
                if (txtKullaniciAdi.Text == "Musteri")
                {
                    Orders Order = new Orders();
                    Order.Show();
                }
                else
                {
                    IncomingOrder Order = new IncomingOrder();
                    Order.Show();
                }
            }
            else
            { 
                MessageBox.Show("Hatalı Bilgi Girişi!"); 
            }
        }
    }
}
