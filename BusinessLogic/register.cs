using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogic
	{
	public class register
		{
		public static bool selec=false;


		public static void BLLRegister(string username, string realname, string lastName, string code, string psw, string email)
			{
			string check= username;
			string check2= realname;
			string check3 = lastName;
			string check4 = code;
			string check5 = psw;
			string check6 = email;

			#region searchForExistingUser
			if (!BusinessEntities.globalLists.registeredUsernameList.Contains(check))
				{
				selec = true;
				DALRegister(check);
				}
			else
				{
				selec = false;
				DALRegister(check);
				}
			#endregion
			}


		public static void DALRegister(string x)
			{
			if (selec)
				{
				BusinessEntities.globalLists.accountList.Add(new BusinessEntities.entity_user(x));
				BusinessEntities.globalLists.registeredUsernameList.Add(x);
				MessageBox.Show("El usuario ha sido creado");
				}
			else
				{
				MessageBox.Show("El usuario ya existe");
				}
			}

		}
	}
