namespace TaskManager
{
	partial class NewProcess
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
			this.tb_Path = new System.Windows.Forms.TextBox();
			this.b_OK = new System.Windows.Forms.Button();
			this.b_Browse = new System.Windows.Forms.Button();
			this.b_Close = new System.Windows.Forms.Button();
			this.ofd_SelectProcess = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// tb_Path
			// 
			this.tb_Path.Location = new System.Drawing.Point(13, 13);
			this.tb_Path.Name = "tb_Path";
			this.tb_Path.Size = new System.Drawing.Size(413, 22);
			this.tb_Path.TabIndex = 0;
			// 
			// b_OK
			// 
			this.b_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.b_OK.Location = new System.Drawing.Point(183, 114);
			this.b_OK.Name = "b_OK";
			this.b_OK.Size = new System.Drawing.Size(79, 27);
			this.b_OK.TabIndex = 2;
			this.b_OK.Text = "OK";
			this.b_OK.UseVisualStyleBackColor = true;
			this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
			// 
			// b_Browse
			// 
			this.b_Browse.Location = new System.Drawing.Point(353, 114);
			this.b_Browse.Name = "b_Browse";
			this.b_Browse.Size = new System.Drawing.Size(79, 27);
			this.b_Browse.TabIndex = 3;
			this.b_Browse.Text = "Browse...";
			this.b_Browse.UseVisualStyleBackColor = true;
			this.b_Browse.Click += new System.EventHandler(this.b_Browse_Click);
			// 
			// b_Close
			// 
			this.b_Close.Location = new System.Drawing.Point(268, 114);
			this.b_Close.Name = "b_Close";
			this.b_Close.Size = new System.Drawing.Size(79, 27);
			this.b_Close.TabIndex = 4;
			this.b_Close.Text = "Cancel";
			this.b_Close.UseVisualStyleBackColor = true;
			this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
			// 
			// NewProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 153);
			this.Controls.Add(this.b_Close);
			this.Controls.Add(this.b_Browse);
			this.Controls.Add(this.b_OK);
			this.Controls.Add(this.tb_Path);
			this.Name = "NewProcess";
			this.Text = "NewProcess";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_Path;
		private System.Windows.Forms.Button b_OK;
		private System.Windows.Forms.Button b_Browse;
		private System.Windows.Forms.Button b_Close;
		private System.Windows.Forms.OpenFileDialog ofd_SelectProcess;
	}
}