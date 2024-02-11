namespace Processes
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.rtb_ProcessName = new System.Windows.Forms.RichTextBox();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.l_ProcessInfo = new System.Windows.Forms.Label();
			this.proc_MyProcess = new System.Diagnostics.Process();
			this.lv_ProcessList = new System.Windows.Forms.ListView();
			this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Base_priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Priority_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Start_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Total_CPU_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.User_CPU_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Session_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Affinity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Threads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.t_RefreshInfo = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// rtb_ProcessName
			// 
			this.rtb_ProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_ProcessName.Location = new System.Drawing.Point(12, 13);
			this.rtb_ProcessName.Name = "rtb_ProcessName";
			this.rtb_ProcessName.Size = new System.Drawing.Size(1110, 26);
			this.rtb_ProcessName.TabIndex = 0;
			this.rtb_ProcessName.Text = "notepad";
			// 
			// btn_Start
			// 
			this.btn_Start.Location = new System.Drawing.Point(12, 45);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 1;
			this.btn_Start.Text = "Старт";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// btn_Stop
			// 
			this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Stop.Location = new System.Drawing.Point(1020, 45);
			this.btn_Stop.Name = "btn_Stop";
			this.btn_Stop.Size = new System.Drawing.Size(97, 23);
			this.btn_Stop.TabIndex = 2;
			this.btn_Stop.Text = "Стоп";
			this.btn_Stop.UseVisualStyleBackColor = true;
			this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
			// 
			// l_ProcessInfo
			// 
			this.l_ProcessInfo.AutoSize = true;
			this.l_ProcessInfo.Location = new System.Drawing.Point(9, 266);
			this.l_ProcessInfo.Name = "l_ProcessInfo";
			this.l_ProcessInfo.Size = new System.Drawing.Size(57, 16);
			this.l_ProcessInfo.TabIndex = 3;
			this.l_ProcessInfo.Text = "Process";
			this.l_ProcessInfo.Visible = false;
			// 
			// proc_MyProcess
			// 
			this.proc_MyProcess.StartInfo.Domain = "";
			this.proc_MyProcess.StartInfo.LoadUserProfile = false;
			this.proc_MyProcess.StartInfo.Password = null;
			this.proc_MyProcess.StartInfo.StandardErrorEncoding = null;
			this.proc_MyProcess.StartInfo.StandardOutputEncoding = null;
			this.proc_MyProcess.StartInfo.UserName = "";
			this.proc_MyProcess.SynchronizingObject = this;
			// 
			// lv_ProcessList
			// 
			this.lv_ProcessList.AllowColumnReorder = true;
			this.lv_ProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Process,
            this.Base_priority,
            this.Priority_class,
            this.Start_time,
            this.Total_CPU_time,
            this.User_CPU_time,
            this.Session_ID,
            this.Affinity,
            this.Threads});
			this.lv_ProcessList.FullRowSelect = true;
			this.lv_ProcessList.GridLines = true;
			this.lv_ProcessList.HideSelection = false;
			this.lv_ProcessList.Location = new System.Drawing.Point(12, 75);
			this.lv_ProcessList.MultiSelect = false;
			this.lv_ProcessList.Name = "lv_ProcessList";
			this.lv_ProcessList.Size = new System.Drawing.Size(1106, 188);
			this.lv_ProcessList.TabIndex = 4;
			this.lv_ProcessList.UseCompatibleStateImageBehavior = false;
			this.lv_ProcessList.View = System.Windows.Forms.View.Details;
			this.lv_ProcessList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_ProcessList_ItemSelectionChanged);
			// 
			// PID
			// 
			this.PID.Text = "PID";
			this.PID.Width = 77;
			// 
			// Process
			// 
			this.Process.Text = "Process";
			this.Process.Width = 150;
			// 
			// Base_priority
			// 
			this.Base_priority.Text = "Base priority";
			this.Base_priority.Width = 129;
			// 
			// Priority_class
			// 
			this.Priority_class.Text = "Priority class";
			this.Priority_class.Width = 100;
			// 
			// Start_time
			// 
			this.Start_time.Text = "Start time";
			this.Start_time.Width = 82;
			// 
			// Total_CPU_time
			// 
			this.Total_CPU_time.Text = "Total CPU time";
			this.Total_CPU_time.Width = 115;
			// 
			// User_CPU_time
			// 
			this.User_CPU_time.Text = "User CPU time";
			this.User_CPU_time.Width = 111;
			// 
			// Session_ID
			// 
			this.Session_ID.Text = "Session ID";
			this.Session_ID.Width = 94;
			// 
			// Affinity
			// 
			this.Affinity.Text = "Affinity";
			this.Affinity.Width = 73;
			// 
			// Threads
			// 
			this.Threads.Text = "Threads";
			this.Threads.Width = 93;
			// 
			// t_RefreshInfo
			// 
			this.t_RefreshInfo.Interval = 500;
			this.t_RefreshInfo.Tick += new System.EventHandler(this.t_RefreshInfo_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 292);
			this.Controls.Add(this.lv_ProcessList);
			this.Controls.Add(this.l_ProcessInfo);
			this.Controls.Add(this.btn_Stop);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.rtb_ProcessName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtb_ProcessName;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Stop;
		private System.Windows.Forms.Label l_ProcessInfo;
		private System.Diagnostics.Process proc_MyProcess;
		private System.Windows.Forms.ListView lv_ProcessList;
		private System.Windows.Forms.ColumnHeader PID;
		private System.Windows.Forms.ColumnHeader Process;
		private System.Windows.Forms.Timer t_RefreshInfo;
		private System.Windows.Forms.ColumnHeader Priority_class;
		private System.Windows.Forms.ColumnHeader Start_time;
		private System.Windows.Forms.ColumnHeader Total_CPU_time;
		private System.Windows.Forms.ColumnHeader User_CPU_time;
		private System.Windows.Forms.ColumnHeader Session_ID;
		private System.Windows.Forms.ColumnHeader Affinity;
		private System.Windows.Forms.ColumnHeader Threads;
		private System.Windows.Forms.ColumnHeader Base_priority;
	}
}

