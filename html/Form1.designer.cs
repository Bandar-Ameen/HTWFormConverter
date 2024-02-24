namespace downloadFile_Demo
{
    partial class frmMain
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
            this.btn_download = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.list_Items = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloaded_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.download_speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.Location = new System.Drawing.Point(476, 10);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 23);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Location = new System.Drawing.Point(12, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(351, 20);
            this.txt_url.TabIndex = 1;
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pause.Enabled = false;
            this.btn_pause.Location = new System.Drawing.Point(369, 10);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(101, 23);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause/Resume";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // list_Items
            // 
            this.list_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.total_length,
            this.downloaded_length,
            this.download_speed,
            this.status,
            this.url});
            this.list_Items.FullRowSelect = true;
            this.list_Items.GridLines = true;
            this.list_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_Items.HideSelection = false;
            this.list_Items.Location = new System.Drawing.Point(12, 74);
            this.list_Items.Name = "list_Items";
            this.list_Items.Size = new System.Drawing.Size(539, 276);
            this.list_Items.TabIndex = 4;
            this.list_Items.UseCompatibleStateImageBehavior = false;
            this.list_Items.View = System.Windows.Forms.View.Details;
            this.list_Items.SelectedIndexChanged += new System.EventHandler(this.list_Items_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "File Name";
            this.name.Width = 90;
            // 
            // total_length
            // 
            this.total_length.Text = "Total Length";
            this.total_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total_length.Width = 80;
            // 
            // downloaded_length
            // 
            this.downloaded_length.Text = "Downloaded Length";
            this.downloaded_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.downloaded_length.Width = 120;
            // 
            // download_speed
            // 
            this.download_speed.Text = "Download Speed";
            this.download_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.download_speed.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 80;
            // 
            // url
            // 
            this.url.Text = "Url";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 361);
            this.Controls.Add(this.list_Items);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_download);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "downloadFile Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.ListView list_Items;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader total_length;
        private System.Windows.Forms.ColumnHeader downloaded_length;
        private System.Windows.Forms.ColumnHeader download_speed;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader url;
    }
}

