using System.Drawing;
using System.Windows.Forms;

namespace ShoppingApp
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.Label();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.PassConfirm = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxMembershipType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1170, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.Location = new System.Drawing.Point(423, 581);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(728, 32);
            this.txtNewPassword.TabIndex = 13;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(219, 585);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(91, 25);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewUserName.Location = new System.Drawing.Point(423, 229);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(728, 32);
            this.txtNewUserName.TabIndex = 11;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(219, 232);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(105, 25);
            this.userName.TabIndex = 10;
            this.userName.Text = "User Name";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewFirstName.Location = new System.Drawing.Point(423, 284);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(728, 32);
            this.txtNewFirstName.TabIndex = 15;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(219, 288);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(102, 25);
            this.FirstName.TabIndex = 14;
            this.FirstName.Text = "First Name";
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewLastName.Location = new System.Drawing.Point(423, 343);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(728, 32);
            this.txtNewLastName.TabIndex = 17;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(219, 346);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 25);
            this.LastName.TabIndex = 16;
            this.LastName.Text = "Last Name";
            // 
            // Membership
            // 
            this.Membership.AutoSize = true;
            this.Membership.Location = new System.Drawing.Point(219, 521);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(162, 25);
            this.Membership.TabIndex = 22;
            this.Membership.Text = "Membership Type";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPhone.Location = new System.Drawing.Point(423, 461);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(728, 32);
            this.txtNewPhone.TabIndex = 21;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(219, 464);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(140, 25);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "Phone Number";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewAddress.Location = new System.Drawing.Point(423, 404);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(728, 32);
            this.txtNewAddress.TabIndex = 19;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(219, 407);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(79, 25);
            this.Address.TabIndex = 18;
            this.Address.Text = "Address";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassConfirm.Location = new System.Drawing.Point(422, 644);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(728, 32);
            this.txtPassConfirm.TabIndex = 25;
            // 
            // PassConfirm
            // 
            this.PassConfirm.AutoSize = true;
            this.PassConfirm.Location = new System.Drawing.Point(219, 647);
            this.PassConfirm.Name = "PassConfirm";
            this.PassConfirm.Size = new System.Drawing.Size(164, 25);
            this.PassConfirm.TabIndex = 24;
            this.PassConfirm.Text = "Confirm Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1238, 477);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 79);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1238, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 45);
            this.label1.TabIndex = 28;
            this.label1.Text = "New User Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxMembershipType
            // 
            this.boxMembershipType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxMembershipType.FormattingEnabled = true;
            this.boxMembershipType.Items.AddRange(new object[] {
            "None",
            "Gold",
            "Platinum"});
            this.boxMembershipType.Location = new System.Drawing.Point(423, 518);
            this.boxMembershipType.Name = "boxMembershipType";
            this.boxMembershipType.Size = new System.Drawing.Size(727, 33);
            this.boxMembershipType.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(224, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(926, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Please enter your details below:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExt
            // 
            this.btnExt.Image = ((System.Drawing.Image)(resources.GetObject("btnExt.Image")));
            this.btnExt.Location = new System.Drawing.Point(1428, -2);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(53, 48);
            this.btnExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExt.TabIndex = 33;
            this.btnExt.TabStop = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxMembershipType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.PassConfirm);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtNewFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewUser";
            this.Text = "New User Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtNewPassword;
        private Label password;
        private TextBox txtNewUserName;
        private Label userName;
        private TextBox txtNewFirstName;
        private Label FirstName;
        private TextBox txtNewLastName;
        private Label LastName;
        private Label Membership;
        private TextBox txtNewPhone;
        private Label Phone;
        private TextBox txtNewAddress;
        private Label Address;
        private TextBox txtPassConfirm;
        private Label PassConfirm;
        private Button btnSubmit;
        private Button btnCancel;
        private Label label1;
        private ComboBox boxMembershipType;
        private Label label2;
        private PictureBox btnExt;
    }
}