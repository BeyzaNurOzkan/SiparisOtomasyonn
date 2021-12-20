using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //USERPC\\MSSQLSERVER01
        //DESKTOP-K72V513
        List<Product> Products;
        Product Product;

        public void urunlistele()
        {
           Product = new Product();
            Product.getProduct();
            Products = Product.Products;
            lw_urun.Items.Clear();
            lw_urun.View = View.Details;
            lw_urun.FullRowSelect = true;
            lw_urun.GridLines = true;
            lw_urun.Columns.Add("No", 50);
            lw_urun.Columns.Add("İsmi", 200);
            lw_urun.Columns.Add("Ağırlığı", 100);
            lw_urun.Columns.Add("Vergi Oranı", 100);
            lw_urun.Columns.Add("Açıklaması", 300);
            string Tax;
            for (int i = 0; i < Products.Count; i++)
            {

                if (Products[i].Tax == 0.01)
                    Tax = "%1";
                else if (Products[i].Tax == 0.08)
                    Tax = "%8";
                else
                    Tax = "%18";

                string[] row =
                {
                    Products[i].ID.ToString(),
                    Products[i].Name,
                    Products[i].Weight.ToString()+" kg",
                    Tax,
                    Products[i].Description
                };
                var listviewLine = new ListViewItem(row);
                lw_urun.Items.Add(listviewLine);
            }
        }
        private void User_Load(object sender, EventArgs e)
        {
            urunlistele();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Payment gec = new Payment();
            gec.Show();
        }
    }   
}
