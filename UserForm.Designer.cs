namespace DBProject
{
    partial class UserForm
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
            this.pasportlabel = new System.Windows.Forms.Label();
            this.userOrdersGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.openRoomsPage = new System.Windows.Forms.TabPage();
            this.Tolabel = new System.Windows.Forms.Label();
            this.fromlabel = new System.Windows.Forms.Label();
            this.btnFindOpenRooms = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.openRoomsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ordersPage.SuspendLayout();
            this.openRoomsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openRoomsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pasportlabel
            // 
            this.pasportlabel.AutoSize = true;
            this.pasportlabel.Location = new System.Drawing.Point(6, 3);
            this.pasportlabel.Name = "pasportlabel";
            this.pasportlabel.Size = new System.Drawing.Size(85, 23);
            this.pasportlabel.TabIndex = 0;
            this.pasportlabel.Text = "Паспорт: ";
            // 
            // userOrdersGridView
            // 
            this.userOrdersGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userOrdersGridView.Location = new System.Drawing.Point(3, 26);
            this.userOrdersGridView.Name = "userOrdersGridView";
            this.userOrdersGridView.RowHeadersWidth = 51;
            this.userOrdersGridView.RowTemplate.Height = 29;
            this.userOrdersGridView.Size = new System.Drawing.Size(762, 367);
            this.userOrdersGridView.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.ordersPage);
            this.tabControl1.Controls.Add(this.openRoomsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 429);
            this.tabControl1.TabIndex = 2;
            // 
            // ordersPage
            // 
            this.ordersPage.Controls.Add(this.userOrdersGridView);
            this.ordersPage.Controls.Add(this.pasportlabel);
            this.ordersPage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPage.Location = new System.Drawing.Point(4, 29);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(768, 396);
            this.ordersPage.TabIndex = 0;
            this.ordersPage.Text = "Проживания";
            this.ordersPage.UseVisualStyleBackColor = true;
            // 
            // openRoomsPage
            // 
            this.openRoomsPage.Controls.Add(this.Tolabel);
            this.openRoomsPage.Controls.Add(this.fromlabel);
            this.openRoomsPage.Controls.Add(this.btnFindOpenRooms);
            this.openRoomsPage.Controls.Add(this.dateTimePickerTo);
            this.openRoomsPage.Controls.Add(this.dateTimePickerFrom);
            this.openRoomsPage.Controls.Add(this.openRoomsGridView);
            this.openRoomsPage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openRoomsPage.Location = new System.Drawing.Point(4, 29);
            this.openRoomsPage.Name = "openRoomsPage";
            this.openRoomsPage.Padding = new System.Windows.Forms.Padding(3);
            this.openRoomsPage.Size = new System.Drawing.Size(768, 396);
            this.openRoomsPage.TabIndex = 1;
            this.openRoomsPage.Text = "Найти свободную комнату";
            this.openRoomsPage.UseVisualStyleBackColor = true;
            // 
            // Tolabel
            // 
            this.Tolabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tolabel.AutoSize = true;
            this.Tolabel.Location = new System.Drawing.Point(289, 11);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(32, 23);
            this.Tolabel.TabIndex = 5;
            this.Tolabel.Text = "До";
            // 
            // fromlabel
            // 
            this.fromlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromlabel.AutoSize = true;
            this.fromlabel.Location = new System.Drawing.Point(6, 11);
            this.fromlabel.Name = "fromlabel";
            this.fromlabel.Size = new System.Drawing.Size(21, 23);
            this.fromlabel.TabIndex = 4;
            this.fromlabel.Text = "С";
            // 
            // btnFindOpenRooms
            // 
            this.btnFindOpenRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindOpenRooms.Location = new System.Drawing.Point(583, 6);
            this.btnFindOpenRooms.Name = "btnFindOpenRooms";
            this.btnFindOpenRooms.Size = new System.Drawing.Size(179, 34);
            this.btnFindOpenRooms.TabIndex = 3;
            this.btnFindOpenRooms.Text = "Найти";
            this.btnFindOpenRooms.UseVisualStyleBackColor = true;
            this.btnFindOpenRooms.Click += new System.EventHandler(this.btnFindOpenRooms_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTo.CustomFormat = "\'\'yyyy\'-\'MM\'-\'dd\'\'";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(327, 8);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(250, 30);
            this.dateTimePickerTo.TabIndex = 2;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 12, 27, 15, 1, 2, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFrom.CustomFormat = "\'\'yyyy\'-\'MM\'-\'dd\'\'";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(33, 8);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(250, 30);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // openRoomsGridView
            // 
            this.openRoomsGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openRoomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openRoomsGridView.Location = new System.Drawing.Point(3, 46);
            this.openRoomsGridView.Name = "openRoomsGridView";
            this.openRoomsGridView.RowHeadersWidth = 51;
            this.openRoomsGridView.RowTemplate.Height = 29;
            this.openRoomsGridView.Size = new System.Drawing.Size(759, 344);
            this.openRoomsGridView.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ordersPage.ResumeLayout(false);
            this.ordersPage.PerformLayout();
            this.openRoomsPage.ResumeLayout(false);
            this.openRoomsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openRoomsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pasportlabel;
        private System.Windows.Forms.DataGridView userOrdersGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.TabPage openRoomsPage;
        private System.Windows.Forms.Label fromlabel;
        private System.Windows.Forms.Button btnFindOpenRooms;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DataGridView openRoomsGridView;
        private System.Windows.Forms.Label Tolabel;
    }
}