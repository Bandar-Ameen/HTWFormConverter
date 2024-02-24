namespace winToWeb.control
{
    partial class entery
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDataEntry1 = new Telerik.WinControls.UI.RadDataEntry();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radButton8 = new Telerik.WinControls.UI.RadButton();
            this.radButton7 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsRingWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).BeginInit();
            this.radDataEntry1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(811, 469);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.Controls.Add(this.radGroupBox3);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(2, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(807, 467);
            this.radGroupBox2.TabIndex = 8;
            this.radGroupBox2.ThemeName = "VisualStudio2012Dark";
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.Controls.Add(this.radWaitingBar1);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridView1.Location = new System.Drawing.Point(2, 190);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::winToWeb.Properties.Resources.trash_icon;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.Width = 35;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(803, 275);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.ThemeName = "VisualStudio2012Dark";
            this.radGridView1.SelectionChanged += new System.EventHandler(this.radGridView1_SelectionChanged);
            this.radGridView1.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.radGridView1_CommandCellClick);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.radDataEntry1);
            this.radGroupBox3.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox3.HeaderText = "";
            this.radGroupBox3.Location = new System.Drawing.Point(2, 0);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.radGroupBox3.Size = new System.Drawing.Size(803, 190);
            this.radGroupBox3.TabIndex = 6;
            this.radGroupBox3.ThemeName = "VisualStudio2012Dark";
            // 
            // radDataEntry1
            // 
            this.radDataEntry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDataEntry1.FitToParentWidth = true;
            this.radDataEntry1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.radDataEntry1.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.radDataEntry1.ItemDefaultSize = new System.Drawing.Size(460, 25);
            this.radDataEntry1.ItemSpace = 10;
            this.radDataEntry1.Location = new System.Drawing.Point(2, 44);
            this.radDataEntry1.Name = "radDataEntry1";
            // 
            // radDataEntry1.PanelContainer
            // 
            this.radDataEntry1.PanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radDataEntry1.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radDataEntry1.PanelContainer.Size = new System.Drawing.Size(797, 142);
            this.radDataEntry1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radDataEntry1.Size = new System.Drawing.Size(799, 144);
            this.radDataEntry1.TabIndex = 7;
            this.radDataEntry1.ThemeName = "VisualStudio2012Dark";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.radButton8);
            this.flowLayoutPanel1.Controls.Add(this.radButton7);
            this.flowLayoutPanel1.Controls.Add(this.radButton1);
            this.flowLayoutPanel1.Controls.Add(this.radButton2);
            this.flowLayoutPanel1.Controls.Add(this.radButton4);
            this.flowLayoutPanel1.Controls.Add(this.radButton3);
            this.flowLayoutPanel1.Controls.Add(this.radButton5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 44);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // radButton8
            // 
            this.radButton8.AutoSize = true;
            this.radButton8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton8.Image = global::winToWeb.Properties.Resources.button_round_plus_icon;
            this.radButton8.Location = new System.Drawing.Point(760, 3);
            this.radButton8.Name = "radButton8";
            this.radButton8.Size = new System.Drawing.Size(34, 34);
            this.radButton8.TabIndex = 9;
            this.radButton8.Text = "f00";
            this.radButton8.ThemeName = "VisualStudio2012Dark";
            this.radButton8.Click += new System.EventHandler(this.commandBarButton1_Click);
            // 
            // radButton7
            // 
            this.radButton7.AutoSize = true;
            this.radButton7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton7.Enabled = false;
            this.radButton7.Image = global::winToWeb.Properties.Resources.floppy_save_icon__1_;
            this.radButton7.Location = new System.Drawing.Point(720, 3);
            this.radButton7.Name = "radButton7";
            this.radButton7.Size = new System.Drawing.Size(34, 34);
            this.radButton7.TabIndex = 10;
            this.radButton7.Text = "f00";
            this.radButton7.ThemeName = "VisualStudio2012Dark";
            this.radButton7.Click += new System.EventHandler(this.radButton7_Click);
            // 
            // radButton1
            // 
            this.radButton1.AutoSize = true;
            this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton1.Image = global::winToWeb.Properties.Resources.button_round_fast_forward_icon;
            this.radButton1.Location = new System.Drawing.Point(680, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(34, 34);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "f00";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // radButton2
            // 
            this.radButton2.AutoSize = true;
            this.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton2.Image = global::winToWeb.Properties.Resources.button_round_arrow_right_icon;
            this.radButton2.Location = new System.Drawing.Point(640, 3);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(34, 34);
            this.radButton2.TabIndex = 6;
            this.radButton2.Text = "f00";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton4
            // 
            this.radButton4.AutoSize = true;
            this.radButton4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton4.Image = global::winToWeb.Properties.Resources.button_round_arrow_left_icon;
            this.radButton4.Location = new System.Drawing.Point(600, 3);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(34, 34);
            this.radButton4.TabIndex = 7;
            this.radButton4.Text = "f00";
            this.radButton4.ThemeName = "VisualStudio2012Dark";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // radButton3
            // 
            this.radButton3.AutoSize = true;
            this.radButton3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton3.Image = global::winToWeb.Properties.Resources.button_round_fast_backward_icon;
            this.radButton3.Location = new System.Drawing.Point(560, 3);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(34, 34);
            this.radButton3.TabIndex = 8;
            this.radButton3.Text = "f00";
            this.radButton3.ThemeName = "VisualStudio2012Dark";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton5
            // 
            this.radButton5.AutoSize = true;
            this.radButton5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton5.Image = global::winToWeb.Properties.Resources.button_round_reload_icon;
            this.radButton5.Location = new System.Drawing.Point(520, 3);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(34, 34);
            this.radButton5.TabIndex = 12;
            this.radButton5.Text = "f00";
            this.radButton5.ThemeName = "VisualStudio2012Dark";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.AssociatedControl = this.radGroupBox1;
            this.radWaitingBar1.Location = new System.Drawing.Point(243, 88);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(70, 70);
            this.radWaitingBar1.TabIndex = 2;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "VisualStudio2012Dark";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsRingWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 50;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsRing;
            // 
            // dotsRingWaitingBarIndicatorElement1
            // 
            this.dotsRingWaitingBarIndicatorElement1.Name = "dotsRingWaitingBarIndicatorElement1";
            // 
            // entery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "entery";
            this.Size = new System.Drawing.Size(811, 469);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            this.radGridView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).EndInit();
            this.radDataEntry1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadDataEntry radDataEntry1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton radButton8;
        private Telerik.WinControls.UI.RadButton radButton7;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.DotsRingWaitingBarIndicatorElement dotsRingWaitingBarIndicatorElement1;
    }
}
