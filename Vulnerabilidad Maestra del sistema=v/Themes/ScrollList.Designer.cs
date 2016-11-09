namespace VulnerabilidadMaestra.Themes
    {
    partial class ScrollList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.childPanelOptional = new System.Windows.Forms.Panel();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.parentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // childPanelOptional
            // 
            this.childPanelOptional.Enabled = false;
            this.childPanelOptional.Location = new System.Drawing.Point(0, 0);
            this.childPanelOptional.Name = "childPanelOptional";
            this.childPanelOptional.Size = new System.Drawing.Size(221, 480);
            this.childPanelOptional.TabIndex = 0;
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.vScrollBar1);
            this.parentPanel.Controls.Add(this.childPanelOptional);
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(240, 100);
            this.parentPanel.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(221, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 100);
            this.vScrollBar1.TabIndex = 1;
            // 
            // ScrollList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parentPanel);
            this.Name = "ScrollList";
            this.Size = new System.Drawing.Size(240, 103);
            this.parentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel childPanelOptional;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        }
    }
