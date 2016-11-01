using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
			this.panelWindowHeader.MouseClick += panelWindowHeader_MouseClick;
			}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void panelWindowHeader_MouseClick(object sender, MouseEventArgs e)
			{
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
		private Point startPoint = new Point(0,0);

		private void panelWindowHeader_Paint(object sender, PaintEventArgs e)
			{

			}
		}
	}
