namespace TooLazyToRead.Forms
{
	partial class FilterSelect
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkedFilterList = new System.Windows.Forms.CheckedListBox();
			this.buttonManage = new System.Windows.Forms.Button();
			this.checkAll = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Enabled = false;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(136, 246);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 100;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(217, 246);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 101;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkedFilterList
			// 
			this.checkedFilterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.checkedFilterList.CheckOnClick = true;
			this.checkedFilterList.FormattingEnabled = true;
			this.checkedFilterList.HorizontalScrollbar = true;
			this.checkedFilterList.Location = new System.Drawing.Point(12, 13);
			this.checkedFilterList.Name = "checkedFilterList";
			this.checkedFilterList.Size = new System.Drawing.Size(280, 199);
			this.checkedFilterList.TabIndex = 0;
			this.checkedFilterList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedFilterList_ItemCheck);
			// 
			// buttonManage
			// 
			this.buttonManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonManage.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonManage.Location = new System.Drawing.Point(12, 246);
			this.buttonManage.Name = "buttonManage";
			this.buttonManage.Size = new System.Drawing.Size(75, 23);
			this.buttonManage.TabIndex = 102;
			this.buttonManage.Text = "&Manage...";
			this.buttonManage.UseVisualStyleBackColor = true;
			this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
			// 
			// checkAll
			// 
			this.checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkAll.AutoSize = true;
			this.checkAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkAll.Location = new System.Drawing.Point(12, 217);
			this.checkAll.Name = "checkAll";
			this.checkAll.Size = new System.Drawing.Size(77, 18);
			this.checkAll.TabIndex = 103;
			this.checkAll.Text = "Check &All";
			this.checkAll.UseVisualStyleBackColor = true;
			this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
			// 
			// FilterSelect
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.Controls.Add(this.checkAll);
			this.Controls.Add(this.buttonManage);
			this.Controls.Add(this.checkedFilterList);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "FilterSelect";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select the desired filters";
			this.Load += new System.EventHandler(this.FilterSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckedListBox checkedFilterList;
		private System.Windows.Forms.Button buttonManage;
		private System.Windows.Forms.CheckBox checkAll;
	}
}