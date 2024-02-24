using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace winToWeb
{
 public   class CustomWeb: WebBrowser
    {


     

            public event Action<bool> A_onstartWiting;
            public event Action<EventFromWeb> A_EventArrivedd;
            public event Action<string> A_OngetData;
            public CustomWeb()
            {
                CreateBrowser("0");

            }
            public async Task<Dictionary<string, string>> getphoto(string Url, string content)
            {
                Url = "http://ab/designt.txt";
                Dictionary<string, string> u = new Dictionary<string, string>();
                Url = urlpur(Url);
                string vv = ""; //Properties.Resources.placehold;
                var extension = Path.GetExtension(Path.GetFileName(Url)) + "file";
                var zzza = getfold(Path.GetFileName(Url), extension);
                //   MessageBox.Show(Url);
                byte[] iio = null;
                if (zzza[0].Equals("0"))
                {
                    // iio = File.ReadAllBytes(ss.Image_URL);
                    iio = Encoding.UTF8.GetBytes(content);
                    File.WriteAllBytes(zzza[1], iio);
                    var hh = File.ReadAllText(zzza[1]);
                    u.Add("desin", hh);


                }
                else
                {
                    var hh = File.ReadAllText(zzza[1]);
                    u.Add("desin", hh);
                    // MessageBox.Show(Path.GetFileName(zzza[1]));
                    // u.Add(Url, zzza[1]);
                    // vv = File.ReadAllText(zzza[1]);
                }
                return u;

            }
            public string[] getfold(string Filename, string typefolder)
            {

                string[] zz = new string[2];
                string fouldernanmee = "/fileDeshin/" + typefolder.Replace(".", "");
                string cc = Assembly.GetExecutingAssembly().Location;

                var ssd = Path.GetDirectoryName(cc) + fouldernanmee;

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
            public async Task<Dictionary<string, string>> getphoto(string Url)
            {
                Dictionary<string, string> u = new Dictionary<string, string>();
                Url = urlpur(Url);
                string vv = ""; //Properties.Resources.placehold;
                var extension = Path.GetExtension(Path.GetFileName(Url)) + "file";

                var zzza = getfold(Path.GetFileName(Url), extension);
                //   MessageBox.Show(Url);
                byte[] iio = null;
                if (zzza[0].Equals("0"))
                {
                    // iio = File.ReadAllBytes(ss.Image_URL);



                    using (WebClient bb = new WebClient())
                    {
                        try
                        {
                            // Uri dd = new Uri(Url);
                            iio = await bb.DownloadDataTaskAsync(Url);

                            File.WriteAllBytes(zzza[1], iio);


                            u.Add(Url, zzza[1]);
                            // vv =  File.ReadAllText(zzza[1]);
                            return u;
                        }
                        catch
                        {

                            return u;

                        }


                    }

                }
                else
                {

                    // MessageBox.Show(Path.GetFileName(zzza[1]));
                    u.Add(Url, zzza[1]);
                    // vv = File.ReadAllText(zzza[1]);
                }
                return u;

            }
            public async void loadfrom(string d)
            {
                try
                {

                    // MessageBox.Show(d);
                    if (A_onstartWiting != null)
                    {
                        A_onstartWiting(true);

                    }
                    string res;
                    if (d == null)
                    {

                        var k = await getphoto("design", "0");
                        k.TryGetValue("desin", out res);
                        if (res == null)
                        {
                            d = "0";
                        }
                        else
                        {
                            d = res;
                        }
                    }
                    else
                    {
                        var k = await getphoto("design", d);
                        k.TryGetValue("desin", out res);
                        if (res == null)
                        {
                            d = "0";
                        }
                        else
                        {
                            d = res;
                        }
                    }
                    var getresul = JsonConvert.DeserializeObject<design>(d);
                    //    MessageBox.Show(getresul.urls.ElementAt(0).url);
                    Dictionary<string, string> dd = new Dictionary<string, string>();
                    for (int v = 0; v < getresul.urls.Count; v++)
                    {

                        //  MessageBox.Show(getresul.urls.ElementAt(v).url);

                        var t = urlpur(getresul.urls.ElementAt(v).url);
                        {
                            if (checkres(t))
                            {

                                try
                                {
                                    var aww = await getphoto(t);

                                    string ull;
                                    aww.TryGetValue(t, out ull);
                                    dd.Add(t, ull);
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }

                    }
                    string resul = "";
                    foreach (var g in getresul.urls)
                    {
                        /* string x;
                       dd.TryGetValue(g.url, out x);
                         if (resul.Equals(""))
                         {
                             resul = getresul.body.Replace(g.url, x);
                         }
                         else {

                             resul=resul.Replace(g.url, x);
                         }
                     }
                     */
                    }
                    if (resul.Equals(""))
                    {
                        resul = getresul.body;
                    }
                // var // string.Format(getresul.body, dd);

                this.DocumentText = resul;
              

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "hhhhhhhhhhh");
                }

            }
      
            private  void CreateBrowser(string u)
            {

                try
                {
                    //radWaitingBar1.StartWaiting();

                    this.Dock = DockStyle.Fill;
                // toolStripContainer.ContentPanel.Controls.Add(browser);


                this.ScriptErrorsSuppressed = true;
                this.IsWebBrowserContextMenuEnabled = false;
               this.AllowWebBrowserDrop = false;
                var eve = new jsScripting();
                eve.EventgetData += Ongetdata;
                eve.EventArrived += OnJavascriptEventArrived;
               this.ObjectForScripting =eve ;
            }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        private void OnJavascriptEventArrived(object eventData)
        {

            try
            {
                var dataa = JsonConvert.DeserializeObject<EventFromWeb>(eventData.ToString());
                if (A_EventArrivedd != null)
                {

                    A_EventArrivedd(dataa);
                }
            }
            catch (Exception ex)
            {


            }

            //   MessageBox.Show(message, "Javascript event arrived", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        public string getscren(string elemntname)
            {

                string secrip = @"

window.addEventListener('resize',function(event){
var width = document.getElementById(" + "\"" + elemntname + "\"" + @");
var left = width.offsetLeft;
            var top = width.offsetTop;
            var scrY = window.screenY;
            var scrX = window.screenX;
            var finlTop = top + scrY;
            var finlleft = left + scrX;
            var hi = width.offsetHeight;
            var wh = width.offsetWidth;


            windowsEvent.changeSc(top, left, wh, hi, scrY, scrX);
        });
";
                return secrip;
            }
            public string getscrenb(string elemntname)
            {

                string secrip = @"


var width = document.getElementById(" + "\"" + elemntname + "\"" + @");
var left = width.offsetLeft;
            var top = width.offsetTop;
            var scrY = window.screenY;
            var scrX = window.screenX;
            var finlTop = top + scrY;
            var finlleft = left + scrX;
            var hi = width.offsetHeight;
            var wh = width.offsetWidth;


            windowsEvent.changeSc(top, left, wh, hi, scrY, scrX);
        
";
                return secrip;
            }
      
            private void Ongetdata(string get)
            {
                if (A_OngetData != null)
                {

                    A_OngetData(get);
                }
            }
            public string urlpur(string url)
            {
                try
                {
                    MatchCollection ms = Regex.Matches(url, @"(www.+|http.+)([\s]|$)");
                    string testMatch = ms[0].Value.ToString();

                    return testMatch;
                }
                catch (Exception ex)
                {
                    return "0";
                }
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
       
      
      



    


  
            private void SetCanGoBack(bool canGoBack)
            {
                // this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
            }

            private void SetCanGoForward(bool canGoForward)
            {
                //   this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
            }
        

    }
}
