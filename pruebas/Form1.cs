using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
	{
	public partial class SimpleLogin : Form
		{
		public SimpleLogin()
			{
			InitializeComponent();
			this.Controls.Add(this.panelWindowHeader);
			this.panelWindowHeader.MouseDown += PanelWindowHeader_MouseDown;
			this.panelWindowHeader.MouseUp += PanelWindowHeader_MouseUp;
			this.panelWindowHeader.MouseMove += PanelWindowHeader_MouseMove;
			}

		private void PanelWindowHeader_MouseMove(object sender, MouseEventArgs e)
			{
			if (this.drag)
			{ // dragging the header
				Point p1 = new Point(e.X, e.Y);
				Point p2 = this.PointToScreen(p1);
				Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y);
				this.Location = p3;
			}

			}

		private void PanelWindowHeader_MouseUp(object sender, MouseEventArgs e)
			{
			this.drag = false;
			}

		private void PanelWindowHeader_MouseDown(object sender, MouseEventArgs e)
			{
	
			this.drag = true;
			}
		private bool drag = false; //did we starteddragging the control ?
		private Point startPoint = new Point(0, 0);
		}
	}
