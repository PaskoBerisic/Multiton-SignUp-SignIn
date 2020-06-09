namespace WindowsFormsApp1
{
    partial class Login
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
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(15, 87);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(181, 20);
            this.loginPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(15, 48);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(181, 20);
            this.loginUsername.TabIndex = 12;
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(121, 124);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 11;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Come in, just sign in !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(12, 124);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 15;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 170);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPassword);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBack;
    }
}