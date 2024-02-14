namespace InterprocessCommunication
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
			this.lb_Processes = new System.Windows.Forms.ListBox();
			this.lb_Assemblies = new System.Windows.Forms.ListBox();
			this.l_Processes = new System.Windows.Forms.Label();
			this.l_Assemblies = new System.Windows.Forms.Label();
			this.b_Start = new System.Windows.Forms.Button();
			this.b_Stop = new System.Windows.Forms.Button();
			this.b_CloseWindow = new System.Windows.Forms.Button();
			this.b_Refresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_Processes
			// 
			this.lb_Processes.FormattingEnabled = true;
			this.lb_Processes.ItemHeight = 16;
			this.lb_Processes.Location = new System.Drawing.Point(12, 64);
			this.lb_Processes.Name = "lb_Processes";
			this.lb_Processes.Size = new System.Drawing.Size(332, 372);
			this.lb_Processes.TabIndex = 0;
			this.lb_Processes.SelectedIndexChanged += new System.EventHandler(this.lb_Processes_SelectedIndexChanged);
			// 
			// lb_Assemblies
			// 
			this.lb_Assemblies.FormattingEnabled = true;
			this.lb_Assemblies.ItemHeight = 16;
			this.lb_Assemblies.Location = new System.Drawing.Point(476, 64);
			this.lb_Assemblies.Name = "lb_Assemblies";
			this.lb_Assemblies.Size = new System.Drawing.Size(322, 372);
			this.lb_Assemblies.TabIndex = 1;
			this.lb_Assemblies.SelectedIndexChanged += new System.EventHandler(this.lb_Assemblies_SelectedIndexChanged);
			// 
			// l_Processes
			// 
			this.l_Processes.AutoSize = true;
			this.l_Processes.Location = new System.Drawing.Point(12, 35);
			this.l_Processes.Name = "l_Processes";
			this.l_Processes.Size = new System.Drawing.Size(156, 16);
			this.l_Processes.TabIndex = 2;
			this.l_Processes.Text = "Запущенные процессы";
			// 
			// l_Assemblies
			// 
			this.l_Assemblies.AutoSize = true;
			this.l_Assemblies.Location = new System.Drawing.Point(473, 35);
			this.l_Assemblies.Name = "l_Assemblies";
			this.l_Assemblies.Size = new System.Drawing.Size(128, 16);
			this.l_Assemblies.TabIndex = 3;
			this.l_Assemblies.Text = "Доступные сборки";
			// 
			// b_Start
			// 
			this.b_Start.Location = new System.Drawing.Point(350, 63);
			this.b_Start.Name = "b_Start";
			this.b_Start.Size = new System.Drawing.Size(120, 32);
			this.b_Start.TabIndex = 4;
			this.b_Start.Text = "Start";
			this.b_Start.UseVisualStyleBackColor = true;
			this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
			// 
			// b_Stop
			// 
			this.b_Stop.Location = new System.Drawing.Point(350, 101);
			this.b_Stop.Name = "b_Stop";
			this.b_Stop.Size = new System.Drawing.Size(120, 34);
			this.b_Stop.TabIndex = 5;
			this.b_Stop.Text = "Stop";
			this.b_Stop.UseVisualStyleBackColor = true;
			this.b_Stop.Click += new System.EventHandler(this.b_Stop_Click);
			// 
			// b_CloseWindow
			// 
			this.b_CloseWindow.Location = new System.Drawing.Point(350, 141);
			this.b_CloseWindow.Name = "b_CloseWindow";
			this.b_CloseWindow.Size = new System.Drawing.Size(120, 36);
			this.b_CloseWindow.TabIndex = 6;
			this.b_CloseWindow.Text = "CloseWindow";
			this.b_CloseWindow.UseVisualStyleBackColor = true;
			this.b_CloseWindow.Click += new System.EventHandler(this.b_CloseWindow_Click);
			// 
			// b_Refresh
			// 
			this.b_Refresh.Location = new System.Drawing.Point(350, 183);
			this.b_Refresh.Name = "b_Refresh";
			this.b_Refresh.Size = new System.Drawing.Size(120, 33);
			this.b_Refresh.TabIndex = 7;
			this.b_Refresh.Text = "Refresh";
			this.b_Refresh.UseVisualStyleBackColor = true;
			this.b_Refresh.Click += new System.EventHandler(this.b_Refresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 450);
			this.Controls.Add(this.b_Refresh);
			this.Controls.Add(this.b_CloseWindow);
			this.Controls.Add(this.b_Stop);
			this.Controls.Add(this.b_Start);
			this.Controls.Add(this.l_Assemblies);
			this.Controls.Add(this.l_Processes);
			this.Controls.Add(this.lb_Assemblies);
			this.Controls.Add(this.lb_Processes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lb_Processes;
		private System.Windows.Forms.ListBox lb_Assemblies;
		private System.Windows.Forms.Label l_Processes;
		private System.Windows.Forms.Label l_Assemblies;
		private System.Windows.Forms.Button b_Start;
		private System.Windows.Forms.Button b_Stop;
		private System.Windows.Forms.Button b_CloseWindow;
		private System.Windows.Forms.Button b_Refresh;
	}
}

