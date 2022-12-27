
namespace DBProject
{
    partial class Administrator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dgName = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Query = new System.Windows.Forms.TabPage();
            this.addUser = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passordlabel = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.pasportlable = new System.Windows.Forms.Label();
            this.pasportOfUserTxtBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Query.SuspendLayout();
            this.addUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(6, 6);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(879, 232);
            this.txtQuery.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(759, 244);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(126, 33);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgName
            // 
            this.dgName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgName.Location = new System.Drawing.Point(10, 283);
            this.dgName.Name = "dgName";
            this.dgName.RowHeadersWidth = 51;
            this.dgName.RowTemplate.Height = 29;
            this.dgName.Size = new System.Drawing.Size(884, 213);
            this.dgName.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Query);
            this.tabControl1.Controls.Add(this.addUser);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 535);
            this.tabControl1.TabIndex = 4;
            // 
            // Query
            // 
            this.Query.Controls.Add(this.dgName);
            this.Query.Controls.Add(this.btnExecute);
            this.Query.Controls.Add(this.txtQuery);
            this.Query.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Query.Location = new System.Drawing.Point(4, 29);
            this.Query.Name = "Query";
            this.Query.Padding = new System.Windows.Forms.Padding(3);
            this.Query.Size = new System.Drawing.Size(891, 502);
            this.Query.TabIndex = 0;
            this.Query.Text = "Запрос SQL";
            this.Query.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.addUser.Controls.Add(this.btnAddUser);
            this.addUser.Controls.Add(this.passwordTxtBox);
            this.addUser.Controls.Add(this.passordlabel);
            this.addUser.Controls.Add(this.usernameTxtBox);
            this.addUser.Controls.Add(this.usernamelabel);
            this.addUser.Controls.Add(this.pasportlable);
            this.addUser.Controls.Add(this.pasportOfUserTxtBox);
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUser.Location = new System.Drawing.Point(4, 29);
            this.addUser.Name = "addUser";
            this.addUser.Padding = new System.Windows.Forms.Padding(3);
            this.addUser.Size = new System.Drawing.Size(891, 502);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(248, 349);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(409, 82);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtBox.Location = new System.Drawing.Point(384, 246);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(273, 38);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // passordlabel
            // 
            this.passordlabel.AutoSize = true;
            this.passordlabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passordlabel.Location = new System.Drawing.Point(232, 249);
            this.passordlabel.Name = "passordlabel";
            this.passordlabel.Size = new System.Drawing.Size(98, 31);
            this.passordlabel.TabIndex = 4;
            this.passordlabel.Text = "Пароль:";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxtBox.Location = new System.Drawing.Point(384, 172);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(273, 38);
            this.usernameTxtBox.TabIndex = 3;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.Location = new System.Drawing.Point(248, 179);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(82, 31);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Логин:";
            // 
            // pasportlable
            // 
            this.pasportlable.AutoSize = true;
            this.pasportlable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasportlable.Location = new System.Drawing.Point(223, 105);
            this.pasportlable.Name = "pasportlable";
            this.pasportlable.Size = new System.Drawing.Size(107, 31);
            this.pasportlable.TabIndex = 1;
            this.pasportlable.Text = "Паспорт:";
            // 
            // pasportOfUserTxtBox
            // 
            this.pasportOfUserTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasportOfUserTxtBox.Location = new System.Drawing.Point(384, 98);
            this.pasportOfUserTxtBox.Name = "pasportOfUserTxtBox";
            this.pasportOfUserTxtBox.Size = new System.Drawing.Size(273, 38);
            this.pasportOfUserTxtBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(891, 502);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Query.ResumeLayout(false);
            this.Query.PerformLayout();
            this.addUser.ResumeLayout(false);
            this.addUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Query;
        private System.Windows.Forms.TabPage addUser;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label pasportlable;
        private System.Windows.Forms.TextBox pasportOfUserTxtBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passordlabel;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button btnAddUser;
    }
}

