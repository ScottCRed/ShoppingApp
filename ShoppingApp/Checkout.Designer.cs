using System.Drawing;
using System.Windows.Forms;

namespace ShoppingApp
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custInfoAddress = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.custInfoMembership = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.custInfoPhone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.custInfoLastName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.custInfoFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.labelNoOfItems = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.boxNoOfItems = new System.Windows.Forms.TextBox();
            this.boxProducts = new System.Windows.Forms.TextBox();
            this.boxPrices = new System.Windows.Forms.TextBox();
            this.boxTotal = new System.Windows.Forms.TextBox();
            this.btnExt = new System.Windows.Forms.PictureBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(524, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 54);
            this.label1.TabIndex = 33;
            this.label1.Text = "Customer Checkout";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1170, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // custInfoAddress
            // 
            this.custInfoAddress.AutoSize = true;
            this.custInfoAddress.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoAddress.Location = new System.Drawing.Point(1269, 465);
            this.custInfoAddress.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoAddress.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoAddress.Name = "custInfoAddress";
            this.custInfoAddress.Size = new System.Drawing.Size(175, 23);
            this.custInfoAddress.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label16.Location = new System.Drawing.Point(1163, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 23);
            this.label16.TabIndex = 66;
            this.label16.Text = "Address";
            // 
            // custInfoMembership
            // 
            this.custInfoMembership.AutoSize = true;
            this.custInfoMembership.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoMembership.Location = new System.Drawing.Point(1269, 422);
            this.custInfoMembership.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoMembership.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoMembership.Name = "custInfoMembership";
            this.custInfoMembership.Size = new System.Drawing.Size(175, 23);
            this.custInfoMembership.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label14.Location = new System.Drawing.Point(1163, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 23);
            this.label14.TabIndex = 64;
            this.label14.Text = "Membership";
            // 
            // custInfoPhone
            // 
            this.custInfoPhone.AutoSize = true;
            this.custInfoPhone.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoPhone.Location = new System.Drawing.Point(1269, 379);
            this.custInfoPhone.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoPhone.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoPhone.Name = "custInfoPhone";
            this.custInfoPhone.Size = new System.Drawing.Size(175, 23);
            this.custInfoPhone.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label12.Location = new System.Drawing.Point(1163, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 62;
            this.label12.Text = "Phone No.";
            // 
            // custInfoLastName
            // 
            this.custInfoLastName.AutoSize = true;
            this.custInfoLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoLastName.Location = new System.Drawing.Point(1269, 339);
            this.custInfoLastName.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoLastName.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoLastName.Name = "custInfoLastName";
            this.custInfoLastName.Size = new System.Drawing.Size(175, 23);
            this.custInfoLastName.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(1163, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 60;
            this.label10.Text = "Last Name";
            // 
            // custInfoFirstName
            // 
            this.custInfoFirstName.AutoSize = true;
            this.custInfoFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoFirstName.Location = new System.Drawing.Point(1269, 298);
            this.custInfoFirstName.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoFirstName.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoFirstName.Name = "custInfoFirstName";
            this.custInfoFirstName.Size = new System.Drawing.Size(175, 23);
            this.custInfoFirstName.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(1163, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1226, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 57;
            this.label6.Text = "Customer Details";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(876, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Red;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(247, 600);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(176, 79);
            this.btnProceed.TabIndex = 72;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // labelNoOfItems
            // 
            this.labelNoOfItems.AutoSize = true;
            this.labelNoOfItems.Location = new System.Drawing.Point(283, 188);
            this.labelNoOfItems.Name = "labelNoOfItems";
            this.labelNoOfItems.Size = new System.Drawing.Size(137, 31);
            this.labelNoOfItems.TabIndex = 74;
            this.labelNoOfItems.Text = "No. of Items";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(911, 187);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 31);
            this.labelPrice.TabIndex = 75;
            this.labelPrice.Text = "Price";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(397, 187);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(94, 31);
            this.labelProduct.TabIndex = 76;
            this.labelProduct.Text = "Product";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(848, 537);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 31);
            this.labelTotal.TabIndex = 77;
            this.labelTotal.Text = "Total";
            // 
            // boxNoOfItems
            // 
            this.boxNoOfItems.Location = new System.Drawing.Point(288, 216);
            this.boxNoOfItems.Multiline = true;
            this.boxNoOfItems.Name = "boxNoOfItems";
            this.boxNoOfItems.Size = new System.Drawing.Size(108, 300);
            this.boxNoOfItems.TabIndex = 78;
            // 
            // boxProducts
            // 
            this.boxProducts.Location = new System.Drawing.Point(402, 215);
            this.boxProducts.Multiline = true;
            this.boxProducts.Name = "boxProducts";
            this.boxProducts.Size = new System.Drawing.Size(498, 300);
            this.boxProducts.TabIndex = 79;
            // 
            // boxPrices
            // 
            this.boxPrices.Location = new System.Drawing.Point(916, 216);
            this.boxPrices.Multiline = true;
            this.boxPrices.Name = "boxPrices";
            this.boxPrices.Size = new System.Drawing.Size(136, 299);
            this.boxPrices.TabIndex = 80;
            this.boxPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxTotal
            // 
            this.boxTotal.Location = new System.Drawing.Point(916, 530);
            this.boxTotal.Name = "boxTotal";
            this.boxTotal.Size = new System.Drawing.Size(136, 38);
            this.boxTotal.TabIndex = 81;
            // 
            // btnExt
            // 
            this.btnExt.Image = ((System.Drawing.Image)(resources.GetObject("btnExt.Image")));
            this.btnExt.Location = new System.Drawing.Point(1429, -1);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(53, 48);
            this.btnExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExt.TabIndex = 82;
            this.btnExt.TabStop = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.Location = new System.Drawing.Point(247, 216);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(35, 299);
            this.panelDelete.TabIndex = 84;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.ControlBox = false;
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.boxTotal);
            this.Controls.Add(this.boxPrices);
            this.Controls.Add(this.boxProducts);
            this.Controls.Add(this.boxNoOfItems);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelNoOfItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.custInfoAddress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.custInfoMembership);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.custInfoPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.custInfoLastName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.custInfoFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label custInfoAddress;
        private Label label16;
        private Label custInfoMembership;
        private Label label14;
        private Label custInfoPhone;
        private Label label12;
        private Label custInfoLastName;
        private Label label10;
        private Label custInfoFirstName;
        private Label label7;
        private Label label6;
        private Button btnCancel;
        private Button btnProceed;
        private Label labelNoOfItems;
        private Label labelPrice;
        private Label labelProduct;
        private Label labelTotal;
        private TextBox boxNoOfItems;
        private TextBox boxProducts;
        private TextBox boxPrices;
        private TextBox boxTotal;
        private PictureBox btnExt;
        private Panel panelDelete;
    }
}