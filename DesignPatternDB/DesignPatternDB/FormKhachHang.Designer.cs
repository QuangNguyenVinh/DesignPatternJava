namespace DesignPatternDB
{
	partial class FormKhachHang
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
			this.colKhachHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbDelete = new System.Windows.Forms.RadioButton();
			this.rbUpdate = new System.Windows.Forms.RadioButton();
			this.rbAdd = new System.Windows.Forms.RadioButton();
			this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
			this.txtboxSoDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBoxTenKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxMaKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKhachHangID,
            this.colTenKH,
            this.colSoDT,
            this.colDiaChi});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(440, 450);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// colKhachHangID
			// 
			this.colKhachHangID.DataPropertyName = "KhachHangID";
			this.colKhachHangID.HeaderText = "Mã Khách hàng";
			this.colKhachHangID.Name = "colKhachHangID";
			// 
			// colTenKH
			// 
			this.colTenKH.DataPropertyName = "TenKH";
			this.colTenKH.HeaderText = "Tên Khách hàng";
			this.colTenKH.Name = "colTenKH";
			// 
			// colSoDT
			// 
			this.colSoDT.DataPropertyName = "SoDT";
			this.colSoDT.HeaderText = "Số điện thoại";
			this.colSoDT.Name = "colSoDT";
			// 
			// colDiaChi
			// 
			this.colDiaChi.DataPropertyName = "DiaChi";
			this.colDiaChi.HeaderText = "Địa chỉ";
			this.colDiaChi.Name = "colDiaChi";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.btn);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.txtBoxDiaChi);
			this.panel2.Controls.Add(this.txtboxSoDT);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBoxTenKH);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBoxMaKH);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(446, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(354, 450);
			this.panel2.TabIndex = 0;
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
			// txtBoxDiaChi
			// 
			this.txtBoxDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxDiaChi.Location = new System.Drawing.Point(142, 221);
			this.txtBoxDiaChi.Name = "txtBoxDiaChi";
			this.txtBoxDiaChi.Size = new System.Drawing.Size(173, 20);
			this.txtBoxDiaChi.TabIndex = 1;
			// 
			// txtboxSoDT
			// 
			this.txtboxSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtboxSoDT.Location = new System.Drawing.Point(142, 174);
			this.txtboxSoDT.Name = "txtboxSoDT";
			this.txtboxSoDT.Size = new System.Drawing.Size(173, 20);
			this.txtboxSoDT.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// txtBoxTenKH
			// 
			this.txtBoxTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxTenKH.Location = new System.Drawing.Point(142, 132);
			this.txtBoxTenKH.Name = "txtBoxTenKH";
			this.txtBoxTenKH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxTenKH.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số điện thoại";
			// 
			// txtBoxMaKH
			// 
			this.txtBoxMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxMaKH.Enabled = false;
			this.txtBoxMaKH.Location = new System.Drawing.Point(142, 84);
			this.txtBoxMaKH.Name = "txtBoxMaKH";
			this.txtBoxMaKH.ReadOnly = true;
			this.txtBoxMaKH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxMaKH.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên khách hàng";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
			// 
			// FormKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormKhachHang";
			this.Text = "FormKhachHang";
			this.Load += new System.EventHandler(this.FormKhachHang_Load);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHangID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
		private System.Windows.Forms.TextBox txtBoxDiaChi;
		private System.Windows.Forms.TextBox txtboxSoDT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBoxTenKH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBoxMaKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDelete;
		private System.Windows.Forms.RadioButton rbUpdate;
		private System.Windows.Forms.RadioButton rbAdd;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btn;
	}
}