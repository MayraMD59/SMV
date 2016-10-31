using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
	{
	#region Create
	public static class Create
		{
		public static int registeredUsers = 0;
		public static bool createSuccess;
		public static void DALCreate(string u, string n, string ln, string c, string p, string e)
			{
			if (createSuccess)
				{
				BusinessEntities.globalLists.userDataArray[0,registeredUsers] = u;
				BusinessEntities.globalLists.userDataArray[1, registeredUsers] = n;
				BusinessEntities.globalLists.userDataArray[2, registeredUsers] = ln;
				BusinessEntities.globalLists.userDataArray[3, registeredUsers] = c;
				BusinessEntities.globalLists.userDataArray[4, registeredUsers] = p;
				BusinessEntities.globalLists.userDataArray[5, registeredUsers] = e;

				registeredUsers++;

				//BusinessEntities.globalLists.accountList.Add(new BusinessEntities.entity_user(u, n, ln, c, p, e));
				//BusinessEntities.globalLists.registeredUsernameList.Add(u);
				MessageBox.Show("El usuario ha sido creado");
				}
			else
				{
				MessageBox.Show("El usuario ya existe");
				}
			}
		}
	#endregion
	#region Read
	public static class Read
		{
		public static bool readSuccess;
		public static int index;
		public static void find(string username)
			{
			if (BusinessEntities.globalLists.registeredUsernameList.Contains(username))
				{
				index = BusinessEntities.globalLists.registeredUsernameList.IndexOf(username);
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
