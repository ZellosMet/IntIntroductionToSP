namespace FileManager
{
	partial class CopyForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.bgw_CopyFile = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this.pb_CopyProgress = new System.Windows.Forms.ProgressBar();
			this.bgw_CopyDirectory = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 61);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// bgw_CopyFile
			// 
			this.bgw_CopyFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_CopyFile_DoWork);
			this.bgw_CopyFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_CopyFile_ProgressChanged);
			this.bgw_CopyFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_CopyFile_RunWorkerCompleted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(331, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// pb_CopyProgress
			// 
			this.pb_CopyProgress.Location = new System.Drawing.Point(12, 82);
			this.pb_CopyProgress.Name = "pb_CopyProgress";
			this.pb_CopyProgress.Size = new System.Drawing.Size(363, 40);
			this.pb_CopyProgress.Step = 1;
			this.pb_CopyProgress.TabIndex = 3;
			// 
			// bgw_CopyDirectory
			// 
			this.bgw_CopyDirectory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_CopyDirectory_DoWork);
			this.bgw_CopyDirectory.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_CopyDirectory_ProgressChanged);
			this.bgw_CopyDirectory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_CopyDirectory_RunWorkerCompleted);
			// 
			// CopyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 169);
			this.Controls.Add(this.pb_CopyProgress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CopyForm";
			this.Text = "CopyForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.BackgroundWorker bgw_CopyFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar pb_CopyProgress;
		private System.ComponentModel.BackgroundWorker bgw_CopyDirectory;
	}
}