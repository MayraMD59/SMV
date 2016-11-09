namespace VulnerabilidadMaestra
	{
	partial class tabHelper
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
			this.formSkin1 = new FlatUI.FormSkin();
			this.flatClose1 = new FlatUI.FlatClose();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.formSkin1.SuspendLayout();
			this.SuspendLayout();
			// 
			// formSkin1
			// 
			this.formSkin1.BackColor = System.Drawing.Color.White;
			this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
			this.formSkin1.Controls.Add(this.flatClose1);
			this.formSkin1.Controls.Add(this.listBox1);
			this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new System.Drawing.Point(0, 0);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new System.Drawing.Size(284, 261);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "formSkin1";
			// 
			// flatClose1
			// 
			this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatClose1.BackColor = System.Drawing.Color.White;
			this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
			this.flatClose1.Location = new System.Drawing.Point(254, 12);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 2;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click_1);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.Teal;
			this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Items.AddRange(new object[] {
            "IniciioSesion",
            "Registro",
            "VPEstudiante",
            "VMaestro",
            "CEstudiante",
            "CMaestro",
            "CrearCursoMaestro",
            "ListaDeCursosMaestro"});
			this.listBox1.Location = new System.Drawing.Point(35, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(207, 157);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// tabHelper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.formSkin1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "tabHelper";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tabHelper";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.formSkin1.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		public FlatUI.FormSkin formSkin1;
		public System.Windows.Forms.ListBox listBox1;
		public FlatUI.FlatClose flatClose1;
		}
	}