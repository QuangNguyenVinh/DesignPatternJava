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
	public partial class FormMatHang : Form, IViewEntity<MATHANG>
	{
		MatHangPresenter presenter = new MatHangPresenter();
		public FormMatHang()
		{
			InitializeComponent();
			presenter.SetView(this);
		}
		private void FormMatHang_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoGenerateColumns = false;
			presenter.ViewList();
		}



		private MATHANG GetEntity()
		{
			MATHANG mh = new MATHANG();
			mh.MaMH = txtBoxMaMH.Text;
			mh.TenMH = txtBoxTenMH.Text;
			mh.SoLuong = Int32.Parse(txtBoxSoLuong.Text);
			mh.Gia = Int32.Parse(txtBoxDonGia.Text);
			mh.DVT = txtBoxDVT.Text;

			return mh;
		}
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			presenter.ViewEntityAt(index);
		}
		MATHANG IViewEntity<MATHANG>.AddNew()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}

		MATHANG IViewEntity<MATHANG>.Delete()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}
		MATHANG IViewEntity<MATHANG>.Update()
		{
			//throw new NotImplementedException();
			return GetEntity();
		}

		void IViewEntity<MATHANG>.ViewEntity(MATHANG entity)
		{
			//throw new NotImplementedException();
			txtBoxMaMH.Text = entity.MaMH;
			txtBoxTenMH.Text = entity.TenMH;
			txtBoxSoLuong.Text = entity.SoLuong.ToString();
			txtBoxDonGia.Text = entity.Gia.ToString();
			txtBoxDVT.Text = entity.DVT;

		}

		void IViewListEntity<MATHANG>.ViewList(BindingSource bindingSource)
		{
			//throw new NotImplementedException();
			dataGridView1.DataSource = bindingSource;
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
			if (rbAdd.Checked == true)
			{
				txtBoxMaMH.ReadOnly = false;
				txtBoxMaMH.Enabled = true;
				btn.Text = "Thêm";
			}

		}

		private void rbUpdate_CheckedChanged(object sender, EventArgs e)
		{
			if (rbUpdate.Checked)
			{
				txtBoxMaMH.ReadOnly = true;
				txtBoxMaMH.Enabled = false;
				btn.Text = "Cập nhật";
			}

		}

		private void rbDelete_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDelete.Checked)
			{
				txtBoxMaMH.ReadOnly = true;
				txtBoxMaMH.Enabled = false;
				btn.Text = "Xóa";
			}

		}

	}
}
