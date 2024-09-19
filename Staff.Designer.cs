namespace licayanlaundry
{
    partial class Staff
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
            this.btnStaffExit = new System.Windows.Forms.Button();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffUsername = new System.Windows.Forms.Label();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.txtStaffUser = new System.Windows.Forms.TextBox();
            this.txtStaffPass = new System.Windows.Forms.TextBox();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStaffExit
            // 
            this.btnStaffExit.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffExit.Location = new System.Drawing.Point(219, 221);
            this.btnStaffExit.Name = "btnStaffExit";
            this.btnStaffExit.Size = new System.Drawing.Size(172, 33);
            this.btnStaffExit.TabIndex = 0;
            this.btnStaffExit.Text = "Exit";
            this.btnStaffExit.UseVisualStyleBackColor = true;
            this.btnStaffExit.Click += new System.EventHandler(this.btnStaffExit_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(176, 74);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(263, 27);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(36, 75);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(123, 23);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "Staff Name:";
            // 
            // lblStaffUsername
            // 
            this.lblStaffUsername.AutoSize = true;
            this.lblStaffUsername.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffUsername.Location = new System.Drawing.Point(45, 108);
            this.lblStaffUsername.Name = "lblStaffUsername";
            this.lblStaffUsername.Size = new System.Drawing.Size(116, 23);
            this.lblStaffUsername.TabIndex = 2;
            this.lblStaffUsername.Text = "Username:";
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPassword.Location = new System.Drawing.Point(54, 141);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.Size = new System.Drawing.Size(114, 23);
            this.lblStaffPassword.TabIndex = 2;
            this.lblStaffPassword.Text = "Password: ";
            // 
            // txtStaffUser
            // 
            this.txtStaffUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffUser.Location = new System.Drawing.Point(176, 105);
            this.txtStaffUser.Name = "txtStaffUser";
            this.txtStaffUser.Size = new System.Drawing.Size(263, 27);
            this.txtStaffUser.TabIndex = 1;
            this.txtStaffUser.TextChanged += new System.EventHandler(this.txtStaffUser_TextChanged);
            // 
            // txtStaffPass
            // 
            this.txtStaffPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPass.Location = new System.Drawing.Point(176, 137);
            this.txtStaffPass.Name = "txtStaffPass";
            this.txtStaffPass.Size = new System.Drawing.Size(263, 27);
            this.txtStaffPass.TabIndex = 1;
            this.txtStaffPass.TextChanged += new System.EventHandler(this.txtStaffPass_TextChanged);
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogin.Location = new System.Drawing.Point(219, 182);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(172, 33);
            this.btnStaffLogin.TabIndex = 0;
            this.btnStaffLogin.Text = "Login";
            this.btnStaffLogin.UseVisualStyleBackColor = true;
            this.btnStaffLogin.Click += new System.EventHandler(this.btnStaffLogin_Click);
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTitle.Location = new System.Drawing.Point(217, 21);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(173, 32);
            this.lblStaffTitle.TabIndex = 2;
            this.lblStaffTitle.Text = "Staff Login";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 284);
            this.Controls.Add(this.lblStaffPassword);
            this.Controls.Add(this.lblStaffUsername);
            this.Controls.Add(this.lblStaffTitle);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.txtStaffPass);
            this.Controls.Add(this.txtStaffUser);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.btnStaffExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Staff";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffExit;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffUsername;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.TextBox txtStaffUser;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Button btnStaffLogin;
        private System.Windows.Forms.Label lblStaffTitle;
    }
}