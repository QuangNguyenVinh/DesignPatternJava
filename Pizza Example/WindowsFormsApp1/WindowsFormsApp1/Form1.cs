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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void configToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void configColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConfigForm f = new ConfigForm();
			f.Show();
		}

		private void windows1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormObserver1 f = new FormObserver1();
			f.Show();
		}

		private void windows2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormObserver2 f = new FormObserver2();
			f.Show();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			string message = "Do you want to close this window?";
			string title = "Close Window";
			
			if (Infloop(message, title) == DialogResult.Yes)
			{
				Infloop(message, title);
			}
			else
			{
				Infloop(message, title);
			}
		}
		public DialogResult Infloop(string message, string title)
		{
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons);
			return Infloop(message, title);
		}
	}
}
