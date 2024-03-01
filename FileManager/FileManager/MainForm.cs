using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace FileManager
{
	public partial class MainForm : Form
	{
		string default_path = @"C:\Users\Professional\Documents" /*@"C:\Users\Zello\OneDrive\Документы"*/;
		string from_file;
		string to_file;
		string from_directory;
		string to_directory;
		public MainForm()
		{
			InitializeComponent();
			b_ToLeft.Enabled = false;
			b_ToRight.Enabled = false;
			fbd_LeftBrowse.SelectedPath = fbd_RightBrowse.SelectedPath = tb_LeftPath.Text = tb_RightPath.Text = default_path;
			LoadDirectory(tb_LeftPath, lv_LeftFileList);
			LoadDirectory(tb_RightPath, lv_RightFileList);
			//DriveInfo[] all_drive = DriveInfo.GetDrives();
			//foreach(DriveInfo i in all_drive)
				//label1.Text += i.Name;
		}

		//////////////////////////// Methods ////////////////////////////

		public void LoadDirectory(TextBox tb, ListView lv) //Загрузка в ListView Содержимого каталога
		{
			lv.Items.Clear();
			ListViewItem lvi = new ListViewItem(new string[] {"..."});
			lv.Items.Add(lvi);
			try
			{				
				DirectoryInfo dir = new DirectoryInfo(tb.Text);				
				foreach (DirectoryInfo item in dir.GetDirectories()) //Загрузка папок
				{
					string directory_name = "";
					FileAttributes atr = item.Attributes;
					if ((atr & FileAttributes.Hidden) == FileAttributes.Hidden) //Проверка на скрытность
						directory_name += "*";
					directory_name += item.Name;
					lvi = new ListViewItem(new string[] { directory_name, "Directory", item.CreationTime.ToString().Split(' ')[0] });
					lv.Items.Add(lvi);
				}
				foreach (FileInfo item in dir.GetFiles()) //Загрузка файлов
				{
					string file_name = "";
					string file_extension = "File";
					FileAttributes atr = item.Attributes;
					int size = Convert.ToInt32(item.Length / 1000);
					if(item.Extension != "") //Проверка на существоание расширения
						file_extension = item.Extension;
					if ((atr & FileAttributes.Hidden) == FileAttributes.Hidden) //Проверка на скрытность
						file_name += "*";
					file_name += item.Name.Replace(file_extension, "");
					lvi = new ListViewItem(new string[] { file_name, file_extension, item.CreationTime.ToString().Split(' ')[0], $"{size.ToString()} Kb" });
					lv.Items.Add(lvi);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось перейти в каталог. Отказано в доступе!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void SetDirectory(FolderBrowserDialog fbd, TextBox tb) //Установка активной папки
		{
			if (fbd.ShowDialog() == DialogResult.OK)
				tb.Text = fbd.SelectedPath;
		}
		void ActivationButtonSelectedItem(ListView lv, Button b) //Активация/деактивация кнопок по выбору элемента ListView
		{
			if (lv.SelectedItems.Count == 0)
				b.Enabled = false;
			else
				b.Enabled = true;
		}
		void DeactivationButtonSetFocus(Button b) //Деактива кнопок при потере фокуса ListView
		{
			if (!b.Focused)
				b.Enabled = false;
		}
		void CopyFile(ListView from_lv, ListView to_lv, TextBox from_tb, TextBox to_tb)	//Метода вызова формы копирования
		{
			CopyForm copy_file;
			CopyForm copy_directory;
			if (from_lv.SelectedItems[0].SubItems[1].Text != "Directory")
			{
				from_file = $@"{from_tb.Text}\{from_lv.SelectedItems[0].SubItems[0].Text}{from_lv.SelectedItems[0].SubItems[1].Text}";
				to_file = $@"{to_tb.Text}\{from_lv.SelectedItems[0].SubItems[0].Text}{from_lv.SelectedItems[0].SubItems[1].Text}";
				//CopyForm copy_file = new CopyForm(from_file, to_file, this);
				copy_file = new CopyForm(from_file, to_file, this);
				copy_file.Owner = this;
				copy_file.Show();
			}
			else
			{
				from_directory = $@"{from_tb.Text}\{from_lv.SelectedItems[0].SubItems[0].Text}";
				to_directory = $@"{to_tb.Text}";
				copy_directory = new CopyForm(from_directory, to_directory, this, true);
				copy_directory.Owner = this;
				copy_directory.Show();
			}
		}
		void MoveDirectory(TextBox tb, ListView lv) //Метод перехода между каталогами
		{
			ListViewItem lvi;
			if (lv.SelectedItems != null)
			{
				if (lv.SelectedItems[0].SubItems[0].Text == "...")
				{
					string[] arr = tb.Text.Split('\\');
					if (arr.Length == 2)
					{
						if (arr[1] == "")
						{
							lv.Items.Clear();
							DriveInfo[] all_drive = DriveInfo.GetDrives();
							foreach (DriveInfo i in all_drive)
							{
								lvi = new ListViewItem(new string[] { i.Name, "Root Directory" });
								lv.Items.Add(lvi);
							}
							tb.Text = "This PC";
						}
						else
						{
							tb.Text = $"{arr[0]}\\";
							LoadDirectory(tb, lv);
						}
					}
					else
					{
						tb.Text = tb.Text.Replace($"\\{arr[arr.Length - 1]}", "").ToString();
						LoadDirectory(tb, lv);
					}
				}
				else if (lv.SelectedItems[0].SubItems[1].Text == "Directory")
				{
					string[] arr = tb.Text.Split('\\');
					if (arr.Length == 2 && arr[1] == "")
						tb.Text = tb.Text.Replace("\\", "");
					tb.Text += $"\\{lv.SelectedItems[0].SubItems[0].Text}";
					LoadDirectory(tb, lv);
				}
				else if (tb.Text == "This PC")
				{
					tb.Text = lv.SelectedItems[0].SubItems[0].Text;
					LoadDirectory(tb, lv);
				}
				else return;
			}
			else return;
		}
		////////////////////////////////////////////////////////////////

		//////////////////////////// Events ////////////////////////////
		private void b_LeftBrowse_Click(object sender, EventArgs e)     //
		{                                                               //
			SetDirectory(fbd_LeftBrowse, tb_LeftPath);                  //
			LoadDirectory(tb_LeftPath, lv_LeftFileList);                //
		}                                                               //
																		//Событие выбора нового каталога
		private void b_RightBrowse_Click(object sender, EventArgs e)    //
		{                                                               //
			SetDirectory(fbd_RightBrowse, tb_RightPath);                //
			LoadDirectory(tb_RightPath, lv_RightFileList);              //
		}                                                               //
		private void lv_LeftFileList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)   //
		{                                                                                                           //
			ActivationButtonSelectedItem(lv_LeftFileList, b_ToRight);                                               //
		}                                                                                                           //Событие активации/деактивации кнопок
		private void lv_RightFileList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)  //
		{                                                                                                           //
			ActivationButtonSelectedItem(lv_RightFileList, b_ToLeft);                                               //
		}                                                                                                           //
		private void lv_LeftFileList_Leave(object sender, EventArgs e)  //
		{                                                               //
			DeactivationButtonSetFocus(b_ToRight);                      //
		}                                                               //Событие потери фокуса ListView
		private void lv_RightFileList_Leave(object sender, EventArgs e) //
		{                                                               //
			DeactivationButtonSetFocus(b_ToLeft);                       //
		}
		private void b_ToRight_Click(object sender, EventArgs e)					//
		{																			//
			CopyFile(lv_LeftFileList, lv_RightFileList, tb_LeftPath, tb_RightPath);	//
		}																			//Событие копирования
		private void b_ToLeft_Click(object sender, EventArgs e)						//
		{																			//
			CopyFile(lv_RightFileList, lv_LeftFileList, tb_RightPath, tb_LeftPath);	//
		}
		
		private void lv_LeftFileList_DoubleClick(object sender, EventArgs e)	//
		{																		//
			MoveDirectory(tb_LeftPath, lv_LeftFileList);						//
		}																		//Событие перехода между каталогами
		private void lv_RightFileList_DoubleClick(object sender, EventArgs e)	//
		{																		//
			MoveDirectory(tb_RightPath, lv_RightFileList);						//
		}																		//
		////////////////////////////////////////////////////////////////
	}
}
