namespace TooLazyToRead.Forms
{
	partial class FilterManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterManager));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupList = new System.Windows.Forms.GroupBox();
			this.checkEnableAll = new System.Windows.Forms.CheckBox();
			this.buttonFilterDown = new System.Windows.Forms.Button();
			this.buttonFilterUp = new System.Windows.Forms.Button();
			this.checkedFilterList = new System.Windows.Forms.CheckedListBox();
			this.buttonRemoveFilter = new System.Windows.Forms.Button();
			this.buttonAddFilter = new System.Windows.Forms.Button();
			this.groupProperties = new System.Windows.Forms.GroupBox();
			this.tableFilterProperties = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textReplace = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textMatch = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tableFilterType = new System.Windows.Forms.TableLayoutPanel();
			this.checkCaseSensitive = new System.Windows.Forms.CheckBox();
			this.radioWildcard = new System.Windows.Forms.RadioButton();
			this.radioPlain = new System.Windows.Forms.RadioButton();
			this.radioRegex = new System.Windows.Forms.RadioButton();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.buttonDefault = new System.Windows.Forms.Button();
			this.checkEscapeReplace = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupList.SuspendLayout();
			this.groupProperties.SuspendLayout();
			this.tableFilterProperties.SuspendLayout();
			this.tableFilterType.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupList);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupProperties);
			this.splitContainer1.Size = new System.Drawing.Size(520, 337);
			this.splitContainer1.SplitterDistance = 172;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupList
			// 
			this.groupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupList.Controls.Add(this.checkEnableAll);
			this.groupList.Controls.Add(this.buttonFilterDown);
			this.groupList.Controls.Add(this.buttonFilterUp);
			this.groupList.Controls.Add(this.checkedFilterList);
			this.groupList.Controls.Add(this.buttonRemoveFilter);
			this.groupList.Controls.Add(this.buttonAddFilter);
			this.groupList.Location = new System.Drawing.Point(12, 12);
			this.groupList.Name = "groupList";
			this.groupList.Size = new System.Drawing.Size(157, 322);
			this.groupList.TabIndex = 0;
			this.groupList.TabStop = false;
			this.groupList.Text = "Filter List";
			// 
			// checkEnableAll
			// 
			this.checkEnableAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkEnableAll.AutoSize = true;
			this.checkEnableAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEnableAll.Location = new System.Drawing.Point(6, 299);
			this.checkEnableAll.Name = "checkEnableAll";
			this.checkEnableAll.Size = new System.Drawing.Size(79, 18);
			this.checkEnableAll.TabIndex = 5;
			this.checkEnableAll.Text = "Enable All";
			this.toolTip1.SetToolTip(this.checkEnableAll, "Toggle automatic mode on all filters.");
			this.checkEnableAll.UseVisualStyleBackColor = true;
			this.checkEnableAll.CheckedChanged += new System.EventHandler(this.checkEnableAll_CheckedChanged);
			// 
			// buttonFilterDown
			// 
			this.buttonFilterDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFilterDown.Enabled = false;
			this.buttonFilterDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFilterDown.Location = new System.Drawing.Point(131, 272);
			this.buttonFilterDown.Name = "buttonFilterDown";
			this.buttonFilterDown.Size = new System.Drawing.Size(20, 20);
			this.buttonFilterDown.TabIndex = 4;
			this.buttonFilterDown.Text = "↓";
			this.toolTip1.SetToolTip(this.buttonFilterDown, "Moves selected filter down.");
			this.buttonFilterDown.UseVisualStyleBackColor = true;
			this.buttonFilterDown.Click += new System.EventHandler(this.buttonFilterDown_Click);
			// 
			// buttonFilterUp
			// 
			this.buttonFilterUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFilterUp.Enabled = false;
			this.buttonFilterUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFilterUp.Location = new System.Drawing.Point(105, 272);
			this.buttonFilterUp.Name = "buttonFilterUp";
			this.buttonFilterUp.Size = new System.Drawing.Size(20, 20);
			this.buttonFilterUp.TabIndex = 3;
			this.buttonFilterUp.Text = "↑";
			this.toolTip1.SetToolTip(this.buttonFilterUp, "Moves selected filter up.");
			this.buttonFilterUp.UseVisualStyleBackColor = true;
			this.buttonFilterUp.Click += new System.EventHandler(this.buttonFilterUp_Click);
			// 
			// checkedFilterList
			// 
			this.checkedFilterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.checkedFilterList.FormattingEnabled = true;
			this.checkedFilterList.HorizontalScrollbar = true;
			this.checkedFilterList.Location = new System.Drawing.Point(6, 20);
			this.checkedFilterList.Name = "checkedFilterList";
			this.checkedFilterList.Size = new System.Drawing.Size(145, 244);
			this.checkedFilterList.TabIndex = 0;
			this.checkedFilterList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedFilterList_ItemCheck);
			this.checkedFilterList.SelectedIndexChanged += new System.EventHandler(this.listFilters_SelectedIndexChanged);
			// 
			// buttonRemoveFilter
			// 
			this.buttonRemoveFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRemoveFilter.Enabled = false;
			this.buttonRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonRemoveFilter.Location = new System.Drawing.Point(32, 272);
			this.buttonRemoveFilter.Name = "buttonRemoveFilter";
			this.buttonRemoveFilter.Size = new System.Drawing.Size(20, 20);
			this.buttonRemoveFilter.TabIndex = 2;
			this.buttonRemoveFilter.Text = "-";
			this.toolTip1.SetToolTip(this.buttonRemoveFilter, "Removes selected filter form the list.");
			this.buttonRemoveFilter.UseVisualStyleBackColor = true;
			this.buttonRemoveFilter.Click += new System.EventHandler(this.buttonRemoveFilter_Click);
			// 
			// buttonAddFilter
			// 
			this.buttonAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAddFilter.Location = new System.Drawing.Point(6, 272);
			this.buttonAddFilter.Name = "buttonAddFilter";
			this.buttonAddFilter.Size = new System.Drawing.Size(20, 20);
			this.buttonAddFilter.TabIndex = 1;
			this.buttonAddFilter.Text = "+";
			this.toolTip1.SetToolTip(this.buttonAddFilter, "Adds a filter to the list.");
			this.buttonAddFilter.UseVisualStyleBackColor = true;
			this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
			// 
			// groupProperties
			// 
			this.groupProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupProperties.Controls.Add(this.tableFilterProperties);
			this.groupProperties.Location = new System.Drawing.Point(3, 12);
			this.groupProperties.Name = "groupProperties";
			this.groupProperties.Size = new System.Drawing.Size(329, 322);
			this.groupProperties.TabIndex = 0;
			this.groupProperties.TabStop = false;
			this.groupProperties.Text = "Filter Properties";
			// 
			// tableFilterProperties
			// 
			this.tableFilterProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableFilterProperties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableFilterProperties.ColumnCount = 2;
			this.tableFilterProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableFilterProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableFilterProperties.Controls.Add(this.label1, 0, 0);
			this.tableFilterProperties.Controls.Add(this.label3, 0, 4);
			this.tableFilterProperties.Controls.Add(this.textReplace, 1, 4);
			this.tableFilterProperties.Controls.Add(this.textName, 1, 0);
			this.tableFilterProperties.Controls.Add(this.textMatch, 1, 3);
			this.tableFilterProperties.Controls.Add(this.label5, 0, 1);
			this.tableFilterProperties.Controls.Add(this.textDescription, 1, 1);
			this.tableFilterProperties.Controls.Add(this.label2, 0, 3);
			this.tableFilterProperties.Controls.Add(this.label4, 0, 2);
			this.tableFilterProperties.Controls.Add(this.tableFilterType, 1, 2);
			this.tableFilterProperties.Controls.Add(this.checkEscapeReplace, 1, 5);
			this.tableFilterProperties.Location = new System.Drawing.Point(6, 19);
			this.tableFilterProperties.Name = "tableFilterProperties";
			this.tableFilterProperties.RowCount = 6;
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableFilterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableFilterProperties.Size = new System.Drawing.Size(317, 297);
			this.tableFilterProperties.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Replace:";
			// 
			// textReplace
			// 
			this.textReplace.AcceptsReturn = true;
			this.textReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textReplace.Location = new System.Drawing.Point(72, 216);
			this.textReplace.Multiline = true;
			this.textReplace.Name = "textReplace";
			this.textReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textReplace.Size = new System.Drawing.Size(242, 35);
			this.textReplace.TabIndex = 4;
			this.toolTip1.SetToolTip(this.textReplace, "The text to replace it with.");
			// 
			// textName
			// 
			this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textName.Location = new System.Drawing.Point(72, 3);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(242, 20);
			this.textName.TabIndex = 0;
			this.toolTip1.SetToolTip(this.textName, "The REQUIRED unique name for your filter.\r\nNote that if two filters have the same" +
		" name, serious injury may occur.");
			// 
			// textMatch
			// 
			this.textMatch.AcceptsReturn = true;
			this.textMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textMatch.Location = new System.Drawing.Point(72, 175);
			this.textMatch.Multiline = true;
			this.textMatch.Name = "textMatch";
			this.textMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textMatch.Size = new System.Drawing.Size(242, 35);
			this.textMatch.TabIndex = 3;
			this.toolTip1.SetToolTip(this.textMatch, "The text to search for.");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Description:";
			// 
			// textDescription
			// 
			this.textDescription.AcceptsReturn = true;
			this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textDescription.Location = new System.Drawing.Point(72, 29);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textDescription.Size = new System.Drawing.Size(242, 60);
			this.textDescription.TabIndex = 1;
			this.toolTip1.SetToolTip(this.textDescription, "A description for your filter. Totally optional.");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Match:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Type:";
			// 
			// tableFilterType
			// 
			this.tableFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableFilterType.ColumnCount = 2;
			this.tableFilterType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableFilterType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableFilterType.Controls.Add(this.checkCaseSensitive, 1, 0);
			this.tableFilterType.Controls.Add(this.radioWildcard, 0, 2);
			this.tableFilterType.Controls.Add(this.radioPlain, 0, 0);
			this.tableFilterType.Controls.Add(this.radioRegex, 0, 1);
			this.tableFilterType.Location = new System.Drawing.Point(72, 95);
			this.tableFilterType.Name = "tableFilterType";
			this.tableFilterType.RowCount = 4;
			this.tableFilterType.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterType.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterType.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableFilterType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableFilterType.Size = new System.Drawing.Size(242, 74);
			this.tableFilterType.TabIndex = 2;
			// 
			// checkCaseSensitive
			// 
			this.checkCaseSensitive.AutoSize = true;
			this.checkCaseSensitive.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkCaseSensitive.Location = new System.Drawing.Point(131, 3);
			this.checkCaseSensitive.Name = "checkCaseSensitive";
			this.checkCaseSensitive.Size = new System.Drawing.Size(102, 18);
			this.checkCaseSensitive.TabIndex = 3;
			this.checkCaseSensitive.Text = "Case Sensitive";
			this.toolTip1.SetToolTip(this.checkCaseSensitive, "Enables or disables case sensitivity.\r\nIt\'s recommended that you leave it off unl" +
		"ess you\'re using Regular Expression.\r\nOr you can just do what works for you.");
			this.checkCaseSensitive.UseVisualStyleBackColor = true;
			// 
			// radioWildcard
			// 
			this.radioWildcard.AutoSize = true;
			this.radioWildcard.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioWildcard.Location = new System.Drawing.Point(3, 51);
			this.radioWildcard.Name = "radioWildcard";
			this.radioWildcard.Size = new System.Drawing.Size(73, 18);
			this.radioWildcard.TabIndex = 2;
			this.radioWildcard.TabStop = true;
			this.radioWildcard.Text = "Wildcard";
			this.toolTip1.SetToolTip(this.radioWildcard, resources.GetString("radioWildcard.ToolTip"));
			this.radioWildcard.UseVisualStyleBackColor = true;
			// 
			// radioPlain
			// 
			this.radioPlain.AutoSize = true;
			this.radioPlain.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioPlain.Location = new System.Drawing.Point(3, 3);
			this.radioPlain.Name = "radioPlain";
			this.radioPlain.Size = new System.Drawing.Size(78, 18);
			this.radioPlain.TabIndex = 0;
			this.radioPlain.TabStop = true;
			this.radioPlain.Text = "Plain Text";
			this.toolTip1.SetToolTip(this.radioPlain, "Matches text like you would expect; just find and replace!");
			this.radioPlain.UseVisualStyleBackColor = true;
			// 
			// radioRegex
			// 
			this.radioRegex.AutoSize = true;
			this.radioRegex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioRegex.Location = new System.Drawing.Point(3, 27);
			this.radioRegex.Name = "radioRegex";
			this.radioRegex.Size = new System.Drawing.Size(122, 18);
			this.radioRegex.TabIndex = 1;
			this.radioRegex.TabStop = true;
			this.radioRegex.Text = "Regular Expression";
			this.toolTip1.SetToolTip(this.radioRegex, "Regular Expression. It\'s not that hard, really!");
			this.radioRegex.UseVisualStyleBackColor = true;
			this.radioRegex.CheckedChanged += new System.EventHandler(this.radioRegex_CheckedChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(271, 343);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(352, 343);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Enabled = false;
			this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonApply.Location = new System.Drawing.Point(433, 343);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 3;
			this.buttonApply.Text = "&Apply";
			this.toolTip1.SetToolTip(this.buttonApply, "Applies the changes made to the selected filter.");
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32766;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// buttonDefault
			// 
			this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDefault.Location = new System.Drawing.Point(12, 343);
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Size = new System.Drawing.Size(75, 23);
			this.buttonDefault.TabIndex = 0;
			this.buttonDefault.Text = "Default";
			this.toolTip1.SetToolTip(this.buttonDefault, "Restores the default filter list");
			this.buttonDefault.UseVisualStyleBackColor = true;
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// checkEscapeReplace
			// 
			this.checkEscapeReplace.AutoSize = true;
			this.checkEscapeReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEscapeReplace.Location = new System.Drawing.Point(72, 257);
			this.checkEscapeReplace.Name = "checkEscapeReplace";
			this.checkEscapeReplace.Size = new System.Drawing.Size(80, 17);
			this.checkEscapeReplace.TabIndex = 5;
			this.checkEscapeReplace.Text = "Escape Replace Text";
			this.toolTip1.SetToolTip(this.checkEscapeReplace, "Automatically escapes all the replace text so you don\'t have to!");
			this.checkEscapeReplace.UseVisualStyleBackColor = true;
			// 
			// FilterManager
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(520, 378);
			this.Controls.Add(this.buttonDefault);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(512, 384);
			this.Name = "FilterManager";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Filter Manager";
			this.Load += new System.EventHandler(this.FilterManager_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupList.ResumeLayout(false);
			this.groupList.PerformLayout();
			this.groupProperties.ResumeLayout(false);
			this.tableFilterProperties.ResumeLayout(false);
			this.tableFilterProperties.PerformLayout();
			this.tableFilterType.ResumeLayout(false);
			this.tableFilterType.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupList;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonRemoveFilter;
		private System.Windows.Forms.Button buttonAddFilter;
		private System.Windows.Forms.CheckedListBox checkedFilterList;
		private System.Windows.Forms.GroupBox groupProperties;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonDefault;
		private System.Windows.Forms.TableLayoutPanel tableFilterProperties;
		private System.Windows.Forms.TextBox textReplace;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textMatch;
		private System.Windows.Forms.TextBox textDescription;
		private System.Windows.Forms.TableLayoutPanel tableFilterType;
		private System.Windows.Forms.CheckBox checkCaseSensitive;
		private System.Windows.Forms.RadioButton radioWildcard;
		private System.Windows.Forms.RadioButton radioPlain;
		private System.Windows.Forms.RadioButton radioRegex;
		private System.Windows.Forms.Button buttonFilterDown;
		private System.Windows.Forms.Button buttonFilterUp;
		private System.Windows.Forms.CheckBox checkEnableAll;
		private System.Windows.Forms.CheckBox checkEscapeReplace;
	}
}