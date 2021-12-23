using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Orders
    {
        SqlConnection connection = new SqlConnection("Data Source=USERPC\\MSSQLSERVER01;Initial Catalog=Siparis;Integrated Security=True");
        public int OrderID { get; set; }
        public int NumberOfProduct { get; set; }
        public int Status { get; set; }
        public int PaymentId { get;  set; }
        public int Quantity { get;  set; }
        public string AddressTitle { get;  set; }
        public string Address { get;  set; }
        public int Tax { get;  set; }
        public double Amount { get;  set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
        public int OrderState { get; set; }
        public int UserID { get; set; }

        public List<Orders> Order;
        public OrderDetail OrderDetail;
        public Product Product;
        public Credit Credit;
        public Cash Cash;
        public Check Check;
        public void getOrderList()
        {
            SqlCommand cmd2 = new SqlCommand("select * from Orders join OrderDetails on OrderDetails.OrderId=Orders.ID join UserAddress on Orders.UserID=UserAddress.UserID join Payment on PaymentId=Orders.PaymentId", connection);
            //cmd.Parameters.AddWithValue("@UserID", UserID);
            connection.Open();
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                Orders tempItem = new Orders();
                tempItem.OrderNo = (int)sdr2["OrderNo"];
                tempItem.CreateDate = (DateTime)sdr2["CreateDate"];
                tempItem.NumberOfProduct = (int)sdr2["NumberOfProduct"];
                tempItem.UserID = (int)sdr2["UserID"];
                tempItem.Status = (int)sdr2["Status"];
                tempItem.PaymentId = (int)sdr2["PaymentId"];
                tempItem.Quantity = (int)sdr2["Quantity"];
                tempItem.AddressTitle = (string)sdr2["AddressTitle"];
                tempItem.Address = (string)sdr2["Address"];
                tempItem.Tax = (int)sdr2["Tax"];
                tempItem.Amount = (double)sdr2["Amount"];

                Order.Add(new Orders() { 
                    OrderID = (int)sdr2["ID"], 
                    CreateDate = (DateTime)sdr2["CreateDate"], 
                    NumberOfProduct = (int)sdr2["NumberOfProduct"], 
                    UserID = UserID, 
                    Address=tempItem.Address,
                    AddressTitle=tempItem.AddressTitle,
                    Amount=tempItem.Amount,
                    Quantity=tempItem.Quantity,
                    Status = (int)sdr2["Status"] });
            }
        }
        public Orders()
        {
            if (Order == null)
            {
                Order = new List<Orders>();
            }
        }
    }
}
