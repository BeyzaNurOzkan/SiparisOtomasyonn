using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public Users User = new Users();

        public int State { get; private set; }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (User.ConnectionQuery(txtKullaniciAdi.Text, txtSifre.Text))
            {
                if (User.State==true)
                {
                    User User = new User();
                    User.Show();
                }
                else
                {
                    Executive Executive = new Executive();
                    Executive.Show();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi!");
            }
        }
        private void btnKayit_Click_1(object sender, EventArgs e)
        {
            Register Register = new Register();
            Register.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
