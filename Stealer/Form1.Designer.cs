namespace Stealer
{
	partial class Stealer
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMain = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtPathList = new System.Windows.Forms.TextBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFileExtension = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.checkFileExtension = new System.Windows.Forms.CheckBox();
			this.btnBrowser = new System.Windows.Forms.Button();
			this.btnAddPath = new System.Windows.Forms.Button();
			this.btnClearPath = new System.Windows.Forms.Button();
			this.btnDelPath = new System.Windows.Forms.Button();
			this.checkFileName = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtMain
			// 
			this.txtMain.Location = new System.Drawing.Point(53, 216);
			this.txtMain.Multiline = true;
			this.txtMain.Name = "txtMain";
			this.txtMain.ReadOnly = true;
			this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMain.Size = new System.Drawing.Size(307, 80);
			this.txtMain.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "日志:";
			// 
			// btnHide
			// 
			this.btnHide.Location = new System.Drawing.Point(366, 216);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(66, 37);
			this.btnHide.TabIndex = 2;
			this.btnHide.Text = "隐藏";
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(366, 259);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(66, 37);
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "关于";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "目录列:";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(53, 162);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(235, 21);
			this.txtPath.TabIndex = 0;
			// 
			// txtPathList
			// 
			this.txtPathList.Location = new System.Drawing.Point(53, 12);
			this.txtPathList.Multiline = true;
			this.txtPathList.Name = "txtPathList";
			this.txtPathList.ReadOnly = true;
			this.txtPathList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPathList.Size = new System.Drawing.Size(378, 117);
			this.txtPathList.TabIndex = 6;
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(53, 135);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.ReadOnly = true;
			this.txtFileName.Size = new System.Drawing.Size(132, 21);
			this.txtFileName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "文件夹:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "目录:";
			// 
			// txtFileExtension
			// 
			this.txtFileExtension.Location = new System.Drawing.Point(53, 189);
			this.txtFileExtension.Name = "txtFileExtension";
			this.txtFileExtension.ReadOnly = true;
			this.txtFileExtension.Size = new System.Drawing.Size(307, 21);
			this.txtFileExtension.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "后缀:";
			// 
			// checkFileExtension
			// 
			this.checkFileExtension.AutoSize = true;
			this.checkFileExtension.Checked = true;
			this.checkFileExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkFileExtension.Location = new System.Drawing.Point(365, 192);
			this.checkFileExtension.Name = "checkFileExtension";
			this.checkFileExtension.Size = new System.Drawing.Size(72, 16);
			this.checkFileExtension.TabIndex = 12;
			this.checkFileExtension.Text = "锁定后缀";
			this.checkFileExtension.UseVisualStyleBackColor = true;
			this.checkFileExtension.CheckedChanged += new System.EventHandler(this.checkFileExtension_CheckedChanged);
			// 
			// btnBrowser
			// 
			this.btnBrowser.Location = new System.Drawing.Point(365, 162);
			this.btnBrowser.Name = "btnBrowser";
			this.btnBrowser.Size = new System.Drawing.Size(66, 21);
			this.btnBrowser.TabIndex = 13;
			this.btnBrowser.Text = "浏览";
			this.btnBrowser.UseVisualStyleBackColor = true;
			this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
			// 
			// btnAddPath
			// 
			this.btnAddPath.Location = new System.Drawing.Point(294, 162);
			this.btnAddPath.Name = "btnAddPath";
			this.btnAddPath.Size = new System.Drawing.Size(66, 21);
			this.btnAddPath.TabIndex = 14;
			this.btnAddPath.Text = "添加目录";
			this.btnAddPath.UseVisualStyleBackColor = true;
			this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
			// 
			// btnClearPath
			// 
			this.btnClearPath.Location = new System.Drawing.Point(365, 135);
			this.btnClearPath.Name = "btnClearPath";
			this.btnClearPath.Size = new System.Drawing.Size(66, 21);
			this.btnClearPath.TabIndex = 15;
			this.btnClearPath.Text = "清空目录";
			this.btnClearPath.UseVisualStyleBackColor = true;
			this.btnClearPath.Click += new System.EventHandler(this.btnClearPath_Click);
			// 
			// btnDelPath
			// 
			this.btnDelPath.Location = new System.Drawing.Point(262, 135);
			this.btnDelPath.Name = "btnDelPath";
			this.btnDelPath.Size = new System.Drawing.Size(98, 21);
			this.btnDelPath.TabIndex = 16;
			this.btnDelPath.Text = "删除上一条目录";
			this.btnDelPath.UseVisualStyleBackColor = true;
			this.btnDelPath.Click += new System.EventHandler(this.btnDelPath_Click);
			// 
			// checkFileName
			// 
			this.checkFileName.AutoSize = true;
			this.checkFileName.Checked = true;
			this.checkFileName.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkFileName.Location = new System.Drawing.Point(191, 138);
			this.checkFileName.Name = "checkFileName";
			this.checkFileName.Size = new System.Drawing.Size(72, 16);
			this.checkFileName.TabIndex = 17;
			this.checkFileName.Text = "锁定名称";
			this.checkFileName.UseVisualStyleBackColor = true;
			this.checkFileName.CheckedChanged += new System.EventHandler(this.checkFileName_CheckedChanged);
			// 
			// Stealer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 307);
			this.Controls.Add(this.checkFileName);
			this.Controls.Add(this.btnDelPath);
			this.Controls.Add(this.btnClearPath);
			this.Controls.Add(this.btnAddPath);
			this.Controls.Add(this.btnBrowser);
			this.Controls.Add(this.checkFileExtension);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFileExtension);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.txtPathList);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnHide);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMain);
			this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Stealer";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Silent Copier";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.TextBox txtPathList;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFileExtension;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkFileExtension;
		private System.Windows.Forms.Button btnBrowser;
		private System.Windows.Forms.Button btnAddPath;
		private System.Windows.Forms.Button btnClearPath;
		private System.Windows.Forms.Button btnDelPath;
		private System.Windows.Forms.CheckBox checkFileName;
	}
}

