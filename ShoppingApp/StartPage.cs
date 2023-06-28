using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class StartPage : Form
    {
        public static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public static string username = "";
        public static string user = "";
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
            this.Close();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            string dbCheck = txtUserName.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = $"SELECT COUNT(*) FROM tbl_user WHERE UserName= @{dbCheck}";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue($"@{dbCheck}", txtUserName.Text);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    sql = $"SELECT Password FROM tbl_user WHERE UserName = @{dbCheck}";
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbPass = reader["Password"].ToString();
                        string checkPass = txtPassword.Text; 

                        if (dbPass == checkPass)
                        {
                            DialogResult result = MessageBox.Show("User succesfully logged in", "Successful log in");
                            if (result == DialogResult.OK) 
                            {
                                username = txtUserName.Text;
                                this.Hide();
                                PurchaseProducts shopPage = new PurchaseProducts();
                                shopPage.ShowDialog();
                                
                            }
                            else { Clear(); }
                        }
                        else
                        {
                            MessageBox.Show("Your password is incorrect", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This User Name is incorrect. If you Do not have an account please click on 'Sign Up' below", "Error");
                }
            }
            catch (Exception ex) { MessageBox.Show("An error occurred" + ex.Message); }

            finally { conn.Close(); }

        }

        private void Clear ( )
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string dbCheck = txtUserName.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = $"SELECT COUNT(*) FROM tbl_user WHERE UserName= @{dbCheck}";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue($"@{dbCheck}", txtUserName.Text);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    sql = $"SELECT Password, UserID FROM tbl_user WHERE UserName = @{dbCheck}";
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbPass = reader["Password"].ToString();
                        string userID = reader["UserId"].ToString();
                        string checkPass = txtPassword.Text;

                        if (dbPass == checkPass)
                        {
                            DialogResult result = MessageBox.Show("User succesfully logged in", "Successful log in");
                            if (result == DialogResult.OK)
                            {
                                user = userID;
                                this.Hide();
                                EditUser edit = new EditUser();
                                edit.ShowDialog();

                            }
                            else { Clear(); }
                        }
                        else
                        {
                            MessageBox.Show("Your password is incorrect", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This User Name is incorrect. If you Do not have an account please click on 'Sign Up' below", "Error");
                }
            }
            catch (Exception ex) { MessageBox.Show("An error occurred" + ex.Message); }

            finally { conn.Close(); }
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}