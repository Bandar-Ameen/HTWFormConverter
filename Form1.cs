using dynFormLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;

namespace winToWeb
{
    public partial class Form1 : RadForm, RecevDataFromWeb
    {
        public Form1()
        {
            InitializeComponent();
            GORS.Instance.RecivDataFromWebs = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string cc = Assembly.GetExecutingAssembly().Location;
            //var ssd = "file:///"+Path.GetDirectoryName(cc) + @"\index.html";
            // FileStream kk = new FileStream(ssd,FileMode.Open,FileAccess.Read);
          
        }
        public void loadfir()
        {

            radWaitingBar1.StartWaiting();
            webBrowser1.ScriptErrorsSuppressed = true;
        // webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.AllowWebBrowserDrop = true;
            webBrowser1.Refresh();
            webBrowser1.DocumentCompleted += oncomplat;
            // webBrowser1.ScrollBarsEnabled = false;
            //  MessageBox.Show(ssd);
            Uri u = new Uri(@"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\starter.html");
            //Uri u = new Uri(@"C:\Users\Mypc\Documents\Winforms.Plugins\Winforms.Plugins\Winforms.Plugins.Host\bin\Debug\starter.html");
            webBrowser1.Url = u;
        }
        public void oncomplat(object sender,WebBrowserDocumentCompletedEventArgs e) {

            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete) {

                radWaitingBar1.StopWaiting();

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            // child.st = FormWindowState.Maximized;
        
            //  var psa = new RadPageViewPage();
           
            this.Dock = DockStyle.Fill;
            var eve = new jsScripting();
           
            eve.EventArrived += ReceveFroms;
            webBrowser1.ObjectForScripting = eve;
            loadfir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // webBrowser1.Document.InvokeScript(textBox1.Text);
        }
        public class getalertv
        {

            public string formname { get; set; }
            public int tyeForm { get; set; }
      

        }
        public class getalert {

            public string A_html { get; set; }
            public int width { get; set; }
            public int hi { get; set; }
            public int dey { get; set; }
            public int auto { get; set; }
            public AlertScreenPosition location { get; set; }

        }
        public class readJSCSS {

            public string htmll { get; set; }

            public string csss { get; set; }

            public string jss { get; set; }

            public string methodLoad { get; set; }
        }
        public string[] getfold(string Filename, string typefolder)
        {

            string[] zz = new string[2];
            string fouldernanmee = "/fileDeshin/" + typefolder.Replace(".", "");
            string cc = Assembly.GetExecutingAssembly().Location;

            var ssd = Path.GetDirectoryName(cc);
           
            if (!Directory.Exists(ssd))
            {

                Directory.CreateDirectory(ssd);
            }
            string fillnamess = ssd + "/" + Filename;
            if (!File.Exists(fillnamess))
            {
                zz[0] = "0";
                zz[1] = fillnamess;
            }
            else
            {

                zz[0] = "1";
                zz[1] = fillnamess;
            }

            return zz;
        }
        public string[] getfoldd(string Filename, string typefolder)
        {

            string[] zz = new string[2];
            string fouldernanmee = "/fileDeshin/" + typefolder.Replace(".", "");
            string cc = Assembly.GetExecutingAssembly().Location;

            var ssd = Path.GetDirectoryName(cc)+ fouldernanmee;

            if (!Directory.Exists(ssd))
            {

                Directory.CreateDirectory(ssd);
            }
            string fillnamess = ssd;
            if (!File.Exists(fillnamess))
            {
                zz[0] = "0";
                zz[1] = fillnamess;
            }
            else
            {

                zz[0] = "1";
                zz[1] = fillnamess;
            }

            return zz;
        }
        public string getHtmll(string url)
        {

            var ge = url.Split('#');
            var zzza = getfold(ge[1] + ".txt", ".txt");
            var getdat = File.ReadAllText(zzza[1]);

            return getdat;



        }

   public void CreateJS(string jsd)
        {
            var q =webBrowser1.Document.GetElementById("mm");
            try
            {
                var ss = q.GetElementsByTagName("script")[0];
                if (ss == null)
                {
                    var ff = webBrowser1.Document.CreateElement("script");
                    //var inlinscx = webBrowser1.Document.CreateElement(jsd);

                    ff.InnerText = jsd;
                    q.AppendChild(ff);
                }
                else
                {
                   // var inlinscxx = webBrowser1.Document.CreateElement(jsd);
                    ss.InnerText=jsd;

                }
            }
            catch (Exception ex) {
                var ff = webBrowser1.Document.CreateElement("script");
                //  var inlinscx = webBrowser1.Document.CreateElement(jsd);
                ff.InnerText = jsd;
                // ff.AppendChild(inlinscx);
                q.AppendChild(ff);
            }

        }

        public void CreateCSS(string jsd)
        {
            var q = webBrowser1.Document.GetElementById("mm");
            try
            {
                var ss = q.GetElementsByTagName("style")[0];
                if (ss == null)
                {
                    var ff = webBrowser1.Document.CreateElement("style");
                    //  var inlinscx = webBrowser1.Document.CreateElement(jsd);
                    ff.InnerText = jsd;
                    // ff.AppendChild(inlinscx);
                    q.AppendChild(ff);
                }
                else
                {
                    // var inlinscxx = webBrowser1.Document.CreateElement(jsd);
                    ss.InnerText = jsd;
                    // ss.AppendChild(inlinscxx);

                }
            }
            catch (Exception ex) {
                var ff = webBrowser1.Document.CreateElement("style");
                // var inlinscx = webBrowser1.Document.CreateElement(jsd);
                ff.InnerText = jsd;
                //ff.AppendChild(inlinscx);
                q.AppendChild(ff);
            }

        }
        //public class datshow : RecevDataFromWeb
        //{
        //    string allcon;
        //    RadForm ra;





        //    string them;
        //    public datshow(string allcon, string them)
        //    {
        //        this.allcon = allcon;
        //        this.them = them;
        //    }
        //    public void ReceveFroms(object anotherData)
        //    {
        //        var ii = anotherData as Eventhtml;

        //        if (ii != null)
        //        {

        //            foreach (var iu in ii.EventControl)
        //            {

        //                try
        //                {
        //                    var b = ra.Controls.Find(iu.controlname, true)[0];

        //                    if (iu.controlEventname.ToLower().StartsWith("ena"))
        //                    {
        //                        b.Enabled = true;
        //                    }
        //                    if (iu.controlEventname.ToLower().StartsWith("dis"))
        //                    {
        //                        b.Enabled = false;
        //                    }
        //                    if (iu.controlEventname.ToLower().StartsWith("read"))
        //                    {
        //                        var h = b as RadMaskedEditBox;
        //                        if (h != null)
        //                        {
        //                            h.ReadOnly = true;
        //                        }
        //                        var hh = b as RadDateTimePicker;
        //                        if (hh != null)
        //                        {
        //                            hh.ReadOnly = true;
        //                        }
        //                        var hhx = b as RadCheckBox;
        //                        if (hhx != null)
        //                        {
        //                            hhx.ReadOnly = true;
        //                        }
        //                    }

        //                    if (iu.controlEventname.ToLower().StartsWith("notread"))
        //                    {

        //                        var h = b as RadMaskedEditBox;
        //                        if (h != null)
        //                        {
        //                            h.ReadOnly = false;
        //                        }
        //                        var hh = b as RadDateTimePicker;
        //                        if (hh != null)
        //                        {
        //                            hh.ReadOnly = false;
        //                        }
        //                        var hhx = b as RadCheckBox;
        //                        if (hhx != null)
        //                        {
        //                            hhx.ReadOnly = false;
        //                        }
        //                    }
        //                    if (iu.controlEventname.ToLower().StartsWith("cle"))
        //                    {
        //                        b.Text = "";
        //                    }
        //                    if (iu.controlEventname.ToLower().StartsWith("hid"))
        //                    {
        //                        b.Visible = false;
        //                    }
        //                    if (iu.controlEventname.ToLower().StartsWith("show"))
        //                    {
        //                        b.Visible = true;
        //                    }
        //                    // MessageBox.Show(anotherData.ToString());
        //                }
        //                catch (Exception ex)
        //                {


        //                }
        //            }
        //        }

        //        var jjj = anotherData as EventOnchange;
        //        if (jjj != null)
        //        {

        //            foreach (var iu in jjj.datahtml.EventControl)
        //            {

        //                try
        //                {
        //                    var b = ra.Controls.Find(iu.controlname, true)[0];
        //                    var er = iu.controlEventname.Split('#');
        //                    if (er[1].ToLower().StartsWith("ena"))
        //                    {
        //                        b.Enabled = true;
        //                    }
        //                    if (er[1].ToLower().StartsWith("dis"))
        //                    {
        //                        b.Enabled = false;
        //                    }
        //                    if (er[1].ToLower().StartsWith("cle"))
        //                    {
        //                        b.Text = "";
        //                    }
        //                    if (er[1].ToLower().StartsWith("hid"))
        //                    {
        //                        b.Visible = false;
        //                    }
        //                    if (er[1].ToLower().StartsWith("read"))
        //                    {
        //                        var h = b as RadMaskedEditBox;
        //                        if (h != null)
        //                        {
        //                            h.ReadOnly = true;
        //                        }
        //                        var hh = b as RadDateTimePicker;
        //                        if (hh != null)
        //                        {
        //                            hh.ReadOnly = true;
        //                        }
        //                        var hhx = b as RadCheckBox;
        //                        if (hhx != null)
        //                        {
        //                            hhx.ReadOnly = true;
        //                        }
        //                    }

        //                    if (er[1].ToLower().StartsWith("notread"))
        //                    {

        //                        var h = b as RadMaskedEditBox;
        //                        if (h != null)
        //                        {
        //                            h.ReadOnly = false;
        //                        }
        //                        var hh = b as RadDateTimePicker;
        //                        if (hh != null)
        //                        {
        //                            hh.ReadOnly = false;
        //                        }
        //                        var hhx = b as RadCheckBox;
        //                        if (hhx != null)
        //                        {
        //                            hhx.ReadOnly = false;
        //                        }
        //                    }
        //                    if (er[1].ToLower().StartsWith("show"))
        //                    {
        //                        b.Visible = true;
        //                    }
        //                    if (er[1].ToLower().StartsWith("set"))
        //                    {
        //                        bool ch = false;
        //                        var gg = b as RadCheckBox;
        //                        var hj = b as RadDateTimePicker;
        //                        if (gg != null)
        //                        {
        //                            ch = true;
        //                            try
        //                            {
        //                                var j = (bool)jjj.columnvalue.SelectToken(er[0]);
        //                                gg.Checked = j;
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                var f = jjj.columnvalue.SelectToken(er[0]).ToString();

        //                                if (f.ToLower().StartsWith("1"))
        //                                {
        //                                    gg.Checked = true;
        //                                }
        //                                else
        //                                {
        //                                    gg.Checked = false;
        //                                }

        //                            }
        //                        }

        //                        if (hj != null)
        //                        {
        //                            ch = true;
        //                            try
        //                            {
        //                                var j = (DateTime)jjj.columnvalue.SelectToken(er[0]);
        //                                hj.Value = j;
        //                            }
        //                            catch (Exception ex)
        //                            {


        //                            }
        //                        }
        //                        if (!ch)
        //                        {
        //                            var datresu = jjj.columnvalue.SelectToken(er[0]).ToString();

        //                            b.Text = datresu;
        //                        }
        //                    }
        //                    // MessageBox.Show(anotherData.ToString());
        //                }
        //                catch (Exception ex)
        //                {


        //                }
        //            }
        //        }

        //    }

        //    private void testForm_FormClosing(object sender, FormClosingEventArgs e)
        //    {
        //        if (e.CloseReason == CloseReason.UserClosing)
        //        {
        //            e.Cancel = true;
        //            ra.Hide();
        //        }
        //    }
        //    public async void show()
        //    {

        //        ra = new RadForm();
        //        ra.FormClosing += testForm_FormClosing;
        //        ra.ThemeName = them;
        //      //  GORS.Instance.System_seting_main = them;
        //        if (ra.InvokeRequired)
        //        {
        //            ra.Invoke(new MethodInvoker(async() =>
        //            {
        //                List<Eventhtml> ghh = new List<Eventhtml>();
        //                HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
        //                gg.LoadHtml(allcon);
        //                try
        //                {
        //                    var re = gg.DocumentNode.Descendants("event");

        //                    foreach (var ik in re.ElementAt(0).Descendants("event"))
        //                    {
        //                        Eventhtml k = new Eventhtml();
        //                        string name = "0";
        //                        Dictionary<string, object> io = new Dictionary<string, object>();
        //                        foreach (var yy in ik.Attributes)
        //                        {
        //                            if (yy.Name.Equals("id"))
        //                            {
        //                                name = yy.Value;
        //                            }
        //                            io.Add(yy.Name, yy.Value);

        //                        }
        //                        k.attEvent = io;
        //                        k.eventName = name;
        //                        k.DataEvent = ik.InnerText;
        //                        ghh.Add(k);

        //                    }
        //                    MessageBox.Show(JsonConvert.SerializeObject(ghh));
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //                var j = new List<ControlInfo>();
        //                Radconverttojson f = new Radconverttojson(ghh);
        //                var getrs =await f.ActualizarMenus(gg.DocumentNode);
        //                var all = getrs.control;
        //                ra.Controls.Add(all);
        //                GORS.Instance.RecivDataFromWebs = this;
        //                ra.Show();
        //            }));
        //        }
        //        else
        //        {
        //            HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
        //            List<Eventhtml> ghh = new List<Eventhtml>();
        //            gg.LoadHtml(allcon);
        //            try
        //            {
        //                var re = gg.DocumentNode.Descendants("event");

        //                foreach (var ik in re.ElementAt(0).Descendants("event"))
        //                {
        //                    Eventhtml k = new Eventhtml();
        //                    string name = "0";
        //                    Dictionary<string, object> io = new Dictionary<string, object>();
        //                    foreach (var yy in ik.Attributes)
        //                    {
        //                        if (yy.Name.Equals("id"))
        //                        {
        //                            name = yy.Value;
        //                        }
        //                        io.Add(yy.Name, yy.Value);

        //                    }
        //                    k.attEvent = io;
        //                    k.eventName = name;
        //                    k.DataEvent = ik.InnerText;
        //                    ghh.Add(k);

        //                }

        //            }
        //            catch (Exception ex)
        //            {

        //            }
        //            var j = new List<ControlInfo>();
        //            Radconverttojson f = new Radconverttojson(ghh);
        //            var getrs =await f.ActualizarMenus(gg.DocumentNode);
        //            var all = getrs.control;
        //            ra.Controls.Add(all);
        //            GORS.Instance.RecivDataFromWebs = this;
        //            ra.Show();

        //        }
        //    }

        //    public async Task<RadForm> radfrom()
        //    {

        //        ra = new RadForm();
        //        ra.FormClosing += testForm_FormClosing;
        //        ra.ThemeName = them;
        //        //GORS.Instance.System_seting_main = them;
        //        if (ra.InvokeRequired)
        //        {
        //            ra.Invoke(new MethodInvoker(async() =>
        //            {
        //                List<Eventhtml> ghh = new List<Eventhtml>();
        //                HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
        //                gg.LoadHtml(allcon);
        //                try
        //                {
        //                    var re = gg.DocumentNode.Descendants("event");

        //                    foreach (var ik in re.ElementAt(0).Descendants("event"))
        //                    {
        //                        Eventhtml k = new Eventhtml();
        //                        string name = "0";
        //                        Dictionary<string, object> io = new Dictionary<string, object>();
        //                        foreach (var yy in ik.Attributes)
        //                        {
        //                            if (yy.Name.Equals("id"))
        //                            {
        //                                name = yy.Value;
        //                            }
        //                            io.Add(yy.Name, yy.Value);

        //                        }
        //                        k.attEvent = io;
        //                        k.eventName = name;
        //                        k.DataEvent = ik.InnerText;
        //                        ghh.Add(k);

        //                    }
                           
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //                var j = new List<ControlInfo>();
        //                Radconverttojson f = new Radconverttojson(ghh);
        //                var getrs =await f.ActualizarMenus(gg.DocumentNode);
        //                var all = getrs.control;
        //                ra.Controls.Add(all);
        //                GORS.Instance.RecivDataFromWebs = this;

        //            }));
        //        }
        //        else
        //        {
        //            List<Eventhtml> ghh = new List<Eventhtml>();
        //            HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
        //            gg.LoadHtml(allcon);
        //            try
        //            {
        //                var re = gg.DocumentNode.Descendants("event");

        //                foreach (var ik in re.ElementAt(0).Descendants("event"))
        //                {
        //                    Eventhtml k = new Eventhtml();
        //                    string name = "0";
        //                    Dictionary<string, object> io = new Dictionary<string, object>();
        //                    foreach (var yy in ik.Attributes)
        //                    {
        //                        if (yy.Name.Equals("id"))
        //                        {
        //                            name = yy.Value;
        //                        }
        //                        io.Add(yy.Name, yy.Value);

        //                    }
        //                    k.attEvent = io;
        //                    k.eventName = name;
        //                    k.DataEvent = ik.InnerText;
        //                    ghh.Add(k);

        //                }
                      
        //            }
        //            catch (Exception ex)
        //            {

        //            }
        //            var j = new List<ControlInfo>();
        //            Radconverttojson f = new Radconverttojson(ghh);
        //            var getrs = await f.ActualizarMenus(gg.DocumentNode);
        //            var all = getrs.control;
        //            ra.Controls.Add(all);
        //            GORS.Instance.RecivDataFromWebs = this;


        //        }

        //        return ra;
        //    }
        //}

        public void ReceveFroms(object anotherData)
        {
            var res = JsonConvert.DeserializeObject<eventOpenFrom>(anotherData.ToString());
            if (res.Event_Type.Equals("Open_Form"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    try
                    {
                        var q = JsonConvert.DeserializeObject<getalertv>(res.Name_Form.ToString());
                        if (q.tyeForm == 1)
                        {
                            myform1 kv = new myform1();
                            kv.Show();
                        }
                        else if (q.tyeForm == 2)
                        {
                            myform1 kk = new myform1();
                            kk.ShowDialog();
                        }
                        else if (q.tyeForm == 3)
                        {

                            var zzza = getfoldd("mycus.txt", ".txt");
                            //  MessageBox.Show(zzza[1]);
                            var getdat = File.ReadAllText(zzza[1] + @"/" + "mycus.txt");
                            RadForm f = new RadForm();
                            f.ThemeName = this.ThemeName;

                            var t = new customefinal(getdat, this.ThemeName);
                            t.Dock = DockStyle.Fill;

                         //   t.showcon();
                            f.Controls.Add(t);
                            f.WindowState = FormWindowState.Maximized;
                            GORS.Instance.OpenForm.ReceveFroms(f, anotherData);
                            /*  winToWeb.control.Form1 kk = new winToWeb.control.Form1();
                              GORS.Instance.OpenForm.ReceveFroms(kk, anotherData);*/
                        }
                        else if (q.tyeForm == 4)
                        {
                            // var  kk =  new datshow(q.formname, this.ThemeName).radfrom();

                            //   RadForm f = new RadForm();
                            //  f.ThemeName = this.ThemeName;
                            winToWeb.control.Form1 kk = new winToWeb.control.Form1();
                            GORS.Instance.OpenForm.ReceveFroms(kk, anotherData);
                        }

                        
                        else
                        {
                            myform1 k = new myform1();
                            GORS.Instance.OpenForm.ReceveFroms(k, anotherData);
                        }
                    }
                    catch (Exception ex) {
                        myform1 k = new myform1();
                        GORS.Instance.OpenForm.ReceveFroms(k, anotherData);

                    }
                }
                else {
                    MessageBox.Show("ffffffffffff");
                }
               
            }

            if (res.Event_Type.Equals("New_Page"))
            {
                try
                {
                    var hh = JsonConvert.DeserializeObject<getalert>(res.Name_Form);

                     var hhtm=   getHtmll(hh.A_html);

                    var gr = JsonConvert.DeserializeObject<readJSCSS>(hhtm);
                    
                   // var q=   this.webBrowser1.Document.CreateElement("div");
                  // var z= this.webBrowser1.Document.GetElementsByTagName("head")[0];
                    var grt = this.webBrowser1.Document.GetElementById("mm");
                    //this.webBrowser1.Document.sc
                    grt.InnerHtml = gr.htmll;
                    CreateJS(gr.jss);
                    CreateCSS(gr.csss);
                    try
                    {
                        var getdat = gr.methodLoad.IndexOf('(');
                        var ress = gr.methodLoad.Substring(0, getdat);
                        if (getdat > 0)
                        {

                            var param = gr.methodLoad.Split('(')[1].Split(')')[0];//
                                                                                  // var ee=  param.Split(')')[0];//.StartsWith("(");//.Substring(getdat, gr.methodLoad.Length);

                            var da = param.Split(',');
                            this.webBrowser1.Document.InvokeScript(ress, da);
                        }
                        else
                        {
                            this.webBrowser1.Document.InvokeScript(gr.methodLoad);
                        }
                    }
                    catch (Exception ex) {


                    }
                  //  grt.AppendChild(q);
                  // grt.Document.InvokeScript("document.location.reload(true);");
                  //.InnerHtml = hhtm;
                  /*  var hh = JsonConvert.DeserializeObject<getalert>(res.Name_Form);
                    RadDesktopAlert r;
                    contentAlertMessaage g = new contentAlertMessaage();

                    RadLabel gg = new RadLabel();
                    gg.Location = new Point(0, 0);
                    g.settexhtml(hh.A_html);
                    gg.Dock = DockStyle.Top;

                    g.Dock = DockStyle.Fill;



                    r = new RadDesktopAlert();// (g);
                    r.ShowPinButton = true;
                    r.ShowOptionsButton = true;
                    r.Popup.Opacity = 1;
                    r.PopupAnimation = false;
                    r.ThemeName = this.ThemeName;
                    r.ContentText = hh.A_html;
                    r.FixedSize = new Size(Convert.ToInt32(hh.width), Convert.ToInt32(hh.hi));
                    r.ScreenPosition = hh.location;
                    r.AutoClose = hh.auto == 1;
                    r.AutoCloseDelay = hh.dey;
                    r.Show();*/
                }
                catch (Exception ex)
                {
                   
                }

            }
            if (res.Event_Type.Equals("Show_Alert"))
            {
                try
                {
                    var hh = JsonConvert.DeserializeObject<getalert>(res.Name_Form);
                    RadDesktopAlert r;
                    contentAlertMessaage g = new contentAlertMessaage();

                    RadLabel gg = new RadLabel();
                    gg.Location = new Point(0, 0);
                    g.settexhtml(hh.A_html);
                    gg.Dock = DockStyle.Top;

                    g.Dock = DockStyle.Fill;


                    
                    r = new RadDesktopAlert();// (g);
                  r.ShowPinButton = true;
                r.ShowOptionsButton = true;
                 r.Popup.Opacity = 1;
                  r.PopupAnimation = false;
                    r.ThemeName = this.ThemeName;
                    r.ContentText = hh.A_html;
                    r.FixedSize = new Size(Convert.ToInt32(hh.width), Convert.ToInt32(hh.hi));
                    r.ScreenPosition = hh.location;
                    r.AutoClose = hh.auto == 1;
                    r.AutoCloseDelay = hh.dey;
                    r.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            if (res.Event_Type.Equals("Open_Formt"))
            {
                if (GORS.Instance.OpenForm != null)
                {

                    Form2 k = new Form2(@"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\starter.html");
                    k.Dock = DockStyle.Fill;
                    k.Text = "ddddddddddvv";
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

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

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
