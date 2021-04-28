
namespace IotdbCat.UI
{
	partial class AddConnectForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbSavePwd = new System.Windows.Forms.CheckBox();
			this.tbPwd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbIpAddr = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbConnectName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.BtnOk = new System.Windows.Forms.Button();
			this.btnTestConnect = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbSavePwd);
			this.groupBox1.Controls.Add(this.tbPwd);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbUserName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbPort);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbIpAddr);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbConnectName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(548, 349);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// cbSavePwd
			// 
			this.cbSavePwd.AutoSize = true;
			this.cbSavePwd.BackColor = System.Drawing.SystemColors.Control;
			this.cbSavePwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbSavePwd.Location = new System.Drawing.Point(169, 287);
			this.cbSavePwd.Name = "cbSavePwd";
			this.cbSavePwd.Size = new System.Drawing.Size(88, 24);
			this.cbSavePwd.TabIndex = 6;
			this.cbSavePwd.Text = "保存密码";
			this.cbSavePwd.UseVisualStyleBackColor = false;
			// 
			// tbPwd
			// 
			this.tbPwd.Location = new System.Drawing.Point(169, 244);
			this.tbPwd.Name = "tbPwd";
			this.tbPwd.PasswordChar = '*';
			this.tbPwd.Size = new System.Drawing.Size(364, 27);
			this.tbPwd.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.label5.Location = new System.Drawing.Point(18, 248);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "密码：";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(169, 211);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(364, 27);
			this.tbUserName.TabIndex = 4;
			this.tbUserName.Text = "root";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Location = new System.Drawing.Point(18, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "用户名：";
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(169, 178);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(364, 27);
			this.tbPort.TabIndex = 3;
			this.tbPort.Text = "6667";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Location = new System.Drawing.Point(18, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "端口：";
			// 
			// tbIpAddr
			// 
			this.tbIpAddr.Location = new System.Drawing.Point(169, 145);
			this.tbIpAddr.Name = "tbIpAddr";
			this.tbIpAddr.Size = new System.Drawing.Size(364, 27);
			this.tbIpAddr.TabIndex = 2;
			this.tbIpAddr.Text = "localhost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Location = new System.Drawing.Point(18, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "主机名或 IP地址：";
			// 
			// tbConnectName
			// 
			this.tbConnectName.Location = new System.Drawing.Point(169, 36);
			this.tbConnectName.Name = "tbConnectName";
			this.tbConnectName.Size = new System.Drawing.Size(364, 27);
			this.tbConnectName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Location = new System.Drawing.Point(18, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "连接名：";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(466, 407);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(356, 407);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(94, 29);
			this.BtnOk.TabIndex = 11;
			this.BtnOk.Text = "确定";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// btnTestConnect
			// 
			this.btnTestConnect.Location = new System.Drawing.Point(14, 407);
			this.btnTestConnect.Name = "btnTestConnect";
			this.btnTestConnect.Size = new System.Drawing.Size(94, 29);
			this.btnTestConnect.TabIndex = 10;
			this.btnTestConnect.Text = "测试链接";
			this.btnTestConnect.UseVisualStyleBackColor = true;
			// 
			// AddConnectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 474);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.btnTestConnect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddConnectForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新建连接";
			this.Load += new System.EventHandler(this.AddConnectForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbSavePwd;
		private System.Windows.Forms.TextBox tbPwd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbIpAddr;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbConnectName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button btnTestConnect;
	}
}