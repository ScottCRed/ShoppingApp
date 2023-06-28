using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class Checkout : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private PurchaseProducts purchaseProducts;
        public Checkout(PurchaseProducts purchaseProducts)
        {
            this.purchaseProducts = purchaseProducts;
            InitializeComponent();          
            ShowCustomerInformation();
            DisplayBasket();
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            string message = "Would you like to proceed to payment?";
            string title = "Proceed to payment";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();                
                MessageBox.Show("Thank you for completing your purchase!");                
                StartPage startPage = new StartPage();
                startPage.ShowDialog();
                this.Close();
            }
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

                    custInfoFirstName.Text = firstName;
                    custInfoLastName.Text = lastName;
                    custInfoAddress.Text = address;
                    custInfoPhone.Text = phoneNo;
                    custInfoMembership.Text = membership;
                }

                else
                {
                    MessageBox.Show("An error has occured");
                }
            }

            catch (Exception ex) { MessageBox.Show("An error has occurred" + ex.Message); }

            finally { conn.Close(); }
        }
        public void DisplayBasket()
        {
            double total = 0;
            int yPos = 4;
            List<string> products = purchaseProducts.GetList();
            List<double> amounts = purchaseProducts.GetListAmounts();
            List<double> prices = purchaseProducts.GetListPrices();

            for (int i = 0; i < products.Count; i++)               
            {
                string priceItem = String.Format("{0:0.00}", prices[i]);
                boxNoOfItems.AppendText($"{amounts[i]}\r\n");
                boxProducts.AppendText($"{products[i]}\r\n");
                boxPrices.AppendText($"{priceItem}\r\n"); 

                total += prices[i];

                PictureBox box = new PictureBox();
                box.Height = 24;
                box.Width = 24;
                box.Location = new Point(0,yPos);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Name = $"imgDelete_{i}";
                box.ImageLocation = "C:\\Users\\ScottC\\source\\repos\\personal\\ShoppingApp\\ShoppingApp\\img\\ext.png";
                panelDelete.Controls.Add(box);

                box.Click += imgDelete_Click;

                yPos += 25;
            }

            boxTotal.Text = String.Format("{0:0.00}", total);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel your purchase? This will empty your basket and log you out.";
            string title = "Cancel purchase";
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

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void imgDelete_Click(object sender, EventArgs e)
        {
            List<string> products = purchaseProducts.GetList();
            List<double> amounts = purchaseProducts.GetListAmounts();
            List<double> prices = purchaseProducts.GetListPrices();

            PictureBox pictureBox = (PictureBox)sender;
            string[] nameSplit = pictureBox.Name.Split('_');
            if (nameSplit[0] == "imgDelete" && nameSplit.Length ==2)
            {
                int index = int.Parse(nameSplit[1]);

                if(index >= 0 && index < products.Count)
                {
                    string message = "Are you sure you want to Remove this item from your basket? This change will be permanent.";
                    string title = "Remove Item";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        boxNoOfItems.Clear();
                        boxPrices.Clear();
                        boxProducts.Clear();
                        panelDelete.Controls.Clear();

                        products.RemoveAt(index);
                        amounts.RemoveAt(index);
                        prices.RemoveAt(index);
                        DisplayBasket();
                    }
                }
            }
        }
    }
}
