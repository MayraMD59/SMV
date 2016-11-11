using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.CRUD
	{
	#region Read
	public static class Read
		{
		public static BusinessEntities.globalLists globalLists = new BusinessEntities.globalLists();
		public static bool readSuccess;
		public static int index;
		public static void find(string username)
			{
			if (Read.globalLists.registeredUsernameList.Contains(username))
				{
				index = Read.globalLists.registeredUsernameList.IndexOf(username);
				readSuccess = true;
				}
			else
				{
				readSuccess = false;
				}
			}
		}
	#endregion
	}
