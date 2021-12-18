using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Product
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K72V513;Initial Catalog=Siparis;Integrated Security=True");
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        public List<Product> Products;
        public double Tax { get; set; }
        public Product()
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
        }
        public void getProduct()
        {
            SqlCommand cmd = new SqlCommand("select * from Product", connection);
            connection.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Products.Add(new Product { ID = Convert.ToInt32( sdr["ID"]), Name = Convert.ToString( sdr["Name"]), Price = Convert.ToDouble( sdr["Price"]), Description = Convert.ToString(sdr["Description"]), Weight = Convert.ToDouble(sdr["Weight"]), Tax = Convert.ToDouble(sdr["Tax"] )});
            }
            connection.Close();
        }

        public int maxProductID()
        {
            SqlCommand cmd = new SqlCommand("select MAX(ID) from Product", connection);
            connection.Open();
            int maxProductID = (int)cmd.ExecuteScalar();
            connection.Close();
            if (maxProductID <= 0)
            {
                return 0;
            }
            else
            {
                return maxProductID;
            }

        }

        public void ProductAdd()
        {
            SqlCommand cmd = new SqlCommand("insert into Product(Name,Price,Description,Weight,Tax) values (@Name,@Price,@Description,@Weight,@Tax)", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@Weight", this.Weight);
            cmd.Parameters.AddWithValue("@Tax", this.Tax);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void ProductRemove(int ID)
        {
            SqlCommand cmd = new SqlCommand("delete from Product where ID=@ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ProductUpdate()
        {
            SqlCommand cmd = new SqlCommand("update Product set Name=@Name,Price=@Price,Description=@Description,Weight=@Weight,Tax=@Tax where ID=@ID", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@Weight", this.Weight);
            cmd.Parameters.AddWithValue("@Tax", this.Tax);
            cmd.Parameters.AddWithValue("@ID", this.ID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void getProductList(int userID)
        {
            SqlCommand cmd = new SqlCommand("select * from OrderTable inner join Item on OrderTable.itemID=Item.ID where OrderTable.userID=@userID", connection);
            cmd.Parameters.AddWithValue("@ProductID", ID);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Product product = new Product();
                product.ID = (int)sdr["ID"];
                product.Name = (string)sdr["Name"];
                product.Price = (double)sdr["Price"];
                product.Tax = (double)sdr["Tax"];
                product.Weight = (double)sdr["Weight"];
                product.Description = (string)sdr["Description"];
            }
        }
    }
}
