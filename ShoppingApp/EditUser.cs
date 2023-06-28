using ShoppingApp.appClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class EditUser : Form
    {
        UserClass c = new UserClass();
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public EditUser()
        {
            InitializeComponent();
            ShowCustomerInformation();
        }

        public void ShowCustomerInformation()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = $"SELECT * FROM tbl_user WHERE UserID=@UserID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@UserID", StartPage.user);
            cmd.CommandText = sql;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userName = reader["UserName"].ToString();
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string address = reader["Address"].ToString();
                    string phoneNo = reader["PhoneNo"].ToString();
                    string membership = reader["Membership"].ToString();
                    int userID = Convert.ToInt32(reader["UserID"]);

                    c.UserName = userName;
                    c.FirstName = firstName;
                    c.LastName = lastName;
                    c.Address = address;
                    c.PhoneNo = phoneNo;
                    c.Membership = membership;
                    c.UserID = userID;

                    txtEditUserName.Text = userName;    
                    txtEditFirstName.Text = firstName;
                    txtEditLastName.Text = lastName;
                    txtEditAddress.Text = address;
                    txtEditPhone.Text = phoneNo;
                    boxEditMembershipType.Text = membership;
                }

                else
                {
                    MessageBox.Show("An error has occured");
                }
            }

            catch (Exception ex) { MessageBox.Show("An error has occurred" + ex.Message); }

            finally { conn.Close(); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string newUserName = txtEditUserName.Text;
                string firstName = txtEditFirstName.Text;
                string lastName = txtEditLastName.Text;
                string address = txtEditAddress.Text;
                string phoneNo = txtEditPhone.Text;
                string membership = boxEditMembershipType.Text;
                string password = txtEditPassword.Text;
                c.UserName = newUserName;
                c.FirstName = firstName;
                c.LastName = lastName;
                c.Address = address;
                c.PhoneNo = phoneNo;
                c.Membership = membership;
                c.Password = password;

                if (String.IsNullOrWhiteSpace(newUserName) || String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName) || String.IsNullOrWhiteSpace(address) || String.IsNullOrWhiteSpace(phoneNo) || String.IsNullOrWhiteSpace(membership))
                {
                    MessageBox.Show("User not updated. Please make sure you fill in all of the above fields");
                }

                else
                {
                    bool success = false;
                    if (password == txtPassConfirm.Text && !String.IsNullOrWhiteSpace(password))
                    {
                        success = c.Edit(c);
                    }
                    else
                    {
                        success = false;
                        MessageBox.Show("Your passwords did not match. Please enter them correctly");
                    }


                    if (success == true)
                    {
                        Clear();
                        string message = "Your details have been updated. Would you like to be directed to the Shopping page?";
                        string title = "User Successfully updated";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            StartPage.username = newUserName;
                            this.Hide();
                            PurchaseProducts shopPage = new PurchaseProducts();
                            shopPage.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            StartPage startPage = new StartPage();
                            startPage.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to update user, try again");
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        public void Clear()
        {
            txtEditUserName.Text = "";
            txtEditFirstName.Text = "";
            txtEditLastName.Text = "";
            txtEditAddress.Text = "";
            txtEditPhone.Text = "";
            boxEditMembershipType.Text = "";
            txtEditPassword.Text = "";
            txtPassConfirm.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? Your updates will be lost.";
            string title = "Cancel Update";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                Clear();
                this.Hide();
                StartPage page = new StartPage();
                page.ShowDialog();
                this.Close();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete your profile? You will need to create a new one in order to shop.";
            string title = "Delete User";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                c.UserName = StartPage.username;
                bool success = c.DeleteUser(c);

                if (success == true)
                {
                    MessageBox.Show("User Deleted Succesfully");

                    Clear();
                    this.Hide();
                    StartPage page = new StartPage();
                    page.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.");
                }

            }
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
