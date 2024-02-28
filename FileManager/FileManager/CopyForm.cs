using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
	public partial class CopyForm : Form
	{
		MainForm main;
		FileInfo from_file;
		FileInfo to_file;
		string from_file_path;
		string to_file_path;
		string target_directory_path;
		string to_directory_path;
		//DirectoryInfo from_directory;
		DirectoryInfo to_directory;
		public CopyForm(string from_file_path, string to_file_path, MainForm main_form)
		{
			InitializeComponent();
			main = this.Owner as MainForm;
			main = main_form;
			this.from_file_path = from_file_path;
			this.to_file_path = to_file_path;
			this.from_file = new FileInfo(from_file_path);
			this.to_file = new FileInfo(to_file_path);
			bgw_CopyFile.WorkerReportsProgress = true;
			bgw_CopyFile.WorkerSupportsCancellation = true;
			label1.Text = $"Copy\nFrom {from_file.Name}\nTo {to_file.Name}";
			bgw_CopyFile.RunWorkerAsync();
			//Copy();
		}
		public CopyForm(string target_directory_path, string to_directory_path, MainForm main_form, bool directory)
		{
			InitializeComponent();
			main = this.Owner as MainForm;
			main = main_form;
			//this.from_directory_path = from_directory_path;
			//this.to_directory_path = to_directory_path;
			//this.from_directory = new DirectoryInfo(from_directory_path);
			//this.to_directory = new DirectoryInfo(to_directory_path);
			this.target_directory_path = target_directory_path;
			this.to_directory_path = to_directory_path;
			//label1.Text = $"Copy\nFrom {from_file.Name}\nTo {to_file.Name}";
			bgw_CopyDirectory.WorkerReportsProgress = true;
			bgw_CopyDirectory.WorkerSupportsCancellation = true;
			bgw_CopyDirectory.RunWorkerAsync();
		}
		void CopyDirectory(string from_directory, string to_directory)
		{
			string[] arr_dir = from_directory.Split('\\');
			this.to_directory.CreateSubdirectory(to_directory + arr_dir[arr_dir.Length-1]);
		}
		void CopyFile(string from_file, string to_file)
		{
			FileStream fs_from_file = new FileStream(to_file, FileMode.Create);
			FileStream fs_to_file = new FileStream(from_file, FileMode.Open);
			byte[] buffer = new byte[1048756];
			int read_byte;
			while ((read_byte = fs_to_file.Read(buffer, 0, buffer.Length)) > 0)
			{
				fs_from_file.Write(buffer, 0, read_byte);
				bgw_CopyFile.ReportProgress((int)(fs_to_file.Position * 100 / fs_to_file.Length));
			}
			fs_from_file.Close();
			fs_to_file.Close();
		}

		private void bgw_CopyFile_DoWork(object sender, DoWorkEventArgs e)
		{ 
			FileInfo fi = new FileInfo(to_file_path);
			if (fi.Exists)
			{
				DialogResult dr = MessageBox.Show("Такой файл существует. Заменить?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
					CopyFile(from_file_path, to_file_path);
			}
			else 
				CopyFile(from_file_path, to_file_path);
		}

		private void bgw_CopyFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pb_CopyProgress.Value = e.ProgressPercentage;
			label2.Text = $"{pb_CopyProgress.Value.ToString()}%";
		}

		private void bgw_CopyFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			//if (pb_CopyProgress.Value == 100) Thread.Sleep(2000);
			main.LoadDirectory(main.tb_LeftPath, main.lv_LeftFileList);
			main.LoadDirectory(main.tb_RightPath, main.lv_RightFileList);
			this.Close();
		}

		private void bgw_CopyDirectory_DoWork(object sender, DoWorkEventArgs e)
		{
			CopyDirectory(target_directory_path, to_directory_path);
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
