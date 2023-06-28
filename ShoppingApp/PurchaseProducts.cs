using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class PurchaseProducts : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        List<string> products = new List<string>();
        List<double> productAmounts = new List<double>();  
        List<double> productPrices = new List<double>();
        public PurchaseProducts()
        {
            InitializeComponent();
            ShowCustomerInformation();
            PopulateBoxes();
        }

        public void ShowCustomerInformation()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = $"SELECT * FROM tbl_user WHERE UserName=@{StartPage.username}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue($"@{StartPage.username}", StartPage.username);
            cmd.CommandText = sql;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string address = reader["Address"].ToString();
                    string phoneNo = reader["PhoneNo"].ToString();
                    string membership = reader["Membership"].ToString();


                    headingCustName.Text = firstName + " " + lastName;
                    custInfoFirstName.Text = firstName;
                    custInfoLastName.Text = lastName;
                    custInfoAddress.Text = address;
                    custInfoPhone.Text = phoneNo;
                    custInfoMembership.Text = membership;
                }

                else
                {
                    MessageBox.Show("An error has occured" );
                }
            }

            catch (Exception ex) { MessageBox.Show("An error has occurred" + ex.Message); }

            finally { conn.Close(); }
        }

        public void PopulateBoxes()
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT ProductDescription FROM tbl_product";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("ProductDescription")))
                    {
                        string productDescription = reader["ProductDescription"].ToString();
                        boxProducts.Items.Add(productDescription);
                    }

                }
                reader.Close();
            }

            catch (Exception ex) { MessageBox.Show("An error occurred" + ex.Message); }

            finally { conn.Close(); }

        }

        private void boxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selection = boxProducts.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT ProductPrice FROM tbl_product WHERE ProductDescription = @selection";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("selection", selection);           
            
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string productPrice = reader["ProductPrice"].ToString();
                    labelAmount.Text = productPrice;
                    boxNoOfItems.Text = null;
                    labelTotal.Text = "Total Amount";
                }
                else { MessageBox.Show("An error occurred"); }
            }
            catch (Exception ex) { MessageBox.Show("An error occurred" + ex.Message); }
            finally { conn.Close(); }

                
        }

        private void boxNoOfItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            double quantity;
            double price;
            double discount;
            string membership = custInfoMembership.Text;
            bool qunatityCheck = Double.TryParse(boxNoOfItems.Text, out quantity);
            bool priceCheck = Double.TryParse(labelAmount.Text, out price);

            try
            {
                if (membership == "None")
                {
                    discount = 1;
                    double result = Math.Floor(quantity * price * discount * 100)/100;
                    labelTotal.Text = String.Format("{0:0.00}", result);
                }

                else if (membership == "Gold")
                {
                    discount = 0.95;
                    double result = Math.Floor(quantity * price * discount * 100) / 100;
                    labelTotal.Text = String.Format("{0:0.00}", result);
                }
                else if (membership == "Platinum")
                {
                    discount = 0.9;
                    double result = Math.Floor(quantity * price * discount * 100) / 100;
                    labelTotal.Text = String.Format("{0:0.00}", result);
                }

                else
                {
                    MessageBox.Show("There was an error");
                }
            }
            catch(Exception ex) { MessageBox.Show("An error occurred" + ex.Message); }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productsText = boxProducts.Text;
            string noOfItems = boxNoOfItems.Text;
            string price = String.Format("{0:0.00}", labelAmount.Text);
            string total = String.Format("{0:0.00}", labelTotal.Text);

            try 
            {
                if (String.IsNullOrWhiteSpace(productsText) || String.IsNullOrWhiteSpace(noOfItems))
                {
                    MessageBox.Show("In order to add an item to your basket, please ensure that you have selected a product as well as the amount of said product you wish to purchase.", "WARNING");
                }
                else
                {
                    string item = boxProducts.SelectedItem.ToString();
                    double amount = Int32.Parse(boxNoOfItems.SelectedItem.ToString());
                    products.Add(item);
                    productAmounts.Add(amount);
                    productPrices.Add(Double.Parse(labelTotal.Text));

                    MessageBox.Show(amount + " x " + item + " has been added to your basket.");

                    boxProducts.Text = "";
                    boxNoOfItems.Text = "";
                    labelAmount.Text = "Item Amount";
                    labelTotal.Text = "Total Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }

              

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool productsIsEmpty = !products.Any();
            bool amountsIsEmpty = !productAmounts.Any();
            bool pricesIsEmpty = !productPrices.Any();

            if (productsIsEmpty || amountsIsEmpty || pricesIsEmpty)
            {
                MessageBox.Show("You have no items in your Basket. Please add items before proceeding to checkout.", "WARNING");
            }

            else
            {
                string message = "Would you like to proceed to checkout?";
                string title = "Proceed to checkout";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Checkout checkout = new Checkout(this);
                    checkout.ShowDialog();
                }
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? Your basket will be emptied and you will be taken back to the login page.";
            string title = "Cancel Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                products.Clear();
                productAmounts.Clear();
                this.Hide();
                StartPage startPage = new StartPage();
                startPage.ShowDialog();
                this.Close();
            }

        }

        public List<string> GetList() 
        { 
            return products;
        }

        public List<double> GetListAmounts()
        {
            return productAmounts;
        }

        public List<double> GetListPrices()
        {
            return productPrices;
        }
        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
