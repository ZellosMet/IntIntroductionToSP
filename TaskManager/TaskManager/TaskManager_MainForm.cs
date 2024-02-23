using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class TaskManager : Form
	{
		string path_process;
		PerformanceCounter cpuCounter;
		PerformanceCounter ramCounter;
		public TaskManager()
		{
			InitializeComponent();
			b_EndProcess.Enabled = false;
			LoadActiveProcesses();
			//t_RefreshProcess.Enabled = true;
		}

		void LoadActiveProcesses()
		{
			ListViewItem lvi = new ListViewItem();
			Process[] all_process = Process.GetProcesses();
			lv_ProcessesList.Items.Clear();

			foreach (Process process in all_process)
			{
				cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
				ramCounter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);

				string[] items = null;

				items = new string[] { process.ProcessName, process.Id.ToString(), $"{Convert.ToString(Convert.ToInt32(ramCounter.NextValue()/1000000))} Mb", cpuCounter.NextValue().ToString()};

				lvi = new ListViewItem(items);
				lvi.Group = (process.MainWindowHandle == IntPtr.Zero ? lv_ProcessesList.Groups["Background_process"] : lv_ProcessesList.Groups["Applications"]);
				lv_ProcessesList.Items.Add(lvi);

			}
		}
		private void b_EndProcess_Click(object sender, EventArgs e)
		{
			Process proc = Process.GetProcessById(Convert.ToInt32(lv_ProcessesList.SelectedItems[0].SubItems[1].Text));
			proc.Kill();
			Thread.Sleep(5);
			LoadActiveProcesses();
		}

		private void lv_ProcessesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lv_ProcessesList.SelectedItems.Count == 0)
				b_EndProcess.Enabled = false;
			else
				b_EndProcess.Enabled = true;
		}

		private void newProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process proc;
			NewProcess new_process = new NewProcess();
			new_process.ShowDialog();

			if (new_process.DialogResult == DialogResult.OK)
				path_process = new_process.Path;
			else 
				return;

			new_process.Close();

			if (path_process.Length != 0)
			{ 
				proc = Process.Start(path_process);
				LoadActiveProcesses();
			}
			else
				MessageBox.Show("Процесс не найден", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void t_RefreshProcess_Tick(object sender, EventArgs e)
		{
			LoadActiveProcesses();
		}
	}
}
