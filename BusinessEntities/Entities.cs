using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
	{

	public class entity_course
		{

		public entity_course(string name, int courseQ, int courseUnits, int studentQ)//Constructor
			{
			// como lo que dijo kevin lo de arriba es lo de abajo , la entrada 
			this.name = name;
			this.x = courseUnits;
			this.studentQuantity = studentQ;
			units = new int[x];
			}//Atributos
		private int x;
		public string name { get; set; }
		public int[] units { get; set; }
		public int studentQuantity { get; set; }
		}

	public class entity_user
		{
		public entity_user(string n)
			{
			this.name = n;
			}
		public entity_user(string username, string psw, string email, string name, string lastName, string code)//Constructor
			{
			this.username = username;
			this.password = psw;
			this.email = email;
			this.name = name;
			this.lastName = lastName;
			this.code = code;

			}//atributos
		public string username;
		public string password;
		public string email;
		public string name;
		public string lastName;
		public string code;

		}

	public class globalLists
		{
		public static List<entity_course> courseList = new List<entity_course>();
		public static List<entity_user> accountList = new List<entity_user>();
		public static List<string> registeredUsernameList = new List<string>();
		}

	}
