namespace QLCanTeen
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            textBox1 = new TextBox();
            btnMergeTable = new Button();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            nmDisCount = new NumericUpDown();
            btnCheckOut = new Button();
            btnSwitchTable = new Button();
            panel4 = new Panel();
            nmSubFood = new NumericUpDown();
            btnSubFood = new Button();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSubFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem, quảnLýKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1341, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(155, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(224, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "thông tin cá nhân ";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(667, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 273);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(21, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(622, 267);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "tên món";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "số lượng ";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "thành tiền ";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnMergeTable);
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Location = new Point(667, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 106);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(310, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "giảm giá (%)";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnMergeTable
            // 
            btnMergeTable.BackColor = SystemColors.ActiveCaption;
            btnMergeTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMergeTable.Location = new Point(143, 9);
            btnMergeTable.Name = "btnMergeTable";
            btnMergeTable.Size = new Size(116, 41);
            btnMergeTable.TabIndex = 10;
            btnMergeTable.Text = "gộp bàn";
            btnMergeTable.UseVisualStyleBackColor = false;
            btnMergeTable.Click += btnMergeTable_Click;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.HideSelection = false;
            txbTotalPrice.Location = new Point(460, 9);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(183, 27);
            txbTotalPrice.TabIndex = 9;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(21, 59);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(238, 28);
            cbSwitchTable.TabIndex = 8;
            // 
            // nmDisCount
            // 
            nmDisCount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nmDisCount.Location = new Point(310, 28);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(135, 27);
            nmDisCount.TabIndex = 7;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ActiveCaption;
            btnCheckOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(460, 42);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(183, 49);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "thanh toán ";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.ActiveCaption;
            btnSwitchTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitchTable.Location = new Point(21, 9);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(116, 39);
            btnSwitchTable.TabIndex = 4;
            btnSwitchTable.Text = "chuyển bàn ";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmSubFood);
            panel4.Controls.Add(btnSubFood);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(667, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(646, 97);
            panel4.TabIndex = 4;
            // 
            // nmSubFood
            // 
            nmSubFood.Location = new Point(440, 58);
            nmSubFood.Name = "nmSubFood";
            nmSubFood.Size = new Size(58, 27);
            nmSubFood.TabIndex = 5;
            nmSubFood.TextAlign = HorizontalAlignment.Center;
            nmSubFood.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSubFood
            // 
            btnSubFood.BackColor = SystemColors.ActiveCaption;
            btnSubFood.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubFood.Location = new Point(299, 48);
            btnSubFood.Name = "btnSubFood";
            btnSubFood.Size = new Size(135, 38);
            btnSubFood.TabIndex = 4;
            btnSubFood.Text = "xóa món";
            btnSubFood.UseVisualStyleBackColor = false;
            btnSubFood.Click += btnSubFood_Click;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(440, 16);
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(58, 27);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.TextAlign = HorizontalAlignment.Center;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ActiveCaption;
            btnAddFood.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFood.Location = new Point(299, 5);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(135, 39);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(21, 58);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(240, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(21, 16);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(240, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 44);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(632, 502);
            flpTable.TabIndex = 5;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(101, 24);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 597);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần Mềm Quản Lý CanTeen";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmSubFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Button btnSwitchTable;
        private NumericUpDown nmFoodCount;
        private FlowLayoutPanel flpTable;
        private Button btnCheckOut;
        private NumericUpDown nmDisCount;
        private ComboBox cbSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private Button btnMergeTable;
        private TextBox textBox1;
        private Button btnSubFood;
        private NumericUpDown nmSubFood;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
    }
}