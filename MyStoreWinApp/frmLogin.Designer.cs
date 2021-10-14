
namespace MyStoreWinApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Management";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(12, 130);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 28);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 171);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(259, 23);
            this.tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 292);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(259, 23);
            this.tbPassword.TabIndex = 4;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(478, 181);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(155, 47);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(478, 279);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(155, 47);
            this.btQuit.TabIndex = 6;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btQuit;
    }
}