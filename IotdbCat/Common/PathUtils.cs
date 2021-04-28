using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotdbCat.Utils
{
	class PathUtils
	{
		public static string GetExeDIR()
		{
			string dir = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			return dir;
		}

		public static string GetConfigDIR()
		{
			string dir = Path.Combine(GetExeDIR(), "cfg");
			Directory.CreateDirectory(dir);
			return dir;
		}

		public static string GetConfigFilePath(string name)
		{
			string filepath = Path.Combine(GetConfigDIR(), name + ".json");
			return filepath;
		}
	}
}
