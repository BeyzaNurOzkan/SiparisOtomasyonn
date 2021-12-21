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
        public int ProductID { get; set; }
        private int AddressID { get; set;}

        public List<Orders> Order;
        public OrderDetail OrderDetail;
        public Product Product;
        public Credit Credit;
        public Cash Cash;
        public Check Check;
        public double calcTax()
        {
            double taxTotal = OrderDetail.calcSubTotal() * OrderDetail.Tax;
            return taxTotal;
        }
        public double calcTotal()
        {
            double priceTotal = OrderDetail.calcSubTotal() + calcTax();
            return priceTotal;
        }
        public void CreditPayment(string Number, string ExpirationDate, int CVV, double Amount)
        {
            Credit = new Credit(Number, ExpirationDate, CVV);
            Credit.Amount = Amount;
        }
        public void CashPayment(double Amount)
        {
            Cash = new Cash();
            Cash.Amount = Amount;
        }
        public void CheckPayment(string bankID, double Amount)
        {
            Check = new Check(bankID);
            Check.Amount = Amount;
        }

        public Orders(Product Product, int Quantity, int UserID, int AddressID)
        {
            OrderDetail = new OrderDetail(Product, Quantity);
            this.ProductID = Product.ID;
            this.UserID = UserID;
            OrderState = 0;
            CreateDate = DateTime.Today;
            this.AddressID = AddressID;
        }
        public void OrderSave(string[,] address, int addressID)
        {
            SqlCommand cmd = new SqlCommand("insert into OrderDetails(date,state,ProductID,UserID,addressTitle,address,quantity,calcTax,priceTotal,weightTotal,Credit,Cash,CheckAmount) values (@date,@state,@ProductID,@UserID,@addressTitle,@address,@quantity,@calcTax,@priceTotal,@weightTotal,@Credit,@Cash,@Check)", connection);
            cmd.Parameters.AddWithValue("@date", CreateDate);
            cmd.Parameters.AddWithValue("@state", OrderState);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@addressTitle", address[addressID, 1]);
            cmd.Parameters.AddWithValue("@quantity", OrderDetail.Quantity);
            cmd.Parameters.AddWithValue("@calcTax", calcTax());
            cmd.Parameters.AddWithValue("@priceTotal", calcTotal());
            cmd.Parameters.AddWithValue("@weightTotal", OrderDetail.calcWeight());
            if (Credit == null) cmd.Parameters.AddWithValue("@Credit", 0);
            else cmd.Parameters.AddWithValue("@Credit", Credit.Amount);
            if (Cash == null) cmd.Parameters.AddWithValue("@Cash", 0);
            else cmd.Parameters.AddWithValue("@Cash", Cash.Amount);
            if (Check == null) cmd.Parameters.AddWithValue("@Check", 0);
            else cmd.Parameters.AddWithValue("@Check", Check.Amount);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
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
