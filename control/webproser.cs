using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlInHtmll;
using Telerik.WinControls.UI;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Threading;
using System.Security.Permissions;

namespace winToWeb.control
{
   
    public partial class webproser : UserControl, SendFromWindowsToWeb
    {
        public SendFromWindowsToWeb sendFromWindowsToWeb;
        private RecevDataFromWeb evnetOben;
        public webproser(RecevDataFromWeb evn)
        {
            InitializeComponent();
            sendFromWindowsToWeb = this;
            evnetOben = evn;
            /* var eve = new jsScripting();
            evnetOben
             eve.EventArrived += ReceveFroms;
             webBrowser1.ObjectForScripting = eve;*/
            ccc = false;
            fromurl = Path.GetDirectoryName(getdependencys.Urllk)+@"\";
            loadfir();
        }
        private string fromurl;
        public webproser(string fromurll, RecevDataFromWeb evn)
        {
            InitializeComponent();
            sendFromWindowsToWeb = this;
            evnetOben = evn;
            fromurl = fromurll;
            /*var eve = new jsScripting();
            fromurl = fromurll;
            eve.EventArrived += ReceveFroms;
            webBrowser1.ObjectForScripting = eve;*/
            ccc = false;
            loadfir();
        }
        private bool ccc;
        public webproser(string fromurll,bool g, RecevDataFromWeb evn)
        {
            InitializeComponent();
            sendFromWindowsToWeb = this;
            evnetOben = evn;
            ccc = true;
            fromurl = fromurll;
            
            

            loadfir();
        }
        /// <summary>
        /// load As asyinc
        /// </summary>
        /// <param name="fromurll"></param>
        /// <param name="g"></param>
        /// <param name="c"></param>
        public webproser(string fromurll, bool g,bool c, RecevDataFromWeb evn)
        {
            InitializeComponent();
            sendFromWindowsToWeb = this;
            evnetOben = evn;
            ccc = true;
            fromurl = fromurll;



           // loadfir();
        }

        /// <summary>
        /// load asyinc
        /// </summary>
        /// <returns></returns>
        public async Task<int>   LoadAsyinc()
        {

         return await  Task.Run(() =>
            {
             /*   sendFromWindowsToWeb = this;
                ccc = true;
                var eve = new jsScripting();
                fromurl = fromurll;
                eve.EventArrived += ReceveFroms;
                webBrowser1.ObjectForScripting = eve;
                */

                loadfir();
                return 1;
            }
            );
        }
        public string lloadd(string getfin)
        {
            string res = "0";
            HtmlAgilityPack.HtmlDocument ggf = new HtmlAgilityPack.HtmlDocument();
            string cc = Assembly.GetExecutingAssembly().Location;
            ggf.LoadHtml(getfin);




            ActualizarMenuss(ggf.DocumentNode);


            //  MessageBox.Show(ssd);
            res = ggf.DocumentNode.InnerHtml;

            return res;
        }

        public bool checkres(string ttt)
        {

            try
            {
                if (Regex.IsMatch(ttt, @"^(http[s]{0,1}:\/\/|\\\\)"))
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {

                return false;
            }
        }
        public class createmenu {
public string menuname { get; set; }
public string id { get; set; }
public string icona { get; set; }
public string iconb { get; set; }
public string herf { get; set; }
            public string spanclass { get; set; }
            public string spantext { get; set; }
            public List<createmenu> menulist { get; set; }
        }
      private void  addm(List<createmenu> ad)
        {
            
            var ui = webBrowser1.Document.GetElementById("first");

            string fulldata = "";

            foreach (var e in ad)
            {

                var lik = ui.Document.CreateElement("li");

                var li = ui.Document.CreateElement("li");

                //li.AppendChild(document.createTextNode("Four"));
                li.SetAttribute("class", "nav-item");
                li.SetAttribute("id", e.id);

                var a = li.Document.CreateElement("a");
                a.SetAttribute("class", "nav-link");
                a.SetAttribute("href", e.herf);


                var i = a.Document.CreateElement("i");
                i.SetAttribute("class", e.icona);
                a.AppendChild(i);
                var p = i.Document.CreateElement("p");
                p.InnerText = e.menuname;

                if (!e.spanclass.Equals("0"))
                {
                    var spa = webBrowser1.Document.CreateElement("span");

                    spa.SetAttribute("class", e.spanclass);
                    spa.InnerText = e.spantext;
                    p.AppendChild(spa);
                }
                // p.appendText("hhhhh");

                var ii = p.Document.CreateElement("i");
                ii.SetAttribute("class", e.iconb);
                p.AppendChild(ii);
                a.AppendChild(p);
                li.AppendChild(a);

                li.AppendChild(creatui(e.menulist));


                lik.AppendChild(li);
                fulldata = fulldata + lik.InnerHtml;
            }



            ui.InnerHtml = ui.InnerHtml+ fulldata;
            
        }
        private HtmlElement  creatui(List<createmenu> uik)
        {

            /*
            <li class="nav-item">
                                <a href="#" class="nav-link active">
                                  <i class="far fa-circle nav-icon"></i>
                                  <p>Active Page</p>
                                </a>
                              </li>
            */

            var lt = webBrowser1.Document.CreateElement("ul");
            lt.SetAttribute("class", "nav nav-treeview");

            foreach (var e in uik)
            {
                lt.AppendChild(gcretli(e));
            }

            return lt;
        }
        private HtmlElement  gcretli(createmenu er)
        {
            var li = webBrowser1.Document.CreateElement("li");
            li.SetAttribute("class", "nav-item");
            li.SetAttribute("id", er.id);

            var a = webBrowser1.Document.CreateElement("a");
            a.SetAttribute("class", "nav-link");
            a.SetAttribute("href", er.herf);
            var i = webBrowser1.Document.CreateElement("i");
            i.SetAttribute("class", er.icona); 
            a.AppendChild(i);
            var p = webBrowser1.Document.CreateElement("p");
            p.InnerText = er.menuname;
            if (!er.spanclass.Equals("0"))
            {
                var spa = webBrowser1.Document.CreateElement("span");

                spa.SetAttribute("class", er.spanclass);
                spa.InnerText = er.spantext;
                p.AppendChild(spa);
            }
            a.AppendChild(p);
            li.AppendChild(a);
            return li;
        }
        public void loadfir()
        {

            if (radWaitingBar1.InvokeRequired)
            {

                radWaitingBar1.Invoke(new MethodInvoker(() =>
               {
                   radWaitingBar1.StartWaiting();
               }));
            }
            else {
                radWaitingBar1.StartWaiting();
            }
            if (webBrowser1.InvokeRequired)
            {

                webBrowser1.Invoke(new MethodInvoker(() =>
                {
                    var eve = new jsScripting();

                    eve.EventArrived += ReceveFroms;
                    webBrowser1.ObjectForScripting = eve;
                    webBrowser1.ScriptErrorsSuppressed = true;
                    webBrowser1.IsWebBrowserContextMenuEnabled = false;
                    //  webBrowser1.AllowWebBrowserDrop = true;

                    webBrowser1.ProgressChanged += prog;

                    //webBrowser1.Refresh();
                    webBrowser1.DocumentCompleted += oncomplat;
                    // webBrowser1.ScrollBarsEnabled = false;
                    //  MessageBox.Show(ssd);
                    if (!ccc)
                    {
                        Uri u = new Uri(fromurl);
                        //Uri u = new Uri(@"C:\Users\Mypc\Documents\Winforms.Plugins\Winforms.Plugins\Winforms.Plugins.Host\bin\Debug\starter.html");
                        webBrowser1.Url = u;
                    }
                    else
                    {
                        //   fromurl = @"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\starter.html";
                        // webBrowser1.Navigate(@"C:\Users\Mypc\Documents\ytt.html");
                        //var u = new FileStream(@"C:\Users\Mypc\Documents\ytt.html", FileMode.Open,FileAccess.Read);
                        //webBrowser1.Url = u;
                        // webBrowser1.Navigate(u);
                        // webBrowser1.AllowNavigation = true;
                        var getdoctext = lloadd(fromurl);
                        var ger = System.IO.Path.GetTempPath();
                        var newguid = ger + @"" + Guid.NewGuid().ToString() + ".html";
                        File.WriteAllText(newguid, getdoctext);
                        var urllk = "file:///" + newguid.Replace(@"\", "/");
                        //  webBrowser1.DocumentText= ;
                        webBrowser1.Navigate(urllk);
                        //webBrowser1.Refresh();
                        //  webBrowser1.Document.Body.InnerHtml = fromurl;
                    }
                }));
            }
            else
            {
                var eve = new jsScripting();

                eve.EventArrived += ReceveFroms;
                webBrowser1.ObjectForScripting = eve;
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.IsWebBrowserContextMenuEnabled = false;
                //  webBrowser1.AllowWebBrowserDrop = true;

                webBrowser1.ProgressChanged += prog;

                //webBrowser1.Refresh();
                webBrowser1.DocumentCompleted += oncomplat;
                // webBrowser1.ScrollBarsEnabled = false;
                //  MessageBox.Show(ssd);
                if (!ccc)
                {
                    Uri u = new Uri(fromurl);
                    //Uri u = new Uri(@"C:\Users\Mypc\Documents\Winforms.Plugins\Winforms.Plugins\Winforms.Plugins.Host\bin\Debug\starter.html");
                    webBrowser1.Url = u;
                }
                else
                {
                    //   fromurl = @"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\starter.html";
                    // webBrowser1.Navigate(@"C:\Users\Mypc\Documents\ytt.html");
                    //var u = new FileStream(@"C:\Users\Mypc\Documents\ytt.html", FileMode.Open,FileAccess.Read);
                    //webBrowser1.Url = u;
                    // webBrowser1.Navigate(u);
                    // webBrowser1.AllowNavigation = true;
                    var getdoctext = lloadd(fromurl);
                    var ger = System.IO.Path.GetTempPath();
                    var newguid = ger + @"" + Guid.NewGuid().ToString() + ".html";
                    File.WriteAllText(newguid, getdoctext);
                    var urllk = "file:///" + newguid.Replace(@"\", "/");
                    //  webBrowser1.DocumentText= ;
                    webBrowser1.Navigate(urllk);
                    //webBrowser1.Refresh();
                    //  webBrowser1.Document.Body.InnerHtml = fromurl;
                }
            }
          
          //  webBrowser1.Document.Window.Load += vv;
        }

        private void vv(object sender, HtmlElementEventArgs e)
        {
           // MessageBox.Show("hhhhhhhhhhhhhhhhhhhhhh");
        }

        private void prog(object sender, WebBrowserProgressChangedEventArgs e)
        {
         

        }

        public void oncomplat(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Loading)
            {

            }
                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {

                var getfu = getdependencys.getFunction;
                try
                {/*var t = webBrowser1.Document.CreateElement("script");
                  
                       var ii = webBrowser1.Document.GetElementsByTagName("head")[0];

                    t.InnerText = getfu;
                    
                    ii.AppendChild(t);*/
                  //  webBrowser1.Document.InvokeScript("lighthem");
                }
                catch (Exception ex) {
                }
               /* HtmlElement hw = webBrowser1.Document.GetElementsByTagName("head")[0];

                HtmlElement el = webBrowser1.Document.CreateElement("script");
                el.InnerText = "window.alert=function(){alert('hhhhhhhhhhhhhhh');}";
                hw.AppendChild(el);*/
               //  webBrowser1.Document.InvokeScript("reloadCss");
                radWaitingBar1.StopWaiting();
                //webBrowser1.Document.Body.InnerHtml = fromurl;

            }

        }
        public class getalertv
        {
            private string type_Event = "0";
            public string formname { get; set; }
            public int tyeForm { get; set; }

            public string Page_name
            {
                get
                {
                    return page_name;
                }

                set
                {
                    page_name = value;
                }
            }

            public string Title_name
            {
                get
                {
                    return title_name;
                }

                set
                {
                    title_name = value;
                }
            }

            public string Tage_name
            {
                get
                {
                    return tage_name;
                }

                set
                {
                    tage_name = value;
                }
            }

            public string Type_Event
            {
                get
                {

                    return type_Event;
                }

                set
                {
                    type_Event = value;
                }
            }

            private string page_name = "main";
            private string title_name = "main";
            private string tage_name = "main";



        }
        public class getalert
        {

            public string A_html { get; set; }
            public int width { get; set; }
            public int hi { get; set; }
            public int dey { get; set; }
            public int auto { get; set; }
            public AlertScreenPosition location { get; set; }

        }
        public class readJSCSS
        {

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

            var ssd = Path.GetDirectoryName(cc) + fouldernanmee;

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
        private void RunNodee(HtmlNode node)
        {

            foreach (HtmlNode child in node.ChildNodes)
            {
                RunNodee(child);
                setatt(child);


            }

        }
        private string urllk;
        public string Urllk
        {
            get
            {

                if (urllk == null)
                {
                    string cc = Assembly.GetExecutingAssembly().Location;



                    urllk = "file:///" + Path.GetDirectoryName(cc).Replace(@"\", "/");
                }
                return urllk;
            }


        }
        private void setatt(HtmlNode node)
        {

            foreach (var yy in node.Attributes)
            {

                if (yy.Name.ToLower().Equals("src"))
                {
                    if (!checkres(yy.Value))
                    {
                        if (!yy.Value.StartsWith("#"))
                        {
                            if (yy.Value.StartsWith("/"))
                            {
                                yy.Value = Urllk + yy.Value;
                            }
                            else
                            {

                                yy.Value = Urllk + "/" + yy.Value;
                            }
                        }
                    }


                    //  MessageBox.Show(yy.Value);
                }
                else if (yy.Name.ToLower().Equals("href"))
                {
                    if (!checkres(yy.Value))
                    {
                        if (!yy.Value.StartsWith("#"))
                        {
                            if (yy.Value.StartsWith("/"))
                            {
                                yy.Value = Urllk + yy.Value;
                            }
                            else
                            {

                                yy.Value = Urllk + "/" + yy.Value;
                            }
                        }
                    }


                    //  MessageBox.Show(yy.Value);
                }
            }
        }
        public void ActualizarMenuss(HtmlNode radTreeView1)
        {
            
            foreach (HtmlNode node in radTreeView1.ChildNodes)
            {
                RunNodee(node);
                setatt(node);

            }
            //  root = new TreeviewPersist_json("root", parents,false,null,null);

           ;
        }
        public void CreateJS(string jsd,bool withsorce, Dictionary<string, AttributeJSwithhava> ss)
        {
            //var q = webBrowser1.Document.GetElementById("webContiner");
          //  webBrowser1.Document.InvokeScript("setsource", new string[] { "webContiner", jsd, "script", "0" });
            try
            {

                foreach (var e in ss) {
                    webBrowser1.Document.InvokeScript("setsource", new string[] { "webContiner", e.Value.script, "script",e.Value.withsrc?"1":"0",JsonConvert.SerializeObject(e.Value.attribute)});
                    /* var ff = webBrowser1.Document.CreateElement("script");
                     ff.SetAttribute("src", e.Value);
                     q.AppendChild(ff);*/
                    //  MessageBox.Show(e.Value);

                }
            //    Thread.Sleep(1000);
              /*  var ss = q.GetElementsByTagName("script")[0];
                if (ss == null)
                {
                    var ff = webBrowser1.Document.CreateElement("script");
                    //var inlinscx = webBrowser1.Document.CreateElement(jsd);
                    if (withsorce)
                    {
                        ff.SetAttribute("src",jsd);
                        q.AppendChild(ff);
                    }
                    else
                    {
                        ff.InnerText = jsd;
                        q.AppendChild(ff);
                    }
                }
                else
                {*/
                   /* if (withsorce)
                    {
                        var ff = webBrowser1.Document.CreateElement("script");
               
                    ff.SetAttribute("src", jsd);
                        q.AppendChild(ff);
                    }
                    else
                    {

                   
                    var ff = q.Document.CreateElement("script");
                    ff.InnerText = jsd;
                    // ff.AppendChild(inlinscx);
                    q.AppendChild(ff);

                    // ss.InnerText = jsd;
                }*/

               // }
            }
            catch (Exception ex)
            {

               
               /* var ff = webBrowser1.Document.CreateElement("script");

                if (withsorce)
                {

                    ff.SetAttribute("src", jsd);
                    q.AppendChild(ff);
                }
                else
                {
                    //  var inlinscx = webBrowser1.Document.CreateElement(jsd);
                    ff.InnerText = jsd;
                    // ff.AppendChild(inlinscx);
                    q.AppendChild(ff);
                }*/
            }

        }

        public void CreateCSS(string jsd)
        {
            var q = webBrowser1.Document.GetElementById("webContiner");
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
            catch (Exception ex)
            {
                var ff = webBrowser1.Document.CreateElement("style");
                // var inlinscx = webBrowser1.Document.CreateElement(jsd);
                ff.InnerText = jsd;
                //ff.AppendChild(inlinscx);
                q.AppendChild(ff);
            }

        }
        public async void ReceveFroms(object anotherData)
        {
            var res = JsonConvert.DeserializeObject<eventOpenFrom>(anotherData.ToString());
            if (res.Event_Type.Equals("Open_Form"))
            {
                if (evnetOben != null)
                {

                    try
                    {


                        /* if (q.tyeForm == 1)
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

                             var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
                             var t = new customefinal(alldat);
                             t.Dock = DockStyle.Fill;

                             var f = await t.inithh.loadForm();
                             f.ThemeName = radGroupBox1.ThemeName;
                             f.FormClosing += testForm_FormClosing;
                            // f.Controls.Add(t);                        
                              f.WindowState = FormWindowState.Maximized;
                               GORS.Instance.OpenForm.ReceveFroms(f, anotherData);
                             /*  winToWeb.control.Form1 kk = new winToWeb.control.Form1();
                               GORS.Instance.OpenForm.ReceveFroms(kk, anotherData);*/
                        // }
                        /* else if (q.tyeForm == 4)
                         {
                             // var  kk =  new datshow(q.formname, this.ThemeName).radfrom();

                             //   RadForm f = new RadForm();
                             //  f.ThemeName = this.ThemeName;
                             winToWeb.control.Form1 kk = new winToWeb.control.Form1();
                             GORS.Instance.OpenForm.ReceveFroms(kk, anotherData);
                         }
                         */
                        /*  if (q.Type_Event.Equals("1")) {
                              var laod = new Astoldesinger.Class.ConnectecedWithmain_ss(GORS.Instance.OpenForm.GetRadPageView());
                              await laod.load();
                          }
                          else
                          {
                              Astoldesinger.Class.GetFormFromIDScreen vvb = new Astoldesinger.Class.GetFormFromIDScreen();

                              // RadForm child = await vvb.shoeformm("37", 0);
                              RadForm child = await vvb.shoeformm(q.formname, 0);
                              */
                        evnetOben.ReceivOpenForm("0", "0", "0", anotherData, "0");
                        //  myform1 k = new myform1();
                        // GORS.Instance.OpenForm.ReceveFroms(child, anotherData);
                        // }

                    }
                    catch (Exception ex)
                    {
                        // myform1 k = new myform1();

                        // GORS.Instance.OpenForm.ReceveFroms(k, anotherData);

                    }
                }
                else
                {
                    //MessageBox.Show("ffffffffffff");
                }

            }
            else if (res.Event_Type.Equals("menu"))
            {

                var uiiop = JsonConvert.DeserializeObject<List<createmenu>>(res.Name_Form);
                addm(uiiop);
                // webBrowser1.Document.InvokeScript("addm");
            }
            else if (res.Event_Type.Equals("Start_Wating"))
            {

                radWaitingBar1.StartWaiting();
                // webBrowser1.Document.InvokeScript("addm");
            }
            else if (res.Event_Type.Equals("Go_Back"))
            {

                webBrowser1.GoBack();
                // webBrowser1.Document.InvokeScript("addm");
            }
            else if (res.Event_Type.Equals("Stop_Wating"))
            {

                radWaitingBar1.StopWaiting();
                // webBrowser1.Document.InvokeScript("addm");
            }
            else if (res.Event_Type.Equals("New_form"))
            {
                try
                {
                    var hh = JsonConvert.DeserializeObject<getalert>(res.Name_Form);

                    //var hhtm = getHtmll(hh.A_html);

                    // var gr = JsonConvert.DeserializeObject<readJSCSS>(hhtm);

                    // var q=   this.webBrowser1.Document.CreateElement("div");
                    // var z= this.webBrowser1.Document.GetElementsByTagName("head")[0];

                    try
                    {
                        this.webBrowser1.Document.InvokeScript("showwindowcontrol");
                    }
                    catch (Exception ex)
                    {

                    }
                    // myform1 k = new myform1();

                    if (GORS.Instance.EventDataRecevOpnForm != null)
                    {
                        GORS.Instance.EventDataRecevOpnForm.openfrmfrommain(hh.A_html, anotherData, anotherData);
                    }
                    // GORS.Instance.OpenForm.ReceveFroms(k, anotherData);
                    /* var grt = this.webBrowser1.Document.GetElementById("webContiner");
                    var grtvx = this.webBrowser1.Document.GetElementById("windoesContiner");
                    grtvx.SetAttribute("class", "windowshow");
                    grt.SetAttribute("class", "webhidden");*/
                    //this.webBrowser1.Document.sc
                    // grt.InnerHtml = hhtm;

                }
                catch (Exception ex)
                {

                }

            }
            else if (res.Event_Type.Equals("New_Page"))
            {
                try
                {
                    var hh = JsonConvert.DeserializeObject<getalert>(res.Name_Form);

                    var hhtm = getHtmll(hh.A_html);
                    var grt = this.webBrowser1.Document.GetElementById("webContiner");


                    this.webBrowser1.Document.InvokeScript("hidwindowcontrol");
                    HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();

                    gg.LoadHtml(hhtm);
                    ActualizarMenuss(gg.DocumentNode);
                    string scr = "";
                    string sty = "";
                    string ht = "";
                    Dictionary<string, AttributeJSwithhava> ss = new Dictionary<string, AttributeJSwithhava>();


                    // var hhtml
                    foreach (var t in gg.DocumentNode.ChildNodes)
                    {



                        if (t.OriginalName.ToLower().Equals("script"))
                        {
                            var keyy = Guid.NewGuid().ToString();
                            AttributeJSwithhava ii = new AttributeJSwithhava();
                            List<AttributeJS> u = new List<AttributeJS>();
                            string aa = "0";
                            bool withser = false;
                            foreach (var k in t.Attributes)
                            {
                                if (k.Name.Equals("src"))
                                {
                                    try
                                    {
                                        withser = true;

                                        //  ss.Add(k.Value, k.Value);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                                u.Add(new AttributeJS { key = k.Name, value = k.Value });
                            }
                            if (aa.Equals("0"))
                            {
                                if (!t.OuterHtml.Equals(""))
                                {
                                    scr = scr + " " + t.InnerHtml;
                                }
                            }
                            ii.attribute = u;
                            ii.script = t.InnerHtml;
                            ii.withsrc = withser;
                            ss.Add(keyy, ii);

                        }
                        else if (t.OriginalName.ToLower().Equals("style"))
                        {
                            if (!t.OuterHtml.Equals(""))
                            {
                                sty = sty + " " + t.InnerHtml;
                            }
                        }
                        else
                        {
                            if (!t.OuterHtml.Equals(""))
                            {

                                ht = ht + " " + t.OuterHtml;
                            }
                        }
                        // gg.DocumentNode.RemoveChild(t);
                    }
                    grt.InnerHtml = ht;
                    try
                    {


                        CreateJS(scr, false, ss);


                    }
                    catch (Exception ex)
                    {

                    }

                    try
                    {

                        CreateCSS(sty);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (res.Event_Type.Equals("Show_Alert"))
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
                    r.ThemeName = this.radGroupBox1.ThemeName;
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

            else if (res.Event_Type.Equals("Open_Formt"))
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
                    // MessageBox.Show("ffffffffffff");
                }

            }
            else if (res.Event_Type.Equals("Change_Them_Dark"))
            {

                getdependencys.ChangeThem("Dark");
                if (GORS.Instance.OpenForm != null)
                {

                    GORS.Instance.OpenForm.changeThem("Dark");
                    GORS.Instance.ThemeSystem = "Dark";
                }

            }

            else if (res.Event_Type.Equals("Change_Them_Light"))
            {
                getdependencys.ChangeThem("Light");
                if (GORS.Instance.OpenForm != null)
                {

                    GORS.Instance.OpenForm.changeThem("Liget");
                    GORS.Instance.ThemeSystem = "Light";
                }

            }
            else {
                if (evnetOben != null) {
                    evnetOben.ReceveFroms(anotherData);
                       }
            }
        }
        private void testForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dss = sender as RadForm;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (dss != null)
                {
                   // MessageBox.Show("ffffffff");
                    dss.Hide();
                }
            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public void SendToJavaScript(string FunctionName, object[] paramter)
        {
            try
            {
                this.webBrowser1.Document.InvokeScript(FunctionName, paramter);
            }
            catch (Exception ex) {

            }
        }
    }
}
