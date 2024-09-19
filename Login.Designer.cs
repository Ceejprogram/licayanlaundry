namespace licayanlaundry
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panLogin = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoginEmployee = new System.Windows.Forms.Button();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("French Script MT", 79.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 152);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Labanderya";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(202, 124);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(148, 22);
            this.lblSubTitle.TabIndex = 4;
            this.lblSubTitle.Text = "since 16th century";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // panLogin
            // 
            this.panLogin.BackColor = System.Drawing.Color.Transparent;
            this.panLogin.Controls.Add(this.btnRegister);
            this.panLogin.Controls.Add(this.lblUsername);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Location = new System.Drawing.Point(12, 164);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(842, 439);
            this.panLogin.TabIndex = 6;
            this.panLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panLogin_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(297, 185);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(172, 33);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(54, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 33);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(297, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 33);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(65, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 33);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(227, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(317, 30);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(227, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 30);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            // 
            // btnLoginEmployee
            // 
            this.btnLoginEmployee.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEmployee.Location = new System.Drawing.Point(998, 658);
            this.btnLoginEmployee.Name = "btnLoginEmployee";
            this.btnLoginEmployee.Size = new System.Drawing.Size(172, 33);
            this.btnLoginEmployee.TabIndex = 7;
            this.btnLoginEmployee.Text = "Login as Staff";
            this.btnLoginEmployee.UseVisualStyleBackColor = true;
            this.btnLoginEmployee.Click += new System.EventHandler(this.btnLoginStaff_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnLoginEmployee);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Button btnLoginEmployee;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

