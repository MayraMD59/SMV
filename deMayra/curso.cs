using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
	public class curso
	{

		public curso(string nombre, int U, int Canalumnos)//Cosntructor
		{
			// como lo que dijo kevin lo de arriba es lo de abajo , la entrada 
			this.nombre = nombre;
			this.x = U;
			this.Canalumnos = Canalumnos;
			Unidad = new int[x];
		}
		//Atributos
		private int x;
		public string nombre;
		public int[] Unidad;
		public int Canalumnos;
	}

	public class usuario
	{

		public usuario(string username, string psw, string email, string name, string lastName, string code)//Constructor
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

	public class global
	{
		public static List<curso> courseList = new List<curso>();
		public static List<usuario> userList = new List<usuario>();

		public static void enlistarBLL()
		{
			//courseList.Add(new curso( ));
		}
	}
}



