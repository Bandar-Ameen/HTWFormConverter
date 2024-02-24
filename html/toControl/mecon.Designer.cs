namespace winToWeb.html.toControl
{
    partial class mecon
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radcon1 = new winToWeb.html.Radcon();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(161, 12);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(435, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.Text = "<div><div> <h1>ffffff</h1></div></div>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radcon1);
            this.groupBox1.Location = new System.Drawing.Point(80, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radcon1
            // 
            this.radcon1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radcon1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.radcon1.HeaderText = "<h1>hhhhhh</h1>";
            this.radcon1.Location = new System.Drawing.Point(74, 61);
            this.radcon1.Name = "radcon1";
            this.radcon1.Size = new System.Drawing.Size(272, 81);
            this.radcon1.TabIndex = 0;
            this.radcon1.Text = "<h1>hhhhhh</h1>";
            // 
            // mecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radTextBox1);
            this.Name = "mecon";
            this.Text = "mecon";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Radcon radcon1;
    }
}