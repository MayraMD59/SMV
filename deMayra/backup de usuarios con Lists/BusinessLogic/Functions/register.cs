using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Functions
	{
	public static class register
		{

		#region checkIfUserExist
		public static void BLLRegisterUser(string username, string realname, string lastName, string code, string psw, string email)
			{


			if (!DataAccessLayer.CRUD.Read.globalLists.registeredUsernameList.Contains(username))
				{
				DataAccessLayer.CRUD.Create.createSuccess = true;
				DataAccessLayer.CRUD.Create.DALCreate(username, realname, lastName, code, psw, email);
				registerCompleteChecker();
				}
			else
				{
				DataAccessLayer.CRUD.Create.createSuccess = false;
				DataAccessLayer.CRUD.Create.DALCreate(username, realname, lastName, code, psw, email);
				registerCompleteChecker();
				}
			}
		#endregion
		#region completeCheck
		public static bool registerCompleteChecker()
		{
		bool x = DataAccessLayer.CRUD.Create.createSuccess;
		return x;
		}
		#endregion


		}

	}

