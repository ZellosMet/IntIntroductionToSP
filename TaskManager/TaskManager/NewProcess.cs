using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class NewProcess : Form
	{
		string path;
		public string Path	{ get { return path; }	}
		public NewProcess()
		{
			InitializeComponent();
		}

		private void b_Browse_Click(object sender, EventArgs e)
		{
			ofd_SelectProcess.ShowDialog();
			tb_Path.Text = ofd_SelectProcess.FileName;
		}

		private void b_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void b_OK_Click(object sender, EventArgs e)
		{
			path = tb_Path.Text;
		}
	}
}
