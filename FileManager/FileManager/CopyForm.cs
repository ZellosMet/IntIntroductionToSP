using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
	public partial class CopyForm : Form
	{
		FileInfo from_file;
		FileInfo to_file;
		public CopyForm(string from_file_path, string to_file_path)
		{
			InitializeComponent();
			this.from_file = new FileInfo(from_file_path);
			this.to_file = new FileInfo(to_file_path);
			pb_CopyProgress.Maximum = Convert.ToInt32(from_file.Length / 1000);
			label1.Text = $"Copy\nFrom {from_file.Name}\nTo {to_file.Name}";
			bgw_Copy.RunWorkerAsync();
			//Copy();
		}

		private void bgw_Copy_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{				
				File.Copy(from_file.FullName, to_file.FullName);		
			}
			catch (Exception)
			{
				DialogResult dr = MessageBox.Show("Такой файл существует. Заменить?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
					File.Copy(from_file.FullName, to_file.FullName, true);
			}
		}

		private void bgw_Copy_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pb_CopyProgress.Value = e.ProgressPercentage;
		}

		private void bgw_Copy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Close();
		}

		//async void Copy()
		//{
		//	await Task.Run(()=>
		//		{				
		//			try
		//			{
		//				label1.Text = $"Copy\nFrom {from_file.Name}\nTo {to_file.Name}";
		//				File.Copy(from_file.FullName, to_file.FullName);
		//
		//			}
		//			catch (Exception)
		//			{
		//				label1.Text = $"Copy\n From {from_file.FullName}\nTo{to_file.FullName}";
		//				DialogResult dr = MessageBox.Show("Такой файл существует. Заменить?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		//				if (dr == DialogResult.Yes)
		//					File.Copy(from_file.FullName, to_file.FullName, true);
		//			}
		//		}
		//	);			
		//	this.Close();
		//}

	}
}
