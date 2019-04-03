using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternDB.Models;
using DesignPatternDB.Views;
using DesignPatternDB.Presenters;
namespace DesignPatternDB
{
	//Concrete Observer
	public partial class FormKhachHang : Form, IViewEntity<KHACHHANG>
	{
		KhachHangPresenter presenter = new KhachHangPresenter();
		public FormKhachHang()
		{
			InitializeComponent();
			presenter.SetView(this);
		}

		private void FormKhachHang_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoGenerateColumns = false;
			presenter.ViewList();
		}




		private KHACHHANG GetEntity()
		{
			KHACHHANG kh = new KHACHHANG();
			kh.KhachHangID = txtBoxMaKH.Text;
			kh.TenKH = txtBoxTenKH.Text;
			kh.SoDT = txtboxSoDT.Text;
			kh.DiaChi = txtBoxDiaChi.Text;
			return kh;
		}
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			presenter.ViewEntityAt(index);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			presenter.AddNew();
		}

		KHACHHANG IViewEntity<KHACHHANG>.AddNew()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}

		KHACHHANG IViewEntity<KHACHHANG>.Update()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}

		KHACHHANG IViewEntity<KHACHHANG>.Delete()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}

		void IViewEntity<KHACHHANG>.ViewEntity(KHACHHANG entity)
		{
			txtBoxMaKH.Text = entity.KhachHangID;
			txtBoxTenKH.Text = entity.TenKH;
			txtboxSoDT.Text = entity.SoDT;
			txtBoxDiaChi.Text = entity.DiaChi;
			//throw new NotImplementedException();
		}

		void IViewListEntity<KHACHHANG>.ViewList(BindingSource bindingSource)
		{
			//throw new NotImplementedException();
			dataGridView1.DataSource = bindingSource;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			presenter.Delete();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			presenter.Update();
		}
		private void btn_Click(object sender, EventArgs e)
		{
			if (rbAdd.Checked == true)
				presenter.AddNew();
			else if (rbUpdate.Checked == true)
				presenter.Update();
			else if (rbDelete.Checked == true)
				presenter.Delete();
		}
		private void rbAdd_CheckedChanged(object sender, EventArgs e)
		{
			if(rbAdd.Checked == true)
			{
				txtBoxMaKH.ReadOnly = false;
				btn.Text = "Thêm";
			}

		}

		private void rbUpdate_CheckedChanged(object sender, EventArgs e)
		{
			if(rbUpdate.Checked)
			{
				txtBoxMaKH.ReadOnly = false;
				btn.Text = "Cập nhật";
			}
		}

		private void rbDelete_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDelete.Checked)
			{
				txtBoxMaKH.ReadOnly = false;
				btn.Text = "Xóa";
			}
		}

	}

}
