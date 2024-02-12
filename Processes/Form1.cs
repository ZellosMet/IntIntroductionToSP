using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class Form1 : Form
	{

		[DllImport("user32.dll")]
		internal static extern IntPtr SetForegroundWindow(IntPtr hWnd); //Подключение метода из сторонней библиотеки для вывода окна на передний план

		int index = 0; //Индекс по ListView
		int pid = 0; //ID процесса
						
		public Form1()
		{
			InitializeComponent();
			InitProcess();			
		}

		///////////////////// МЕТОДЫ КЛАССА ///////////////////// 
		
		void InitProcess()//Метод установки параметров запускаемого процесс
		{
			AllignText();
			proc_MyProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtb_ProcessName.Text);
		}
		void AllignText()//Метод установки текста в RichListBox по центру
		{ 
			rtb_ProcessName.SelectAll();
			rtb_ProcessName.SelectionAlignment = HorizontalAlignment.Center;			
		}
		void Info() //Метод получения вывода параметров процесса
		{
			l_ProcessInfo.Text = "Process info:\n";
			l_ProcessInfo.Text += $"Base priority:	{proc_MyProcess.BasePriority}\n";
			l_ProcessInfo.Text += $"Priority class:	{proc_MyProcess.PriorityClass}\n";
			l_ProcessInfo.Text += $"Start time:		{proc_MyProcess.StartTime}\n";
			l_ProcessInfo.Text += $"Total CPU time:	{proc_MyProcess.TotalProcessorTime}\n";
			l_ProcessInfo.Text += $"User  CPU time:	{proc_MyProcess.UserProcessorTime}\n";
			l_ProcessInfo.Text += $"Session ID:		{proc_MyProcess.SessionId}\n";
			l_ProcessInfo.Text += $"Affinity:		{proc_MyProcess.ProcessorAffinity}\n";
			l_ProcessInfo.Text += $"Threads:		{proc_MyProcess.Threads.Count}\n";
		}
		void SelectItem(int i)//Метод перезаписи данных в элемент ListView
		{
			try
			{
				int refresh_pid = Convert.ToInt32(lv_ProcessList.Items[i].SubItems[0].Text);
				proc_MyProcess = System.Diagnostics.Process.GetProcessById(refresh_pid);

				lv_ProcessList.Items[i].SubItems[0].Text = proc_MyProcess.Id.ToString();
				lv_ProcessList.Items[i].SubItems[1].Text = proc_MyProcess.ProcessName;
				lv_ProcessList.Items[i].SubItems[2].Text = proc_MyProcess.BasePriority.ToString();
				lv_ProcessList.Items[i].SubItems[3].Text = proc_MyProcess.PriorityClass.ToString();
				lv_ProcessList.Items[i].SubItems[4].Text = proc_MyProcess.StartTime.ToString();
				lv_ProcessList.Items[i].SubItems[5].Text = proc_MyProcess.TotalProcessorTime.ToString();
				lv_ProcessList.Items[i].SubItems[6].Text = proc_MyProcess.UserProcessorTime.ToString();
				lv_ProcessList.Items[i].SubItems[7].Text = proc_MyProcess.SessionId.ToString();
				lv_ProcessList.Items[i].SubItems[8].Text = proc_MyProcess.ProcessorAffinity.ToString();
				lv_ProcessList.Items[i].SubItems[9].Text = proc_MyProcess.Threads.Count.ToString();
			}
			catch (Exception) { }
		}

		/////////////////////////////////////////////////////////

		///////////////////// СОБЫТИЯ ФОРМЫ /////////////////////

		private void btn_Start_Click(object sender, EventArgs e)//Событие старта процесса
		{

			InitProcess();
			proc_MyProcess.Start(); //Запуск процесса
			ListViewItem lvi = new ListViewItem //Формирование элемента ListView
				(new string[] 
					{ 
						proc_MyProcess.Id.ToString(), 
						proc_MyProcess.ProcessName, 
						proc_MyProcess.BasePriority.ToString(),
						proc_MyProcess.PriorityClass.ToString(),
						proc_MyProcess.StartTime.ToString(),
						proc_MyProcess.TotalProcessorTime.ToString(),
						proc_MyProcess.UserProcessorTime.ToString(),
						proc_MyProcess.SessionId.ToString(),
						proc_MyProcess.ProcessorAffinity.ToString(),
						proc_MyProcess.Threads.Count.ToString()
					}
				);
			lv_ProcessList.Items.Add(lvi); //Помещение элемента в ListView
			//Info();
			t_RefreshInfo.Enabled = true; //Запуск таймера обновления данных в ListView
		}

		private void btn_Stop_Click(object sender, EventArgs e) //событие остановки текущего процесса
		{
			if (lv_ProcessList.Items.Count == 0)//Проверка на существование запущенных процессов
			{ 
				proc_MyProcess.Close();
				t_RefreshInfo.Enabled = false;
				return;
			}

			try//Попытка завершение процесса
			{
				if (lv_ProcessList.FocusedItem == null)//Проверка на установку фокуса на элемент ListView
					index = lv_ProcessList.Items.Count - 1;
				pid = Convert.ToInt32(lv_ProcessList.Items[index].SubItems[0].Text);//Получение ID процесса по индексу ListView
				try
				{
					if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetProcessById(pid).ProcessName).Any())//Проверка на существование процесса
					{
						proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid); //Установка ID в процесс
						proc_MyProcess.CloseMainWindow(); //Закрытие процесса

						//if (proc_MyProcess.ProcessName.Contains("CalculatorApp"))
						//{ 
						//	proc_MyProcess.Kill();
						//}
						//else
						//{ 
						//	proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid);
						//	proc_MyProcess.CloseMainWindow();
						//}
					}
				}
				catch (Exception) {}
				lv_ProcessList.Items.RemoveAt(index); //Удаление процесса из списка LiscView
			}
			catch (Exception) {}

			//if (lv_ProcessList.Items.Count <= 0) 
			//	l_ProcessInfo.Text = "";

			if (lv_ProcessList.Items.Count > 1)//Проверка на возможность установки предпоследнего процесса процесса
			{
				index = lv_ProcessList.Items.Count - 1;
				pid = Convert.ToInt32(lv_ProcessList.Items[index].SubItems[0].Text);				
				proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid);
				SetForegroundWindow(proc_MyProcess.Handle);	//Метод вывода окна на передний план			
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)//Событие закрытие формы
		{
			while (lv_ProcessList.Items.Count != 0)//Перебор всех процессов в ListView
			{ 
				index = lv_ProcessList.Items.Count - 1;
				btn_Stop_Click(sender, e);
			}
			t_RefreshInfo.Enabled = false;//Остановка счётик обновления ListView
		}

		private void lv_ProcessList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)//Событие выбора процесса пользователем в ListView
		{
			try
			{
				index = lv_ProcessList.SelectedItems[0].Index;
				pid = Convert.ToInt32(lv_ProcessList.SelectedItems[0].SubItems[0].Text);
				proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid);
				//Info();
			}
			catch (Exception) {}
		}
		private void t_RefreshInfo_Tick(object sender, EventArgs e)//Событие счётчика
		{
			for (int i = 0; i < lv_ProcessList.Items.Count; i++)//Проход по всему списку процессов в ListView
				SelectItem(i);
		}
		/////////////////////////////////////////////////////////
	}
}
