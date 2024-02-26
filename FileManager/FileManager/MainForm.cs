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

namespace FileManager
{
	public partial class MainForm : Form
	{
		string default_path = @"C:\Users\Professional\Documents";
		string from_file;
		string to_file;
		public MainForm()
		{
			InitializeComponent();
			tb_LeftPath.Text = fbd_LeftBrowse.SelectedPath;
			tb_RightPath.Text = fbd_RightBrowse.SelectedPath;
			b_ToLeft.Enabled = false;
			b_ToRight.Enabled = false;
			fbd_LeftBrowse.SelectedPath = fbd_RightBrowse.SelectedPath = tb_LeftPath.Text = tb_RightPath.Text = default_path;
			LoadDirectory(tb_LeftPath, lv_LeftFileList);
			LoadDirectory(tb_RightPath, lv_RightFileList);
		}

		//////////////////////////// Methods ////////////////////////////

		public void LoadDirectory(TextBox tb, ListView lv) //Загрузка в ListView Содержимого каталога
		{
			lv.Items.Clear();
			DirectoryInfo dir = new DirectoryInfo(tb.Text);
			foreach (DirectoryInfo item in dir.GetDirectories()) //Загрузка папок
			{
				ListViewItem lvi = new ListViewItem(new string[] { item.Name, "Directory", item.CreationTime.ToString().Split(' ')[0] });
				lv.Items.Add(lvi);
			}

			foreach (FileInfo item in dir.GetFiles()) //Загрузка файлов
			{
				int size = Convert.ToInt32(item.Length / 1000);
				ListViewItem lvi = new ListViewItem(new string[] { item.Name.Replace(item.Extension, ""), item.Extension, item.CreationTime.ToString().Split(' ')[0], $"{size.ToString()} Kb" });
				lv.Items.Add(lvi);
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
		void CopyFile(ListView from_lv, ListView to_lv, TextBox from_tb, TextBox to_tb)
		{
			from_file = $@"{from_tb.Text}\{from_lv.SelectedItems[0].SubItems[0].Text}{from_lv.SelectedItems[0].SubItems[1].Text}";
			to_file = $@"{to_tb.Text}\{from_lv.SelectedItems[0].SubItems[0].Text}{from_lv.SelectedItems[0].SubItems[1].Text}";
			CopyForm copyfile = new CopyForm(from_file, to_file, this);
			copyfile.Owner = this;
			copyfile.Show();
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
		private void b_ToRight_Click(object sender, EventArgs e)
		{
			CopyFile(lv_LeftFileList, lv_RightFileList, tb_LeftPath, tb_RightPath);
		}

		private void b_ToLeft_Click(object sender, EventArgs e)
		{
			CopyFile(lv_RightFileList, lv_LeftFileList, tb_RightPath, tb_LeftPath);
		}
		////////////////////////////////////////////////////////////////
	}
}
