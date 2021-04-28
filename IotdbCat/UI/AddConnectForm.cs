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
	public partial class AddConnectForm : Form
	{
		MainForm _fm = new MainForm();
		private DataManager mDataManager = null;
		public AddConnectForm(MainForm fm)
		{
			InitializeComponent();
			_fm = fm;
		}
		private void AddConnectForm_Load(object sender, EventArgs e)
		{
			mDataManager = DataManager.Instance;
		}
		private void BtnOk_Click(object sender, EventArgs e)
		{
			try
			{
				string connName = tbConnectName.Text.Trim();
				if (connName.Trim() == "")
				{
					tbConnectName.Text = "localhost_6667";
					connName = "localhost_6667";
				}
				if (tbIpAddr.Text.Trim() == "")
					tbIpAddr.Text = "localhost";
				if (tbPort.Text.Trim() == "")
					tbPort.Text = "6667";
				//输入框不能为空
				if (tbUserName.Text.Trim() == "")
				{
					MessageBox.Show("请补全帐号信息！", "提示信息");
					return;
				}
				if (mDataManager.mAllIotbdConnection.ContainsKey(connName))
				{
					MessageBox.Show(string.Format("连接名{0}已经存在，请指定其他连接名。", connName), "错误信息");
					return;
				}
				IotbdConnection model = new IotbdConnection();
				model.ConnectName = connName;
				model.Host = tbIpAddr.Text;
				model.Port = int.Parse(tbPort.Text);
				model.Username = tbUserName.Text;
				model.Password = tbPwd.Text;
				model.IsSavePwd = cbSavePwd.Checked;
				mDataManager.mAllIotbdConnection[tbConnectName.Text] = model;
				string path = PathUtils.GetConfigFilePath(GlobalParam.DBINFO);
				using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
				{
					string content = JsonConvert.SerializeObject(mDataManager.mAllIotbdConnection);
					sw.Write(content);
				}
				_fm.AddParentNode(connName);
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
			}
		}

		
	}
}
