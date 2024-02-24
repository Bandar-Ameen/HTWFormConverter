namespace winToWeb
{
    partial class contentAlertMessaage
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radcon1 = new winToWeb.html.Radcon();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radcon1);
            this.radGroupBox1.Controls.Add(this.radTitleBar1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(150, 150);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(2, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(146, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.ThemeName = "VisualStudio2012Dark";
            this.radTitleBar1.Click += new System.EventHandler(this.radTitleBar1_Click);
            // 
            // radcon1
            // 
            this.radcon1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radcon1.AutoScrollMinSize = new System.Drawing.Size(146, 85);
            this.radcon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radcon1.FooterTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radcon1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radcon1.HeaderText = "";
            this.radcon1.Location = new System.Drawing.Point(2, 23);
            this.radcon1.Name = "radcon1";
            this.radcon1.Size = new System.Drawing.Size(146, 125);
            this.radcon1.TabIndex = 1;
            this.radcon1.Tex = "<h1 style=\"color:red;\">fffff</h1>";
            this.radcon1.ThemeName = "VisualStudio2012Dark";
            // 
            // contentAlertMessaage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "contentAlertMessaage";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radcon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private html.Radcon radcon1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
