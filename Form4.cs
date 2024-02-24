using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;

namespace winToWeb
{
    [PermissionSet(SecurityAction.LinkDemand,Name ="FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Form4 : RadForm, RecevDataFromWeb
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void shometh()
        {

            try
            {
                var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\tem.txt");
                // var vvv = new cutest();
                var con = new webproser(alldat, true,this);
                con.Dock = DockStyle.Fill;
                this.Controls.Add(con);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }
        private async void Form4_Load(object sender, EventArgs e)
        {
            /* var laod = new ConnectecedWithmain_ss(radPageView1);
             await laod.load();*/

            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\tem.txt");
            // var vvv = new cutest();
     /*  var k=     await Task.Run(() =>
            {
                var con = new webproser(alldat, true);
                con.Dock = DockStyle.Fill;
                return con;
            });*/
          /*  var con = new webproser(alldat, true,false,this);
            con.Dock = DockStyle.Fill;
            // await con.webproserv(alldat, true);
            this.Controls.Add(con);
            await con.LoadAsyinc();*/
          
            
            // this.Controls.Add(t);

            /* var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\te.html");
            var ger= System.IO.Path.GetTempPath();
             var newguid = ger+@""+Guid.NewGuid().ToString()+".html";
             File.WriteAllText(newguid,alldat);
          var    urllk = "file:///" + newguid.Replace(@"\", "/");
             //  Clipboard.SetText(newguid);
             //MessageBox.Show(ger);
             webBrowser1.ScriptErrorsSuppressed = true;
             webBrowser1.IsWebBrowserContextMenuEnabled = false;
             webBrowser1.AllowWebBrowserDrop = true;*/
            //   webBrowser1.Navigate(,);.ObjectForScripting = new jsScripting();
            // webBrowser1.DocumentText = alldat;
            /*  webBrowser1.Navigate("about:blank");
              webBrowser1.Document.OpenNew(false);
              webBrowser1.Document.Write(alldat);
              webBrowser1.Refresh();*/
            // var f = new Uri("");
            /*  Uri u = new Uri(urllk);
               webBrowser1.Navigate(u);
               try
               {
                 //  File.Delete(newguid);
               }
               catch (Exception ex) {

                   MessageBox.Show(ex.Message);
               }*/
            //  u.

            //Uri u = new Uri(@"C:\Users\Mypc\Documents\Winforms.Plugins\Winforms.Plugins\Winforms.Plugins.Host\bin\Debug\starter.html");
            // webBrowser1.DocumentText = "<h1>ffffff</h1>";// =u ;
            //  webBrowser1.Url = u;//"file:///C:/Users/Mypc/Documents";
            // webBrowser1.DocumentStream = alldat;// =u ;
            //webBrowser1.AllowNavigation = true;


        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        public void ReceveFroms(object anotherData)
        {
            
        }

        public async void ReceivOpenForm(string Pagename, string TageName, string pageTitle, object anotherData, string showAsDailoge)
        {
            try {
                var res = JsonConvert.DeserializeObject<eventOpenFrom>(anotherData.ToString());
                var q = JsonConvert.DeserializeObject<webproser.getalertv>(res.Name_Form.ToString());
                if (q.Type_Event.Equals("1"))
                {
                   /* var laod = new Astoldesinger.Class.ConnectecedWithmain_ss(GORS.Instance.OpenForm.GetRadPageView());
                    await laod.load();*/
                }
                else
                {
                  //  Astoldesinger.Class.GetFormFromIDScreen vvb = new Astoldesinger.Class.GetFormFromIDScreen();

                    // RadForm child = await vvb.shoeformm("37", 0);
                 /*   RadForm child = await vvb.shoeformm(q.formname, 0);

                    GORS.Instance.OpenForm.ReceivOpenForm(child, q.Page_name, q.Tage_name, q.Title_name, anotherData, q.tyeForm.ToString());
                   */
                    //  myform1 k = new myform1();
                    // GORS.Instance.OpenForm.ReceveFroms(child, anotherData);
                }
            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ReceivAnotherData(string Pagename, string TageName, string pageTitle, string showAsDailoge, object[] another)
        {
          
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            GORS.Instance.Date_typ = 1;
            GORS.Instance.Date_fromate = "yyyy-dd-MM";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
            var t = new customefinal(alldat, this);
            t.Dock = DockStyle.Fill;
            var ex = await t.inithh.loadForm();
            ex.Show();
        }
    }
}
