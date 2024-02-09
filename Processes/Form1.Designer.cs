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
			this.rtb_ProcessName = new System.Windows.Forms.RichTextBox();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.l_ProcessInfo = new System.Windows.Forms.Label();
			this.proc_MyProcess = new System.Diagnostics.Process();
			this.SuspendLayout();
			// 
			// rtb_ProcessName
			// 
			this.rtb_ProcessName.Location = new System.Drawing.Point(12, 13);
			this.rtb_ProcessName.Name = "rtb_ProcessName";
			this.rtb_ProcessName.Size = new System.Drawing.Size(524, 26);
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
			this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Stop.Location = new System.Drawing.Point(461, 45);
			this.btn_Stop.Name = "btn_Stop";
			this.btn_Stop.Size = new System.Drawing.Size(75, 23);
			this.btn_Stop.TabIndex = 2;
			this.btn_Stop.Text = "Стоп";
			this.btn_Stop.UseVisualStyleBackColor = true;
			this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
			// 
			// l_ProcessInfo
			// 
			this.l_ProcessInfo.AutoSize = true;
			this.l_ProcessInfo.Location = new System.Drawing.Point(9, 85);
			this.l_ProcessInfo.Name = "l_ProcessInfo";
			this.l_ProcessInfo.Size = new System.Drawing.Size(57, 16);
			this.l_ProcessInfo.TabIndex = 3;
			this.l_ProcessInfo.Text = "Process";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 357);
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
	}
}

