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
	public partial class Screen : Form
		{
		public Screen()
			{
			InitializeComponent();
			
			}
		private void llb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			{
			tab_Control.SelectedTab = tab_SignIn;
			}
		private void btn_registerCancel_Click(object sender, EventArgs e)
			{

			tab_Control.SelectedTab = tab_Login;
			}
		private void btn_registerOK_Click(object sender, EventArgs e)
			{
			string rawUser = txtbox_regUsername.Text;
			string rawName = txtbox_regName.Text;
			string rawLastName = txtbox_regLastNames.Text;
			string rawCode = txtbox_regTeacherCode.Text;
			string rawPswrd = txtbox_regPsswrd.Text;
			string rawConfirm = txtbox_regConfPsw.Text;
			string rawEmail = txtbox_regEmail.Text;

			
			}


		}
	}
