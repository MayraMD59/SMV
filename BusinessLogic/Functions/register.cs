using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Functions
	{
	public static class register
		{
		public static bool logged;
		public static bool loggedAsTeacher;
		#region checkIfUserExist
		public static void BLLRegisterUser(string username, string realname, string lastName, string code, string psw, string email)
			{


			if (!DataAccessLayer.CRUD.Read.globalLists.registeredUsernameList.Contains(username))
				{
				DataAccessLayer.CRUD.Create.createSuccess = true;
				DataAccessLayer.CRUD.Create.DALCreate(username, realname, lastName, code, psw, email);
				processCompleteChecker();
				}
			else
				{
				DataAccessLayer.CRUD.Create.createSuccess = false;
				DataAccessLayer.CRUD.Create.DALCreate(username, realname, lastName, code, psw, email);
				processCompleteChecker();
				}
			}
		#endregion
		#region completeCheck
		public static bool processCompleteChecker()
		{
		bool x = DataAccessLayer.CRUD.Create.createSuccess;
		return x;
		}
		#endregion


		}

	}

