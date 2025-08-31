﻿namespace LiveSplit.Cuphead {
	partial class SplitterSettings {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.btnAddSplit = new System.Windows.Forms.Button();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSort = new System.Windows.Forms.Label();
            this.rdType = new System.Windows.Forms.RadioButton();
            this.rdAlpha = new System.Windows.Forms.RadioButton();
            this.chkScoreBoardTiming = new System.Windows.Forms.CheckBox();
            this.chkScoreBoardTimingSaltbaker = new System.Windows.Forms.CheckBox();
            this.chkILTime = new System.Windows.Forms.CheckBox();
            this.flowMain.SuspendLayout();
            this.flowOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSplit
            // 
            this.btnAddSplit.Location = new System.Drawing.Point(3, 3);
            this.btnAddSplit.Name = "btnAddSplit";
            this.btnAddSplit.Size = new System.Drawing.Size(57, 21);
            this.btnAddSplit.TabIndex = 0;
            this.btnAddSplit.Text = "Add Split";
            this.btnAddSplit.UseVisualStyleBackColor = true;
            this.btnAddSplit.Click += new System.EventHandler(this.btnAddSplit_Click);
            // 
            // flowMain
            // 
            this.flowMain.AllowDrop = true;
            this.flowMain.AutoSize = true;
            this.flowMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMain.Controls.Add(this.flowOptions);
            this.flowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMain.Location = new System.Drawing.Point(0, 0);
            this.flowMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowMain.Name = "flowMain";
            this.flowMain.Size = new System.Drawing.Size(646, 27);
            this.flowMain.TabIndex = 0;
            this.flowMain.WrapContents = false;
            this.flowMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowMain_DragDrop);
            this.flowMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowMain_DragEnter);
            this.flowMain.DragOver += new System.Windows.Forms.DragEventHandler(this.flowMain_DragOver);
            // 
            // flowOptions
            // 
            this.flowOptions.AutoScroll = true;
            this.flowOptions.AutoSize = true;
            this.flowOptions.Controls.Add(this.btnAddSplit);
            this.flowOptions.Controls.Add(this.lblSort);
            this.flowOptions.Controls.Add(this.rdType);
            this.flowOptions.Controls.Add(this.rdAlpha);
            this.flowOptions.Controls.Add(this.chkScoreBoardTiming);
            this.flowOptions.Controls.Add(this.chkScoreBoardTimingSaltbaker);
            this.flowOptions.Controls.Add(this.chkILTime);
            this.flowOptions.Location = new System.Drawing.Point(0, 0);
            this.flowOptions.Margin = new System.Windows.Forms.Padding(0);
            this.flowOptions.Name = "flowOptions";
            this.flowOptions.Size = new System.Drawing.Size(646, 27);
            this.flowOptions.TabIndex = 0;
            // 
            // lblSort
            // 
            this.lblSort.Location = new System.Drawing.Point(66, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(105, 23);
            this.lblSort.TabIndex = 1;
            this.lblSort.Text = "Sort Combo List By:";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdType
            // 
            this.rdType.AutoSize = true;
            this.rdType.Location = new System.Drawing.Point(177, 3);
            this.rdType.Name = "rdType";
            this.rdType.Size = new System.Drawing.Size(49, 17);
            this.rdType.TabIndex = 2;
            this.rdType.Text = "Type";
            this.rdType.UseVisualStyleBackColor = true;
            this.rdType.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rdAlpha
            // 
            this.rdAlpha.AutoSize = true;
            this.rdAlpha.Checked = true;
            this.rdAlpha.Location = new System.Drawing.Point(232, 3);
            this.rdAlpha.Name = "rdAlpha";
            this.rdAlpha.Size = new System.Drawing.Size(83, 17);
            this.rdAlpha.TabIndex = 3;
            this.rdAlpha.TabStop = true;
            this.rdAlpha.Text = "Alphabetical";
            this.rdAlpha.UseVisualStyleBackColor = true;
            this.rdAlpha.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // chkScoreBoardTiming
            // 
            this.chkScoreBoardTiming.AutoSize = true;
            this.chkScoreBoardTiming.Location = new System.Drawing.Point(321, 3);
            this.chkScoreBoardTiming.Name = "chkScoreBoardTiming";
            this.chkScoreBoardTiming.Size = new System.Drawing.Size(129, 17);
            this.chkScoreBoardTiming.TabIndex = 5;
            this.chkScoreBoardTiming.Text = "Split After Scoreboard";
            this.chkScoreBoardTiming.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkScoreBoardTiming.UseVisualStyleBackColor = true;
            this.chkScoreBoardTiming.CheckedChanged += new System.EventHandler(this.chkScoreBoardTiming_CheckedChanged);
            // 
            // chkScoreBoardTimingSaltbaker
            // 
            this.chkScoreBoardTimingSaltbaker.AutoSize = true;
            this.chkScoreBoardTimingSaltbaker.Enabled = false;
            this.chkScoreBoardTimingSaltbaker.Location = new System.Drawing.Point(456, 3);
            this.chkScoreBoardTimingSaltbaker.Name = "chkScoreBoardTimingSaltbaker";
            this.chkScoreBoardTimingSaltbaker.Size = new System.Drawing.Size(120, 17);
            this.chkScoreBoardTimingSaltbaker.TabIndex = 7;
            this.chkScoreBoardTimingSaltbaker.Text = "Even on Saltbaker?";
            this.chkScoreBoardTimingSaltbaker.UseVisualStyleBackColor = true;
            this.chkScoreBoardTimingSaltbaker.CheckedChanged += new System.EventHandler(this.chkScoreBoardTimingSaltbaker_CheckedChanged);
            // 
            // chkILTime
            // 
            this.chkILTime.AutoSize = true;
            this.chkILTime.Location = new System.Drawing.Point(582, 3);
            this.chkILTime.Name = "chkILTime";
            this.chkILTime.Size = new System.Drawing.Size(61, 17);
            this.chkILTime.TabIndex = 6;
            this.chkILTime.Text = "IL Time";
            this.chkILTime.UseVisualStyleBackColor = true;
            this.chkILTime.CheckedChanged += new System.EventHandler(this.chkILTime_CheckedChanged);
            // 
            // SplitterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SplitterSettings";
            this.Size = new System.Drawing.Size(646, 27);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flowMain.ResumeLayout(false);
            this.flowMain.PerformLayout();
            this.flowOptions.ResumeLayout(false);
            this.flowOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAddSplit;
		private System.Windows.Forms.FlowLayoutPanel flowMain;
		private System.Windows.Forms.FlowLayoutPanel flowOptions;
		private System.Windows.Forms.Label lblSort;
		private System.Windows.Forms.RadioButton rdType;
		private System.Windows.Forms.RadioButton rdAlpha;
        private System.Windows.Forms.CheckBox chkScoreBoardTiming;
        private System.Windows.Forms.CheckBox chkILTime;
        private System.Windows.Forms.CheckBox chkScoreBoardTimingSaltbaker;
    }
}
