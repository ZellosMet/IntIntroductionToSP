using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitProcess();
		}

		//void Form1_Closing(object sender, CancelEventArgs e)
		//{
		//	proc_MyProcess.CloseMainWindow(); 
		//	proc_MyProcess.Close();
		//}
		void InitProcess()
		{
			AllignText();
			proc_MyProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtb_ProcessName.Text);
		}
		void AllignText()
		{ 
			rtb_ProcessName.SelectAll();
			rtb_ProcessName.SelectionAlignment = HorizontalAlignment.Center;			
		}
		void Info()
		{
			l_ProcessInfo.Text = "Process Info:\n";
			l_ProcessInfo.Text += $"PID: {proc_MyProcess.Id}\n";
			l_ProcessInfo.Text += $"BasePriority: {proc_MyProcess.BasePriority}\n";
			l_ProcessInfo.Text += $"StartTime: {proc_MyProcess.StartTime}\n";
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			InitProcess();
			proc_MyProcess.Start(); //Запуск процесса
			Info();
		}

		private void btn_Stop_Click(object sender, EventArgs e)
		{
			try
			{
				proc_MyProcess.CloseMainWindow(); //Закрытие процесса
			}
			catch (Exception) { }
			proc_MyProcess.Close(); // Освобождает ресурсы
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			btn_Stop_Click(sender, e);
		}
	}
}
