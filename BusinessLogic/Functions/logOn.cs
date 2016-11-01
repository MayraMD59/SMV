using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogic.Functions
	{
	public static class logOn
		{
		public static bool logged;
		public static bool loggedAsTeacher;
		static BusinessEntities.user userAccess = new BusinessEntities.user();
		public static bool BLLLogonUser(string username, string psw)
			{
			#region checkIfExistInDataBase
			userAccess.username = username;
			userAccess.password = psw;

			int index = DataAccessLayer.CRUD.Read.globalLists.accountList.FindIndex(a => (a.username == userAccess.username) && (a.password == userAccess.password));
			BusinessEntities.user pswss = new BusinessEntities.user();
			try
				{
				pswss = DataAccessLayer.CRUD.Read.globalLists.accountList.Find(a => (a.password == userAccess.password) && (a.username == userAccess.username));
				}
			catch (Exception)
				{
				pswss.username = ""; 
				pswss.password = "";
				}
			#endregion
			#region loginConfirmation
			try
				{// !("Login info does'n match with any object") true or false?
				if (!((pswss.username == null || pswss.password == null) && (userAccess.username != pswss.username || userAccess.password != pswss.password)))
					{
					#region accessedAsUser?
					if (pswss.code != null)
						{
						logged = true;
						}
					else
						{
						loggedAsTeacher = true;
						}
					#endregion
					MessageBox.Show("Bienvenido al sistema" + pswss.username);
					return true;
					}
				else//exeption Occurs
					{
					return false;
					}
				}
			catch (Exception)
				{
				MessageBox.Show("Usuario o Contraseña no Valido(s)", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
				}
			#endregion
			}
		}

	}
