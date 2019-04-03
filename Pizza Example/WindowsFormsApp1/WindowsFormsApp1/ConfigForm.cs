using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ConfigForm : Form
	{
		Config config;
		public ConfigForm()
		{
			InitializeComponent();
			config = Config.Instance();
		}

		private void btnRed_Click(object sender, EventArgs e)
		{
			config.Notify(System.Drawing.Color.Red);
		}

		private void btnBlue_Click(object sender, EventArgs e)
		{
			config.Notify(System.Drawing.Color.Blue);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			config.Notify(System.Drawing.Color.Gray);
		}
	}
}
