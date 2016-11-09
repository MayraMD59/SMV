using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
	{

	public class course
		{

		public course(string name, int courseQ, int courseUnits, int studentQ)//Constructor
			{
			// como lo que dijo kevin lo de arriba es lo de abajo , la entrada 
			this.name = name;
			this.x = courseUnits;
			this.studentQuantity = studentQ;
			units = new int[x];
			}
		//Atributos
		public int x;
		public string leader { get; set; }
		public string name { get; set; }
		public int[] units { get; set; }
		public int studentQuantity { get; set; }
		}
	}

