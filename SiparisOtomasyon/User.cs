using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SiparisOtomasyon
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
       SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K72V513;Initial Catalog=Siparis;Integrated Security=True");
        private void btn_UrunGoruntule_Click(object sender, EventArgs e)
        {
            lw_urun.Items.Clear();
            lw_urun.View = View.Details;
            lw_urun.FullRowSelect = true;
            lw_urun.GridLines = true;
            lw_urun.Columns.Add("Ürün Adı", 100);
            lw_urun.Columns.Add("Ürün Fiyatı", 100);
            lw_urun.Columns.Add("Ürün Adı", 100);

            connection.Open();
            SqlCommand komut = new SqlCommand("select *from Product", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = read["Name"].ToString();
                item.SubItems.Add(read["Price"].ToString()); 
                item.SubItems.Add(read["Weight"].ToString());
                
                lw_urun.Items.Add(item);
            }

            connection.Close();
        }
    }
}
