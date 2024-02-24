using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb
{
    public partial class Form2 : RadForm, RecevDataFromWeb
    {
        private string url;
        public Form2(string  url)
        {
            this.url = url;
            InitializeComponent();
            GORS.Instance.RecivDataFromWebs = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.ObjectForScripting = new jsScripting();
            loadfir();
        }
        public void ReceveFroms(object anotherData)
        {
            var res = JsonConvert.DeserializeObject<eventOpenFrom>(anotherData.ToString());
            if (res.Event_Type.Equals("Open_Form"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    myform1 k = new myform1();
                    GORS.Instance.OpenForm.ReceveFroms(k, anotherData);
                }
                else
                {
                    MessageBox.Show("ffffffffffff");
                }

            }
            if (res.Event_Type.Equals("Open_Formt"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    myform1 k = new myform1();
                    k.Text = "dddddddddd";
                    GORS.Instance.OpenForm.ReceveFroms(k, anotherData);
                }
                else
                {
                    MessageBox.Show("ffffffffffff");
                }

            }
            if (res.Event_Type.Equals("Change_Them_Dark"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    GORS.Instance.OpenForm.changeThem("Dark");
                }

            }

            if (res.Event_Type.Equals("Change_Them_Light"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    GORS.Instance.OpenForm.changeThem("Liget");
                }

            }
        }
        public void loadfir()
        {

            radWaitingBar1.StartWaiting();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.AllowWebBrowserDrop = true;
            webBrowser1.Refresh();
            webBrowser1.DocumentCompleted += oncomplat;
            // webBrowser1.ScrollBarsEnabled = false;
            //  MessageBox.Show(ssd);
            Uri u = new Uri(this.url);//@"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\starter.html");

            webBrowser1.Url = u;
        }
        public void oncomplat(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {

                radWaitingBar1.StopWaiting();

            }

        }

        public void ReceivOpenForm(string Pagename, string TageName, string pageTitle, object anotherData, string showAsDailoge)
        {
            throw new NotImplementedException();
        }

        public void ReceivAnotherData(string Pagename, string TageName, string pageTitle, string showAsDailoge, object[] another)
        {
            throw new NotImplementedException();
        }
    }
}
