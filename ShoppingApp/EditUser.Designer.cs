namespace ShoppingApp
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.label2 = new System.Windows.Forms.Label();
            this.boxEditMembershipType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.PassConfirm = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtEditUserName = new System.Windows.Forms.TextBox();
            this.lableUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(225, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(926, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Please edit your details below as required:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxEditMembershipType
            // 
            this.boxEditMembershipType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxEditMembershipType.FormattingEnabled = true;
            this.boxEditMembershipType.Items.AddRange(new object[] {
            "None",
            "Gold",
            "Platinum"});
            this.boxEditMembershipType.Location = new System.Drawing.Point(424, 528);
            this.boxEditMembershipType.Name = "boxEditMembershipType";
            this.boxEditMembershipType.Size = new System.Drawing.Size(727, 40);
            this.boxEditMembershipType.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(225, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 45);
            this.label1.TabIndex = 50;
            this.label1.Text = "Edit User Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1239, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1239, 414);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 79);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassConfirm.Location = new System.Drawing.Point(423, 654);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(728, 39);
            this.txtPassConfirm.TabIndex = 47;
            // 
            // PassConfirm
            // 
            this.PassConfirm.AutoSize = true;
            this.PassConfirm.Location = new System.Drawing.Point(220, 657);
            this.PassConfirm.Name = "PassConfirm";
            this.PassConfirm.Size = new System.Drawing.Size(204, 32);
            this.PassConfirm.TabIndex = 46;
            this.PassConfirm.Text = "Confirm Password";
            // 
            // Membership
            // 
            this.Membership.AutoSize = true;
            this.Membership.Location = new System.Drawing.Point(220, 531);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(207, 32);
            this.Membership.TabIndex = 45;
            this.Membership.Text = "Membership Type";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditPhone.Location = new System.Drawing.Point(424, 471);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(728, 39);
            this.txtEditPhone.TabIndex = 44;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(220, 474);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(177, 32);
            this.Phone.TabIndex = 43;
            this.Phone.Text = "Phone Number";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditAddress.Location = new System.Drawing.Point(424, 414);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(728, 39);
            this.txtEditAddress.TabIndex = 42;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(220, 417);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(98, 32);
            this.Address.TabIndex = 41;
            this.Address.Text = "Address";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditLastName.Location = new System.Drawing.Point(424, 353);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(728, 39);
            this.txtEditLastName.TabIndex = 40;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(220, 356);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(126, 32);
            this.LastName.TabIndex = 39;
            this.LastName.Text = "Last Name";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditFirstName.Location = new System.Drawing.Point(424, 294);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(728, 39);
            this.txtEditFirstName.TabIndex = 38;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(220, 298);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(129, 32);
            this.FirstName.TabIndex = 37;
            this.FirstName.Text = "First Name";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditPassword.Location = new System.Drawing.Point(424, 591);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.PasswordChar = '*';
            this.txtEditPassword.Size = new System.Drawing.Size(728, 39);
            this.txtEditPassword.TabIndex = 36;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(220, 595);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(111, 32);
            this.password.TabIndex = 35;
            this.password.Text = "Password";
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditUserName.Location = new System.Drawing.Point(424, 239);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(728, 39);
            this.txtEditUserName.TabIndex = 34;
            // 
            // lableUserName
            // 
            this.lableUserName.AutoSize = true;
            this.lableUserName.Location = new System.Drawing.Point(220, 242);
            this.lableUserName.Name = "lableUserName";
            this.lableUserName.Size = new System.Drawing.Size(132, 32);
            this.lableUserName.TabIndex = 33;
            this.lableUserName.Text = "User Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1171, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(1239, 510);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(176, 79);
            this.btnDeleteUser.TabIndex = 53;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnExt
            // 
            this.btnExt.Image = ((System.Drawing.Image)(resources.GetObject("btnExt.Image")));
            this.btnExt.Location = new System.Drawing.Point(1430, 0);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(53, 48);
            this.btnExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExt.TabIndex = 54;
            this.btnExt.TabStop = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxEditMembershipType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.PassConfirm);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.txtEditPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtEditUserName);
            this.Controls.Add(this.lableUserName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditUser";
            this.Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxEditMembershipType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Label PassConfirm;
        private System.Windows.Forms.Label Membership;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtEditUserName;
        private System.Windows.Forms.Label lableUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.PictureBox btnExt;
    }
}