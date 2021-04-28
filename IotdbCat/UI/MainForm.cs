using IotdbCat.Domain;
using IotdbCat.Managers;
using IotdbCat.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IotdbCat.Common.Common;

namespace IotdbCat.UI
{
    public partial class MainForm : Form
    {
        private DataManager mDataManager = null;
        Dictionary<string, TabPage> mDicTabPageDlg = new Dictionary<string, TabPage>();
        public MainForm()
        {
            InitializeComponent();
        }
		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				DataManager.Instance.Init();
				mDataManager = DataManager.Instance;
				string DBInfoFile = PathUtils.GetConfigFilePath(GlobalParam.DBINFO);
				if (File.Exists(DBInfoFile))
				{
					using (StreamReader sr = new StreamReader(DBInfoFile, Encoding.UTF8))
					{
						string content = sr.ReadToEnd();
						mDataManager.mAllIotbdConnection = 
							JsonConvert.DeserializeObject<Dictionary<string, IotbdConnection>>(content);
					}
				}
				//加载树的根节点
				LoadTreeRootNodes();


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
			}
		}
		private void LoadTreeRootNodes()
		{
			MyTreeView.Nodes.Clear();
			for(int i= 0;i<10;i++)
			{
				TreeNode tmp = new TreeNode("test" + i);
				tmp.ImageIndex = 1;
				tmp.SelectedImageIndex = 2;
				for (int j = 0; j < 4; j++)
				{
					TreeNode tmp2 = new TreeNode("child" + j);
					tmp2.ImageIndex = 3;
					tmp2.SelectedImageIndex = 3;
					tmp.Nodes.Add(tmp2);
					for (int k = 0; k < 8; k++)
					{
						TreeNode tmp3 = new TreeNode("childchild" +k);
						tmp3.ImageIndex = 3;
						tmp3.SelectedImageIndex = 3;
						tmp2.Nodes.Add(tmp3);
					}
				}
				MyTreeView.Nodes.Add(tmp);
			}
			//MyTreeView.Nodes.Find("test1", true)[0].Nodes.Add("child");
		}
		private void MyTreeView_DoubleClick(object sender, EventArgs e)
		{
//             string name = MyTreeView.SelectedNode.Text;
//             if (mDicTabPageDlg.ContainsKey(name))
//                 MyTabControlParent.SelectedTab = mDicTabPageDlg[name];
//             else
//                 AddTabPage(name);

        }
		//新建查询
		private void toolStripMenuItemNewExecSQL_Click(object sender, EventArgs e)
		{
			if (MyTreeView.SelectedNode != null)
			{
				string name = MyTreeView.SelectedNode.Text;
				string parentname = FindRootNode(MyTreeView.SelectedNode).Text;
				string pagename = name + " @" + parentname;
// 				if (mDicTabPageDlg.ContainsKey(name))
// 					MyTabControlParent.SelectedTab = mDicTabPageDlg[name];
// 				else
				AddTabPage(pagename);
			}
			
		}

		//新建连接【目录】
		private void toolStripMenuItemNew_Click(object sender, EventArgs e)
		{
            AddConnectForm fm = new AddConnectForm(this);
            fm.ShowDialog();

        }
		//退出
		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		//查询前一千条数据
		private void toolStripMenuItemShow1000_Click(object sender, EventArgs e)
		{
			
		}

		//新建连接【右键】
		private void toolStripMenuItemNew2_Click(object sender, EventArgs e)
		{
			AddConnectForm fm = new AddConnectForm(this);
			fm.ShowDialog();
		}
		//查找根基节点
		private TreeNode FindRootNode(TreeNode node)
		{
			while (node.Parent != null)
			{
				node = node.Parent;
			}
			return node;
		}
		//添加父节点
		public void AddParentNode(string node)
		{
			TreeNode tmp = new TreeNode(node);
			tmp.ImageIndex = 1;
			MyTreeView.Nodes.Add(tmp);
		}
		private void AddTabPage(string text)
		{
            TabPage Page = new TabPage();
            Page.Name = text;
            Page.Text = text;
            MyTabControlParent.Controls.Add(Page);
            MyTabControlParent.SelectedTab = Page;
            TabForm fm = new TabForm();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            Page.Controls.Add(fm);
            fm.Show();
            mDicTabPageDlg[text] = Page;
           
        }

		private void MyTreeView_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				TreeView treeView = (TreeView)sender;
				if (treeView != null)
					treeView.SelectedNode = treeView.GetNodeAt(e.X, e.Y);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "提示信息");
			}
		}
	}
}
