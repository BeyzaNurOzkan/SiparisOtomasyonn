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
            lw_urun.Columns.Add("Ürün Ağırlığı", 100);


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

        private void User_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from Product", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["Name"]);
            }
            connection.Close();
        }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select *from Product where Name ='" +comboBox1.Text+"';";
            SqlCommand komut = new SqlCommand(sql, connection);
            SqlDataReader myreader;
            try
            {
                connection.Open();
                myreader = komut.ExecuteReader();
                while (myreader.Read())
                {
                    
                    
                    string description = myreader.GetString(2);
                    string agirlik = myreader.GetDouble(3).ToString();
                    string fiyat = myreader.GetDouble(4).ToString();
                    
                    txt_fyt.Text = fiyat;
                    txt_UrunAcik.Text = description;
                    txt_UrunAg.Text = agirlik;


                }
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO BasketProduct(Name,Quantity,Price,Description) VALUES (@Name,@Quantity,@Price,@Description)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@Name", comboBox1.Text);
            komut.Parameters.AddWithValue("@Quantity", txt_adet.Text);
            komut.Parameters.AddWithValue("@Price", txt_fyt.Text);
            komut.Parameters.AddWithValue("@Description", txt_UrunAcik.Text);
            MessageBox.Show("Ürün Sepete Eklendi");
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lw_sepet.Items.Clear();
            lw_sepet.View = View.Details;
            lw_sepet.FullRowSelect = true;
            lw_sepet.GridLines = true;
            lw_sepet.Columns.Add("Ürün Adı", 100);
            lw_sepet.Columns.Add("Ürün Fiyatı", 100);
            lw_sepet.Columns.Add("Ürün Adeti", 100);
            lw_sepet.Columns.Add("Ürün Bilgi", 100);


            connection.Open();
            SqlCommand komut = new SqlCommand("select *from BasketProduct", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = read["Name"].ToString();
                item.SubItems.Add(read["Price"].ToString());
                item.SubItems.Add(read["Quantity"].ToString());
                item.SubItems.Add(read["Description"].ToString());

                lw_sepet.Items.Add(item);
            }

            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string silmeSorgusu = "DELETE from BasketProduct";
            SqlCommand komut = new SqlCommand(silmeSorgusu, connection);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            lw_sepet.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment gec = new Payment();
            gec.Show();
        }
    }   
}
