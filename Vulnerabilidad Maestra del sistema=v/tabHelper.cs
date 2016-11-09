using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VulnerabilidadMaestra
	{
	public partial class tabHelper : Form
		{
		public tabHelper()
			{
			InitializeComponent();
			this.Show();
			}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
			{
			int index = listBox1.SelectedIndex;
			switch (index)
				{
				case 0:
					Screen.tIndex = index;
					break;
				case 1:
					Screen.tIndex = index;
					break;
				case 2:
					Screen.tIndex = index;
					break;
				case 3:
					Screen.tIndex = index;
					break;
				case 4:
					Screen.tIndex = index;
					break;
				case 5:
					Screen.tIndex = index;
					break;
				case 6:
					Screen.tIndex = index;
					break;
				case 7:
					Screen.tIndex = index;
					break;
				case 8:
					Screen.tIndex = index;
					break;
				case 9:
					Screen.tIndex = index;
					break;
				case 10:
					Screen.tIndex = index;
					break;
				default:
					break;
				}
			}

		private void flatClose1_Click(object sender, EventArgs e)
			{
			try
				{

				}
			catch (Exception)
				{
				
				}
			
			}

		private void flatClose1_Click_1(object sender, EventArgs e)
			{
			this.Close();
			}
		}
	}
