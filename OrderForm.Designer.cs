namespace CoffeeManager
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAccountInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnServed = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDisCount = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccountInfor,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAccountInfor
            // 
            this.toolStripMenuItemAccountInfor.Name = "toolStripMenuItemAccountInfor";
            this.toolStripMenuItemAccountInfor.Size = new System.Drawing.Size(182, 29);
            this.toolStripMenuItemAccountInfor.Text = "Thông tin tài khoản";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 29);
            this.toolStripMenuItem2.Text = "Đăng xuất";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFood, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnServed, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLeft, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(203, 10);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(298, 28);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbFood
            // 
            this.cbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(203, 59);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(298, 28);
            this.cbFood.TabIndex = 1;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCount.Location = new System.Drawing.Point(507, 60);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(144, 26);
            this.numericUpDownCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lọc theo loại:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn món:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng giá:";
            // 
            // btnServed
            // 
            this.btnServed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServed.Location = new System.Drawing.Point(774, 56);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(310, 34);
            this.btnServed.TabIndex = 8;
            this.btnServed.Text = "Đã phục vụ";
            this.btnServed.UseVisualStyleBackColor = true;
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.Location = new System.Drawing.Point(774, 106);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(310, 35);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "Đã rời đi";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDecrease, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(507, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 43);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecrease.Location = new System.Drawing.Point(75, 3);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(66, 37);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "bớt";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecFood_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(507, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.Controls.Add(this.txbTotalPrice, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbDisCount, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(203, 101);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(298, 46);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.Location = new System.Drawing.Point(3, 10);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(68, 26);
            this.txbTotalPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "giảm giá:";
            // 
            // cbDisCount
            // 
            this.cbDisCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisCount.FormattingEnabled = true;
            this.cbDisCount.Location = new System.Drawing.Point(151, 9);
            this.cbDisCount.Name = "cbDisCount";
            this.cbDisCount.Size = new System.Drawing.Size(144, 28);
            this.cbDisCount.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lsvBill, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flpTable, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 222);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.277056F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.72295F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1204, 462);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            // 
            // lsvBill
            // 
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 31);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(596, 428);
            this.lsvBill.TabIndex = 2;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.BurlyWood;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(605, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(596, 428);
            this.flpTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách bàn";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 696);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccountInfor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnServed;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDisCount;
    }
}