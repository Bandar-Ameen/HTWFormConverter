namespace winToWeb.control
{
    partial class customefinal
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
            this.continers = new Telerik.WinControls.UI.RadGroupBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.continers)).BeginInit();
            this.SuspendLayout();
            // 
            // continers
            // 
            this.continers.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.continers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.continers.HeaderText = "";
            this.continers.Location = new System.Drawing.Point(0, 0);
            this.continers.Margin = new System.Windows.Forms.Padding(0);
            this.continers.Name = "continers";
            this.continers.Padding = new System.Windows.Forms.Padding(0);
            this.continers.Size = new System.Drawing.Size(150, 150);
            this.continers.TabIndex = 0;
            this.continers.ThemeName = "VisualStudio2012Dark";
            this.continers.Click += new System.EventHandler(this.continers_Click);
            // 
            // customefinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.continers);
            this.Name = "customefinal";
            ((System.ComponentModel.ISupportInitialize)(this.continers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox continers;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
