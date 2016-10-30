using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
	{
	public class Create
		{
		public static void create (string name)
			{
			BusinessEntities.globalLists.accountList.Add(new BusinessEntities.entity_user(name));
			BusinessEntities.globalLists.registeredUsernameList.Add(name);
			}
		}
	}
