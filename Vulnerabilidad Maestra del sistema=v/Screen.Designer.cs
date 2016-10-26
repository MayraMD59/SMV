namespace VulnerabilidadMaestra
	{
	partial class Screen
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pnl_Header = new System.Windows.Forms.Panel();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.tab_Control = new FlatUI.FlatTabControl();
			this.tab_Login = new System.Windows.Forms.TabPage();
			this.llb_register = new iTalk.iTalk_LinkLabel();
			this.flatButton1 = new FlatUI.FlatButton();
			this.flatLabel3 = new FlatUI.FlatLabel();
			this.flatLabel2 = new FlatUI.FlatLabel();
			this.flatLabel1 = new FlatUI.FlatLabel();
			this.txtbox_psswrd = new FlatUI.FlatTextBox();
			this.txtbox_Usrnm = new FlatUI.FlatTextBox();
			this.tab_SignIn = new System.Windows.Forms.TabPage();
			this.iTalk_Label1 = new iTalk.iTalk_Label();
			this.flatLabel11 = new FlatUI.FlatLabel();
			this.txtbox_newTeacherCode = new FlatUI.FlatTextBox();
			this.flatLabel10 = new FlatUI.FlatLabel();
			this.flatTextBox1 = new FlatUI.FlatTextBox();
			this.flatLabel9 = new FlatUI.FlatLabel();
			this.txtbox_newpsswrd = new FlatUI.FlatTextBox();
			this.flatLabel8 = new FlatUI.FlatLabel();
			this.txtbox_newEmail = new FlatUI.FlatTextBox();
			this.flatLabel7 = new FlatUI.FlatLabel();
			this.flatLabel6 = new FlatUI.FlatLabel();
			this.flatLabel5 = new FlatUI.FlatLabel();
			this.txtbox_lastNames = new FlatUI.FlatTextBox();
			this.txtbox_newName = new FlatUI.FlatTextBox();
			this.txtbox_newID = new FlatUI.FlatTextBox();
			this.flatLabel4 = new FlatUI.FlatLabel();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.iTalk_ProgressBar1 = new iTalk.iTalk_ProgressBar();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbl_NombreAlumno = new FlatUI.FlatLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.lbl_Title = new FlatUI.FlatLabel();
			this.btn_min = new FlatUI.FlatMini();
			this.btn_close = new FlatUI.FlatClose();
			this.pnl_Header.SuspendLayout();
			this.pnl_Body.SuspendLayout();
			this.tab_Control.SuspendLayout();
			this.tab_Login.SuspendLayout();
			this.tab_SignIn.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_Header
			// 
			this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.pnl_Header.Controls.Add(this.lbl_Title);
			this.pnl_Header.Controls.Add(this.btn_min);
			this.pnl_Header.Controls.Add(this.btn_close);
			this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Header.Location = new System.Drawing.Point(0, 0);
			this.pnl_Header.Name = "pnl_Header";
			this.pnl_Header.Size = new System.Drawing.Size(540, 40);
			this.pnl_Header.TabIndex = 0;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Controls.Add(this.tab_Control);
			this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Body.Location = new System.Drawing.Point(0, 40);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(540, 440);
			this.pnl_Body.TabIndex = 0;
			// 
			// tab_Control
			// 
			this.tab_Control.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.tab_Control.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.tab_Control.Controls.Add(this.tab_Login);
			this.tab_Control.Controls.Add(this.tab_SignIn);
			this.tab_Control.Controls.Add(this.tabPage1);
			this.tab_Control.Controls.Add(this.tabPage2);
			this.tab_Control.Controls.Add(this.tabPage3);
			this.tab_Control.Controls.Add(this.tabPage4);
			this.tab_Control.Controls.Add(this.tabPage5);
			this.tab_Control.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tab_Control.ItemSize = new System.Drawing.Size(120, 40);
			this.tab_Control.Location = new System.Drawing.Point(0, -42);
			this.tab_Control.Name = "tab_Control";
			this.tab_Control.SelectedIndex = 0;
			this.tab_Control.Size = new System.Drawing.Size(540, 482);
			this.tab_Control.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tab_Control.TabIndex = 2;
			// 
			// tab_Login
			// 
			this.tab_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab_Login.Controls.Add(this.llb_register);
			this.tab_Login.Controls.Add(this.flatButton1);
			this.tab_Login.Controls.Add(this.flatLabel3);
			this.tab_Login.Controls.Add(this.flatLabel2);
			this.tab_Login.Controls.Add(this.flatLabel1);
			this.tab_Login.Controls.Add(this.txtbox_psswrd);
			this.tab_Login.Controls.Add(this.txtbox_Usrnm);
			this.tab_Login.Location = new System.Drawing.Point(4, 44);
			this.tab_Login.Name = "tab_Login";
			this.tab_Login.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Login.Size = new System.Drawing.Size(532, 434);
			this.tab_Login.TabIndex = 0;
			this.tab_Login.Text = "tabPage3";
			// 
			// llb_register
			// 
			this.llb_register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
			this.llb_register.AutoSize = true;
			this.llb_register.BackColor = System.Drawing.Color.Transparent;
			this.llb_register.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.llb_register.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.llb_register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
			this.llb_register.Location = new System.Drawing.Point(228, 318);
			this.llb_register.Name = "llb_register";
			this.llb_register.Size = new System.Drawing.Size(76, 19);
			this.llb_register.TabIndex = 4;
			this.llb_register.TabStop = true;
			this.llb_register.Text = "Registrarse";
			this.llb_register.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
			this.llb_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_register_LinkClicked);
			// 
			// flatButton1
			// 
			this.flatButton1.BackColor = System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.flatButton1.Location = new System.Drawing.Point(192, 283);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new System.Drawing.Size(148, 32);
			this.flatButton1.TabIndex = 3;
			this.flatButton1.Text = "Iniciar sesion";
			this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// flatLabel3
			// 
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabel3.ForeColor = System.Drawing.Color.White;
			this.flatLabel3.Location = new System.Drawing.Point(139, 202);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new System.Drawing.Size(77, 17);
			this.flatLabel3.TabIndex = 0;
			this.flatLabel3.Text = "Contraseña";
			// 
			// flatLabel2
			// 
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabel2.ForeColor = System.Drawing.Color.White;
			this.flatLabel2.Location = new System.Drawing.Point(139, 124);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new System.Drawing.Size(128, 17);
			this.flatLabel2.TabIndex = 0;
			this.flatLabel2.Text = "Usuario // Matricula";
			// 
			// flatLabel1
			// 
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
			this.flatLabel1.ForeColor = System.Drawing.Color.White;
			this.flatLabel1.Location = new System.Drawing.Point(19, 30);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new System.Drawing.Size(109, 37);
			this.flatLabel1.TabIndex = 0;
			this.flatLabel1.Text = "Ingreso";
			// 
			// txtbox_psswrd
			// 
			this.txtbox_psswrd.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_psswrd.FocusOnHover = false;
			this.txtbox_psswrd.Location = new System.Drawing.Point(142, 222);
			this.txtbox_psswrd.MaxLength = 32767;
			this.txtbox_psswrd.Multiline = false;
			this.txtbox_psswrd.Name = "txtbox_psswrd";
			this.txtbox_psswrd.ReadOnly = false;
			this.txtbox_psswrd.Size = new System.Drawing.Size(255, 29);
			this.txtbox_psswrd.TabIndex = 2;
			this.txtbox_psswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_psswrd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_psswrd.UseSystemPasswordChar = false;
			// 
			// txtbox_Usrnm
			// 
			this.txtbox_Usrnm.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_Usrnm.FocusOnHover = false;
			this.txtbox_Usrnm.Location = new System.Drawing.Point(142, 145);
			this.txtbox_Usrnm.MaxLength = 32767;
			this.txtbox_Usrnm.Multiline = false;
			this.txtbox_Usrnm.Name = "txtbox_Usrnm";
			this.txtbox_Usrnm.ReadOnly = false;
			this.txtbox_Usrnm.Size = new System.Drawing.Size(255, 29);
			this.txtbox_Usrnm.TabIndex = 1;
			this.txtbox_Usrnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_Usrnm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_Usrnm.UseSystemPasswordChar = false;
			// 
			// tab_SignIn
			// 
			this.tab_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab_SignIn.Controls.Add(this.iTalk_Label1);
			this.tab_SignIn.Controls.Add(this.flatLabel11);
			this.tab_SignIn.Controls.Add(this.txtbox_newTeacherCode);
			this.tab_SignIn.Controls.Add(this.flatLabel10);
			this.tab_SignIn.Controls.Add(this.flatTextBox1);
			this.tab_SignIn.Controls.Add(this.flatLabel9);
			this.tab_SignIn.Controls.Add(this.txtbox_newpsswrd);
			this.tab_SignIn.Controls.Add(this.flatLabel8);
			this.tab_SignIn.Controls.Add(this.txtbox_newEmail);
			this.tab_SignIn.Controls.Add(this.flatLabel7);
			this.tab_SignIn.Controls.Add(this.flatLabel6);
			this.tab_SignIn.Controls.Add(this.flatLabel5);
			this.tab_SignIn.Controls.Add(this.txtbox_lastNames);
			this.tab_SignIn.Controls.Add(this.txtbox_newName);
			this.tab_SignIn.Controls.Add(this.txtbox_newID);
			this.tab_SignIn.Controls.Add(this.flatLabel4);
			this.tab_SignIn.Location = new System.Drawing.Point(4, 44);
			this.tab_SignIn.Name = "tab_SignIn";
			this.tab_SignIn.Padding = new System.Windows.Forms.Padding(3);
			this.tab_SignIn.Size = new System.Drawing.Size(532, 434);
			this.tab_SignIn.TabIndex = 1;
			this.tab_SignIn.Text = "tabPage4";
			// 
			// iTalk_Label1
			// 
			this.iTalk_Label1.AutoSize = true;
			this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label1.Location = new System.Drawing.Point(198, 200);
			this.iTalk_Label1.Name = "iTalk_Label1";
			this.iTalk_Label1.Size = new System.Drawing.Size(212, 13);
			this.iTalk_Label1.TabIndex = 15;
			this.iTalk_Label1.Text = "*Dejese en blanco si no cuenta con uno";
			// 
			// flatLabel11
			// 
			this.flatLabel11.AutoSize = true;
			this.flatLabel11.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel11.ForeColor = System.Drawing.Color.White;
			this.flatLabel11.Location = new System.Drawing.Point(31, 184);
			this.flatLabel11.Name = "flatLabel11";
			this.flatLabel11.Size = new System.Drawing.Size(106, 13);
			this.flatLabel11.TabIndex = 14;
			this.flatLabel11.Text = "Codigo de docente";
			// 
			// txtbox_newTeacherCode
			// 
			this.txtbox_newTeacherCode.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_newTeacherCode.FocusOnHover = false;
			this.txtbox_newTeacherCode.Location = new System.Drawing.Point(26, 200);
			this.txtbox_newTeacherCode.MaxLength = 32767;
			this.txtbox_newTeacherCode.Multiline = false;
			this.txtbox_newTeacherCode.Name = "txtbox_newTeacherCode";
			this.txtbox_newTeacherCode.ReadOnly = false;
			this.txtbox_newTeacherCode.Size = new System.Drawing.Size(166, 29);
			this.txtbox_newTeacherCode.TabIndex = 13;
			this.txtbox_newTeacherCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_newTeacherCode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_newTeacherCode.UseSystemPasswordChar = false;
			// 
			// flatLabel10
			// 
			this.flatLabel10.AutoSize = true;
			this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel10.ForeColor = System.Drawing.Color.White;
			this.flatLabel10.Location = new System.Drawing.Point(31, 280);
			this.flatLabel10.Name = "flatLabel10";
			this.flatLabel10.Size = new System.Drawing.Size(123, 13);
			this.flatLabel10.TabIndex = 12;
			this.flatLabel10.Text = "Confirmar Contraseña ";
			// 
			// flatTextBox1
			// 
			this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.flatTextBox1.FocusOnHover = false;
			this.flatTextBox1.Location = new System.Drawing.Point(27, 296);
			this.flatTextBox1.MaxLength = 32767;
			this.flatTextBox1.Multiline = false;
			this.flatTextBox1.Name = "flatTextBox1";
			this.flatTextBox1.ReadOnly = false;
			this.flatTextBox1.Size = new System.Drawing.Size(250, 29);
			this.flatTextBox1.TabIndex = 11;
			this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.flatTextBox1.UseSystemPasswordChar = false;
			// 
			// flatLabel9
			// 
			this.flatLabel9.AutoSize = true;
			this.flatLabel9.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel9.ForeColor = System.Drawing.Color.White;
			this.flatLabel9.Location = new System.Drawing.Point(31, 232);
			this.flatLabel9.Name = "flatLabel9";
			this.flatLabel9.Size = new System.Drawing.Size(66, 13);
			this.flatLabel9.TabIndex = 10;
			this.flatLabel9.Text = "Contraseña";
			// 
			// txtbox_newpsswrd
			// 
			this.txtbox_newpsswrd.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_newpsswrd.FocusOnHover = false;
			this.txtbox_newpsswrd.Location = new System.Drawing.Point(27, 248);
			this.txtbox_newpsswrd.MaxLength = 32767;
			this.txtbox_newpsswrd.Multiline = false;
			this.txtbox_newpsswrd.Name = "txtbox_newpsswrd";
			this.txtbox_newpsswrd.ReadOnly = false;
			this.txtbox_newpsswrd.Size = new System.Drawing.Size(250, 29);
			this.txtbox_newpsswrd.TabIndex = 9;
			this.txtbox_newpsswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_newpsswrd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_newpsswrd.UseSystemPasswordChar = false;
			// 
			// flatLabel8
			// 
			this.flatLabel8.AutoSize = true;
			this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel8.ForeColor = System.Drawing.Color.White;
			this.flatLabel8.Location = new System.Drawing.Point(31, 331);
			this.flatLabel8.Name = "flatLabel8";
			this.flatLabel8.Size = new System.Drawing.Size(167, 13);
			this.flatLabel8.TabIndex = 8;
			this.flatLabel8.Text = "Direccion de correo electronico";
			// 
			// txtbox_newEmail
			// 
			this.txtbox_newEmail.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_newEmail.FocusOnHover = false;
			this.txtbox_newEmail.Location = new System.Drawing.Point(26, 347);
			this.txtbox_newEmail.MaxLength = 32767;
			this.txtbox_newEmail.Multiline = false;
			this.txtbox_newEmail.Name = "txtbox_newEmail";
			this.txtbox_newEmail.ReadOnly = false;
			this.txtbox_newEmail.Size = new System.Drawing.Size(250, 29);
			this.txtbox_newEmail.TabIndex = 7;
			this.txtbox_newEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_newEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_newEmail.UseSystemPasswordChar = false;
			// 
			// flatLabel7
			// 
			this.flatLabel7.AutoSize = true;
			this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel7.ForeColor = System.Drawing.Color.White;
			this.flatLabel7.Location = new System.Drawing.Point(31, 136);
			this.flatLabel7.Name = "flatLabel7";
			this.flatLabel7.Size = new System.Drawing.Size(55, 13);
			this.flatLabel7.TabIndex = 6;
			this.flatLabel7.Text = "Apellidos";
			// 
			// flatLabel6
			// 
			this.flatLabel6.AutoSize = true;
			this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel6.ForeColor = System.Drawing.Color.White;
			this.flatLabel6.Location = new System.Drawing.Point(170, 88);
			this.flatLabel6.Name = "flatLabel6";
			this.flatLabel6.Size = new System.Drawing.Size(48, 13);
			this.flatLabel6.TabIndex = 5;
			this.flatLabel6.Text = "Nombre";
			// 
			// flatLabel5
			// 
			this.flatLabel5.AutoSize = true;
			this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel5.ForeColor = System.Drawing.Color.White;
			this.flatLabel5.Location = new System.Drawing.Point(31, 88);
			this.flatLabel5.Name = "flatLabel5";
			this.flatLabel5.Size = new System.Drawing.Size(55, 13);
			this.flatLabel5.TabIndex = 4;
			this.flatLabel5.Text = "Matricula";
			// 
			// txtbox_lastNames
			// 
			this.txtbox_lastNames.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_lastNames.FocusOnHover = false;
			this.txtbox_lastNames.Location = new System.Drawing.Point(27, 152);
			this.txtbox_lastNames.MaxLength = 32767;
			this.txtbox_lastNames.Multiline = false;
			this.txtbox_lastNames.Name = "txtbox_lastNames";
			this.txtbox_lastNames.ReadOnly = false;
			this.txtbox_lastNames.Size = new System.Drawing.Size(250, 29);
			this.txtbox_lastNames.TabIndex = 3;
			this.txtbox_lastNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_lastNames.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_lastNames.UseSystemPasswordChar = false;
			// 
			// txtbox_newName
			// 
			this.txtbox_newName.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_newName.FocusOnHover = false;
			this.txtbox_newName.Location = new System.Drawing.Point(164, 104);
			this.txtbox_newName.MaxLength = 32767;
			this.txtbox_newName.Multiline = false;
			this.txtbox_newName.Name = "txtbox_newName";
			this.txtbox_newName.ReadOnly = false;
			this.txtbox_newName.Size = new System.Drawing.Size(152, 29);
			this.txtbox_newName.TabIndex = 2;
			this.txtbox_newName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_newName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_newName.UseSystemPasswordChar = false;
			// 
			// txtbox_newID
			// 
			this.txtbox_newID.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_newID.FocusOnHover = false;
			this.txtbox_newID.Location = new System.Drawing.Point(27, 104);
			this.txtbox_newID.MaxLength = 32767;
			this.txtbox_newID.Multiline = false;
			this.txtbox_newID.Name = "txtbox_newID";
			this.txtbox_newID.ReadOnly = false;
			this.txtbox_newID.Size = new System.Drawing.Size(112, 29);
			this.txtbox_newID.TabIndex = 1;
			this.txtbox_newID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_newID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_newID.UseSystemPasswordChar = false;
			// 
			// flatLabel4
			// 
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.flatLabel4.ForeColor = System.Drawing.Color.White;
			this.flatLabel4.Location = new System.Drawing.Point(23, 25);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new System.Drawing.Size(115, 37);
			this.flatLabel4.TabIndex = 0;
			this.flatLabel4.Text = "Registro";
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tabPage1.Controls.Add(this.iTalk_ProgressBar1);
			this.tabPage1.Controls.Add(this.chart1);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.lbl_NombreAlumno);
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(532, 434);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "tabPage1";
			// 
			// iTalk_ProgressBar1
			// 
			this.iTalk_ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.iTalk_ProgressBar1.Location = new System.Drawing.Point(367, 91);
			this.iTalk_ProgressBar1.Maximum = ((long)(100));
			this.iTalk_ProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
			this.iTalk_ProgressBar1.Name = "iTalk_ProgressBar1";
			this.iTalk_ProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
			this.iTalk_ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.iTalk_ProgressBar1.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Flat;
			this.iTalk_ProgressBar1.Size = new System.Drawing.Size(130, 130);
			this.iTalk_ProgressBar1.TabIndex = 3;
			this.iTalk_ProgressBar1.Text = "iTalk_ProgressBar1";
			this.iTalk_ProgressBar1.Value = ((long)(75));
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Empty;
			this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.chart1.BorderSkin.PageColor = System.Drawing.Color.Turquoise;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(8, 91);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Parcial 1";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Parcial 2";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(330, 136);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 233);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(330, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// lbl_NombreAlumno
			// 
			this.lbl_NombreAlumno.AutoSize = true;
			this.lbl_NombreAlumno.BackColor = System.Drawing.Color.Transparent;
			this.lbl_NombreAlumno.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.lbl_NombreAlumno.ForeColor = System.Drawing.Color.White;
			this.lbl_NombreAlumno.Location = new System.Drawing.Point(26, 23);
			this.lbl_NombreAlumno.Name = "lbl_NombreAlumno";
			this.lbl_NombreAlumno.Size = new System.Drawing.Size(82, 37);
			this.lbl_NombreAlumno.TabIndex = 0;
			this.lbl_NombreAlumno.Text = "NULL";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tabPage2.Location = new System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(532, 434);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "tabPage2";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(532, 434);
			this.tabPage3.TabIndex = 4;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 44);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(532, 434);
			this.tabPage4.TabIndex = 5;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 44);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(532, 434);
			this.tabPage5.TabIndex = 6;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(24, 3);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(318, 32);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "System Master Vulnerability";
			// 
			// btn_min
			// 
			this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_min.BackColor = System.Drawing.Color.White;
			this.btn_min.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.btn_min.Font = new System.Drawing.Font("Marlett", 12F);
			this.btn_min.Location = new System.Drawing.Point(492, 11);
			this.btn_min.Name = "btn_min";
			this.btn_min.Size = new System.Drawing.Size(18, 18);
			this.btn_min.TabIndex = 0;
			this.btn_min.Text = "flatMini1";
			this.btn_min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.White;
			this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.btn_close.Font = new System.Drawing.Font("Marlett", 10F);
			this.btn_close.Location = new System.Drawing.Point(510, 11);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(18, 18);
			this.btn_close.TabIndex = 0;
			this.btn_close.Text = "flatClose1";
			this.btn_close.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 480);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Screen";
			this.Text = "Main";
			this.pnl_Header.ResumeLayout(false);
			this.pnl_Header.PerformLayout();
			this.pnl_Body.ResumeLayout(false);
			this.tab_Control.ResumeLayout(false);
			this.tab_Login.ResumeLayout(false);
			this.tab_Login.PerformLayout();
			this.tab_SignIn.ResumeLayout(false);
			this.tab_SignIn.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Panel pnl_Header;
		private FlatUI.FlatTabControl tab_Control;
		private System.Windows.Forms.TabPage tab_Login;
		private System.Windows.Forms.TabPage tab_SignIn;
		private System.Windows.Forms.Panel pnl_Body;
		private FlatUI.FlatMini btn_min;
		private FlatUI.FlatClose btn_close;
		private FlatUI.FlatLabel lbl_Title;
		private iTalk.iTalk_LinkLabel llb_register;
		private FlatUI.FlatButton flatButton1;
		private FlatUI.FlatLabel flatLabel3;
		private FlatUI.FlatLabel flatLabel2;
		private FlatUI.FlatLabel flatLabel1;
		private FlatUI.FlatTextBox txtbox_psswrd;
		private FlatUI.FlatTextBox txtbox_Usrnm;
		private FlatUI.FlatLabel flatLabel4;
		private FlatUI.FlatLabel flatLabel5;
		private FlatUI.FlatTextBox txtbox_lastNames;
		private FlatUI.FlatTextBox txtbox_newName;
		private FlatUI.FlatTextBox txtbox_newID;
		private FlatUI.FlatLabel flatLabel6;
		private FlatUI.FlatTextBox txtbox_newEmail;
		private FlatUI.FlatLabel flatLabel7;
		private FlatUI.FlatTextBox txtbox_newpsswrd;
		private FlatUI.FlatLabel flatLabel8;
		private FlatUI.FlatLabel flatLabel10;
		private FlatUI.FlatTextBox flatTextBox1;
		private FlatUI.FlatLabel flatLabel9;
		private FlatUI.FlatLabel flatLabel11;
		private FlatUI.FlatTextBox txtbox_newTeacherCode;
		private iTalk.iTalk_Label iTalk_Label1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private FlatUI.FlatLabel lbl_NombreAlumno;
		private iTalk.iTalk_ProgressBar iTalk_ProgressBar1;
		}
	}