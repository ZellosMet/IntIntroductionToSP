using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Management;

namespace InterprocessCommunication
{
	public partial class Form1 : Form
	{
		const uint WM_SETTEXT = 0x0C;
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint uMsg, int wParam, [MarshalAs(UnmanagedType.LPStr)]string lParam);
		List<Process> processes = new List<Process> ();
		int count = 0;
		public Form1()
		{
			InitializeComponent();
			LoadAvailableAssemblies();
			b_Stop.Enabled = false;
			b_CloseWindow.Enabled = false;
			b_Start.Enabled = false;
			b_Refresh.Enabled = false;
		}

		///////////////////// МЕТОДЫ КЛАССА ///////////////////// 
		void LoadAvailableAssemblies()
		{
			string except = new FileInfo(Application.ExecutablePath).Name;
			except.Substring(0, except.IndexOf("."));
			string[] files = Directory.GetFiles(Application.StartupPath, "*.lnk");
			foreach (string file in files)
			{
				string fileName = new FileInfo(file).Name;
				if (fileName.IndexOf(except) == -1)
					lb_Assemblies.Items.Add(fileName.Split('.')[0]);
			}
		}
		void RunProcess(string assembly_name)
		{
			Process proc = Process.Start(assembly_name);
			processes.Add(proc);
			if (Process.GetCurrentProcess().Id == GetParentProcessId(proc.Id))
			{
				MessageBox.Show(this, proc.ProcessName+" дочерний процесс текущего процесса.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				proc.EnableRaisingEvents = true;
				proc.Exited += Proc_Exited;
				SendMessage(proc.MainWindowHandle, WM_SETTEXT, 0, $"Child process #{count++}");
				if (!lb_Processes.Items.Contains(proc.ProcessName))
				{
					lb_Processes.Items.Add(proc.ProcessName);
					lb_Assemblies.Items.Remove(lb_Assemblies.SelectedItem);
				}
			}
		}
		int GetParentProcessId(int id)
		{
			int parentId = 0;
			using (System.Management.ManagementObject obj = new ManagementObject($"win32_process.handle={id}"))
			{
				obj.Get();
				parentId = Convert.ToInt32(obj["ParentProcessId"]);
			}
			return parentId;
		}

		delegate void ProcessDelegate(Process pros);
		void ExecuteOnProcessByName(string processName, ProcessDelegate function)
		{
			Process[] processes = Process.GetProcessesByName(processName);
			foreach (Process process in processes)
			{
				if (Process.GetCurrentProcess().Id == GetParentProcessId(process.Id))
					function(process);
			}
		}
		void Kill(Process proc)
		{ 
			proc.Kill();
		}
		void CloseMainWindow(Process proc)
		{
			proc.CloseMainWindow();
		}
		void Refresh(Process proc)
		{ 
			proc.Refresh();
		}
		private void MainWindow_FormClosing(object sender, FormClosedEventArgs e)
		{ 
			foreach(Process process in processes)
				process.Kill();
		}

		/////////////////////////////////////////////////////////

		///////////////////// СОБЫТИЯ ФОРМЫ /////////////////////
		void Proc_Exited(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
			Process proc = sender as Process;
			lb_Processes.Items.Remove(proc.ProcessName);
			lb_Assemblies.Items.Add(proc.ProcessName);
			processes.Remove(proc);
			count--;
			int index = 0;
			foreach (Process process in processes)			
				SendMessage(process.MainWindowHandle, WM_SETTEXT, 0, $"Cild process#{++index}");			
		}

		private void b_Start_Click(object sender, EventArgs e)
		{
			RunProcess(lb_Assemblies.SelectedItem.ToString());
		}
		private void b_Stop_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lb_Processes.SelectedItem.ToString(), Kill);
			lb_Processes.Items.Remove(lb_Processes.SelectedItems);
		}
		private void b_CloseWindow_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lb_Processes.SelectedItem.ToString(), CloseMainWindow);
			lb_Processes.Items.Remove(lb_Processes.SelectedItems);
		}
		private void b_Refresh_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lb_Processes.SelectedItem.ToString(), Refresh);
		}
		private void lb_Assemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lb_Assemblies.SelectedItems.Count == 0)
				b_Start.Enabled = false;
			else
				b_Start.Enabled = true;
		}

		private void lb_Processes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lb_Processes.SelectedItems.Count == 0)
			{
				b_Stop.Enabled = false;
				b_CloseWindow.Enabled = false;
				b_Refresh.Enabled = false;
			}
			else
			{ 
				b_Stop.Enabled= true;
				b_CloseWindow.Enabled = true;
				b_Refresh.Enabled = true;
			}
		}

		/////////////////////////////////////////////////////////
	}
}
