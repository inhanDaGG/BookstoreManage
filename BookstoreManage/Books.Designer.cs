namespace BookstoreManage
{
    partial class Books
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            panel2 = new Panel();
            button2 = new Button();
            CatCbSearchCb = new ComboBox();
            label14 = new Label();
            BookDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            PriceTb = new TextBox();
            label13 = new Label();
            QtyTb = new TextBox();
            label12 = new Label();
            BCatCb = new ComboBox();
            label4 = new Label();
            BAutTb = new TextBox();
            label3 = new Label();
            BTitleTb = new TextBox();
            label2 = new Label();
            CloseWeb = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(CatCbSearchCb);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(BCatCb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BAutTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CloseWeb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(224, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 692);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.FlatAppearance.BorderColor = Color.ForestGreen;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(582, 298);
            button2.Name = "button2";
            button2.Size = new Size(107, 34);
            button2.TabIndex = 26;
            button2.Text = "刷新";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CatCbSearchCb
            // 
            CatCbSearchCb.FormattingEnabled = true;
            CatCbSearchCb.Items.AddRange(new object[] { "兒童讀物", "文學藝術", "人文歷史", "生活美食", "經濟管理", "科學技術" });
            CatCbSearchCb.Location = new Point(395, 302);
            CatCbSearchCb.Name = "CatCbSearchCb";
            CatCbSearchCb.Size = new Size(161, 28);
            CatCbSearchCb.TabIndex = 25;
            CatCbSearchCb.Text = "選定類目";
            CatCbSearchCb.SelectedIndexChanged += CatCbSearchCb_SelectedIndexChanged;
            CatCbSearchCb.SelectionChangeCommitted += CatCbSearchCb_SelectionChangeCommitted;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(418, 268);
            label14.Name = "label14";
            label14.Size = new Size(96, 27);
            label14.TabIndex = 24;
            label14.Text = "書籍清單";
            label14.Click += label14_Click;
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
            BookDGV.Location = new Point(5, 345);
            BookDGV.Name = "BookDGV";
            BookDGV.ReadOnly = true;
            BookDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            BookDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.RowTemplate.Height = 25;
            BookDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookDGV.Size = new Size(990, 330);
            BookDGV.TabIndex = 23;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BId";
            Column1.HeaderText = "書籍編號";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BTitle";
            Column2.HeaderText = "書籍名稱";
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
            Column4.HeaderText = "書籍類型";
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
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.ForestGreen;
            DeleteBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(502, 217);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(107, 34);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "刪除";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.ForestGreen;
            ResetBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            ResetBtn.FlatAppearance.BorderSize = 2;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(652, 217);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(107, 34);
            ResetBtn.TabIndex = 21;
            ResetBtn.Text = "重置";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.ForestGreen;
            EditBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            EditBtn.FlatAppearance.BorderSize = 2;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(346, 217);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(107, 34);
            EditBtn.TabIndex = 20;
            EditBtn.Text = "編輯";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.ForestGreen;
            SaveBtn.FlatAppearance.BorderColor = Color.ForestGreen;
            SaveBtn.FlatAppearance.BorderSize = 2;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(199, 217);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(107, 34);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "保存";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(792, 147);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(120, 29);
            PriceTb.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.GrayText;
            label13.Location = new Point(792, 124);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 17;
            label13.Text = "價格";
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.Location = new Point(639, 147);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(120, 29);
            QtyTb.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GrayText;
            label12.Location = new Point(639, 124);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 15;
            label12.Text = "數量";
            // 
            // BCatCb
            // 
            BCatCb.FormattingEnabled = true;
            BCatCb.Items.AddRange(new object[] { "兒童讀物", "文學藝術", "人文歷史", "生活美食", "經濟管理", "科學技術" });
            BCatCb.Location = new Point(448, 148);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(161, 28);
            BCatCb.TabIndex = 13;
            BCatCb.Text = "全部分類";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(448, 124);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 12;
            label4.Text = "書目類型";
            // 
            // BAutTb
            // 
            BAutTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BAutTb.Location = new Point(265, 147);
            BAutTb.Name = "BAutTb";
            BAutTb.Size = new Size(161, 29);
            BAutTb.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(265, 124);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 11;
            label3.Text = "作者";
            // 
            // BTitleTb
            // 
            BTitleTb.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitleTb.Location = new Point(73, 147);
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
            label2.Location = new Point(73, 124);
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
            pictureBox1.Location = new Point(447, 36);
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
            label1.Location = new Point(439, 6);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "杜康書店";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 692);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(19, 368);
            panel6.Name = "panel6";
            panel6.Size = new Size(174, 39);
            panel6.TabIndex = 17;
            panel6.Paint += panel6_Paint;
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
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(19, 299);
            panel5.Name = "panel5";
            panel5.Size = new Size(174, 39);
            panel5.TabIndex = 16;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("標楷體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(41, 4);
            label8.Name = "label8";
            label8.Size = new Size(142, 32);
            label8.TabIndex = 9;
            label8.Text = "帳戶管理";
            label8.Click += label8_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(19, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 39);
            panel4.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("標楷體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(74, 4);
            label11.Name = "label11";
            label11.Size = new Size(78, 32);
            label11.TabIndex = 9;
            label11.Text = "用戶";
            label11.Click += label11_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(19, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 39);
            panel3.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("標楷體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 4);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 9;
            label5.Text = "圖書";
            label5.Click += label5_Click;
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
            // Books
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1236, 713);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label CloseWeb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label10;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label8;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label11;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Label label9;
        private ComboBox BCatCb;
        private Label label4;
        private TextBox BAutTb;
        private Label label3;
        private TextBox BTitleTb;
        private Label label2;
        private TextBox PriceTb;
        private Label label13;
        private TextBox QtyTb;
        private Label label12;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private ComboBox CatCbSearchCb;
        private Label label14;
        private DataGridView BookDGV;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}