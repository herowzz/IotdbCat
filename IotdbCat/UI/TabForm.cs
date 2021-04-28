using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IotdbCat.UI
{
	public partial class TabForm : Form
	{
		public TabForm()
		{
			InitializeComponent();
		}
		int num = 0;
		private void btnRun_Click(object sender, EventArgs e)
		{
			MyTabControl1.SelectedIndex = 0;
			MyInfoBox.Text = "";
			string msgInfo = "[SQL] select * from cust_data";
			string Msg = "受影响的行: 0 \r\n 时间: 1.827s";
			string msgErr = "[Err] 1054 - Unknown column 'X' in 'field list'";
			MyGridView.Columns.Clear();
			if (num % 2 == 0)
			{

				MyInfoBox.Text = msgInfo;   //设置Text属性
				string[] Header = new string[] { "姓名", "性别", "年龄" };
				string[] names = new string[] { "name", "gender", "age" };
				for (int i = 0; i < Header.Length; i++)
				{
					DataGridViewColumn data_colu = new DataGridViewTextBoxColumn();
					data_colu.Name = names[i];//设置列名称
					data_colu.HeaderText = Header[i];//设置列标题文本
					data_colu.ReadOnly = true;//是否允许编辑
					data_colu.DataPropertyName = names[i];//设置绑定数据时列名称
					MyGridView.Columns.Add(data_colu);//添加到表格列
				}
				MyGridView.AutoGenerateColumns = false;  //让它不自己产生多余的列
				MyGridView.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control;//设置颜色。还有很多属性可以设置，不一一列举
				msgInfo += "\r\n ";

				for (int i = 0; i < 10; i++)
				{

					DataGridViewRow row = new DataGridViewRow();
					int index = MyGridView.Rows.Add(row);
					MyGridView.Rows[index].Cells[0].Value = "test" + i;
					if(i%2==0)
						MyGridView.Rows[index].Cells[1].Value = "男";
					else
						MyGridView.Rows[index].Cells[1].Value = "女";

					MyGridView.Rows[index].Cells[2].Value = 10 + i;
					Thread.Sleep(10);
					msgInfo += ".";
					MyInfoBox.Text = msgInfo;

				}
			}

			if (num % 2 == 0)
			{
				MyInfoBox.Text = msgInfo + "\r\n" + Msg;
				MyTabControl1.SelectedIndex = 1;
			}
			else
			{
				MyInfoBox.Text = msgInfo + "\r\n" + msgErr;
				MyTabControl1.SelectedIndex = 0;
			}
			num++;
		}
	}
}
