namespace TextDrawer
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsm_Format = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Format});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(545, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsm_Format
			// 
			this.tsm_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontColorToolStripMenuItem});
			this.tsm_Format.Name = "tsm_Format";
			this.tsm_Format.Size = new System.Drawing.Size(70, 24);
			this.tsm_Format.Text = "Format";
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(545, 340);
			this.panel1.TabIndex = 1;
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.fontToolStripMenuItem.Text = "Font";
			this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
			// 
			// fontColorToolStripMenuItem
			// 
			this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
			this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.fontColorToolStripMenuItem.Text = "Font Color";
			this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 368);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "TextDrawer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsm_Format;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
	}
}

