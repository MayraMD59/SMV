using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogic
	{

	public static class register
		{
		public static void BLLRegisterUser(string username, string realname, string lastName, string code, string psw, string email)
			{

			#region searchForExistingUser
			if (!BusinessEntities.globalLists.registeredUsernameList.Contains(username))
				{
				DataAccessLayer.Create.createSuccess = true;
				DataAccessLayer.Create.DALCreate(username, realname, lastName, code, psw, email);
				registrationDone();
				}
			else
				{
				DataAccessLayer.Create.createSuccess = false;
				DataAccessLayer.Create.DALCreate(username,realname,lastName,code,psw,email);
				registrationDone();
				}
			#endregion
			}
		public static bool registrationDone()
			{
			bool x = DataAccessLayer.Create.createSuccess;
			return x;
			}
		}

	public static class logOn
		{
		public static void BLLLogonUser(string username, string psw)
			{

			}
		}

	}
