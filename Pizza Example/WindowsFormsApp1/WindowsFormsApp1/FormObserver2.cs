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
	public partial class FormObserver2 : Form, IObserver
	{
		Config config;
		public FormObserver2()
		{
			InitializeComponent();
			config = Config.Instance();
			config.Attach(this);
		}

		public void updateColor(Color color)
		{
			button1.BackColor = color;
		}

		private void FormObserver2_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			config.Detach(this);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			config.Attach(this);
		}
	}
}
