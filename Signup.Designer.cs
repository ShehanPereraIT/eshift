namespace EShiftApp
{
    partial class Signup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginRedirect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 99);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(17, 199);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(118, 16);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 252);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 302);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(152, 199);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(152, 248);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 299);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSignUp.Location = new System.Drawing.Point(87, 367);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(90, 30);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(192, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(104, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sign Up";
            // 
            // lblLoginRedirect
            // 
            this.lblLoginRedirect.AutoSize = true;
            this.lblLoginRedirect.ForeColor = System.Drawing.Color.Blue;
            this.lblLoginRedirect.Location = new System.Drawing.Point(84, 412);
            this.lblLoginRedirect.Name = "lblLoginRedirect";
            this.lblLoginRedirect.Size = new System.Drawing.Size(198, 16);
            this.lblLoginRedirect.TabIndex = 15;
            this.lblLoginRedirect.Text = "Already have an account? Login";
            this.lblLoginRedirect.Click += new System.EventHandler(this.lblLoginRedirect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e_shift.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Signup
            // 
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginRedirect);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Signup";
            this.Text = "Sign Up - e-Shift Application";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginRedirect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
