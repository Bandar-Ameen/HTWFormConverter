using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winToWeb.control;

namespace downloadFile_Demo
{
    public partial class frmMain : Form
    {
        List<DownloadHelper.downloadFile> ldf = new List<DownloadHelper.downloadFile>();

        string uurl = "";
        private List<datafile> don;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(List<datafile> g)
        {
            don = g;
          
            InitializeComponent();
            downloadauto();
        }
        public void downloadauto() {
            foreach (var ii in don)
            {
                int indx = list_Items.Items.Count;

                list_Items.Items.Add(ii.path);
                for (int i = 1; i < 6; i++)
                {
                    list_Items.Items[indx].SubItems.Add("");
                }

                DownloadHelper.downloadFile d = new DownloadHelper.downloadFile(ii.url, ii.path);
                ldf.Add(d);




                Action<int, int, object> act1 = new Action<int, int, object>(delegate (int idx, int sidx, object obj)
                { list_Items.Invoke(new Action(() => list_Items.Items[idx].SubItems[sidx].Text = obj.ToString())); });

                d.eSize += (object s1, long size) => act1.Invoke(indx, 1, size);
                d.eDownloadedSize += (object s1, long size) => act1.Invoke(indx, 2, size);
                d.eSpeed += (object s1, string size) => act1.Invoke(indx, 3, size);
                d.eDownloadState += (object s1, string size) => act1.Invoke(indx, 4, size);
            }
        }
        private void btn_download_Click(object sender, EventArgs e)
        {


            try
            {
                string f = Path.GetDirectoryName(txt_url.Text);
                string extin = Path.GetExtension(txt_url.Text);
                // System.Windows.Forms.MessageBox.Show(extin);
                if (extin.ToLower().Equals(".zip"))
                {
                    ZipFile.ExtractToDirectory(txt_url.Text, f);
                }
                if (extin.ToLower().Equals(".rar"))
                {

                    ZipFile.ExtractToDirectory(txt_url.Text, f);
                }
            }
            catch (Exception ex)
            {
            }
            //File.


            /*   try
               {
                   SaveFileDialog sfd = new SaveFileDialog();
                   if (sfd.ShowDialog() == DialogResult.OK)
                   {
                       int indx = list_Items.Items.Count;
                       list_Items.Items.Add(sfd.FileName);
                       for (int i = 1; i < 6; i++)
                       {
                           list_Items.Items[indx].SubItems.Add("");
                       }

                       DownloadHelper.downloadFile d = new DownloadHelper.downloadFile(txt_url.Text, sfd.FileName);
                       ldf.Add(d);



                       Action<int,int, object> act1 = new Action<int, int, object>(delegate (int idx, int sidx, object obj) 
                                          { list_Items.Invoke(new Action(() => list_Items.Items[idx].SubItems[sidx].Text = obj.ToString())); });

                       d.eSize += (object s1, long size) => act1.Invoke(indx, 1, size);
                       d.eDownloadedSize += (object s1, long size) => act1.Invoke(indx, 2, size);
                       d.eSpeed += (object s1, string size) => act1.Invoke(indx, 3, size);
                       d.eDownloadState += (object s1, string size) => act1.Invoke(indx, 4, size);
                   }
               }
               catch(Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/
        }

        private void list_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Items.SelectedItems.Count > 0)
            {
                var indx = list_Items.SelectedItems[0].Index;
                if (list_Items.Items[indx].SubItems[4].Text == "Downloading")
                {
                    btn_pause.Enabled = true;
                    btn_pause.Text = "Pause";

                }
                else if (list_Items.Items[indx].SubItems[4].Text == "Paused")
                {
                    btn_pause.Enabled = true;
                    btn_pause.Text = "Resume";

                }
                else
                {
                    btn_pause.Enabled = false;
                    btn_pause.Text = "Pause/Resume";
                }
            }
            else
            {
                btn_pause.Enabled = false;
                btn_pause.Text = "Pause/Resume";
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            var indx = list_Items.SelectedItems[0].Index;
            if (btn_pause.Text == "Pause")
            {
                ldf[indx].CancelDownload();
                btn_pause.Text = "Resume";

            }
            else if(btn_pause.Text == "Resume")
            {
                ldf[indx].ResumeDownload();
                btn_pause.Text = "Pause";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
