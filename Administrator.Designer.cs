
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
            this.addOrder = new System.Windows.Forms.TabPage();
            this.bedComboBox = new System.Windows.Forms.ComboBox();
            this.departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pasportOrderTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.TabPage();
            this.organizationsGridView = new System.Windows.Forms.DataGridView();
            this.numRoomComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.departureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orgNumComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.deletedComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deletedDataGridView = new System.Windows.Forms.DataGridView();
            this.labelDeletedKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgName)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Query.SuspendLayout();
            this.addUser.SuspendLayout();
            this.addOrder.SuspendLayout();
            this.addReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsGridView)).BeginInit();
            this.Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuery.Location = new System.Drawing.Point(6, 6);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(879, 232);
            this.txtQuery.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.dgName.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.Query);
            this.tabControl1.Controls.Add(this.addUser);
            this.tabControl1.Controls.Add(this.addOrder);
            this.tabControl1.Controls.Add(this.addReservation);
            this.tabControl1.Controls.Add(this.Delete);
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
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.passwordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxtBox.Location = new System.Drawing.Point(384, 246);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(273, 38);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // passordlabel
            // 
            this.passordlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.usernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxtBox.Location = new System.Drawing.Point(384, 172);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(273, 38);
            this.usernameTxtBox.TabIndex = 3;
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.pasportlable.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.pasportOfUserTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasportOfUserTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasportOfUserTxtBox.Location = new System.Drawing.Point(384, 98);
            this.pasportOfUserTxtBox.Name = "pasportOfUserTxtBox";
            this.pasportOfUserTxtBox.Size = new System.Drawing.Size(273, 38);
            this.pasportOfUserTxtBox.TabIndex = 0;
            // 
            // addOrder
            // 
            this.addOrder.Controls.Add(this.bedComboBox);
            this.addOrder.Controls.Add(this.departureDatePicker);
            this.addOrder.Controls.Add(this.arrivalDatePicker);
            this.addOrder.Controls.Add(this.label4);
            this.addOrder.Controls.Add(this.label3);
            this.addOrder.Controls.Add(this.label2);
            this.addOrder.Controls.Add(this.pasportOrderTxtBox);
            this.addOrder.Controls.Add(this.label1);
            this.addOrder.Controls.Add(this.btnAddOrder);
            this.addOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOrder.Location = new System.Drawing.Point(4, 29);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(891, 502);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "Добавить проживание";
            this.addOrder.UseVisualStyleBackColor = true;
            // 
            // bedComboBox
            // 
            this.bedComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bedComboBox.FormattingEnabled = true;
            this.bedComboBox.Location = new System.Drawing.Point(400, 132);
            this.bedComboBox.Name = "bedComboBox";
            this.bedComboBox.Size = new System.Drawing.Size(151, 36);
            this.bedComboBox.TabIndex = 10;
            // 
            // departureDatePicker
            // 
            this.departureDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDatePicker.Location = new System.Drawing.Point(400, 273);
            this.departureDatePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.departureDatePicker.Name = "departureDatePicker";
            this.departureDatePicker.Size = new System.Drawing.Size(250, 34);
            this.departureDatePicker.TabIndex = 9;
            this.departureDatePicker.Value = new System.DateTime(2022, 12, 27, 15, 39, 47, 0);
            // 
            // arrivalDatePicker
            // 
            this.arrivalDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalDatePicker.Location = new System.Drawing.Point(400, 207);
            this.arrivalDatePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.arrivalDatePicker.Name = "arrivalDatePicker";
            this.arrivalDatePicker.Size = new System.Drawing.Size(250, 34);
            this.arrivalDatePicker.TabIndex = 8;
            this.arrivalDatePicker.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(222, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата выезда:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата приезда:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер кровати:";
            // 
            // pasportOrderTxtBox
            // 
            this.pasportOrderTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasportOrderTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasportOrderTxtBox.Location = new System.Drawing.Point(400, 65);
            this.pasportOrderTxtBox.Name = "pasportOrderTxtBox";
            this.pasportOrderTxtBox.Size = new System.Drawing.Size(273, 38);
            this.pasportOrderTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Паспорт:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOrder.Location = new System.Drawing.Point(243, 351);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(430, 83);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Добавить";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // addReservation
            // 
            this.addReservation.Controls.Add(this.organizationsGridView);
            this.addReservation.Controls.Add(this.numRoomComboBox);
            this.addReservation.Controls.Add(this.label8);
            this.addReservation.Controls.Add(this.departureTimePicker);
            this.addReservation.Controls.Add(this.arrivalTimePicker);
            this.addReservation.Controls.Add(this.label7);
            this.addReservation.Controls.Add(this.label6);
            this.addReservation.Controls.Add(this.label5);
            this.addReservation.Controls.Add(this.orgNumComboBox);
            this.addReservation.Controls.Add(this.btnAddReservation);
            this.addReservation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addReservation.Location = new System.Drawing.Point(4, 29);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(891, 502);
            this.addReservation.TabIndex = 3;
            this.addReservation.Text = "Добавить резервацию";
            this.addReservation.UseVisualStyleBackColor = true;
            // 
            // organizationsGridView
            // 
            this.organizationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizationsGridView.Location = new System.Drawing.Point(451, 3);
            this.organizationsGridView.Name = "organizationsGridView";
            this.organizationsGridView.RowHeadersWidth = 51;
            this.organizationsGridView.RowTemplate.Height = 29;
            this.organizationsGridView.Size = new System.Drawing.Size(437, 496);
            this.organizationsGridView.TabIndex = 15;
            // 
            // numRoomComboBox
            // 
            this.numRoomComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numRoomComboBox.FormattingEnabled = true;
            this.numRoomComboBox.Location = new System.Drawing.Point(195, 251);
            this.numRoomComboBox.Name = "numRoomComboBox";
            this.numRoomComboBox.Size = new System.Drawing.Size(97, 36);
            this.numRoomComboBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(59, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Комната:";
            // 
            // departureTimePicker
            // 
            this.departureTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureTimePicker.Location = new System.Drawing.Point(195, 187);
            this.departureTimePicker.Name = "departureTimePicker";
            this.departureTimePicker.Size = new System.Drawing.Size(250, 34);
            this.departureTimePicker.TabIndex = 12;
            this.departureTimePicker.Value = new System.DateTime(2022, 12, 27, 15, 39, 47, 0);
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimePicker.Location = new System.Drawing.Point(195, 128);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.Size = new System.Drawing.Size(250, 34);
            this.arrivalTimePicker.TabIndex = 11;
            this.arrivalTimePicker.Value = new System.DateTime(2022, 12, 27, 15, 39, 40, 0);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дата выезда:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата приезда:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Организация:";
            // 
            // orgNumComboBox
            // 
            this.orgNumComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orgNumComboBox.FormattingEnabled = true;
            this.orgNumComboBox.Location = new System.Drawing.Point(195, 68);
            this.orgNumComboBox.Name = "orgNumComboBox";
            this.orgNumComboBox.Size = new System.Drawing.Size(97, 36);
            this.orgNumComboBox.TabIndex = 2;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddReservation.Location = new System.Drawing.Point(17, 336);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(414, 78);
            this.btnAddReservation.TabIndex = 1;
            this.btnAddReservation.Text = "Добавить";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.btnDelete);
            this.Delete.Controls.Add(this.deletedComboBox);
            this.Delete.Controls.Add(this.label10);
            this.Delete.Controls.Add(this.tableDeleteComboBox);
            this.Delete.Controls.Add(this.label9);
            this.Delete.Controls.Add(this.deletedDataGridView);
            this.Delete.Controls.Add(this.labelDeletedKey);
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(4, 29);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(891, 502);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Удаление";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(701, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // deletedComboBox
            // 
            this.deletedComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletedComboBox.FormattingEnabled = true;
            this.deletedComboBox.Location = new System.Drawing.Point(544, 3);
            this.deletedComboBox.Name = "deletedComboBox";
            this.deletedComboBox.Size = new System.Drawing.Size(151, 36);
            this.deletedComboBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(361, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "элемент с ключем";
            // 
            // tableDeleteComboBox
            // 
            this.tableDeleteComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableDeleteComboBox.FormattingEnabled = true;
            this.tableDeleteComboBox.Items.AddRange(new object[] {
            "Order",
            "Bed",
            "Room",
            "Reservation",
            "users",
            "Organization",
            "Guest"});
            this.tableDeleteComboBox.Location = new System.Drawing.Point(204, 3);
            this.tableDeleteComboBox.Name = "tableDeleteComboBox";
            this.tableDeleteComboBox.Size = new System.Drawing.Size(151, 36);
            this.tableDeleteComboBox.TabIndex = 2;
            this.tableDeleteComboBox.SelectedValueChanged += new System.EventHandler(this.tableDeleteComboBox_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Удалить из таблицы";
            // 
            // deletedDataGridView
            // 
            this.deletedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedDataGridView.Location = new System.Drawing.Point(3, 45);
            this.deletedDataGridView.Name = "deletedDataGridView";
            this.deletedDataGridView.RowHeadersWidth = 51;
            this.deletedDataGridView.RowTemplate.Height = 29;
            this.deletedDataGridView.Size = new System.Drawing.Size(885, 454);
            this.deletedDataGridView.TabIndex = 0;
            // 
            // labelDeletedKey
            // 
            this.labelDeletedKey.AutoSize = true;
            this.labelDeletedKey.Location = new System.Drawing.Point(474, 34);
            this.labelDeletedKey.Name = "labelDeletedKey";
            this.labelDeletedKey.Size = new System.Drawing.Size(0, 23);
            this.labelDeletedKey.TabIndex = 6;
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
            this.addOrder.ResumeLayout(false);
            this.addOrder.PerformLayout();
            this.addReservation.ResumeLayout(false);
            this.addReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsGridView)).EndInit();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage addOrder;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passordlabel;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pasportOrderTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TabPage addReservation;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DateTimePicker departureDatePicker;
        private System.Windows.Forms.DateTimePicker arrivalDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker departureTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox orgNumComboBox;
        private System.Windows.Forms.ComboBox numRoomComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bedComboBox;
        private System.Windows.Forms.DataGridView organizationsGridView;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.ComboBox tableDeleteComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView deletedDataGridView;
        private System.Windows.Forms.ComboBox deletedComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelDeletedKey;
    }
}

