using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Users
    {
        SqlConnection connection = new SqlConnection("Data Source=USERPC\\MSSQLSERVER01;Initial Catalog=Siparis;Integrated Security=True");
        //USERPC\\MSSQLSERVER01
        //DESKTOP-K72V513
        public int UserID { get; set; }
        public string Name { get; set; }
        public string[,] UserAddress = new string[5, 3];
        public string UserName { get; set; }
        public string AddressTitle { get;  set; }
        public string Address { get;  set; }
        public string Password { get; set; }
        public Boolean State { get; set; }
        public List<Users> User;

        public bool ConnectionQuery(string userName, string password)
        {
            SqlCommand cmd = new SqlCommand("select * from Users", connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if ((sdr["UserName"].ToString() == userName) && (sdr["Password"].ToString() == password))
                {
                    this.UserID = (int)sdr["UserID"];
                    this.Name = (string)sdr["Name"];
                    this.UserName = (string)sdr["UserName"];
                    this.Password = (string)sdr["Password"];
                    this.State = Convert.ToBoolean(sdr["State"]);
                    connection.Close();
                    SqlCommand cmd1 = new SqlCommand("select * from UserAddress where UserID=@UserID", connection);
                    cmd1.Parameters.AddWithValue("@UserID", this.UserID);
                    connection.Open();
                    sdr = cmd1.ExecuteReader();
                    int i = 0;
                    while (sdr.Read())
                    {
                        UserAddress[i, 0] = sdr["AddressID"].ToString();
                        UserAddress[i, 1] = (string)sdr["AddressTitle"];
                        UserAddress[i, 2] = (string)sdr["Address"];
                        i++;
                    }
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
        public bool UserNameUsedControl(string UserName)
        {
            SqlCommand cmd = new SqlCommand("select COUNT(UserName) from Users where UserName=@UserName", connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            connection.Open();
            int userCount = (int)cmd.ExecuteScalar();
            connection.Close();
            if (userCount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UserAdd(string Name, string UserName, string Password, string AddressTitle, string Address, bool State)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.UserAddress[0, 0] = AddressTitle;
            this.UserAddress[0, 1] = Address;
            this.State = State;

            SqlCommand cmd = new SqlCommand("insert into Users(Name,UserName,Password,State) values (@Name,@UserName,@Password,@State)", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@UserName", this.UserName);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Parameters.AddWithValue("@State", this.State);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            if (Address != "")
            {
                cmd.CommandText = "select MAX(UserID) from Users";
                connection.Open();
                int maxUserID = (int)cmd.ExecuteScalar();
                connection.Close();
                cmd.CommandText = "insert into UserAddress(AddressTitle,Address,UserID) values (@AddressTitle,@Address,@UserID)";
                cmd.Parameters.AddWithValue("@AddressTitle", this.UserAddress[0, 0]);
                cmd.Parameters.AddWithValue("@Address", this.UserAddress[0, 1]);
                cmd.Parameters.AddWithValue("@UserID", maxUserID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public Users()
        {
            if (User == null)
            {
                User = new List<Users>();
            }
        }
        public void getUsers()
        {

            SqlCommand cmd = new SqlCommand("select * from Users", connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User.Add(new Users { UserID = (int)sdr["UserID"], UserName = (string)sdr["UserName"], Name = (string)sdr["Name"], Password = (string)sdr["Password"] , State= Convert.ToBoolean( sdr["State"])});
            }
            connection.Close();
        }
        public void UserUpdate()
        {
            SqlCommand cmd = new SqlCommand("update Users set Name=@Name,Password=@Password,UserName=@UserName,State=@State where UserID=@ID", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Parameters.AddWithValue("@UserName", this.UserName);
            cmd.Parameters.AddWithValue("@State", this.State);
            cmd.Parameters.AddWithValue("@ID", this.UserID);
            connection.Open();
            cmd.ExecuteNonQuery();
        }
        public void UserUpdate2(int UserID,string Name, string Password, string UserName, string AddressTitle, string Address)
        {
            this.Name = Name;
            this.Password = Password;
            this.UserID = UserID;
            this.UserName = UserName;
            
            SqlCommand cmd = new SqlCommand("update Users set Name=@Name,Password=@Password,UserName=@UserName where UserID=@UserID update UserAddress set AddressTitle=@AddressTitle,Address=@Address where UserID=@UserID ", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Parameters.AddWithValue("@UserName", this.UserName);
            cmd.Parameters.AddWithValue("@UserID", this.UserID);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@AddressTitle",AddressTitle);
            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
