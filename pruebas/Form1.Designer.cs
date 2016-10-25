namespace pruebas
	{
	partial class SimpleLogin
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
			this.flatClose1 = new FlatUI.FlatClose();
			this.TabControl = new iTalk.iTalk_TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panelWindowHeader = new System.Windows.Forms.Panel();
			this.TabControl.SuspendLayout();
			this.panelWindowHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// flatClose1
			// 
			this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatClose1.BackColor = System.Drawing.Color.White;
			this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
			this.flatClose1.Location = new System.Drawing.Point(254, 10);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 0;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// TabControl
			// 
			this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.TabControl.Controls.Add(this.tabPage1);
			this.TabControl.Controls.Add(this.tabPage2);
			this.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.TabControl.ItemSize = new System.Drawing.Size(44, 135);
			this.TabControl.Location = new System.Drawing.Point(0, 34);
			this.TabControl.Multiline = true;
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(281, 226);
			this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabControl.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tabPage1.Location = new System.Drawing.Point(139, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(138, 218);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tabPage2.Location = new System.Drawing.Point(139, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(138, 218);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// panelWindowHeader
			// 
			this.panelWindowHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.panelWindowHeader.Controls.Add(this.flatClose1);
			this.panelWindowHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelWindowHeader.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panelWindowHeader.Location = new System.Drawing.Point(0, 0);
			this.panelWindowHeader.Name = "panelWindowHeader";
			this.panelWindowHeader.Size = new System.Drawing.Size(284, 37);
			this.panelWindowHeader.TabIndex = 0;
			this.panelWindowHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWindowHeader_Paint);
			// 
			// SimpleLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.panelWindowHeader);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(126, 39);
			this.Name = "SimpleLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "iTalk_ThemeContainer1";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.TabControl.ResumeLayout(false);
			this.panelWindowHeader.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private FlatUI.FlatClose flatClose1;
		private iTalk.iTalk_TabControl TabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panelWindowHeader;
		}
	}

