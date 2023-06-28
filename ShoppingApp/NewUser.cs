using ShoppingApp.appClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class NewUser : Form
    {
        UserClass c = new UserClass();
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtNewUserName.Text;
            string firstName = txtNewFirstName.Text;
            string lastName = txtNewLastName.Text;
            string address = txtNewAddress.Text;
            string phoneNo = txtNewPhone.Text;
            string membership = boxMembershipType.Text;
            string password = txtNewPassword.Text;
            c.UserName = userName;
            c.FirstName = firstName;
            c.LastName = lastName;
            c.Address = address;
            c.PhoneNo = phoneNo;
            c.Membership = membership;
            c.Password = password;

            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName) || String.IsNullOrWhiteSpace(address) || String.IsNullOrWhiteSpace(phoneNo) || String.IsNullOrWhiteSpace(membership))
            {
                MessageBox.Show("User not submitted. Please make sure you fill in all of the above fields");
            }

            else
            {
                bool success = false;
                if (password == txtPassConfirm.Text && !String.IsNullOrWhiteSpace(password))
                {
                    success = c.Insert(c);
                }
                else
                {
                    success = false;
                    MessageBox.Show("Your passwords did not match. Please enter them correctly");
                }


                if (success == true)
                {
                    Clear();
                    string message = "New user has been added. Would you like to be directed to the Shopping page?";
                    string title = "User Successfully added";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        StartPage.username = userName;
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
                    MessageBox.Show("Failed to add new user, try again");
                }
            }
            

        }

        public void Clear ()
        {
            txtNewUserName.Text = "";
            txtNewFirstName.Text = "";
            txtNewLastName.Text = "";
            txtNewAddress.Text = "";
            txtNewPhone.Text = "";
            boxMembershipType.Text = "";
            txtNewPassword.Text = "";
            txtPassConfirm.Text = "";
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? All your information will be lost.";
            string title = "Cancel Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                StartPage startPage = new StartPage();
                startPage.ShowDialog();
                this.Close();
            }
        }
    }
}
