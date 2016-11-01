using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.CRUD
	{
	#region Create
	public static class Create
		{
		//public static int registeredUsers = 0;
		public static bool createSuccess;
		public static void DALCreate(string u, string n, string ln, string c, string p, string e)
			{
			if (createSuccess)
				{
				Read.globalLists.accountList.Add(new BusinessEntities.user(u, n, ln, c, p, e));
				Read.globalLists.registeredUsernameList.Add(u);
				MessageBox.Show("El usuario ha sido creado");
				}
			else
				{
				MessageBox.Show("El usuario ya existe");
				}
			}
		}
	#endregion
	}
