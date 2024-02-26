namespace FileManager
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
		void InitializeComponent()
		{
			this.lv_LeftFileList = new System.Windows.Forms.ListView();
			this.c_LFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_LFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_LCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_LSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lv_RightFileList = new System.Windows.Forms.ListView();
			this.c_RFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_RFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_RCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_RSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.b_ToRight = new System.Windows.Forms.Button();
			this.b_ToLeft = new System.Windows.Forms.Button();
			this.tb_LeftPath = new System.Windows.Forms.TextBox();
			this.tb_RightPath = new System.Windows.Forms.TextBox();
			this.b_LeftBrowse = new System.Windows.Forms.Button();
			this.b_RightBrowse = new System.Windows.Forms.Button();
			this.fbd_LeftBrowse = new System.Windows.Forms.FolderBrowserDialog();
			this.fbd_RightBrowse = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// lv_LeftFileList
			// 
			this.lv_LeftFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_LFileName,
            this.c_LFileType,
            this.c_LCreateDate,
            this.c_LSize});
			this.lv_LeftFileList.FullRowSelect = true;
			this.lv_LeftFileList.HideSelection = false;
			this.lv_LeftFileList.Location = new System.Drawing.Point(13, 85);
			this.lv_LeftFileList.Name = "lv_LeftFileList";
			this.lv_LeftFileList.Size = new System.Drawing.Size(509, 424);
			this.lv_LeftFileList.TabIndex = 0;
			this.lv_LeftFileList.UseCompatibleStateImageBehavior = false;
			this.lv_LeftFileList.View = System.Windows.Forms.View.Details;
			this.lv_LeftFileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_LeftFileList_ItemSelectionChanged);
			this.lv_LeftFileList.Leave += new System.EventHandler(this.lv_LeftFileList_Leave);
			// 
			// c_LFileName
			// 
			this.c_LFileName.Text = "Name";
			this.c_LFileName.Width = 168;
			// 
			// c_LFileType
			// 
			this.c_LFileType.Text = "Type";
			this.c_LFileType.Width = 62;
			// 
			// c_LCreateDate
			// 
			this.c_LCreateDate.Text = "Data Create";
			this.c_LCreateDate.Width = 97;
			// 
			// c_LSize
			// 
			this.c_LSize.Text = "Size";
			// 
			// lv_RightFileList
			// 
			this.lv_RightFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_RFileName,
            this.c_RFileType,
            this.c_RCreateDate,
            this.c_RSize});
			this.lv_RightFileList.FullRowSelect = true;
			this.lv_RightFileList.HideSelection = false;
			this.lv_RightFileList.Location = new System.Drawing.Point(601, 85);
			this.lv_RightFileList.Name = "lv_RightFileList";
			this.lv_RightFileList.Size = new System.Drawing.Size(509, 424);
			this.lv_RightFileList.TabIndex = 1;
			this.lv_RightFileList.UseCompatibleStateImageBehavior = false;
			this.lv_RightFileList.View = System.Windows.Forms.View.Details;
			this.lv_RightFileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_RightFileList_ItemSelectionChanged);
			this.lv_RightFileList.Leave += new System.EventHandler(this.lv_RightFileList_Leave);
			// 
			// c_RFileName
			// 
			this.c_RFileName.Text = "Name";
			this.c_RFileName.Width = 246;
			// 
			// c_RFileType
			// 
			this.c_RFileType.Text = "Type";
			// 
			// c_RCreateDate
			// 
			this.c_RCreateDate.Text = "Data Create";
			// 
			// c_RSize
			// 
			this.c_RSize.Text = "Size";
			// 
			// b_ToRight
			// 
			this.b_ToRight.Location = new System.Drawing.Point(540, 167);
			this.b_ToRight.Name = "b_ToRight";
			this.b_ToRight.Size = new System.Drawing.Size(42, 42);
			this.b_ToRight.TabIndex = 2;
			this.b_ToRight.Text = "=>";
			this.b_ToRight.UseVisualStyleBackColor = true;
			this.b_ToRight.Click += new System.EventHandler(this.b_ToRight_Click);
			// 
			// b_ToLeft
			// 
			this.b_ToLeft.Location = new System.Drawing.Point(540, 226);
			this.b_ToLeft.Name = "b_ToLeft";
			this.b_ToLeft.Size = new System.Drawing.Size(42, 42);
			this.b_ToLeft.TabIndex = 3;
			this.b_ToLeft.Text = "<=";
			this.b_ToLeft.UseVisualStyleBackColor = true;
			this.b_ToLeft.Click += new System.EventHandler(this.b_ToLeft_Click);
			// 
			// tb_LeftPath
			// 
			this.tb_LeftPath.Location = new System.Drawing.Point(13, 49);
			this.tb_LeftPath.Name = "tb_LeftPath";
			this.tb_LeftPath.Size = new System.Drawing.Size(459, 22);
			this.tb_LeftPath.TabIndex = 4;
			// 
			// tb_RightPath
			// 
			this.tb_RightPath.Location = new System.Drawing.Point(601, 49);
			this.tb_RightPath.Name = "tb_RightPath";
			this.tb_RightPath.Size = new System.Drawing.Size(459, 22);
			this.tb_RightPath.TabIndex = 5;
			// 
			// b_LeftBrowse
			// 
			this.b_LeftBrowse.Location = new System.Drawing.Point(479, 48);
			this.b_LeftBrowse.Name = "b_LeftBrowse";
			this.b_LeftBrowse.Size = new System.Drawing.Size(43, 23);
			this.b_LeftBrowse.TabIndex = 6;
			this.b_LeftBrowse.Text = "...";
			this.b_LeftBrowse.UseVisualStyleBackColor = true;
			this.b_LeftBrowse.Click += new System.EventHandler(this.b_LeftBrowse_Click);
			// 
			// b_RightBrowse
			// 
			this.b_RightBrowse.Location = new System.Drawing.Point(1067, 48);
			this.b_RightBrowse.Name = "b_RightBrowse";
			this.b_RightBrowse.Size = new System.Drawing.Size(43, 23);
			this.b_RightBrowse.TabIndex = 7;
			this.b_RightBrowse.Text = "...";
			this.b_RightBrowse.UseVisualStyleBackColor = true;
			this.b_RightBrowse.Click += new System.EventHandler(this.b_RightBrowse_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 553);
			this.Controls.Add(this.b_RightBrowse);
			this.Controls.Add(this.b_LeftBrowse);
			this.Controls.Add(this.tb_RightPath);
			this.Controls.Add(this.tb_LeftPath);
			this.Controls.Add(this.b_ToLeft);
			this.Controls.Add(this.b_ToRight);
			this.Controls.Add(this.lv_RightFileList);
			this.Controls.Add(this.lv_LeftFileList);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ListView lv_LeftFileList;
		public System.Windows.Forms.ListView lv_RightFileList;
		private System.Windows.Forms.Button b_ToRight;
		private System.Windows.Forms.Button b_ToLeft;
		public System.Windows.Forms.TextBox tb_LeftPath;
		public System.Windows.Forms.TextBox tb_RightPath;
		private System.Windows.Forms.Button b_LeftBrowse;
		private System.Windows.Forms.Button b_RightBrowse;
		private System.Windows.Forms.FolderBrowserDialog fbd_LeftBrowse;
		private System.Windows.Forms.FolderBrowserDialog fbd_RightBrowse;
		private System.Windows.Forms.ColumnHeader c_LFileName;
		private System.Windows.Forms.ColumnHeader c_RFileName;
		private System.Windows.Forms.ColumnHeader c_LFileType;
		private System.Windows.Forms.ColumnHeader c_RFileType;
		private System.Windows.Forms.ColumnHeader c_LCreateDate;
		private System.Windows.Forms.ColumnHeader c_RCreateDate;
		private System.Windows.Forms.ColumnHeader c_LSize;
		private System.Windows.Forms.ColumnHeader c_RSize;
	}
}

