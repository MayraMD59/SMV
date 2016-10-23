namespace pruebas.PruebasVentanas
{
	partial class Alumnos
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
			this.flatMini1 = new FlatUI.FlatMini();
			this.flatMax1 = new FlatUI.FlatMax();
			this.flatClose1 = new FlatUI.FlatClose();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flatContextMenuStrip1 = new FlatUI.FlatContextMenuStrip();
			this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formSkin1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flatContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// formSkin1
			// 
			this.formSkin1.BackColor = System.Drawing.Color.White;
			this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
			this.formSkin1.Controls.Add(this.pictureBox1);
			this.formSkin1.Controls.Add(this.flatClose1);
			this.formSkin1.Controls.Add(this.flatMax1);
			this.formSkin1.Controls.Add(this.flatMini1);
			this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new System.Drawing.Point(0, 0);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new System.Drawing.Size(768, 505);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "formSkin1";
			// 
			// flatMini1
			// 
			this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatMini1.BackColor = System.Drawing.Color.White;
			this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
			this.flatMini1.Location = new System.Drawing.Point(685, 13);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 0;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// flatMax1
			// 
			this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatMax1.BackColor = System.Drawing.Color.White;
			this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
			this.flatMax1.Location = new System.Drawing.Point(710, 12);
			this.flatMax1.Name = "flatMax1";
			this.flatMax1.Size = new System.Drawing.Size(18, 18);
			this.flatMax1.TabIndex = 1;
			this.flatMax1.Text = "flatMax1";
			this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// flatClose1
			// 
			this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatClose1.BackColor = System.Drawing.Color.White;
			this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
			this.flatClose1.Location = new System.Drawing.Point(747, 0);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 2;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(28, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// flatContextMenuStrip1
			// 
			this.flatContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatContextMenuStrip1.ForeColor = System.Drawing.Color.White;
			this.flatContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.listaGruposToolStripMenuItem});
			this.flatContextMenuStrip1.Name = "flatContextMenuStrip1";
			this.flatContextMenuStrip1.ShowImageMargin = false;
			this.flatContextMenuStrip1.Size = new System.Drawing.Size(111, 48);
			// 
			// alumnosToolStripMenuItem
			// 
			this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
			this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.alumnosToolStripMenuItem.Text = "Alumnos";
			// 
			// listaGruposToolStripMenuItem
			// 
			this.listaGruposToolStripMenuItem.Name = "listaGruposToolStripMenuItem";
			this.listaGruposToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.listaGruposToolStripMenuItem.Text = "ListaGrupos";
			// 
			// Alumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 505);
			this.Controls.Add(this.formSkin1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(126, 39);
			this.Name = "Alumnos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "iTalk_ThemeContainer1";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.formSkin1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flatContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FlatUI.FormSkin formSkin1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private FlatUI.FlatClose flatClose1;
		private FlatUI.FlatMax flatMax1;
		private FlatUI.FlatMini flatMini1;
		private FlatUI.FlatContextMenuStrip flatContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listaGruposToolStripMenuItem;
	}
}