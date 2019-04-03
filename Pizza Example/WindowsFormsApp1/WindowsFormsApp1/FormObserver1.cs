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
	public partial class FormObserver1 : Form, IObserver
	{
		Config config;
		public FormObserver1()
		{
			InitializeComponent();
			config = Config.Instance();
			config.Attach(this);
			
		}

		public void updateColor(Color color)
		{
			button1.BackColor = color;
		}

		private void FormObserver1_Load(object sender, EventArgs e)
		{

		}

		private void btnBreakup_Click(object sender, EventArgs e)
		{
			config.Detach(this);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			config.Attach(this);
		}
	}
}
