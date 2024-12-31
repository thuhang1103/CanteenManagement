namespace QLCanTeen
{
    partial class fAdmin
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
            tpAccount = new TabPage();
            panel21 = new Panel();
            btnResetPassword = new Button();
            panel23 = new Panel();
            nmTypeAccount = new NumericUpDown();
            label11 = new Label();
            panel24 = new Panel();
            txbDisplayName = new TextBox();
            label12 = new Label();
            panel25 = new Panel();
            txbUserName = new TextBox();
            label13 = new Label();
            panel26 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel27 = new Panel();
            dtgvAccount = new DataGridView();
            tpTable = new TabPage();
            panel19 = new Panel();
            txbStatus = new TextBox();
            label9 = new Label();
            panel15 = new Panel();
            txbTableName = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            txbTableID = new TextBox();
            label8 = new Label();
            panel17 = new Panel();
            dtgvTable = new DataGridView();
            panel18 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpCategoryFood = new TabPage();
            panel13 = new Panel();
            txbNameCategory = new TextBox();
            label5 = new Label();
            panel14 = new Panel();
            txbCategoryID = new TextBox();
            label6 = new Label();
            panel12 = new Panel();
            dtgvCategory = new DataGridView();
            panel11 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodId = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpBill = new TabPage();
            panel2 = new Panel();
            txbPage = new TextBox();
            btnLast = new Button();
            btnNextLast = new Button();
            btnNextFirst = new Button();
            btnFirst = new Button();
            txbTotalRevenueDay = new TextBox();
            dtpkDate = new DateTimePicker();
            btnTotalRevenua = new Button();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            txbTotalRevenueMonth = new TextBox();
            btnTotalRevenueMonth = new Button();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tcAdmin = new TabControl();
            tpAccount.SuspendLayout();
            panel21.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmTypeAccount).BeginInit();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            tpTable.SuspendLayout();
            panel19.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel18.SuspendLayout();
            tpCategoryFood.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel11.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tcAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel21);
            tpAccount.Controls.Add(panel26);
            tpAccount.Controls.Add(panel27);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1007, 569);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài Khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Controls.Add(btnResetPassword);
            panel21.Controls.Add(panel23);
            panel21.Controls.Add(panel24);
            panel21.Controls.Add(panel25);
            panel21.Location = new Point(572, 93);
            panel21.Name = "panel21";
            panel21.Size = new Size(424, 470);
            panel21.TabIndex = 4;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = SystemColors.ActiveCaption;
            btnResetPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetPassword.Location = new Point(232, 253);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(149, 44);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "đặt lại mật khẩu ";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel23
            // 
            panel23.Controls.Add(nmTypeAccount);
            panel23.Controls.Add(label11);
            panel23.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel23.Location = new Point(3, 168);
            panel23.Name = "panel23";
            panel23.Size = new Size(378, 64);
            panel23.TabIndex = 3;
            // 
            // nmTypeAccount
            // 
            nmTypeAccount.Location = new Point(188, 22);
            nmTypeAccount.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmTypeAccount.Name = "nmTypeAccount";
            nmTypeAccount.Size = new Size(46, 33);
            nmTypeAccount.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 24);
            label11.Name = "label11";
            label11.Size = new Size(145, 30);
            label11.TabIndex = 0;
            label11.Text = "Loại tài khoản :";
            // 
            // panel24
            // 
            panel24.Controls.Add(txbDisplayName);
            panel24.Controls.Add(label12);
            panel24.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel24.Location = new Point(3, 84);
            panel24.Name = "panel24";
            panel24.Size = new Size(378, 64);
            panel24.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDisplayName.Location = new Point(160, 22);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(215, 33);
            txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 24);
            label12.Name = "label12";
            label12.Size = new Size(126, 30);
            label12.TabIndex = 0;
            label12.Text = "tên hiển thị  :";
            // 
            // panel25
            // 
            panel25.Controls.Add(txbUserName);
            panel25.Controls.Add(label13);
            panel25.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel25.Location = new Point(3, 3);
            panel25.Name = "panel25";
            panel25.Size = new Size(378, 64);
            panel25.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(160, 24);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(215, 33);
            txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(16, 24);
            label13.Name = "label13";
            label13.Size = new Size(138, 30);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản :";
            // 
            // panel26
            // 
            panel26.Controls.Add(btnShowAccount);
            panel26.Controls.Add(btnEditAccount);
            panel26.Controls.Add(btnDeleteAccount);
            panel26.Controls.Add(btnAddAccount);
            panel26.Location = new Point(11, 6);
            panel26.Name = "panel26";
            panel26.Size = new Size(555, 81);
            panel26.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = SystemColors.ActiveCaption;
            btnShowAccount.Font = new Font("Segoe UI", 12F);
            btnShowAccount.Location = new Point(338, 20);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(94, 44);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "xem";
            btnShowAccount.UseVisualStyleBackColor = false;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.BackColor = SystemColors.ActiveCaption;
            btnEditAccount.Font = new Font("Segoe UI", 12F);
            btnEditAccount.Location = new Point(227, 20);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 44);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = SystemColors.ActiveCaption;
            btnDeleteAccount.Font = new Font("Segoe UI", 12F);
            btnDeleteAccount.Location = new Point(115, 20);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 44);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = SystemColors.ActiveCaption;
            btnAddAccount.Font = new Font("Segoe UI", 12F);
            btnAddAccount.Location = new Point(3, 20);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 44);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "thêm";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel27
            // 
            panel27.Controls.Add(dtgvAccount);
            panel27.Location = new Point(11, 93);
            panel27.Name = "panel27";
            panel27.Size = new Size(555, 470);
            panel27.TabIndex = 3;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(538, 464);
            dtgvAccount.TabIndex = 0;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel19);
            tpTable.Controls.Add(panel15);
            tpTable.Controls.Add(panel16);
            tpTable.Controls.Add(panel17);
            tpTable.Controls.Add(panel18);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(1007, 569);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn Ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.Controls.Add(txbStatus);
            panel19.Controls.Add(label9);
            panel19.Font = new Font("Segoe UI", 12F);
            panel19.Location = new Point(606, 259);
            panel19.Name = "panel19";
            panel19.Size = new Size(378, 64);
            panel19.TabIndex = 10;
            // 
            // txbStatus
            // 
            txbStatus.Location = new Point(145, 20);
            txbStatus.Name = "txbStatus";
            txbStatus.ReadOnly = true;
            txbStatus.Size = new Size(230, 34);
            txbStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 24);
            label9.Name = "label9";
            label9.Size = new Size(108, 30);
            label9.TabIndex = 0;
            label9.Text = "trạng thái :";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbTableName);
            panel15.Controls.Add(label7);
            panel15.Font = new Font("Segoe UI", 12F);
            panel15.Location = new Point(606, 178);
            panel15.Name = "panel15";
            panel15.Size = new Size(378, 64);
            panel15.TabIndex = 9;
            // 
            // txbTableName
            // 
            txbTableName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTableName.Location = new Point(145, 22);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(230, 34);
            txbTableName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 24);
            label7.Name = "label7";
            label7.Size = new Size(89, 30);
            label7.TabIndex = 0;
            label7.Text = "tên bàn :";
            // 
            // panel16
            // 
            panel16.Controls.Add(txbTableID);
            panel16.Controls.Add(label8);
            panel16.Font = new Font("Segoe UI", 12F);
            panel16.Location = new Point(606, 97);
            panel16.Name = "panel16";
            panel16.Size = new Size(378, 64);
            panel16.TabIndex = 8;
            // 
            // txbTableID
            // 
            txbTableID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTableID.Location = new Point(145, 24);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(230, 34);
            txbTableID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 24);
            label8.Name = "label8";
            label8.Size = new Size(35, 30);
            label8.TabIndex = 0;
            label8.Text = "id:";
            // 
            // panel17
            // 
            panel17.Controls.Add(dtgvTable);
            panel17.Location = new Point(22, 94);
            panel17.Name = "panel17";
            panel17.Size = new Size(555, 409);
            panel17.TabIndex = 7;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(538, 389);
            dtgvTable.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnShowTable);
            panel18.Controls.Add(btnEditTable);
            panel18.Controls.Add(btnDeleteTable);
            panel18.Controls.Add(btnAddTable);
            panel18.Location = new Point(22, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(555, 81);
            panel18.TabIndex = 6;
            // 
            // btnShowTable
            // 
            btnShowTable.BackColor = SystemColors.ActiveCaption;
            btnShowTable.Font = new Font("Segoe UI", 12F);
            btnShowTable.Location = new Point(338, 20);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(94, 44);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "xem";
            btnShowTable.UseVisualStyleBackColor = false;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.BackColor = SystemColors.ActiveCaption;
            btnEditTable.Font = new Font("Segoe UI", 12F);
            btnEditTable.Location = new Point(227, 20);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(94, 44);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = false;
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.BackColor = SystemColors.ActiveCaption;
            btnDeleteTable.Font = new Font("Segoe UI", 12F);
            btnDeleteTable.Location = new Point(115, 20);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(94, 44);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "xóa";
            btnDeleteTable.UseVisualStyleBackColor = false;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = SystemColors.ActiveCaption;
            btnAddTable.Font = new Font("Segoe UI", 12F);
            btnAddTable.Location = new Point(3, 20);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 44);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "thêm";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tpCategoryFood
            // 
            tpCategoryFood.Controls.Add(panel13);
            tpCategoryFood.Controls.Add(panel14);
            tpCategoryFood.Controls.Add(panel12);
            tpCategoryFood.Controls.Add(panel11);
            tpCategoryFood.Location = new Point(4, 29);
            tpCategoryFood.Name = "tpCategoryFood";
            tpCategoryFood.Padding = new Padding(3);
            tpCategoryFood.Size = new Size(1007, 569);
            tpCategoryFood.TabIndex = 2;
            tpCategoryFood.Text = "Danh Mục ";
            tpCategoryFood.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(txbNameCategory);
            panel13.Controls.Add(label5);
            panel13.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel13.Location = new Point(590, 180);
            panel13.Name = "panel13";
            panel13.Size = new Size(378, 64);
            panel13.TabIndex = 5;
            // 
            // txbNameCategory
            // 
            txbNameCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNameCategory.Location = new Point(145, 22);
            txbNameCategory.Name = "txbNameCategory";
            txbNameCategory.Size = new Size(230, 34);
            txbNameCategory.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 24);
            label5.Name = "label5";
            label5.Size = new Size(122, 26);
            label5.TabIndex = 0;
            label5.Text = "tên danh mục :";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbCategoryID);
            panel14.Controls.Add(label6);
            panel14.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel14.Location = new Point(590, 99);
            panel14.Name = "panel14";
            panel14.Size = new Size(378, 64);
            panel14.TabIndex = 4;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCategoryID.Location = new Point(145, 24);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(230, 31);
            txbCategoryID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 24);
            label6.Name = "label6";
            label6.Size = new Size(29, 26);
            label6.TabIndex = 0;
            label6.Text = "id:";
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvCategory);
            panel12.Location = new Point(6, 96);
            panel12.Name = "panel12";
            panel12.Size = new Size(555, 452);
            panel12.TabIndex = 3;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(538, 435);
            dtgvCategory.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(555, 81);
            panel11.TabIndex = 2;
            // 
            // btnShowCategory
            // 
            btnShowCategory.BackColor = SystemColors.ActiveCaption;
            btnShowCategory.Font = new Font("Segoe UI", 12F);
            btnShowCategory.Location = new Point(338, 20);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(94, 44);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "xem";
            btnShowCategory.UseVisualStyleBackColor = false;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.BackColor = SystemColors.ActiveCaption;
            btnEditCategory.Font = new Font("Segoe UI", 12F);
            btnEditCategory.Location = new Point(227, 20);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 44);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = SystemColors.ActiveCaption;
            btnDeleteCategory.Font = new Font("Segoe UI", 12F);
            btnDeleteCategory.Location = new Point(115, 20);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 44);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "xóa";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = SystemColors.ActiveCaption;
            btnAddCategory.Font = new Font("Segoe UI", 12F);
            btnAddCategory.Location = new Point(3, 20);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 44);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "thêm";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(1007, 569);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(567, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(424, 81);
            panel6.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 30);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(265, 27);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.BackColor = SystemColors.ActiveCaption;
            btnSearchFood.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchFood.Location = new Point(310, 20);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(111, 44);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = false;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(567, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(424, 470);
            panel5.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel10.Location = new Point(3, 251);
            panel10.Name = "panel10";
            panel10.Size = new Size(378, 64);
            panel10.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            nmFoodPrice.Location = new Point(145, 17);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmFoodPrice.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(230, 33);
            nmFoodPrice.TabIndex = 1;
            nmFoodPrice.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 24);
            label4.Name = "label4";
            label4.Size = new Size(43, 26);
            label4.TabIndex = 0;
            label4.Text = "giá :";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel9.Location = new Point(3, 168);
            panel9.Name = "panel9";
            panel9.Size = new Size(378, 64);
            panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(145, 19);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(230, 36);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 0;
            label3.Text = "danh mục";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel8.Location = new Point(3, 84);
            panel8.Name = "panel8";
            panel8.Size = new Size(378, 64);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFoodName.Location = new Point(145, 22);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(230, 34);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(83, 26);
            label2.TabIndex = 0;
            label2.Text = "tên món :";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodId);
            panel7.Controls.Add(label1);
            panel7.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(378, 64);
            panel7.TabIndex = 1;
            // 
            // txbFoodId
            // 
            txbFoodId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFoodId.Location = new Point(145, 24);
            txbFoodId.Name = "txbFoodId";
            txbFoodId.ReadOnly = true;
            txbFoodId.Size = new Size(230, 34);
            txbFoodId.TabIndex = 1;
            txbFoodId.TextChanged += txbFoodId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(29, 26);
            label1.TabIndex = 0;
            label1.Text = "id:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 81);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.BackColor = SystemColors.ActiveCaption;
            btnShowFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowFood.Location = new Point(338, 20);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 44);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "xem";
            btnShowFood.UseVisualStyleBackColor = false;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = SystemColors.ActiveCaption;
            btnEditFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditFood.Location = new Point(227, 20);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 44);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = false;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = SystemColors.ActiveCaption;
            btnDeleteFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteFood.Location = new Point(115, 20);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 44);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "xóa";
            btnDeleteFood.UseVisualStyleBackColor = false;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ActiveCaption;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFood.Location = new Point(3, 20);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 44);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "thêm";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 470);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(538, 464);
            dtgvFood.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(1007, 569);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh Thu ";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPage);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(btnNextLast);
            panel2.Controls.Add(btnNextFirst);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(txbTotalRevenueDay);
            panel2.Controls.Add(dtpkDate);
            panel2.Controls.Add(btnTotalRevenua);
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(6, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 465);
            panel2.TabIndex = 1;
            // 
            // txbPage
            // 
            txbPage.BackColor = Color.White;
            txbPage.Location = new Point(459, 357);
            txbPage.Name = "txbPage";
            txbPage.ReadOnly = true;
            txbPage.Size = new Size(49, 27);
            txbPage.TabIndex = 8;
            txbPage.Text = "1";
            txbPage.TextAlign = HorizontalAlignment.Center;
            txbPage.TextChanged += txbPage_TextChanged;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.White;
            btnLast.Location = new Point(837, 355);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(94, 29);
            btnLast.TabIndex = 7;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnNextLast
            // 
            btnNextLast.BackColor = Color.White;
            btnNextLast.Location = new Point(737, 355);
            btnNextLast.Name = "btnNextLast";
            btnNextLast.Size = new Size(94, 29);
            btnNextLast.TabIndex = 6;
            btnNextLast.Text = "Next";
            btnNextLast.UseVisualStyleBackColor = false;
            btnNextLast.Click += btnNextLast_Click;
            // 
            // btnNextFirst
            // 
            btnNextFirst.BackColor = Color.White;
            btnNextFirst.Location = new Point(103, 355);
            btnNextFirst.Name = "btnNextFirst";
            btnNextFirst.Size = new Size(94, 29);
            btnNextFirst.TabIndex = 5;
            btnNextFirst.Text = "Next";
            btnNextFirst.UseVisualStyleBackColor = false;
            btnNextFirst.Click += btnNextFirst_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.White;
            btnFirst.Location = new Point(3, 355);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(94, 29);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "first";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // txbTotalRevenueDay
            // 
            txbTotalRevenueDay.Location = new Point(3, 423);
            txbTotalRevenueDay.Name = "txbTotalRevenueDay";
            txbTotalRevenueDay.Size = new Size(334, 27);
            txbTotalRevenueDay.TabIndex = 3;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(3, 390);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(334, 27);
            dtpkDate.TabIndex = 2;
            // 
            // btnTotalRevenua
            // 
            btnTotalRevenua.BackColor = SystemColors.ActiveCaption;
            btnTotalRevenua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalRevenua.Location = new Point(361, 390);
            btnTotalRevenua.Name = "btnTotalRevenua";
            btnTotalRevenua.Size = new Size(111, 60);
            btnTotalRevenua.TabIndex = 1;
            btnTotalRevenua.Text = "doanh thu ngày";
            btnTotalRevenua.UseVisualStyleBackColor = false;
            btnTotalRevenua.Click += btnTotalRevenua_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(928, 346);
            dtgvBill.TabIndex = 0;
            dtgvBill.CellContentClick += dtgvBill_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTotalRevenueMonth);
            panel1.Controls.Add(btnTotalRevenueMonth);
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 86);
            panel1.TabIndex = 0;
            // 
            // txbTotalRevenueMonth
            // 
            txbTotalRevenueMonth.BackColor = SystemColors.ButtonHighlight;
            txbTotalRevenueMonth.Location = new Point(651, 48);
            txbTotalRevenueMonth.Name = "txbTotalRevenueMonth";
            txbTotalRevenueMonth.Size = new Size(280, 27);
            txbTotalRevenueMonth.TabIndex = 4;
            // 
            // btnTotalRevenueMonth
            // 
            btnTotalRevenueMonth.BackColor = SystemColors.ActiveCaption;
            btnTotalRevenueMonth.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalRevenueMonth.Location = new Point(651, 15);
            btnTotalRevenueMonth.Name = "btnTotalRevenueMonth";
            btnTotalRevenueMonth.Size = new Size(280, 32);
            btnTotalRevenueMonth.TabIndex = 3;
            btnTotalRevenueMonth.Text = "doanh thu tháng";
            btnTotalRevenueMonth.UseVisualStyleBackColor = false;
            btnTotalRevenueMonth.Click += btnTotalRevenueMonth_Click;
            // 
            // btnViewBill
            // 
            btnViewBill.BackColor = SystemColors.ActiveCaption;
            btnViewBill.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBill.Location = new Point(361, 15);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(111, 60);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống Kê";
            btnViewBill.UseVisualStyleBackColor = false;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(3, 48);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(334, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 15);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(334, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpCategoryFood);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(2, 1);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1015, 602);
            tcAdmin.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 633);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tpAccount.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmTypeAccount).EndInit();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            tpTable.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel18.ResumeLayout(false);
            tpCategoryFood.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel11.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tpAccount;
        private Panel panel21;
        private Button btnResetPassword;
        private Panel panel23;
        private NumericUpDown nmTypeAccount;
        private Label label11;
        private Panel panel24;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel25;
        private TextBox txbUserName;
        private Label label13;
        private Panel panel26;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel27;
        private DataGridView dtgvAccount;
        private TabPage tpTable;
        private Panel panel19;
        private TextBox txbStatus;
        private Label label9;
        private Panel panel15;
        private TextBox txbTableName;
        private Label label7;
        private Panel panel16;
        private TextBox txbTableID;
        private Label label8;
        private Panel panel17;
        private DataGridView dtgvTable;
        private Panel panel18;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private TabPage tpCategoryFood;
        private Panel panel13;
        private TextBox txbNameCategory;
        private Label label5;
        private Panel panel14;
        private TextBox txbCategoryID;
        private Label label6;
        private Panel panel12;
        private DataGridView dtgvCategory;
        private Panel panel11;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private TabPage tpFood;
        private Panel panel6;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel5;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel7;
        private TextBox txbFoodId;
        private Label label1;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TabPage tpBill;
        private Panel panel2;
        private TextBox txbPage;
        private Button btnLast;
        private Button btnNextLast;
        private Button btnNextFirst;
        private Button btnFirst;
        private TextBox txbTotalRevenueDay;
        private DateTimePicker dtpkDate;
        private Button btnTotalRevenua;
        private DataGridView dtgvBill;
        private Panel panel1;
        private TextBox txbTotalRevenueMonth;
        private Button btnTotalRevenueMonth;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private TabControl tcAdmin;
    }
}