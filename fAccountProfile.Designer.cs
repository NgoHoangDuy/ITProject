namespace CoffeeManager
{
    partial class fAccountProfile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20814F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.54116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.250694F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbDisplayName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbPassWord, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbNewPass, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbReEnterPass, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbDisplayName.Location = new System.Drawing.Point(204, 98);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(405, 26);
            this.txbDisplayName.TabIndex = 6;
            // 
            // txbUserName
            // 
            this.txbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbUserName.Location = new System.Drawing.Point(204, 24);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(405, 26);
            this.txbUserName.TabIndex = 7;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPassWord.Location = new System.Drawing.Point(204, 172);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(405, 26);
            this.txbPassWord.TabIndex = 8;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNewPass.Location = new System.Drawing.Point(204, 246);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(405, 26);
            this.txbNewPass.TabIndex = 9;
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbReEnterPass.Location = new System.Drawing.Point(204, 320);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(405, 26);
            this.txbReEnterPass.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 373);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 74);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(79, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExti_Click);
            // 
            // fAccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fAccountProfile";
            this.Text = "Thông tin tài khoản";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}