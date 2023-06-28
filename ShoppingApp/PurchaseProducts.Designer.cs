using System.Drawing;
using System.Windows.Forms;

namespace ShoppingApp
{
    partial class PurchaseProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseProducts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.Label();
            this.boxProducts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxNoOfItems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.custInfoFirstName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.custInfoLastName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.custInfoPhone = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.custInfoMembership = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.custInfoAddress = new System.Windows.Forms.Label();
            this.headingCustName = new System.Windows.Forms.Label();
            this.btnExt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(434, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Welcome to the Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Please select your product and the amount you wish to purchase below";
            // 
            // Membership
            // 
            this.Membership.AutoSize = true;
            this.Membership.Location = new System.Drawing.Point(274, 249);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(78, 25);
            this.Membership.TabIndex = 35;
            this.Membership.Text = "Product";
            // 
            // boxProducts
            // 
            this.boxProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxProducts.DisplayMember = "ProductDescription";
            this.boxProducts.FormattingEnabled = true;
            this.boxProducts.Location = new System.Drawing.Point(473, 246);
            this.boxProducts.Name = "boxProducts";
            this.boxProducts.Size = new System.Drawing.Size(650, 33);
            this.boxProducts.TabIndex = 36;
            this.boxProducts.SelectionChangeCommitted += new System.EventHandler(this.boxProducts_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "No. of Items";
            // 
            // boxNoOfItems
            // 
            this.boxNoOfItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxNoOfItems.FormattingEnabled = true;
            this.boxNoOfItems.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxNoOfItems.Location = new System.Drawing.Point(473, 319);
            this.boxNoOfItems.Name = "boxNoOfItems";
            this.boxNoOfItems.Size = new System.Drawing.Size(650, 33);
            this.boxNoOfItems.TabIndex = 38;
            this.boxNoOfItems.SelectedIndexChanged += new System.EventHandler(this.boxNoOfItems_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Amount per Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total amount";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAmount.Location = new System.Drawing.Point(473, 396);
            this.labelAmount.MinimumSize = new System.Drawing.Size(650, 39);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(650, 39);
            this.labelAmount.TabIndex = 41;
            this.labelAmount.Text = "Item Amount";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Location = new System.Drawing.Point(473, 471);
            this.labelTotal.MinimumSize = new System.Drawing.Size(650, 39);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(650, 39);
            this.labelTotal.TabIndex = 42;
            this.labelTotal.Text = "Total Amount";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(278, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 79);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add to Basket";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(628, 573);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(176, 79);
            this.btnCheckOut.TabIndex = 44;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(951, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1233, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Customer Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(1170, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "First Name";
            // 
            // custInfoFirstName
            // 
            this.custInfoFirstName.AutoSize = true;
            this.custInfoFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoFirstName.Location = new System.Drawing.Point(1276, 290);
            this.custInfoFirstName.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoFirstName.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoFirstName.Name = "custInfoFirstName";
            this.custInfoFirstName.Size = new System.Drawing.Size(175, 19);
            this.custInfoFirstName.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label10.Location = new System.Drawing.Point(1170, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "Last Name";
            // 
            // custInfoLastName
            // 
            this.custInfoLastName.AutoSize = true;
            this.custInfoLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoLastName.Location = new System.Drawing.Point(1276, 331);
            this.custInfoLastName.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoLastName.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoLastName.Name = "custInfoLastName";
            this.custInfoLastName.Size = new System.Drawing.Size(175, 19);
            this.custInfoLastName.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label12.Location = new System.Drawing.Point(1170, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "Phone No.";
            // 
            // custInfoPhone
            // 
            this.custInfoPhone.AutoSize = true;
            this.custInfoPhone.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoPhone.Location = new System.Drawing.Point(1276, 371);
            this.custInfoPhone.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoPhone.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoPhone.Name = "custInfoPhone";
            this.custInfoPhone.Size = new System.Drawing.Size(175, 19);
            this.custInfoPhone.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label14.Location = new System.Drawing.Point(1170, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = "Membership";
            // 
            // custInfoMembership
            // 
            this.custInfoMembership.AutoSize = true;
            this.custInfoMembership.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoMembership.Location = new System.Drawing.Point(1276, 414);
            this.custInfoMembership.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoMembership.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoMembership.Name = "custInfoMembership";
            this.custInfoMembership.Size = new System.Drawing.Size(175, 19);
            this.custInfoMembership.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label16.Location = new System.Drawing.Point(1170, 457);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 19);
            this.label16.TabIndex = 55;
            this.label16.Text = "Address";
            // 
            // custInfoAddress
            // 
            this.custInfoAddress.AutoSize = true;
            this.custInfoAddress.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.custInfoAddress.Location = new System.Drawing.Point(1276, 457);
            this.custInfoAddress.MaximumSize = new System.Drawing.Size(175, 0);
            this.custInfoAddress.MinimumSize = new System.Drawing.Size(175, 0);
            this.custInfoAddress.Name = "custInfoAddress";
            this.custInfoAddress.Size = new System.Drawing.Size(175, 19);
            this.custInfoAddress.TabIndex = 56;
            // 
            // headingCustName
            // 
            this.headingCustName.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.headingCustName.Location = new System.Drawing.Point(434, 77);
            this.headingCustName.Name = "headingCustName";
            this.headingCustName.Size = new System.Drawing.Size(614, 45);
            this.headingCustName.TabIndex = 57;
            this.headingCustName.Text = "*Name*";
            this.headingCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExt
            // 
            this.btnExt.Image = ((System.Drawing.Image)(resources.GetObject("btnExt.Image")));
            this.btnExt.Location = new System.Drawing.Point(1428, -1);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(53, 48);
            this.btnExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExt.TabIndex = 59;
            this.btnExt.TabStop = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // PurchaseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.headingCustName);
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxNoOfItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxProducts);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PurchaseProducts";
            this.Text = "Purchase Products";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label Membership;
        private ComboBox boxProducts;
        private Label label3;
        private ComboBox boxNoOfItems;
        private Label label5;
        private Label label4;
        private Label labelAmount;
        private Label labelTotal;
        private Button btnAdd;
        private Button btnCheckOut;
        private Button btnCancel;
        private Label label6;
        private Label label7;
        private Label custInfoFirstName;
        private Label label10;
        private Label custInfoLastName;
        private Label label12;
        private Label custInfoPhone;
        private Label label14;
        private Label custInfoMembership;
        private Label label16;
        private Label custInfoAddress;
        private Label headingCustName;
        private PictureBox btnExt;
    }
}