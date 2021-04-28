
using System;

namespace IotdbCat.UI
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2", 4, 4);
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node6", 4, 4);
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8", 4, 4);
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("测试1", new System.Windows.Forms.TreeNode[] {
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node9", 4, 4);
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node11", 4, 4);
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node16", 4, 4);
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node17", 4, 4);
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node12", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node7", 4, 4);
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node10", 4, 4);
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node25", 4, 4);
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node26", 4, 4);
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node13", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode16});
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node15", 4, 4);
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode18});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MyMenuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.MyStatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusServerNum = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.MySplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.MyTreeView = new System.Windows.Forms.TreeView();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemCatField = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNewExecSQL = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSql = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShow1000 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelTable = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemNew2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
			this.MyImageList = new System.Windows.Forms.ImageList(this.components);
			this.MyTabControlParent = new System.Windows.Forms.TabControl();
			this.MyMenuStrip.SuspendLayout();
			this.MyStatusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MySplitContainer1)).BeginInit();
			this.MySplitContainer1.Panel1.SuspendLayout();
			this.MySplitContainer1.Panel2.SuspendLayout();
			this.MySplitContainer1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MyMenuStrip
			// 
			this.MyMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
			this.MyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MyMenuStrip.ImeMode = System.Windows.Forms.ImeMode.On;
			this.MyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemTool,
            this.toolStripMenuItemAbout});
			this.MyMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MyMenuStrip.Name = "MyMenuStrip";
			this.MyMenuStrip.Size = new System.Drawing.Size(1662, 28);
			this.MyMenuStrip.TabIndex = 0;
			this.MyMenuStrip.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(53, 24);
			this.toolStripMenuItemFile.Text = "文件";
			// 
			// toolStripMenuItemNew
			// 
			this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
			this.toolStripMenuItemNew.Size = new System.Drawing.Size(152, 26);
			this.toolStripMenuItemNew.Text = "新建连接";
			this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(152, 26);
			this.toolStripMenuItemExit.Text = "退出";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemTool
			// 
			this.toolStripMenuItemTool.Name = "toolStripMenuItemTool";
			this.toolStripMenuItemTool.Size = new System.Drawing.Size(53, 24);
			this.toolStripMenuItemTool.Text = "工具";
			// 
			// toolStripMenuItemAbout
			// 
			this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			this.toolStripMenuItemAbout.Size = new System.Drawing.Size(53, 24);
			this.toolStripMenuItemAbout.Text = "关于";
			// 
			// MyStatusStrip1
			// 
			this.MyStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MyStatusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MyStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusServerNum,
            this.toolStripStatusLabel1,
            this.toolStripStatusUser,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusTime});
			this.MyStatusStrip1.Location = new System.Drawing.Point(0, 977);
			this.MyStatusStrip1.Name = "MyStatusStrip1";
			this.MyStatusStrip1.Size = new System.Drawing.Size(1662, 26);
			this.MyStatusStrip1.TabIndex = 1;
			this.MyStatusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusServerNum
			// 
			this.toolStripStatusServerNum.Name = "toolStripStatusServerNum";
			this.toolStripStatusServerNum.Size = new System.Drawing.Size(78, 20);
			this.toolStripStatusServerNum.Text = "服务器：5";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Salmon;
			this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Enabled = false;
			this.toolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(301, 20);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "|";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// toolStripStatusUser
			// 
			this.toolStripStatusUser.Name = "toolStripStatusUser";
			this.toolStripStatusUser.Size = new System.Drawing.Size(203, 20);
			this.toolStripStatusUser.Text = "localhost_6667  用户：root";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(301, 20);
			this.toolStripStatusLabel3.Spring = true;
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(301, 20);
			this.toolStripStatusLabel4.Spring = true;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Enabled = false;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(301, 20);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "|";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripStatusTime
			// 
			this.toolStripStatusTime.Name = "toolStripStatusTime";
			this.toolStripStatusTime.Size = new System.Drawing.Size(159, 20);
			this.toolStripStatusTime.Text = "2021-04-27 09:18:01";
			// 
			// MySplitContainer1
			// 
			this.MySplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MySplitContainer1.Location = new System.Drawing.Point(0, 28);
			this.MySplitContainer1.Name = "MySplitContainer1";
			// 
			// MySplitContainer1.Panel1
			// 
			this.MySplitContainer1.Panel1.Controls.Add(this.MyTreeView);
			this.MySplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// MySplitContainer1.Panel2
			// 
			this.MySplitContainer1.Panel2.Controls.Add(this.MyTabControlParent);
			this.MySplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MySplitContainer1.Size = new System.Drawing.Size(1662, 949);
			this.MySplitContainer1.SplitterDistance = 395;
			this.MySplitContainer1.SplitterWidth = 5;
			this.MySplitContainer1.TabIndex = 2;
			// 
			// MyTreeView
			// 
			this.MyTreeView.ContextMenuStrip = this.ContextMenuStrip1;
			this.MyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyTreeView.HideSelection = false;
			this.MyTreeView.ImageIndex = 1;
			this.MyTreeView.ImageList = this.MyImageList;
			this.MyTreeView.Location = new System.Drawing.Point(0, 0);
			this.MyTreeView.Name = "MyTreeView";
			treeNode1.ImageIndex = 4;
			treeNode1.Name = "Node2";
			treeNode1.SelectedImageIndex = 4;
			treeNode1.Text = "Node2";
			treeNode2.ImageIndex = 4;
			treeNode2.Name = "Node6";
			treeNode2.SelectedImageIndex = 4;
			treeNode2.Text = "Node6";
			treeNode3.ImageIndex = 4;
			treeNode3.Name = "Node8";
			treeNode3.SelectedImageIndex = 4;
			treeNode3.Text = "Node8";
			treeNode4.ImageIndex = 3;
			treeNode4.Name = "Node1";
			treeNode4.SelectedImageIndex = 3;
			treeNode4.Text = "Node1";
			treeNode5.Name = "Node0";
			treeNode5.Text = "测试1";
			treeNode6.ImageIndex = 4;
			treeNode6.Name = "Node9";
			treeNode6.SelectedImageIndex = 4;
			treeNode6.Text = "Node9";
			treeNode7.ImageIndex = 4;
			treeNode7.Name = "Node11";
			treeNode7.SelectedImageIndex = 4;
			treeNode7.Text = "Node11";
			treeNode8.Name = "Node3";
			treeNode8.Text = "Node3";
			treeNode9.ImageIndex = 4;
			treeNode9.Name = "Node16";
			treeNode9.SelectedImageIndex = 4;
			treeNode9.Text = "Node16";
			treeNode10.ImageIndex = 4;
			treeNode10.Name = "Node17";
			treeNode10.SelectedImageIndex = 4;
			treeNode10.Text = "Node17";
			treeNode11.ImageIndex = 3;
			treeNode11.Name = "Node12";
			treeNode11.SelectedImageIndex = 3;
			treeNode11.Text = "Node12";
			treeNode12.ImageIndex = 4;
			treeNode12.Name = "Node7";
			treeNode12.SelectedImageIndex = 4;
			treeNode12.Text = "Node7";
			treeNode13.ImageIndex = 4;
			treeNode13.Name = "Node10";
			treeNode13.SelectedImageIndex = 4;
			treeNode13.Text = "Node10";
			treeNode14.ImageIndex = 4;
			treeNode14.Name = "Node25";
			treeNode14.SelectedImageIndex = 4;
			treeNode14.Text = "Node25";
			treeNode15.ImageIndex = 4;
			treeNode15.Name = "Node26";
			treeNode15.SelectedImageIndex = 4;
			treeNode15.Text = "Node26";
			treeNode16.ImageIndex = 3;
			treeNode16.Name = "Node13";
			treeNode16.SelectedImageIndex = 3;
			treeNode16.Text = "Node13";
			treeNode17.Name = "Node4";
			treeNode17.Text = "Node4";
			treeNode18.ImageIndex = 4;
			treeNode18.Name = "Node15";
			treeNode18.SelectedImageIndex = 4;
			treeNode18.Text = "Node15";
			treeNode19.Name = "Node5";
			treeNode19.Text = "Node5";
			this.MyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode17,
            treeNode19});
			this.MyTreeView.SelectedImageIndex = 2;
			this.MyTreeView.ShowLines = false;
			this.MyTreeView.Size = new System.Drawing.Size(395, 949);
			this.MyTreeView.TabIndex = 0;
			this.MyTreeView.DoubleClick += new System.EventHandler(this.MyTreeView_DoubleClick);
			this.MyTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyTreeView_MouseDown);
			// 
			// ContextMenuStrip1
			// 
			this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCatField,
            this.toolStripMenuItemNewExecSQL,
            this.toolStripMenuItemSql,
            this.toolStripSeparator2,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.toolStripSeparator3,
            this.toolStripMenuItemNew2,
            this.toolStripMenuItemDel});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(154, 184);
			// 
			// toolStripMenuItemCatField
			// 
			this.toolStripMenuItemCatField.Name = "toolStripMenuItemCatField";
			this.toolStripMenuItemCatField.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemCatField.Text = "查看表字段";
			// 
			// toolStripMenuItemNewExecSQL
			// 
			this.toolStripMenuItemNewExecSQL.Name = "toolStripMenuItemNewExecSQL";
			this.toolStripMenuItemNewExecSQL.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemNewExecSQL.Text = "新建查询";
			this.toolStripMenuItemNewExecSQL.Click += new System.EventHandler(this.toolStripMenuItemNewExecSQL_Click);
			// 
			// toolStripMenuItemSql
			// 
			this.toolStripMenuItemSql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow1000,
            this.toolStripMenuItemDelTable});
			this.toolStripMenuItemSql.Name = "toolStripMenuItemSql";
			this.toolStripMenuItemSql.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemSql.Text = "便捷SQL";
			// 
			// toolStripMenuItemShow1000
			// 
			this.toolStripMenuItemShow1000.Name = "toolStripMenuItemShow1000";
			this.toolStripMenuItemShow1000.Size = new System.Drawing.Size(218, 26);
			this.toolStripMenuItemShow1000.Text = "显示前1000条数据";
			this.toolStripMenuItemShow1000.Click += new System.EventHandler(this.toolStripMenuItemShow1000_Click);
			// 
			// toolStripMenuItemDelTable
			// 
			this.toolStripMenuItemDelTable.Name = "toolStripMenuItemDelTable";
			this.toolStripMenuItemDelTable.Size = new System.Drawing.Size(218, 26);
			this.toolStripMenuItemDelTable.Text = "删除表";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemOpen.Text = "打开连接";
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemClose.Text = "关闭连接";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
			// 
			// toolStripMenuItemNew2
			// 
			this.toolStripMenuItemNew2.Name = "toolStripMenuItemNew2";
			this.toolStripMenuItemNew2.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemNew2.Text = "新建连接";
			this.toolStripMenuItemNew2.Click += new System.EventHandler(this.toolStripMenuItemNew2_Click);
			// 
			// toolStripMenuItemDel
			// 
			this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
			this.toolStripMenuItemDel.Size = new System.Drawing.Size(153, 24);
			this.toolStripMenuItemDel.Text = "删除连接";
			// 
			// MyImageList
			// 
			this.MyImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.MyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImageList.ImageStream")));
			this.MyImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.MyImageList.Images.SetKeyName(0, "0添加数据库.png");
			this.MyImageList.Images.SetKeyName(1, "1数据库未打开.png");
			this.MyImageList.Images.SetKeyName(2, "2数据库打开.png");
			this.MyImageList.Images.SetKeyName(3, "3表.png");
			this.MyImageList.Images.SetKeyName(4, "4字段.png");
			// 
			// MyTabControlParent
			// 
			this.MyTabControlParent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyTabControlParent.Location = new System.Drawing.Point(0, 0);
			this.MyTabControlParent.Name = "MyTabControlParent";
			this.MyTabControlParent.SelectedIndex = 0;
			this.MyTabControlParent.Size = new System.Drawing.Size(1262, 949);
			this.MyTabControlParent.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1662, 1003);
			this.Controls.Add(this.MySplitContainer1);
			this.Controls.Add(this.MyStatusStrip1);
			this.Controls.Add(this.MyMenuStrip);
			this.MainMenuStrip = this.MyMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IotdbCat";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MyMenuStrip.ResumeLayout(false);
			this.MyMenuStrip.PerformLayout();
			this.MyStatusStrip1.ResumeLayout(false);
			this.MyStatusStrip1.PerformLayout();
			this.MySplitContainer1.Panel1.ResumeLayout(false);
			this.MySplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MySplitContainer1)).EndInit();
			this.MySplitContainer1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

	





		#endregion

		private System.Windows.Forms.MenuStrip MyMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTool;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
		private System.Windows.Forms.StatusStrip MyStatusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusServerNum;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUser;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
		private System.Windows.Forms.SplitContainer MySplitContainer1;
		private System.Windows.Forms.TreeView MyTreeView;
		private System.Windows.Forms.ImageList MyImageList;
		private System.Windows.Forms.TabControl MyTabControlParent;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewExecSQL;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSql;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow1000;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelTable;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCatField;
		
	}
}