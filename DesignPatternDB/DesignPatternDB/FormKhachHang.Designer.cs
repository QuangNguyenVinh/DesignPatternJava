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
			this.btnAdd = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
			this.txtboxSoDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBoxTenKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxMaKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.txtBoxDiaChi);
			this.panel2.Controls.Add(this.txtboxSoDT);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBoxTenKH);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBoxMaKH);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(446, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(354, 450);
			this.panel2.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(36, 318);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(267, 318);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtBoxDiaChi
			// 
			this.txtBoxDiaChi.Location = new System.Drawing.Point(142, 221);
			this.txtBoxDiaChi.Name = "txtBoxDiaChi";
			this.txtBoxDiaChi.Size = new System.Drawing.Size(173, 20);
			this.txtBoxDiaChi.TabIndex = 1;
			// 
			// txtboxSoDT
			// 
			this.txtboxSoDT.Location = new System.Drawing.Point(142, 174);
			this.txtboxSoDT.Name = "txtboxSoDT";
			this.txtboxSoDT.Size = new System.Drawing.Size(173, 20);
			this.txtboxSoDT.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// txtBoxTenKH
			// 
			this.txtBoxTenKH.Location = new System.Drawing.Point(142, 132);
			this.txtBoxTenKH.Name = "txtBoxTenKH";
			this.txtBoxTenKH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxTenKH.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số điện thoại";
			// 
			// txtBoxMaKH
			// 
			this.txtBoxMaKH.Location = new System.Drawing.Point(142, 84);
			this.txtBoxMaKH.Name = "txtBoxMaKH";
			this.txtBoxMaKH.Size = new System.Drawing.Size(173, 20);
			this.txtBoxMaKH.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên khách hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(155, 318);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cập nhật";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button button1;
	}
}