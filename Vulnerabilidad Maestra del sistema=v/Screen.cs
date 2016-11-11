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
using MySql.Data.MySqlClient;

namespace VulnerabilidadMaestra
	{
	public partial class Screen : Form
		{
		public Screen()
			{
			InitializeComponent();
			connectToDatabase();
			}
		#region connectToLocalDatabase
		MySqlConnection connection;
		string connectionString = "server=localhost; uid=root;" + "pwd=Midios7777; database=SMV;";
		private void connectToDatabase()
			{
			try
				{
				connection = new MySqlConnection();
				connection.ConnectionString = connectionString;
				connection.Open();
				}
			catch (MySql.Data.MySqlClient.MySqlException ex)
				{
				MessageBox.Show(ex.Message);
				}
			}
		#endregion
		#region BorderDraggable
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		#endregion

		private void pnl_Header_MouseMove(object sender, MouseEventArgs e)
			{
			if (e.Button == MouseButtons.Left)
				{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
		private void llb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			{
			tab_Control.SelectedTab = tab2CreateAcc;
			tmr_pssword.Enabled = true;
			}
		private void btn_registerCancel_Click(object sender, EventArgs e)
			{
			txtbox_regConfPsw.Text = null;
			txtbox_regEmail.Text = null;
			txtbox_regLastNames.Text = null;
			txtbox_regName.Text = null;
			txtbox_regPsswrd.Text = null;
			txtbox_regTeacherCode.Text = null;
			txtbox_regUsername.Text = null;

			tab_Control.SelectedTab = tab1Login;
			tmr_pssword.Enabled = false;
			}
		private void changeToTabStudentMain(EventArgs e)
			{

			}
		#region ExitButton
		private void btn_close_Click(object sender, EventArgs e)
			{
			this.Close();
			}
		#endregion
		#region SignInButton
		private void btn_registerOK_Click(object sender, EventArgs e)
			{
			if (signInFormEmptyField())
				{

				string rawUser = txtbox_regUsername.Text;
				string rawName = txtbox_regName.Text;
				string rawLastName = txtbox_regLastNames.Text;
				string rawCode = txtbox_regTeacherCode.Text;
				string rawPswrd = txtbox_regPsswrd.Text;
				string rawEmail = txtbox_regEmail.Text;

				BusinessLogic.Functions.register.BLLRegisterUser(rawUser, rawName, rawLastName, rawCode, rawPswrd, rawEmail);

				if (BusinessLogic.Functions.register.registerCompleteChecker())
					{//Clean Textbox
					txtbox_regUsername.Text = null;
					txtbox_regName.Text = null;
					txtbox_regLastNames.Text = null;
					txtbox_regTeacherCode.Text = null;
					txtbox_regPsswrd.Text = null;
					txtbox_regConfPsw.Text = null;
					txtbox_regEmail.Text = null;

					tab_Control.SelectedTab = tab1Login;
					}
				}
			}
		#endregion
		#region emptyTextboxCheck
		private bool signInFormEmptyField()
			{//Username textbox is empty
			if (txtbox_regUsername.Text.Length == (0) || txtbox_regUsername.Text.Length < 0x4)
				{
				lbl_signInUsrnm.ForeColor = Color.Red;
				return false;
				}//Name TextBox is empty
			else if (txtbox_regName.Text.Length == 0 || txtbox_regName.Text.Length < 0x2)
				{
				lbl_signInName.ForeColor = Color.Red;
				return false;
				}// Last Name textbox is empty
			else if (txtbox_regLastNames.Text.Length == 0 || txtbox_regLastNames.Text.Length < 0x4)
				{
				lbl_signInLastName.ForeColor = Color.Red;
				return false;
				}//Password textbox is empty
			else if (txtbox_regPsswrd.Text.Length == 0 || txtbox_regPsswrd.Text.Length < 0x6)
				{
				lbl_signInPsw.ForeColor = Color.Red;
				return false;
				}//confirm password textbox is empty
			else if (txtbox_regConfPsw.Text != txtbox_regPsswrd.Text)
				{
				lbl_signInConfPsw.ForeColor = Color.Red;
				return false;
				}
			else
				{
				lbl_signInUsrnm.ForeColor = Color.White;
				lbl_signInPsw.ForeColor = Color.White;
				lbl_signInConfPsw.ForeColor = Color.White;
				lbl_signInName.ForeColor = Color.White;
				lbl_signInLastName.ForeColor = Color.White;
				return true;
				}
			}
		#endregion
		#region passwordTester
		private void tmr_pssword_Tick(object sender, EventArgs e)
			{// Void Textboxes
			if ((txtbox_regPsswrd.Text.Length == 0 && txtbox_regConfPsw.Text.Length == 0))
				{
				lbl_pswMeter.Text = "";
				}
			else if ((txtbox_regPsswrd.Text == txtbox_regConfPsw.Text))
				{
				lbl_pswMeter.Text = "Las contraselas coinciden:)";
				lbl_pswMeter.ForeColor = Color.Green;
				}
			else
				{
				lbl_pswMeter.Text = "Las contraseñas no coinciden:(";
				lbl_pswMeter.ForeColor = Color.Red;
				}
			}
		#endregion

		#region LogInButton


		private void btn_logIn_Click(object sender, EventArgs e)
			{
			if (logOnFormEmptyField())
				{
				BusinessLogic.Functions.logOn.BLLLogonUser(txtbox_Usrnm.Text, txtbox_psswrd.Text);
				}
			else
				{
				MessageBox.Show("Rellene los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			if (BusinessLogic.Functions.logOn.logged)
				{
				txtbox_Usrnm.Text = null;
				txtbox_psswrd.Text = null;
				tab_Control.SelectedTab = tab3AsStudentMain;
				}
			else if (BusinessLogic.Functions.logOn.loggedAsTeacher)
				{
				txtbox_Usrnm.Text = null;
				txtbox_psswrd.Text = null;
				tab_Control.SelectedTab = tab3AsTeacherMain;
				}
			}
		#endregion
		#region emptyTextBoxCheck
		private bool logOnFormEmptyField()
			{
			if (txtbox_Usrnm.Text.Length == 0 || txtbox_psswrd.Text.Length == 0)
				{

				return false;
				}
			else
				{
				return true;
				}
			}



		#endregion


		#region TabHelper

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
			{
			switch (listBox1.SelectedIndex)
				{
				case 0:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab1Login;
					break;
				case 1:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab2CreateAcc;
					break;
				case 2:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab3AsStudentMain;
					break;
				case 3:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab3AsTeacherMain;
					break;
				case 4:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab4AsStudentCourseOverview;
					break;
				case 5:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab4AsTeacherCourseOverview;
					break;
				case 6:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab5AsTeacherCreateCourse;
					break;
				case 7:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					listBox1.Parent = tab6AsTeacherCourseList;
					break;
				case 8:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					break;
				case 9:
					tab_Control.SelectedIndex = listBox1.SelectedIndex;
					break;
				default:
					break;
				}
			}

		#endregion

		//this.btn_close.Click += new System.EventHandler(this.btn_close_Click);


		}
	}

