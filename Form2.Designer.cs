namespace winToWeb
{
    partial class Form2
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dotsSpinnerWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement();
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radPdfViewer1);
            this.radGroupBox1.Controls.Add(this.radWaitingBar1);
            this.radGroupBox1.Controls.Add(this.webBrowser1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.ForeColor = System.Drawing.Color.White;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(733, 261);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.AssociatedControl = this.webBrowser1;
            this.radWaitingBar1.Location = new System.Drawing.Point(245, 129);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(70, 70);
            this.radWaitingBar1.TabIndex = 1;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "VisualStudio2012Dark";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsSpinnerWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 100;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(729, 241);
            this.webBrowser1.TabIndex = 0;
            // 
            // dotsSpinnerWaitingBarIndicatorElement1
            // 
            this.dotsSpinnerWaitingBarIndicatorElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dotsSpinnerWaitingBarIndicatorElement1.Name = "dotsSpinnerWaitingBarIndicatorElement1";
            this.dotsSpinnerWaitingBarIndicatorElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dotsSpinnerWaitingBarIndicatorElement1.UseCompatibleTextRendering = false;
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Location = new System.Drawing.Point(-19, -44);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(200, 200);
            this.radPdfViewer1.TabIndex = 2;
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 261);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Form2";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form2";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement dotsSpinnerWaitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
    }
}