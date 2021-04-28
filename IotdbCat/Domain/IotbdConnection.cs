using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotdbCat.Domain
{
	class IotbdConnection
	{
		public string ConnectName { set; get; }
		public string Host { set; get; }
		public int Port { set; get; }
		public string Username { set; get; }
		public string Password { set; get; }
		public bool IsSavePwd { set; get; }
	}
}
