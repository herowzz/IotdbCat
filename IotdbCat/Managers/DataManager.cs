using IotdbCat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotdbCat.Managers
{
	class DataManager
	{
		private static DataManager mInstance = null;
		public static DataManager Instance
		{
			get
			{
				if (mInstance == null)
					mInstance = new DataManager();
				return mInstance;
			}
		}
		public void Init()
		{
			mAllIotbdConnection = new Dictionary<string, IotbdConnection>();
			//mAllDBObject = new Dictionary<string, DataOperate>();
		}
		//数据库连接属性
		public Dictionary<string, IotbdConnection> mAllIotbdConnection;
		//存取数据连接实例
		//public Dictionary<string, DataOperate> mAllDBObject;
	}
}
