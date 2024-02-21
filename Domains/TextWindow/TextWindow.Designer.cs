namespace TextWindow
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
			this.t_text = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// t_text
			// 
			this.t_text.Location = new System.Drawing.Point(12, 23);
			this.t_text.Name = "t_text";
			this.t_text.Size = new System.Drawing.Size(557, 22);
			this.t_text.TabIndex = 0;
			this.t_text.TextChanged += new System.EventHandler(this.t_text_TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 68);
			this.Controls.Add(this.t_text);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "TextWindow";
			this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox t_text;
	}
}

