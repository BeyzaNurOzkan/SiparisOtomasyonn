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
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
        }
        public Product Product;
       
        public string ProductId;
        public int loginId;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=USERPC\\MSSQLSERVER01;Initial Catalog=Siparis;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into BasketProduct (UserId,ProductId,Quantity)  values (@UserId,@ProductId,@Quantity)", connection);
            cmd.Parameters.AddWithValue("@UserId", loginId);
            cmd.Parameters.AddWithValue("@ProductId",Convert.ToInt32(ProductId));
            cmd.Parameters.AddWithValue("@Quantity",Convert.ToInt32( txtAdet.Text));
            connection.Open();

           

            connection.Close();
            Close();
           
        }
    }
}
