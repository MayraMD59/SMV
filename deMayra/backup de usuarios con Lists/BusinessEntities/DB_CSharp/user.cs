using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
	{
	public class user
		{
		public user() { }
		public user(string n)
			{
			this.name = n;
			}
		public user(string username, string name, string lastName, string code, string psw, string email)//Constructor
			{
			this.username = username;
			password = psw;
			this.email = email;
			this.name = name;
			this.lastName = lastName;
			this.code = code;

			}//atributos
		public int currentCourse = 0;
		public course[] courseQ = new course[10];
		public string username { get; set; }
		public string name { get; set; }
		public string lastName { get; set; }
		public string code { get; set; }
		public string password { get; set; }
		public string email { get; set; }

		}
	}
