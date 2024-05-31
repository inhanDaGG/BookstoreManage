namespace BookstoreManage
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox6 = new PictureBox();
            label14 = new Label();
            BookDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            ResetBtn = new Button();
            PrintBtn = new Button();
            AddToBillBtn = new Button();
            QtyTb = new TextBox();
            label13 = new Label();
            PriceTb = new TextBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            BTitleTb = new TextBox();
            label2 = new Label();
            CloseWeb = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            TotalLbl = new Label();
            label5 = new Label();
            BillDGV = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(181, 310);
            label14.Name = "label14";
            label14.Size = new Size(96, 27);
            label14.TabIndex = 24;
            label14.Text = "書籍清單";
            // 
            // BookDGV
            // 
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.BackgroundColor = Color.White;
            BookDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Indigo;
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            BookDGV.EnableHeadersVisualStyles = false;
            BookDGV.GridColor = Color.LightGray;
            BookDGV.Location = new Point(5, 342);
            BookDGV.Name = "BookDGV";
            BookDGV.ReadOnly = true;
            BookDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            BookDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.RowTemplate.Height = 25;
            BookDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookDGV.Size = new Size(508, 333);
            BookDGV.TabIndex = 23;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BId";
            Column1.HeaderText = "編號";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BTitle";
            Column2.HeaderText = "書名";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BAuthor";
            Column3.HeaderText = "作者";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "BCat";
            Column4.HeaderText = "類型";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BQty";
            Column5.HeaderText = "數量";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "BPrice";
            Column6.HeaderText = "價格";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("標楷體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(74, 4);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 9;
            label9.Text = "退出";
            label9.Click += label9_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.ForestGreen;
            ResetBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            ResetBtn.FlatAppearance.BorderSize = 2;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(272, 203);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(107, 34);
            ResetBtn.TabIndex = 21;
            ResetBtn.Text = "重置";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.ForestGreen;
            PrintBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            PrintBtn.FlatAppearance.BorderSize = 2;
            PrintBtn.FlatStyle = FlatStyle.Flat;
            PrintBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(728, 568);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(107, 34);
            PrintBtn.TabIndex = 20;
            PrintBtn.Text = "結算";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.ForestGreen;
            AddToBillBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            AddToBillBtn.FlatAppearance.BorderSize = 2;
            AddToBillBtn.FlatStyle = FlatStyle.Flat;
            AddToBillBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddToBillBtn.ForeColor = Color.White;
            AddToBillBtn.Location = new Point(52, 203);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(190, 34);
            AddToBillBtn.TabIndex = 18;
            AddToBillBtn.Text = "加入購物車";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.Location = new Point(283, 147);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(96, 29);
            QtyTb.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.GrayText;
            label13.Location = new Point(283, 124);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 17;
            label13.Text = "數量";
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(179, 147);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(98, 29);
            PriceTb.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(56, 6);
            label10.Name = "label10";
            label10.Size = new Size(96, 27);
            label10.TabIndex = 10;
            label10.Text = "杜康書店";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(69, 311);
            label6.Name = "label6";
            label6.Size = new Size(0, 27);
            label6.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(179, 124);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 11;
            label3.Text = "價格";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 692);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(19, 637);
            panel6.Name = "panel6";
            panel6.Size = new Size(174, 39);
            panel6.TabIndex = 17;
            panel6.Paint += panel6_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(69, 358);
            label7.Name = "label7";
            label7.Size = new Size(0, 27);
            label7.TabIndex = 11;
            // 
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitleTb.Location = new Point(12, 147);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(161, 29);
            BTitleTb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "書籍名稱";
            // 
            // CloseWeb
            // 
            CloseWeb.AutoSize = true;
            CloseWeb.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CloseWeb.ForeColor = SystemColors.GrayText;
            CloseWeb.Location = new Point(975, 0);
            CloseWeb.Name = "CloseWeb";
            CloseWeb.Size = new Size(22, 24);
            CloseWeb.TabIndex = 9;
            CloseWeb.Text = "X";
            CloseWeb.Click += CloseWeb_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(414, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(406, 5);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "杜康書店";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(TotalLbl);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BillDGV);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(PrintBtn);
            panel2.Controls.Add(AddToBillBtn);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CloseWeb);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(224, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 692);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(48, 5);
            label4.Name = "label4";
            label4.Size = new Size(75, 27);
            label4.TabIndex = 31;
            label4.Text = "用戶名";
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLbl.ForeColor = Color.ForestGreen;
            TotalLbl.Location = new Point(733, 484);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(96, 27);
            TotalLbl.TabIndex = 29;
            TotalLbl.Text = "訂單總額";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(733, 63);
            label5.Name = "label5";
            label5.Size = new Size(75, 27);
            label5.TabIndex = 28;
            label5.Text = "購物車";
            // 
            // BillDGV
            // 
            BillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillDGV.BackgroundColor = Color.White;
            BillDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Indigo;
            dataGridViewCellStyle3.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11 });
            BillDGV.EnableHeadersVisualStyles = false;
            BillDGV.GridColor = Color.LightGray;
            BillDGV.Location = new Point(562, 93);
            BillDGV.Name = "BillDGV";
            BillDGV.ReadOnly = true;
            BillDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue;
            BillDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            BillDGV.RowTemplate.Height = 25;
            BillDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillDGV.Size = new Size(424, 300);
            BillDGV.TabIndex = 27;
            // 
            // Column7
            // 
            Column7.HeaderText = "訂單號";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "書名";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "單價";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "數量";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "金額";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1236, 713);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox6;
        private Label label14;
        private DataGridView BookDGV;
        private Label label9;
        private Button ResetBtn;
        private Button PrintBtn;
        private Button AddToBillBtn;
        private Label label13;
        private TextBox QtyTb;
        private TextBox PriceTb;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label3;
        private Panel panel1;
        private Panel panel6;
        private Label label7;
        private TextBox BTitleTb;
        private Label label2;
        private Label CloseWeb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label5;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label TotalLbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox3;
        private Label label4;
    }
}