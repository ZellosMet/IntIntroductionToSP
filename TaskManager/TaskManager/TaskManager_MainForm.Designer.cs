using System;

namespace TaskManager
{
	partial class TaskManager
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
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Applications", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Background process", System.Windows.Forms.HorizontalAlignment.Left);
			this.lv_ProcessesList = new System.Windows.Forms.ListView();
			this.NameProcesses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.b_EndProcess = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsm_File = new System.Windows.Forms.ToolStripMenuItem();
			this.newProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.t_RefreshProcess = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv_ProcessesList
			// 
			this.lv_ProcessesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_ProcessesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProcesses,
            this.PID,
            this.Memory,
            this.CPU});
			this.lv_ProcessesList.FullRowSelect = true;
			listViewGroup3.Header = "Applications";
			listViewGroup3.Name = "Applications";
			listViewGroup4.Header = "Background process";
			listViewGroup4.Name = "Background_process";
			this.lv_ProcessesList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
			this.lv_ProcessesList.HideSelection = false;
			this.lv_ProcessesList.Location = new System.Drawing.Point(12, 38);
			this.lv_ProcessesList.MultiSelect = false;
			this.lv_ProcessesList.Name = "lv_ProcessesList";
			this.lv_ProcessesList.Size = new System.Drawing.Size(440, 400);
			this.lv_ProcessesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lv_ProcessesList.TabIndex = 0;
			this.lv_ProcessesList.UseCompatibleStateImageBehavior = false;
			this.lv_ProcessesList.View = System.Windows.Forms.View.Details;
			this.lv_ProcessesList.SelectedIndexChanged += new System.EventHandler(this.lv_ProcessesList_SelectedIndexChanged);
			// 
			// NameProcesses
			// 
			this.NameProcesses.Text = "Name";
			// 
			// PID
			// 
			this.PID.Text = "PID";
			// 
			// Memory
			// 
			this.Memory.Text = "Memory";
			this.Memory.Width = 93;
			// 
			// CPU
			// 
			this.CPU.Text = "CPU";
			this.CPU.Width = 94;
			// 
			// b_EndProcess
			// 
			this.b_EndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.b_EndProcess.Location = new System.Drawing.Point(343, 444);
			this.b_EndProcess.Name = "b_EndProcess";
			this.b_EndProcess.Size = new System.Drawing.Size(109, 23);
			this.b_EndProcess.TabIndex = 3;
			this.b_EndProcess.Text = "End Process";
			this.b_EndProcess.UseVisualStyleBackColor = true;
			this.b_EndProcess.Click += new System.EventHandler(this.b_EndProcess_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_File});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(464, 28);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsm_File
			// 
			this.tsm_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProcessToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.tsm_File.Name = "tsm_File";
			this.tsm_File.Size = new System.Drawing.Size(46, 24);
			this.tsm_File.Text = "File";
			// 
			// newProcessToolStripMenuItem
			// 
			this.newProcessToolStripMenuItem.Name = "newProcessToolStripMenuItem";
			this.newProcessToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
			this.newProcessToolStripMenuItem.Text = "New Task";
			this.newProcessToolStripMenuItem.Click += new System.EventHandler(this.newProcessToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// t_RefreshProcess
			// 
			this.t_RefreshProcess.Interval = 3000;
			this.t_RefreshProcess.Tick += new System.EventHandler(this.t_RefreshProcess_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(185, 450);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// TaskManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 475);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.b_EndProcess);
			this.Controls.Add(this.lv_ProcessesList);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "TaskManager";
			this.Text = "TaskManager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_ProcessesList;
		private System.Windows.Forms.ColumnHeader NameProcesses;
		private System.Windows.Forms.Button b_EndProcess;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsm_File;
		private System.Windows.Forms.ToolStripMenuItem newProcessToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader PID;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader Memory;
		private System.Windows.Forms.Timer t_RefreshProcess;
		private System.Windows.Forms.ColumnHeader CPU;
		private System.Windows.Forms.Label label1;
	}
}

