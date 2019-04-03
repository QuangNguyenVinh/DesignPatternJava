using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternDB
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			FormKhachHang formKhachHang = new FormKhachHang();
			formKhachHang.Show();
			formKhachHang.MdiParent = this;
			this.Cursor = Cursors.Default;
		}

		private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			FormMatHang formMatHang = new FormMatHang();
			formMatHang.Show();
			formMatHang.MdiParent = this;
			this.Cursor = Cursors.Default;


		}
	}
}
