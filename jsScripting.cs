using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using UserControlInHtmll;


namespace winToWeb
{
    [PermissionSet(SecurityAction.Demand)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class jsScripting
    {
        /// <summary>
        /// Raised when a Javascript event arrives.
        /// </summary>
        public event Action<object> EventArrived;
        public event Action<string> EventgetData;


        public string DataGet;

        public void getData(string controlName)
        {

            if (EventgetData != null)
            {

                EventgetData(controlName);
            }


        }
        public string API_UserAgent { get { return GORS.Instance.API_UserAgent; } }
        /// <summary>
        /// تغير الاكسس توكن
        /// </summary>

        /*   public System_seting_main_acount seting_sys
           {


               get
               {


                   return GORS.Instance.seting_sys;
               }
           }
           */

        public string System_seting_main { get { return GORS.Instance.System_seting_main; } }
        public int group_screennumber { get { return GORS.Instance.group_screennumber; } }
        public int sience_screennumber { get { return GORS.Instance.sience_screennumber; } }
        public int A_alfa { get { return GORS.Instance.A_alfa; } }
        public int A_stock { get { return GORS.Instance.A_stock; } }
        public int A_groub_connect { get { return GORS.Instance.A_groub_connect; } }
        public int company_screennumber { get { return GORS.Instance.company_screennumber; } }
        public int currancy_screennumber { get { return GORS.Instance.currancy_screennumber; } }
        public string Date_fromate { get { return GORS.Instance.Date_fromate; } }
        public int Date_typ { get { return GORS.Instance.Date_typ; } }
        public bool Date_enable { get { return GORS.Instance.Date_enable; } }
        public bool A_daloge { get { return GORS.Instance.A_daloge; } }

        public bool A_alert { get { return GORS.Instance.A_alert; } }
        public bool A_sound { get { return GORS.Instance.A_sound; } }
        public Boolean disablec { get { return GORS.Instance.disablec; } }

        public string fontnameeyeornot { get { return GORS.Instance.fontnameeyeornot; } }
        public string fontnamee { get { return GORS.Instance.fontnamee; } }

        public string Useridc { get { return GORS.Instance.Useridc; } }
        public string API_URL { get { return GORS.Instance.API_URL; } }
        public string API_Username { get { return GORS.Instance.API_Username; } }

        public string API_Ref { get { return GORS.Instance.API_Ref; } }
        public string API_AcessToken { get { return GORS.Instance.API_AcessToken; } }


        public int Use_type_barcode { get { return GORS.Instance.Use_type_barcode; } }
        public bool showMEssageStatuse { get { return GORS.Instance.showMEssageStatuse; } }

        public bool inforceShowConfirmMessage { get { return GORS.Instance.inforceShowConfirmMessage; } }
        public string GetTheme() {


            return winToWeb.control.getdependencys.ThemeType;
        }
        public string GetUrlFromString(string filenames,string encryption) {

            try
            {
                winToWeb.control.ReadTextAsHtml d = new winToWeb.control.ReadTextAsHtml();
                var gee = getHtmlpure(filenames);

                var dat = d.GetPureHmlToUrl(gee);

                return dat;
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }
        public string GetSetting() {

            try
            {
                
               var ffer=  JsonConvert.SerializeObject(new winToWeb.control.viewSetting());

                return ffer;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string SaveToCache(string key,string valu) {
            try
            {
                winToWeb.control.CacheClass.add(key, valu);
                return "1";
            }
            catch (Exception ex) {

                return "0";
            }
            }
        public string UpdateToCache(string key, string valu)
        {
            try
            {
                winToWeb.control.CacheClass.update(key, valu);
                return "1";
            }
            catch (Exception ex)
            {

                return "0";
            }
        }
        public string RemoveFromCache(string key)
        {
            try
            {
                winToWeb.control.CacheClass.Remov(key);
                return "1";
            }
            catch (Exception ex)
            {

                return "0";
            }
        }
        public string GetFromCache(string key)
        {
            try
            {
              var q=(string)winToWeb.control.CacheClass.get(key);
                return q;
            }
            catch (Exception ex)
            {

                return "0";
            }
        }
        public string GetHtmlFromString(string filenames, string encryption,string without)
        {

            try
            {
                winToWeb.control.ReadTextAsHtml d = new winToWeb.control.ReadTextAsHtml();
                var gee = getHtmlpure(filenames);

                var dat = d.GetPureHml(gee);
                string res = @"class=""k-content hold-transition sidebar-mini-xs layout-fixed sc""";
                var iitu= @"<!DOCTYPE html><html lang=""en""><head>"+encryption+"</head><body   "+ res + ">"+dat+"</body></html>";
                if (without.Equals("0"))
                {

                    return iitu;
                }
                else {

                    return dat;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
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
        private string getHtmlpure(string url)
        {

            //  var ge = url.Split('#');
            try
            {
                var zzza = getfold(url, ".txt");
                var getdat = File.ReadAllText(zzza[1]);

                return getdat;
            }
            catch (Exception ex) {
                return "0";
            }


        }
        public string getHtml(string url) {

            var ge = url.Split('#');
            var zzza = getfold(ge[1]+".txt", ".txt");
            var getdat=  File.ReadAllText(zzza[1]);

            return getdat;



        }

        public string getHtmlDec(string url)
        {

           // var ge = url.Split('#');
            var zzza = getfold(url, ".txt");
            var getdat = File.ReadAllText(zzza[1]);
            var k = Convert.FromBase64String(getdat);
            var res = System.Text.Encoding.UTF8.GetString(k);
            return res;



        }
        private string urllk { get; set; }
        
            private string Urllk
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
        public string geturl(string url)
        {

            
            return Urllk;



        }
        public void alert(string message, string title, string type)
        {
            customalrtDalog_alert_daloge re = new customalrtDalog_alert_daloge();
            int typp = 1;

            try
            {
                typp = Convert.ToInt32(type);
            }
            catch (Exception ex)
            {

            }
            re.messge_aler(typp, message, title);
        }
        public bool confirm(string message,string title)
        {

            if (RadMessageBox.Show(message, title, MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {

                return true;
                //S_IDDD

                //  apiSave("0");

            }
            else {
                return false;
            }
          



        }
        public void newPage() {


        }
        public void b(string eventName)
        {
            if (EventArrived != null)
            {
                EventArrived(eventName);
            }
        }
        public void sendEvent(string eventName)
        {
            if (EventArrived != null)
            {
                EventArrived(eventName);
            }
        }
    }

}
