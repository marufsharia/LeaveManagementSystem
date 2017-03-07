namespace LeaveManagementSystem
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkLabelCreakeAcc = new System.Windows.Forms.LinkLabel();
            this.linkLabelforgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(90, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(197, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(90, 67);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(197, 27);
            this.txtemail.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(90, 105);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(197, 27);
            this.txtpassword.TabIndex = 2;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.Location = new System.Drawing.Point(38, 70);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(46, 20);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // linkLabelCreakeAcc
            // 
            this.linkLabelCreakeAcc.AutoSize = true;
            this.linkLabelCreakeAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelCreakeAcc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreakeAcc.Location = new System.Drawing.Point(124, 207);
            this.linkLabelCreakeAcc.Name = "linkLabelCreakeAcc";
            this.linkLabelCreakeAcc.Size = new System.Drawing.Size(112, 20);
            this.linkLabelCreakeAcc.TabIndex = 5;
            this.linkLabelCreakeAcc.TabStop = true;
            this.linkLabelCreakeAcc.Text = "Create account ";
            this.linkLabelCreakeAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreakeAcc_LinkClicked);
            // 
            // linkLabelforgot
            // 
            this.linkLabelforgot.AutoSize = true;
            this.linkLabelforgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelforgot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelforgot.Location = new System.Drawing.Point(124, 182);
            this.linkLabelforgot.Name = "linkLabelforgot";
            this.linkLabelforgot.Size = new System.Drawing.Size(125, 20);
            this.linkLabelforgot.TabIndex = 6;
            this.linkLabelforgot.TabStop = true;
            this.linkLabelforgot.Text = "Forgot Password?";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.linkLabelforgot);
            this.Controls.Add(this.linkLabelCreakeAcc);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 236);
            this.MinimumSize = new System.Drawing.Size(334, 236);
            this.Name = "frmLogin";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "LMS -Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel linkLabelCreakeAcc;
        private System.Windows.Forms.LinkLabel linkLabelforgot;
    }
}