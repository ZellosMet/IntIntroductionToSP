using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class Form1 : Form
	{
		int index = 0;
		int pid = 0;
						
		public Form1()
		{
			InitializeComponent();
			InitProcess();
		}

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

		private void btn_Start_Click(object sender, EventArgs e)
		{

			InitProcess();
			proc_MyProcess.Start(); //Запуск процесса
			ListViewItem lvi = new ListViewItem
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
			lv_ProcessList.Items.Add(lvi);
			//Info();
			t_RefreshInfo.Enabled = true;
		}

		private void btn_Stop_Click(object sender, EventArgs e)
		{
			try
			{
				if (lv_ProcessList.FocusedItem == null)
					index = lv_ProcessList.Items.Count - 1;
				pid = Convert.ToInt32(lv_ProcessList.Items[index].SubItems[0].Text);
				try
				{
					if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetProcessById(pid).ProcessName).Any())
					{ 
						proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid);
						proc_MyProcess.CloseMainWindow();
					}
				}
				catch (Exception)
				{}
				lv_ProcessList.Items.RemoveAt(index);
			}
			catch (Exception) { }
			if (lv_ProcessList.Items.Count <= 0) 
				l_ProcessInfo.Text = "";
			if (lv_ProcessList.Items.Count == 0)
			{ 
				proc_MyProcess.Close();
				t_RefreshInfo.Enabled = false;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			while (lv_ProcessList.Items.Count != 0)
			{ 
				index = lv_ProcessList.Items.Count - 1;
				btn_Stop_Click(sender, e);
			}
			t_RefreshInfo.Enabled = false;
		}

		private void lv_ProcessList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			try
			{
				index = lv_ProcessList.SelectedItems[0].Index;
				pid = Convert.ToInt32(lv_ProcessList.SelectedItems[0].SubItems[0].Text);
				proc_MyProcess = System.Diagnostics.Process.GetProcessById(pid);
				//Info();
			}
			catch (Exception)
			{ }
		}
		private void t_RefreshInfo_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < lv_ProcessList.Items.Count; i++)
				SelectItem(i);
		}

		void SelectItem(int i)
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
			catch (Exception)
			{ }
		}
	}
}
