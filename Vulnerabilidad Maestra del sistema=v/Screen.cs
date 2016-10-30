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
			tmr_pssword.Enabled = true;
			}
		private void btn_registerCancel_Click(object sender, EventArgs e)
			{

			tab_Control.SelectedTab = tab_Login;
			tmr_pssword.Enabled = false;
			}
		private void btn_registerOK_Click(object sender, EventArgs e)
			{

			signInFormEmptyField();

			if (signInFormEmptyField())
				{
				string rawUser = txtbox_regUsername.Text;
				string rawName = txtbox_regName.Text;
				string rawLastName = txtbox_regLastNames.Text;
				string rawCode = txtbox_regTeacherCode.Text;
				string rawPswrd = txtbox_regPsswrd.Text;
				string rawEmail = txtbox_regEmail.Text;

				BusinessLogic.register.BLLRegister(rawUser,rawName,rawLastName,rawCode,rawPswrd,rawEmail);
				}



			
			}
		private bool signInFormEmptyField()
			{
			if (txtbox_regUsername.Text.Length == (0) || txtbox_regUsername.Text.Length < 0x4)
				{
				lbl_signInUsrnm.ForeColor = Color.Red;
				return false;
				}
			else if (txtbox_regName.Text.Length == 0 || txtbox_regName.Text.Length < 0x4)
				{
				lbl_signInName.ForeColor = Color.Red;
				return false;
				}
			else if (txtbox_regLastNames.Text.Length == 0 || txtbox_regLastNames.Text.Length < 0x4)
				{
				lbl_signInLastName.ForeColor = Color.Red;
				return false;
				}
			else if ((txtbox_regPsswrd.Text.Length == 0 || txtbox_psswrd.Text.Length < 0x6))
				{
				lbl_signInPsw.ForeColor = Color.Red;
				return false;
				}
			else if (txtbox_regConfPsw.Text.Length == 0 || txtbox_regConfPsw.Text.Length < 0x6)
				{
				lbl_signInConfPsw.ForeColor = Color.Red;
				return false;
				}
			else
				{
				return true;
				}
			}

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
		}
	}
