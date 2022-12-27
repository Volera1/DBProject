namespace DBProject
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
            this.autorizacia = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.btnAutorization = new System.Windows.Forms.Button();
            this.userlable = new System.Windows.Forms.Label();
            this.passworlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autorizacia
            // 
            this.autorizacia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autorizacia.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autorizacia.Location = new System.Drawing.Point(14, 12);
            this.autorizacia.Name = "autorizacia";
            this.autorizacia.Size = new System.Drawing.Size(513, 72);
            this.autorizacia.TabIndex = 0;
            this.autorizacia.Text = "Авторизация";
            this.autorizacia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxtBox.Location = new System.Drawing.Point(154, 96);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(372, 47);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtBox.Location = new System.Drawing.Point(154, 183);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(372, 47);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // btnAutorization
            // 
            this.btnAutorization.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutorization.Location = new System.Drawing.Point(14, 272);
            this.btnAutorization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutorization.Name = "btnAutorization";
            this.btnAutorization.Size = new System.Drawing.Size(513, 72);
            this.btnAutorization.TabIndex = 3;
            this.btnAutorization.Text = "Войти";
            this.btnAutorization.UseVisualStyleBackColor = true;
            this.btnAutorization.Click += new System.EventHandler(this.btnAutorization_Click);
            // 
            // userlable
            // 
            this.userlable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userlable.Location = new System.Drawing.Point(14, 83);
            this.userlable.Name = "userlable";
            this.userlable.Size = new System.Drawing.Size(134, 72);
            this.userlable.TabIndex = 4;
            this.userlable.Text = "User:";
            this.userlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passworlable
            // 
            this.passworlable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passworlable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passworlable.Location = new System.Drawing.Point(-19, 170);
            this.passworlable.Name = "passworlable";
            this.passworlable.Size = new System.Drawing.Size(203, 72);
            this.passworlable.TabIndex = 5;
            this.passworlable.Text = "Password:";
            this.passworlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 367);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passworlable);
            this.Controls.Add(this.userlable);
            this.Controls.Add(this.btnAutorization);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.autorizacia);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autorizacia;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button btnAutorization;
        private System.Windows.Forms.Label userlable;
        private System.Windows.Forms.Label passworlable;
    }
}