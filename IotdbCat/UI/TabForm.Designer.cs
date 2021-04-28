
namespace IotdbCat.UI
{
	partial class TabForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnRun = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.MyTabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.MyGridView = new System.Windows.Forms.DataGridView();
			this.MyInfoBox = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.MyTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MyGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.btnRun);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1387, 40);
			this.panel1.TabIndex = 0;
			// 
			// btnStop
			// 
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.Location = new System.Drawing.Point(82, 5);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(80, 32);
			this.btnStop.TabIndex = 1;
			this.btnStop.UseVisualStyleBackColor = true;
			// 
			// btnRun
			// 
			this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
			this.btnRun.Location = new System.Drawing.Point(0, 4);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(80, 32);
			this.btnRun.TabIndex = 0;
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 40);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.MyTabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(1387, 909);
			this.splitContainer1.SplitterDistance = 250;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1387, 250);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// MyTabControl1
			// 
			this.MyTabControl1.Controls.Add(this.tabPage1);
			this.MyTabControl1.Controls.Add(this.tabPage2);
			this.MyTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyTabControl1.Location = new System.Drawing.Point(0, 0);
			this.MyTabControl1.Name = "MyTabControl1";
			this.MyTabControl1.SelectedIndex = 0;
			this.MyTabControl1.Size = new System.Drawing.Size(1387, 653);
			this.MyTabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.MyInfoBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1379, 620);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "信息";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.MyGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1379, 620);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "结果";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MyGridView
			// 
			this.MyGridView.AllowUserToOrderColumns = true;
			this.MyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyGridView.Location = new System.Drawing.Point(3, 3);
			this.MyGridView.Name = "MyGridView";
			this.MyGridView.RowHeadersWidth = 51;
			this.MyGridView.RowTemplate.Height = 29;
			this.MyGridView.Size = new System.Drawing.Size(1373, 614);
			this.MyGridView.TabIndex = 0;
			// 
			// MyInfoBox
			// 
			this.MyInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyInfoBox.Location = new System.Drawing.Point(3, 3);
			this.MyInfoBox.Name = "MyInfoBox";
			this.MyInfoBox.Size = new System.Drawing.Size(1373, 614);
			this.MyInfoBox.TabIndex = 0;
			this.MyInfoBox.Text = "";
			// 
			// TabForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 949);
			this.ControlBox = false;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TabForm";
			this.Text = "TabForm";
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.MyTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MyGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TabControl MyTabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView MyGridView;
		private System.Windows.Forms.RichTextBox MyInfoBox;
	}
}