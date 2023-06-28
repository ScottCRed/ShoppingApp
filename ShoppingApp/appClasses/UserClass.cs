using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp.appClasses
{
    public class UserClass
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Membership { get; set; }
        public string Password { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Insert (UserClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_user (UserName, FirstName, LastName, Address, PhoneNo, Membership, Password) VALUES (@UserName, @FirstName, @LastName, @Address, @PhoneNo, @Membership, @Password)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", c.UserName);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@PhoneNo", c.PhoneNo);
                cmd.Parameters.AddWithValue("@Membership", c.Membership);
                cmd.Parameters.AddWithValue("@Password", c.Password);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) 
                { 
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex) { }

            finally { conn.Close(); }   

            return isSuccess;
        }
        public bool Edit(UserClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_user SET UserName=@UserName, FirstName=@FirstName, LastName=@LastName, PhoneNo=@PhoneNo, Address=@Address, Membership=@Membership, Password=@Password WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", c.UserName);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@PhoneNo", c.PhoneNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Membership", c.Membership);
                cmd.Parameters.AddWithValue("@Password", c.Password);
                cmd.Parameters.AddWithValue("@UserID", c.UserID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return isSuccess;
        }
        public bool DeleteUser(UserClass c) 
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_user WHERE UserName=@UserName";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserName", c.UserName);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return isSuccess;
        }
    }
}
