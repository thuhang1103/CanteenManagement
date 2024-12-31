namespace QLCanTeen
{
    partial class fWarehouseManagement
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
            panel1 = new Panel();
            btnShow3 = new Button();
            btnShow2 = new Button();
            btnShow1 = new Button();
            panel3 = new Panel();
            cbType = new ComboBox();
            btnExport = new Button();
            btnImport = new Button();
            nmCommodity = new NumericUpDown();
            txbNameCommodity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            dtgvCommodity = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            dtgvCommodity2 = new DataGridView();
            label1 = new Label();
            dtpkCommodity = new DateTimePicker();
            btnShowGoods = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmCommodity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCommodity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCommodity2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShow3);
            panel1.Controls.Add(btnShow2);
            panel1.Controls.Add(btnShow1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dtgvCommodity);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 295);
            panel1.TabIndex = 0;
            // 
            // btnShow3
            // 
            btnShow3.BackColor = SystemColors.ActiveCaption;
            btnShow3.Location = new Point(269, 263);
            btnShow3.Name = "btnShow3";
            btnShow3.Size = new Size(124, 29);
            btnShow3.TabIndex = 5;
            btnShow3.Text = "nước giải khát";
            btnShow3.UseVisualStyleBackColor = false;
            btnShow3.Click += btnShow3_Click;
            // 
            // btnShow2
            // 
            btnShow2.BackColor = SystemColors.ActiveCaption;
            btnShow2.Location = new Point(139, 263);
            btnShow2.Name = "btnShow2";
            btnShow2.Size = new Size(124, 29);
            btnShow2.TabIndex = 4;
            btnShow2.Text = "hàng khô";
            btnShow2.UseVisualStyleBackColor = false;
            btnShow2.Click += btnShow2_Click;
            // 
            // btnShow1
            // 
            btnShow1.BackColor = SystemColors.ActiveCaption;
            btnShow1.Location = new Point(9, 263);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(124, 29);
            btnShow1.TabIndex = 3;
            btnShow1.Text = "thực phẩm tươi";
            btnShow1.UseVisualStyleBackColor = false;
            btnShow1.Click += btnShow1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbType);
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(btnImport);
            panel3.Controls.Add(nmCommodity);
            panel3.Controls.Add(txbNameCommodity);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(554, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 289);
            panel3.TabIndex = 2;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(144, 78);
            cbType.Name = "cbType";
            cbType.Size = new Size(271, 28);
            cbType.TabIndex = 11;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ActiveCaption;
            btnExport.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(233, 237);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(182, 49);
            btnExport.TabIndex = 10;
            btnExport.Text = "xuất hàng";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.ActiveCaption;
            btnImport.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(15, 237);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(182, 49);
            btnImport.TabIndex = 9;
            btnImport.Text = "Nhập Hàng";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // nmCommodity
            // 
            nmCommodity.Location = new Point(144, 130);
            nmCommodity.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nmCommodity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmCommodity.Name = "nmCommodity";
            nmCommodity.Size = new Size(150, 27);
            nmCommodity.TabIndex = 8;
            nmCommodity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txbNameCommodity
            // 
            txbNameCommodity.Location = new Point(144, 29);
            txbNameCommodity.Name = "txbNameCommodity";
            txbNameCommodity.Size = new Size(271, 27);
            txbNameCommodity.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 76);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 5;
            label6.Text = "loại hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 127);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 4;
            label5.Text = "số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 26);
            label2.Name = "label2";
            label2.Size = new Size(51, 30);
            label2.TabIndex = 1;
            label2.Text = "tên ";
            // 
            // dtgvCommodity
            // 
            dtgvCommodity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCommodity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCommodity.Location = new Point(9, 3);
            dtgvCommodity.Name = "dtgvCommodity";
            dtgvCommodity.RowHeadersWidth = 51;
            dtgvCommodity.Size = new Size(539, 256);
            dtgvCommodity.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dtgvCommodity2);
            panel2.Location = new Point(3, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 212);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.Location = new Point(569, 161);
            button3.Name = "button3";
            button3.Size = new Size(246, 29);
            button3.TabIndex = 3;
            button3.Text = "hàng tồn kho ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.Location = new Point(569, 113);
            button1.Name = "button1";
            button1.Size = new Size(246, 29);
            button1.TabIndex = 1;
            button1.Text = "hàng hóa sắp hết";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtgvCommodity2
            // 
            dtgvCommodity2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCommodity2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCommodity2.Location = new Point(9, 3);
            dtgvCommodity2.Name = "dtgvCommodity2";
            dtgvCommodity2.RowHeadersWidth = 51;
            dtgvCommodity2.Size = new Size(539, 187);
            dtgvCommodity2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 355);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "thống kê hàng hóa";
            // 
            // dtpkCommodity
            // 
            dtpkCommodity.Location = new Point(12, 10);
            dtpkCommodity.Name = "dtpkCommodity";
            dtpkCommodity.Size = new Size(250, 27);
            dtpkCommodity.TabIndex = 2;
            // 
            // btnShowGoods
            // 
            btnShowGoods.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowGoods.Location = new Point(358, 8);
            btnShowGoods.Name = "btnShowGoods";
            btnShowGoods.Size = new Size(94, 29);
            btnShowGoods.TabIndex = 3;
            btnShowGoods.Text = "xem";
            btnShowGoods.UseVisualStyleBackColor = true;
            btnShowGoods.Click += btnShowGoods_Click;
            // 
            // fWarehouseManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 602);
            Controls.Add(btnShowGoods);
            Controls.Add(dtpkCommodity);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fWarehouseManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Kho";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmCommodity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCommodity).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCommodity2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dtpkCommodity;
        private Button btnShowGoods;
        private Panel panel3;
        private Label label2;
        private DataGridView dtgvCommodity;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Button btnExport;
        private Button btnImport;
        private NumericUpDown numericUpDown1;
        private ComboBox cbType;
        private Button btnShow3;
        private Button btnShow2;
        private Button btnShow1;
        private Button button1;
        private DataGridView dtgvCommodity2;
        private Button button3;
        private NumericUpDown nmCommodity;
        private ComboBox txbTypeCommodity;
        private TextBox txbNameCommodity;
    }
}