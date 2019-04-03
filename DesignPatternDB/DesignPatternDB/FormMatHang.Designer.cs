namespace DesignPatternDB
{
	partial class FormMatHang
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.colMatHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbDelete = new System.Windows.Forms.RadioButton();
			this.rbUpdate = new System.Windows.Forms.RadioButton();
			this.rbAdd = new System.Windows.Forms.RadioButton();
			this.txtBoxDonGia = new System.Windows.Forms.TextBox();
			this.txtBoxDVT = new System.Windows.Forms.TextBox();
			this.txtBoxSoLuong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBoxTenMH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxMaMH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 450);
			this.panel1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatHangID,
            this.colTenMH,
            this.colSoLuong,
            this.colGia,
            this.colDVT});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(440, 450);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);
			// 
			// colMatHangID
			// 
			this.colMatHangID.DataPropertyName = "MaMH";
			this.colMatHangID.HeaderText = "Mã mặt hàng";
			this.colMatHangID.Name = "colMatHangID";
			// 
			// colTenMH
			// 
			this.colTenMH.DataPropertyName = "TenMH";
			this.colTenMH.HeaderText = "Tên mặt hàng";
			this.colTenMH.Name = "colTenMH";
			// 
			// colSoLuong
			// 
			this.colSoLuong.DataPropertyName = "SoLuong";
			this.colSoLuong.HeaderText = "Số lượng";
			this.colSoLuong.Name = "colSoLuong";
			// 
			// colGia
			// 
			this.colGia.DataPropertyName = "Gia";
			this.colGia.HeaderText = "Đơn giá";
			this.colGia.Name = "colGia";
			// 
			// colDVT
			// 
			this.colDVT.DataPropertyName = "DVT";
			this.colDVT.HeaderText = "Đơn vị tính";
			this.colDVT.Name = "colDVT";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.btn);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.txtBoxDonGia);
			this.panel2.Controls.Add(this.txtBoxDVT);
			this.panel2.Controls.Add(this.txtBoxSoLuong);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBoxTenMH);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBoxMaMH);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(446, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(354, 450);
			this.panel2.TabIndex = 2;
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(190, 256);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(79, 23);
			this.btn.TabIndex = 3;
			this.btn.Text = "Cập nhật";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbDelete);
			this.groupBox1.Controls.Add(this.rbUpdate);
			this.groupBox1.Controls.Add(this.rbAdd);
			this.groupBox1.Location = new System.Drawing.Point(32, 285);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 153);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lựa chọn chức năng";
			// 
			// rbDelete
			// 
			this.rbDelete.AutoSize = true;
			this.rbDelete.Location = new System.Drawing.Point(6, 113);
			this.rbDelete.Name = "rbDelete";
			this.rbDelete.Size = new System.Drawing.Size(44, 17);
			this.rbDelete.TabIndex = 0;
			this.rbDelete.Text = "Xóa";
			this.rbDelete.UseVisualStyleBackColor = true;
			this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
			// 
			// rbUpdate
			// 
			this.rbUpdate.AutoSize = true;
			this.rbUpdate.Checked = true;
			this.rbUpdate.Location = new System.Drawing.Point(6, 69);
			this.rbUpdate.Name = "rbUpdate";
			this.rbUpdate.Size = new System.Drawing.Size(68, 17);
			this.rbUpdate.TabIndex = 0;
			this.rbUpdate.TabStop = true;
			this.rbUpdate.Text = "Cập nhật";
			this.rbUpdate.UseVisualStyleBackColor = true;
			this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
			// 
			// rbAdd
			// 
			this.rbAdd.AutoSize = true;
			this.rbAdd.Location = new System.Drawing.Point(7, 29);
			this.rbAdd.Name = "rbAdd";
			this.rbAdd.Size = new System.Drawing.Size(52, 17);
			this.rbAdd.TabIndex = 0;
			this.rbAdd.Text = "Thêm";
			this.rbAdd.UseVisualStyleBackColor = true;
			this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
			// 
			// txtBoxDonGia
			// 
			this.txtBoxDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxDonGia.Location = new System.Drawing.Point(142, 170);
			this.txtBoxDonGia.Name = "txtBoxDonGia";
			this.txtBoxDonGia.Size = new System.Drawing.Size(173, 20);
			this.txtBoxDonGia.TabIndex = 1;
			// 
			// txtBoxDVT
			// 
			this.txtBoxDVT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxDVT.Location = new System.Drawing.Point(142, 213);
			this.txtBoxDVT.Name = "txtBoxDVT";
			this.txtBoxDVT.Size = new System.Drawing.Size(173, 20);
			this.txtBoxDVT.TabIndex = 1;
			// 
			// txtBoxSoLuong
			// 
			this.txtBoxSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxSoLuong.Location = new System.Drawing.Point(142, 123);
			this.txtBoxSoLuong.Name = "txtBoxSoLuong";
			this.txtBoxSoLuong.Size = new System.Drawing.Size(173, 20);
			this.txtBoxSoLuong.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá";
			// 
			// txtBoxTenMH
			// 
			this.txtBoxTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxTenMH.Location = new System.Drawing.Point(142, 81);
			this.txtBoxTenMH.Name = "txtBoxTenMH";
			this.txtBoxTenMH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxTenMH.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Đơn vị tính";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số lượng";
			// 
			// txtBoxMaMH
			// 
			this.txtBoxMaMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxMaMH.Enabled = false;
			this.txtBoxMaMH.Location = new System.Drawing.Point(142, 33);
			this.txtBoxMaMH.Name = "txtBoxMaMH";
			this.txtBoxMaMH.ReadOnly = true;
			this.txtBoxMaMH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxMaMH.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên mặt hàng";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã mặt hàng";
			// 
			// FormMatHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormMatHang";
			this.Text = "FormMatHang";
			this.Load += new System.EventHandler(this.FormMatHang_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDelete;
		private System.Windows.Forms.RadioButton rbUpdate;
		private System.Windows.Forms.RadioButton rbAdd;
		private System.Windows.Forms.TextBox txtBoxDonGia;
		private System.Windows.Forms.TextBox txtBoxSoLuong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBoxTenMH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBoxMaMH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxDVT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMatHangID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
	}
}