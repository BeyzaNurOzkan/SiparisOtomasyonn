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
        SqlConnection connection = new SqlConnection("Data Source=USERPC;Initial Catalog=Siparis;Integrated Security=True");
        public int UserID { get; private set; }
        public string Name { get; private set; }
        public string[,] UserAddress = new string[5, 3];
        private string UserName { get; set; }
        private string Password { get; set; }
        public Boolean State { get; private set; }
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

        public void UserAdd(string Name, string UserName, string Password, string AddressTitle, string Address)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.UserAddress[0, 0] = AddressTitle;
            this.UserAddress[0, 1] = Address;
            SqlCommand cmd = new SqlCommand("insert into Users(Name,UserName,Password) values (@Name,@UserName,@Password)", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@UserName", this.UserName);
            cmd.Parameters.AddWithValue("@Password", this.Password);
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

            SqlCommand cmd = new SqlCommand("select * from Users where UserState='0'", connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User.Add(new Users { UserID = (int)sdr["UserID"], UserName = (string)sdr["UserName"], Name = (string)sdr["Name"] });
            }
            connection.Close();
        }
        public void getAddress(int userID)
        {
            SqlCommand cmd = new SqlCommand("select * from UserAddress where UserID=@UserID", connection);
            cmd.Parameters.AddWithValue("@UserID", userID);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            for (int j = 0; j < UserAddress.Length / 3; j++)
            {
                UserAddress[j, 0] = null;
                UserAddress[j, 1] = null;
                UserAddress[j, 2] = null;
            }
            int i = 0;
            while (sdr.Read())
            {
                UserAddress[i, 0] = sdr["AddressID"].ToString();
                UserAddress[i, 1] = (string)sdr["AddressTitle"];
                UserAddress[i, 2] = (string)sdr["Address"];
                i++;
            }
            connection.Close();
        }
        public void AddressRemove(int ListNumber)
        {
            int addressID = Convert.ToInt32(UserAddress[ListNumber, 0]);
            for (int i = 0; i < 3; i++)
                UserAddress[ListNumber, i] = null;
            SqlCommand cmd = new SqlCommand("delete from UserAddress where AddressID=@AddressID", connection);
            cmd.Parameters.AddWithValue("@AddressID", addressID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
