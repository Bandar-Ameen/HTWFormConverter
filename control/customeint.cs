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
using dynFormLib;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Drawing.Html;
using Telerik.WinControls;
using System.Net;
using System.IO;

namespace winToWeb.control
{
 public   interface customeint
    {
        void openfrmfrommain(object dat);
    }


    public class inith: OnReciveForm
    {
        private Control uj;
        private string themnamel;
        private string allcon;
        private RecevDataFromWeb evn;
        private OnReciveForm onform;
        public inith(Control conti, string themnamell,string desin, RecevDataFromWeb ev) {
            uj = conti;
           
            this.themnamel = themnamell;
            allcon = desin;evn = ev;
            onform = this;
           // GORS.Instance.System_seting_main = this.themnamel;
            radValidationProvider1 = new RadValidationProvider();
            radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;

            //radValidationRule1.Controls.Add(this.N_addcoustom);
            //  radValidationRule1.Controls.Add(this.radMaskedEditBox2);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "هذه الحقل مطلوب";
            radValidationRule1.ToolTipTitle = "يرجي إدخال البيانات بشكل صحيح";
            radValidationRule1.Value = "";
            this.radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});

        }
        public async void showcon()
        {
           // vald = new Valdation();
            var ra = uj;
            //  ra.FormClosing += testForm_FormClosing;
           
            if (ra.InvokeRequired)
            {
                ra.Invoke(new MethodInvoker(async () =>
                {
                    List<Eventhtml> ghh = new List<Eventhtml>();
                    List<DataSource> datasurce = new List<DataSource>();
                    HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();

                    gg.LoadHtml(allcon);
                    Dictionary<string, object> fromhtmlh = new Dictionary<string, object>();
                    Dictionary<string, object> imagesvg = new Dictionary<string, object>();
                    try
                    {
                        var re = gg.DocumentNode.Descendants("event");
                        var getdatasoruce = gg.DocumentNode.Descendants("datasource");

                        var svghtm = gg.DocumentNode.Descendants("fromhtml");


                        foreach (var ik in svghtm.ElementAt(0).Descendants("htmldata"))
                        {
                            string name = "0";
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                            }

                            fromhtmlh.Add(name, ik.InnerHtml);

                        }

                        var svg = gg.DocumentNode.Descendants("imagesvg");


                        foreach (var ik in svg.ElementAt(0).Descendants("imagesvgsorce"))
                        {
                            string name = "0";
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                            }

                            imagesvg.Add(name, ik.InnerHtml);

                        }
                        foreach (var ik in getdatasoruce.ElementAt(0).Descendants("sources"))
                        {
                            DataSource k = new DataSource();
                            string name = "0";
                            string method = "0";
                            string urll = "0";
                            Dictionary<string, object> hedaer = new Dictionary<string, object>();
                            Dictionary<string, object> quriy = new Dictionary<string, object>();
                            Dictionary<string, object> body = new Dictionary<string, object>();

                            Dictionary<string, object> another = new Dictionary<string, object>();
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                                else if (yy.Name.Equals("method"))
                                {
                                    method = yy.Value;
                                }
                                else if (yy.Name.Equals("url"))
                                {
                                    urll = yy.Value;
                                }
                                else if (yy.Name.Equals("headr"))
                                {
                                    hedaer.Add(yy.Name, yy.Value);
                                }
                                else if (yy.Name.Equals("query"))
                                {
                                    quriy.Add(yy.Name, yy.Value);
                                }
                                else if (yy.Name.Equals("body"))
                                {
                                    body.Add(yy.Name, yy.Value);
                                }

                                else
                                {

                                    another.Add(yy.Name, yy.Value);
                                }




                            }
                            k.sourceName = name;
                            k.methodtype = method;
                            k.queryurl = quriy;
                            k.anotherdata = another;
                            k.body = body;
                            k.data = ik.InnerText;
                            k.hedaer = hedaer;
                            k.url = urll;

                            datasurce.Add(k);

                        }
                        foreach (var ik in re.ElementAt(0).Descendants("event"))
                        {
                            Eventhtml k = new Eventhtml();
                            string name = "0";
                            string sourceid = "0";
                            Dictionary<string, object> io = new Dictionary<string, object>();
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                                if (yy.Name.Equals("sourceid"))
                                {
                                    sourceid = yy.Value;
                                }
                                io.Add(yy.Name, yy.Value);

                            }
                            k.attEvent = io;
                            k.eventName = name;
                            k.sourceid = sourceid;
                            k.datao = datasurce;
                            k.DataEvent = ik.InnerText;
                            ghh.Add(k);

                        }
                        //  MessageBox.Show(JsonConvert.SerializeObject(ghh));
                    }
                    catch (Exception ex)
                    {

                    }
                    var j = new List<ControlInfo>();

                    Radconverttojson f = new Radconverttojson(ghh, radValidationRule1, imagesvg, fromhtmlh,evn, onform);
                    var getrs = await f.ActualizarMenus(gg.DocumentNode);
                    var all = getrs.control;
                    ra.Controls.Add(all);
                  //  GORS.Instance.RecivDataFromWebs = this;

                }));
            }
            else
            {
                HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
                List<Eventhtml> ghh = new List<Eventhtml>();
                List<DataSource> datasurce = new List<DataSource>();
                gg.LoadHtml(allcon);
                Dictionary<string, object> fromhtmlh = new Dictionary<string, object>();
                Dictionary<string, object> imagesvg = new Dictionary<string, object>();
                try
                {
                    var re = gg.DocumentNode.Descendants("event");
                    var getdatasoruce = gg.DocumentNode.Descendants("datasource");


                    var svghtm = gg.DocumentNode.Descendants("fromhtml");


                    foreach (var ik in svghtm.ElementAt(0).Descendants("htmldata"))
                    {
                        string name = "0";
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                        }

                        fromhtmlh.Add(name, ik.InnerHtml);

                    }
                    var svg = gg.DocumentNode.Descendants("imagesvg");

                    foreach (var ik in svg.ElementAt(0).Descendants("imagesvgsorce"))
                    {
                        string name = "0";
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                        }

                        imagesvg.Add(name, ik.InnerHtml);

                    }
                    foreach (var ik in getdatasoruce.ElementAt(0).Descendants("sources"))
                    {
                        DataSource k = new DataSource();
                        string name = "0";
                        string method = "0";
                        string urll = "0";
                        Dictionary<string, object> hedaer = new Dictionary<string, object>();
                        Dictionary<string, object> quriy = new Dictionary<string, object>();
                        Dictionary<string, object> body = new Dictionary<string, object>();
                        Dictionary<string, object> another = new Dictionary<string, object>();
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                            else if (yy.Name.Equals("method"))
                            {
                                method = yy.Value;
                            }
                            else if (yy.Name.Equals("url"))
                            {
                                urll = yy.Value;
                            }
                            else if (yy.Name.Equals("headr"))
                            {
                                hedaer.Add(yy.Name, yy.Value);
                            }
                            else if (yy.Name.Equals("query"))
                            {
                                quriy.Add(yy.Name, yy.Value);
                            }
                            else if (yy.Name.Equals("body"))
                            {
                                body.Add(yy.Name, yy.Value);
                            }


                            else
                            {

                                another.Add(yy.Name, yy.Value);
                            }


                        }

                        k.sourceName = name;
                        k.methodtype = method;
                        k.queryurl = quriy;
                        k.body = body;
                        k.anotherdata = another;
                        k.data = ik.InnerText;
                        k.hedaer = hedaer;
                        k.url = urll;

                        datasurce.Add(k);

                    }



                    //datasource
                    foreach (var ik in re.ElementAt(0).Descendants("event"))
                    {
                        Eventhtml k = new Eventhtml();
                        string name = "0";
                        string sourceid = "";
                        Dictionary<string, object> io = new Dictionary<string, object>();
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                            if (yy.Name.Equals("sourceid"))
                            {
                                sourceid = yy.Value;
                            }

                            io.Add(yy.Name, yy.Value);

                        }
                        k.attEvent = io;
                        k.eventName = name;
                        k.sourceid = sourceid;
                        k.datao = datasurce;
                        k.DataEvent = ik.InnerText;
                        ghh.Add(k);

                    }

                }
                catch (Exception ex)
                {

                }
                var j = new List<ControlInfo>();
                Radconverttojson f = new Radconverttojson(ghh, radValidationRule1, imagesvg, fromhtmlh,evn, onform);
                var dddd = await f.ActualizarMenus(gg.DocumentNode);
                var all = dddd.control;
                ra.Controls.Add(all);
               // GORS.Instance.RecivDataFromWebs = this;


            }
        }

        private RadForm ujj;
        /// <summary>
        /// loadForm
        /// </summary>
        /// <returns></returns>
        public async Task<RadForm> loadForm()
        {

            ujj = new RadForm();

           // vald = new Valdation();

            var ra = uj;

            ujj.FormClosing += testForm_FormClosing;
           // ra.ThemeName = them;
            ujj.ThemeName = this.themnamel;
          //  GORS.Instance.System_seting_main = them;
            if (ra.InvokeRequired)
            {
                ra.Invoke(new MethodInvoker(async () =>
                {
                    List<Eventhtml> ghh = new List<Eventhtml>();
                    List<DataSource> datasurce = new List<DataSource>();
                    HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();

                    gg.LoadHtml(allcon);
                    Dictionary<string, object> fromhtmlh = new Dictionary<string, object>();
                    Dictionary<string, object> imagesvg = new Dictionary<string, object>();
                    try
                    {
                        var re = gg.DocumentNode.Descendants("event");
                        var getdatasoruce = gg.DocumentNode.Descendants("datasource");

                        var svghtm = gg.DocumentNode.Descendants("fromhtml");


                        foreach (var ik in svghtm.ElementAt(0).Descendants("htmldata"))
                        {
                            string name = "0";
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                            }

                            fromhtmlh.Add(name, ik.InnerHtml);

                        }

                        var svg = gg.DocumentNode.Descendants("imagesvg");


                        foreach (var ik in svg.ElementAt(0).Descendants("imagesvgsorce"))
                        {
                            string name = "0";
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                            }

                            imagesvg.Add(name, ik.InnerHtml);

                        }
                        foreach (var ik in getdatasoruce.ElementAt(0).Descendants("sources"))
                        {
                            DataSource k = new DataSource();
                            string name = "0";
                            string method = "0";
                            string urll = "0";
                            Dictionary<string, object> hedaer = new Dictionary<string, object>();
                            Dictionary<string, object> quriy = new Dictionary<string, object>();
                            Dictionary<string, object> body = new Dictionary<string, object>();

                            Dictionary<string, object> another = new Dictionary<string, object>();
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                                else if (yy.Name.Equals("method"))
                                {
                                    method = yy.Value;
                                }
                                else if (yy.Name.Equals("url"))
                                {
                                    urll = yy.Value;
                                }
                                else if (yy.Name.Equals("headr"))
                                {
                                    hedaer.Add(yy.Name, yy.Value);
                                }
                                else if (yy.Name.Equals("query"))
                                {
                                    quriy.Add(yy.Name, yy.Value);
                                }
                                else if (yy.Name.Equals("body"))
                                {
                                    body.Add(yy.Name, yy.Value);
                                }

                                else
                                {

                                    another.Add(yy.Name, yy.Value);
                                }




                            }
                            k.sourceName = name;
                            k.methodtype = method;
                            k.queryurl = quriy;
                            k.anotherdata = another;
                            k.body = body;
                            k.data = ik.InnerText;
                            k.hedaer = hedaer;
                            k.url = urll;

                            datasurce.Add(k);

                        }
                        foreach (var ik in re.ElementAt(0).Descendants("event"))
                        {
                            Eventhtml k = new Eventhtml();
                            string name = "0";
                            string sourceid = "0";
                            Dictionary<string, object> io = new Dictionary<string, object>();
                            foreach (var yy in ik.Attributes)
                            {
                                if (yy.Name.Equals("id"))
                                {
                                    name = yy.Value;
                                }
                                if (yy.Name.Equals("sourceid"))
                                {
                                    sourceid = yy.Value;
                                }
                                io.Add(yy.Name, yy.Value);

                            }
                            k.attEvent = io;
                            k.eventName = name;
                            k.sourceid = sourceid;
                            k.datao = datasurce;
                            k.DataEvent = ik.InnerText;
                            ghh.Add(k);

                        }
                        //  MessageBox.Show(JsonConvert.SerializeObject(ghh));
                    }
                    catch (Exception ex)
                    {

                    }
                    var j = new List<ControlInfo>();

                    Radconverttojson f = new Radconverttojson(ghh, radValidationRule1, imagesvg, fromhtmlh,evn, onform);
                    var getrs = await f.ActualizarMenus(gg.DocumentNode);
                    var all = getrs.control;
                    ra.Controls.Add(all);
                //    GORS.Instance.RecivDataFromWebs = this;

                }));
            }
            else
            {
                HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
                List<Eventhtml> ghh = new List<Eventhtml>();
                List<DataSource> datasurce = new List<DataSource>();
                gg.LoadHtml(allcon);
                Dictionary<string, object> fromhtmlh = new Dictionary<string, object>();
                Dictionary<string, object> imagesvg = new Dictionary<string, object>();
                try
                {
                    var re = gg.DocumentNode.Descendants("event");
                    var getdatasoruce = gg.DocumentNode.Descendants("datasource");


                    var svghtm = gg.DocumentNode.Descendants("fromhtml");


                    foreach (var ik in svghtm.ElementAt(0).Descendants("htmldata"))
                    {
                        string name = "0";
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                        }

                        fromhtmlh.Add(name, ik.InnerHtml);

                    }
                    var svg = gg.DocumentNode.Descendants("imagesvg");

                    foreach (var ik in svg.ElementAt(0).Descendants("imagesvgsorce"))
                    {
                        string name = "0";
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                        }

                        imagesvg.Add(name, ik.InnerHtml);

                    }
                    foreach (var ik in getdatasoruce.ElementAt(0).Descendants("sources"))
                    {
                        DataSource k = new DataSource();
                        string name = "0";
                        string method = "0";
                        string urll = "0";
                        Dictionary<string, object> hedaer = new Dictionary<string, object>();
                        Dictionary<string, object> quriy = new Dictionary<string, object>();
                        Dictionary<string, object> body = new Dictionary<string, object>();
                        Dictionary<string, object> another = new Dictionary<string, object>();
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                            else if (yy.Name.Equals("method"))
                            {
                                method = yy.Value;
                            }
                            else if (yy.Name.Equals("url"))
                            {
                                urll = yy.Value;
                            }
                            else if (yy.Name.Equals("headr"))
                            {
                                hedaer.Add(yy.Name, yy.Value);
                            }
                            else if (yy.Name.Equals("query"))
                            {
                                quriy.Add(yy.Name, yy.Value);
                            }
                            else if (yy.Name.Equals("body"))
                            {
                                body.Add(yy.Name, yy.Value);
                            }


                            else
                            {

                                another.Add(yy.Name, yy.Value);
                            }


                        }

                        k.sourceName = name;
                        k.methodtype = method;
                        k.queryurl = quriy;
                        k.body = body;
                        k.anotherdata = another;
                        k.data = ik.InnerText;
                        k.hedaer = hedaer;
                        k.url = urll;

                        datasurce.Add(k);

                    }



                    //datasource
                    foreach (var ik in re.ElementAt(0).Descendants("event"))
                    {
                        Eventhtml k = new Eventhtml();
                        string name = "0";
                        string sourceid = "";
                        Dictionary<string, object> io = new Dictionary<string, object>();
                        foreach (var yy in ik.Attributes)
                        {
                            if (yy.Name.Equals("id"))
                            {
                                name = yy.Value;
                            }
                            if (yy.Name.Equals("sourceid"))
                            {
                                sourceid = yy.Value;
                            }

                            io.Add(yy.Name, yy.Value);

                        }
                        k.attEvent = io;
                        k.eventName = name;
                        k.sourceid = sourceid;
                        k.datao = datasurce;
                        k.DataEvent = ik.InnerText;
                        ghh.Add(k);

                    }

                }
                catch (Exception ex)
                {

                }
                var j = new List<ControlInfo>();
                Radconverttojson f = new Radconverttojson(ghh, radValidationRule1, imagesvg, fromhtmlh,evn, onform);
                var dddd = await f.ActualizarMenus(gg.DocumentNode);
                var all = dddd.control;
                //uj.Controls.Add(all);
                ra.Controls.Add(all);
              //  GORS.Instance.RecivDataFromWebs = this;


            }
            ujj.Controls.Add(ra);
            return ujj;
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
        public bool checkres(string ttt)
        {

            try
            {
                if (Regex.IsMatch(ttt, @"^([a-zA-Z]{0,1}:\\|http[s]{0,1}:\/\/|\\\\)"))
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
        public void getorsetMultiav(string curancysam, RadMultiColumnComboBox kk)
        {
            try
            {
                string columnname = kk.Tag.ToString();
                RadMultiColumnComboBox fd = new RadMultiColumnComboBox();
                fd = kk;
                int x = 0;
                for (int a = 0; a < fd.MultiColumnComboBoxElement.Rows.Count; a++)
                {

                    if (kk.MultiColumnComboBoxElement.Rows[a].Cells[columnname].Value.ToString().Equals(curancysam))
                    {
                        x = Convert.ToInt32(kk.MultiColumnComboBoxElement.Rows[a].Cells[columnname].RowInfo.Index.ToString());
                    }
                    // + radMultiColumnComboBox1.MultiColumnComboBoxElement.Rows[a].Cells[1].RowInfo.Index.ToString());

                }

                kk.SelectedIndex = x;
            }
            catch (Exception ex)
            {

            }
        }
        public Image ConvertBase64ToImage(byte[] bytes)
        {
            //  var bytes = Convert.FromBase64String(base64);

            using (var memory = new MemoryStream(bytes, 0, bytes.Length))
            {
                return Image.FromStream(memory, true);
            }
        }
        private Image em(string value)
        {
            WebRequest request = System.Net.WebRequest.Create(value + "");

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    return Bitmap.FromStream(stream);
                }
            }
        }
        public Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        Telerik.WinControls.UI.RadValidationRule radValidationRule1;
        Valdation ss = new Valdation();

        public Dictionary<string, object> getdatsource(List<hedaervalue> ii)
        {
            Dictionary<string, object> retudata = new Dictionary<string, object>();
            if (ii != null)
            {

                foreach (var iu in ii)
                {

                    try
                    {
                        var b = uj.Controls.Find(iu.hedervalue, true)[0];
                        var h = b as RadMaskedEditBox;
                        if (h != null)
                        {
                            retudata.Add(iu.hederkey, h.Text);
                        }
                        var hh = b as RadDateTimePicker;
                        if (hh != null)
                        {
                            retudata.Add(iu.hederkey, hh.Value);

                        }
                        var hhx = b as RadCheckBox;
                        if (hhx != null)
                        {
                            retudata.Add(iu.hederkey, hhx.Checked);
                        }

                        var bvvv = b as FlowLayoutPanel;
                        if (bvvv != null)
                        {

                            try
                            {

                                var qqq = bvvv.Controls.OfType<RadRadioButton>().Where(ss => ss.CheckState == CheckState.Checked).FirstOrDefault();
                                retudata.Add(iu.hederkey, qqq.Name);
                            }
                            catch (Exception ex)
                            {

                            }
                            //  getorsetMultiav(j, hjhn);
                        }
                        var hhxx = b as PictureBox;
                        if (hhxx != null)
                        {
                            retudata.Add(iu.hederkey, hhxx.Image);
                        }

                        // MessageBox.Show(anotherData.ToString());
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }

            return retudata;
        }
     //   private Valdation vald;
        public void processevent(List<hedaervalue> ii)
        {
            if (ii != null)
            {

                foreach (var iu in ii)
                {

                    try
                    {
                        var b = uj.Controls.Find(iu.hederkey, true)[0];
                        var er = iu.hedervalue.Split('#');
                        if (er[1].ToLower().StartsWith("ena"))
                        {
                            b.Enabled = true;
                        }
                        if (er[1].ToLower().StartsWith("dis"))
                        {
                            b.Enabled = false;
                        }
                        if (er[1].ToLower().StartsWith("cle"))
                        {
                            b.Text = "";
                        }
                        if (er[1].ToLower().StartsWith("hid"))
                        {
                            b.Visible = false;
                        }
                        if (er[1].ToLower().StartsWith("start"))
                        {
                            var h = b as RadWaitingBar;
                            if (h != null)
                            {
                                var ui = h.Tag;

                                if (ui != null)
                                {

                                    var ass = h.AssociatedControl;

                                    if (ass == null)
                                    {

                                        try
                                        {
                                            var bz = uj.Controls.Find(ui.ToString(), true)[0];
                                            h.AssociatedControl = bz;
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                    }
                                }

                                h.StartWaiting();
                            }
                        }
                        if (er[1].ToLower().StartsWith("stop"))
                        {
                            var h = b as RadWaitingBar;
                            if (h != null)
                            {

                                var ui = h.Tag;

                                if (ui != null)
                                {

                                    var ass = h.AssociatedControl;

                                    if (ass == null)
                                    {

                                        try
                                        {
                                            var bz = uj.Controls.Find(ui.ToString(), true)[0];
                                            h.AssociatedControl = bz;
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                    }
                                }
                                h.StopWaiting();
                            }
                        }


                        if (er[1].ToLower().StartsWith("click"))
                        {
                            var h = b as RadButton;
                            if (h != null)
                            {
                                //  MessageBox.Show("fffff");
                                h.PerformClick();
                            }
                        }

                        if (er[1].ToLower().StartsWith("read"))
                        {
                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = true;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = true;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = true;
                            }

                        }

                        if (er[1].ToLower().StartsWith("notread"))
                        {

                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = false;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = false;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = false;
                            }
                        }
                        if (er[1].ToLower().StartsWith("show"))
                        {
                            b.Visible = true;
                        }

                        // MessageBox.Show(anotherData.ToString());
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }

        }
        private async void btnExecute_WebAPI(string apiname, string authoa, string dat, Eventhtml k, List<hedaervalue> onstart, List<hedaervalue> onstop)
        {
            processevent(onstart);
            //  MessageBox.Show("ehhxxxxxxxxxxxmmmmmmmmm");
            await BbtnExecute_WebAPI(apiname, authoa, dat, k, onstop);
        }

        private async Task BbtnExecute_WebAPI(string apiname, string method, string dat, Eventhtml k, List<hedaervalue> onstopp)
        {


            // database = new controlx();
            // MessageBox.Show("vvvvvvvvvvvvvvv");
            try
            {
                customalrtDalog_alert_daloge dd = new customalrtDalog_alert_daloge();
                //  MessageBox.Show("ehh");
                var urr = checkres(apiname);
                string urll = "";
                if (!urr)
                {

                    urll = GORS.Instance.API_URL + apiname + "";
                }
                else
                {
                    urll = apiname;
                }
                Method b = Method.GET;

                try
                {
                    Enum.TryParse<Method>(method, out b);
                }
                catch (Exception ex)
                {

                }


                var request = new RestRequest(b);
                //  var gg = new RestClient();
                try
                {
                    JToken tok = JToken.Parse(dat);

                    var getquer = tok.SelectToken("query");

                    if (getquer is JArray)
                    {
                        var eq = getquer as JArray;
                        foreach (var kj in eq)
                        {
                            try
                            {
                                var key = (string)kj.SelectToken("key");
                                var value = (string)kj.SelectToken("value");
                                request.AddQueryParameter(key, value);
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                    }
                    //  MessageBox.Show(JsonConvert.SerializeObject(tok));
                }
                catch (Exception ex)
                {

                }
                try
                {
                    JToken tok = JToken.Parse(dat);

                    var getquer = tok.SelectToken("header");

                    if (getquer is JArray)
                    {
                        var eq = getquer as JArray;
                        foreach (var kj in eq)
                        {
                            try
                            {
                                var key = (string)kj.SelectToken("key");
                                var value = (string)kj.SelectToken("value");
                                request.AddHeader(key, value);
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                    }
                    //  MessageBox.Show(JsonConvert.SerializeObject(tok));
                }
                catch (Exception ex)
                {

                }
                try
                {
                    JToken tok = JToken.Parse(dat);

                    var getquer = tok.SelectToken("body");

                    dat = JsonConvert.SerializeObject(getquer);
                }
                catch (Exception ex)
                {


                }
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("username", GORS.Instance.API_Username);
                request.AddHeader("refreshtoken", GORS.Instance.API_Ref);
                request.AddHeader("Authorization", GORS.Instance.API_AcessToken);

                 // request.AddHeader("User-Agent", "/vvvvvvvvvvvvvvmmmmmmmm");
                request.AddHeader("Accept", "*/*");
                // request.AddHeader("Host", "192.168.1.1");

              //  MessageBox.Show(request.Parameters.ElementAt(0).);
                //  RadMessageBox.Show(radMaskedEditBox1.Text.EncodeBase64());
                request.AddParameter("application/json", dat, RestSharp.ParameterType.RequestBody);
                IRestResponse response = await database.Getresponse(urll, request);
                if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                    // MessageBox.Show(response.Content);

                    // response.Content = "hhhhhhhhhhhhhh";

                    setDatasource(k, response.Content, onstopp);
                }
                else
                {
                    try
                    {

                        object selct = "0";

                        var getresponse = k.datao.Where(ss => ss.sourceName.ToLower().Equals(k.sourceid.ToLower())).ToList();

                        if (getresponse.Count > 0)
                        {
                            var e = getresponse.ElementAt(0);
                            var getano = e.anotherdata;

                            getano.TryGetValue("selectresponseerror", out selct);
                            var r = selctfrom(response.Content, selct.ToString());
                            if (IsValidJson(response.Content))
                            {
                                dd.messge_aler(themnamel, 2, 0, JsonConvert.SerializeObject(r), "message");

                            }
                            else
                            {
                                dd.messge_aler(themnamel, 2, 0, response.Content, "message");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dd.messge_aler(themnamel, 2, 0, ex.Message, "message");

                    }
                    // MessageBox.Show(response.Content);
                }
                // MessageBox.Show(response.Content+"fffffffffffffffffff");

            }
            catch (Exception ex)
            {
                processevent(onstopp);
                //  logregister.registerece(ex);
                // radWaitingBar1.Visible = false;
                //radWaitingBar1.StopWaiting();
                // RadMessageBox.Show(sqlError.Message, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
        AA_PI database = new AA_PI();


        private JToken selctfrom(string data, string selc)
        {
            JToken h = null;
            try
            {
                JObject j = new JObject();
                var uio = JToken.Parse(data);
                j.Add("response", uio);
                if (!selc.Equals("0"))
                {
                    if (!selc.Equals(""))
                    {

                        h = j.SelectToken(selc);


                    }
                    else
                    {
                        h = uio;
                    }
                }
                else
                {
                    h = uio;
                }
            }
            catch (Exception ex)
            {


            }
            return h;

        }

        public bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {

                    //  RadMessageBox.Show(jex.Message + ":" + strInput, "حدث خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                    //Exception in parsing json
                    //  Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {

                    //  RadMessageBox.Show(ex.Message, "حدث خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                    // Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {


                return false;
            }
        }
        private void setDatasource(Eventhtml ii, string data, List<hedaervalue> onstoppp)
        {

            customalrtDalog_alert_daloge dd = new customalrtDalog_alert_daloge();


            try
            {
                if (ii != null)
                {
                    var getresponse = ii.datao.Where(ss => ss.sourceName.ToLower().Equals(ii.sourceid.ToLower())).ToList();

                    if (getresponse.Count > 0)
                    {
                        var e = getresponse.ElementAt(0);
                        var getano = e.anotherdata;
                        object selct = "0";
                        getano.TryGetValue("selectresponse", out selct);
                        object selcta = "0";
                        getano.TryGetValue("showasmessage", out selcta);


                        var r = selctfrom(data, selct.ToString());
                        if (selcta.ToString().ToLower().StartsWith("t"))
                        {

                            processevent(onstoppp);

                            if (IsValidJson(data))
                            {
                                dd.messge_aler(themnamel, 1, 0, JsonConvert.SerializeObject(r), "message");

                            }
                            else
                            {
                                dd.messge_aler(themnamel, 1, 0, data, "message");

                            }
                        }
                        else
                        {
                            processevent(onstoppp);
                            foreach (var iu in ii.EventControl)
                            {

                                try
                                {
                                    var b = uj.Controls.Find(iu.controlname, true)[0];


                                    if (iu.controlEventname.ToLower().StartsWith("sorc"))
                                    {
                                        var h = b as RadGridView;
                                        if (h != null)
                                        {

                                            h.DataSource = r;
                                            /*  vald.adddatetimes(h);

                                              Random rand = new Random();
                                              DataTable productsTable = new DataTable();
                                              productsTable.Columns.Add("ProductID", typeof(int));
                                              productsTable.Columns.Add("CategoryID", typeof(int));
                                              productsTable.Columns.Add("Name", typeof(string));
                                              productsTable.Columns.Add("UnitPrice", typeof(decimal));
                                              for (int i = 0; i < 30; i++)
                                              {
                                                  productsTable.Rows.Add(i, rand.Next(0, 5), "Product" + i, 1.25 * i);
                                              }

                                             h.MasterTemplate.Templates[0].DataSource = productsTable;*/
                                        }

                                        var hh = b as RadCardView;
                                        if (hh != null)
                                        {

                                            hh.DataSource = r;
                                        }
                                        var hhx = b as RadMultiColumnComboBox;
                                        if (hhx != null)
                                        {

                                            hhx.DataSource = r;
                                        }
                                    }


                                    // MessageBox.Show(anotherData.ToString());
                                }
                                catch (Exception ex)
                                {
                                    // MessageBox.Show(ex.Message + "ddfdfdddd");
                                    processevent(onstoppp);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message+"ddddd");
                processevent(onstoppp);
            }
        }

        private List<hedaervalue> anotherdataget(string daiop)
        {


            List<hedaervalue> ut = new List<hedaervalue>();
            try
            {

                if (!daiop.Equals("0"))
                {

                    MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                    //Scan matches
                    foreach (Match match in matches)
                    {
                        //Split match by colon
                        string[] chunks = match.Value.Split(':');
                        hedaervalue dd = new hedaervalue();
                        if (chunks.Length != 2) continue;

                        //Extract property name and value
                        string propName = chunks[0].Trim();
                        string propValue = chunks[1].Trim();

                        //Remove semicolon
                        if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                        //Add property to list
                        dd.hedervalue = propValue;
                        dd.hederkey = propName;

                        ut.Add(dd);

                    }

                }
            }
            catch (Exception ex)
            {
            }
            return ut;




        }
        public async void processeventt(Eventhtml ii)
        {


            if (ii != null)
            {
                if (!ii.sourceid.Equals("0"))
                {
                    var iuup = ii.datao.Where(ss => ss.sourceName.ToLower().Equals(ii.sourceid)).ToList();
                    if (iuup.Count > 0)
                    {


                        var getsurce = iuup.ElementAt(0);
                        object checkb = null;
                        getsurce.anotherdata.TryGetValue("usenull", out checkb);
                        if (checkb != null)
                        {
                            if (checkb.ToString().StartsWith("t"))
                            {
                                var sss = await ss.CheckValdation(radValidationProvider1);
                                if (!sss)
                                {
                                    return;
                                }
                            }
                        }


                        var gethed = getdatsource(getsurce.headervalues);
                        var body = getdatsource(getsurce.bodyata);
                        List<hedaervalue> fst = new List<hedaervalue>();

                        List<hedaervalue> fstop = new List<hedaervalue>();
                        List<hedaervalue> fstopmessage = new List<hedaervalue>();
                        object onstartmes = "0";
                        try
                        {
                            object onstart = "";
                            getsurce.anotherdata.TryGetValue("onstart", out onstart);
                            fst = anotherdataget(onstart.ToString());
                            object onstop = "";
                            getsurce.anotherdata.TryGetValue("onstop", out onstop);

                            fstop = anotherdataget(onstop.ToString());


                            getsurce.anotherdata.TryGetValue("onstartmessage", out onstartmes);
                            fstopmessage = anotherdataget(onstartmes.ToString());
                        }
                        catch (Exception ex)
                        {

                        }

                        if (fstopmessage.Count > 0)
                        {
                            string nmess = "0";
                            try
                            {
                                var g = fstopmessage.Where(ss => ss.hederkey.ToLower().Equals("message")).ToList();
                                nmess = g.ElementAt(0).hedervalue.ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                            if (RadMessageBox.Show(nmess, "تأكيد", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                            {
                                object[] ert = new object[body.Count];
                                for (int i = 0; i < body.Count; i++)
                                {

                                    ert[i] = body.ElementAt(i).Value;
                                }
                                string results = string.Format(getsurce.data, ert);

                                btnExecute_WebAPI(getsurce.url, getsurce.methodtype, results, ii, fst, fstop);
                                //MessageBox.Show(results);
                                var gue = getdatsource(getsurce.querydat);
                            }
                        }
                        else
                        {
                            object[] ert = new object[body.Count];
                            for (int i = 0; i < body.Count; i++)
                            {

                                ert[i] = body.ElementAt(i).Value;
                            }
                            string results = string.Format(getsurce.data, ert);

                            btnExecute_WebAPI(getsurce.url, getsurce.methodtype, results, ii, fst, fstop);
                            //MessageBox.Show(results);
                            var gue = getdatsource(getsurce.querydat);

                        }



                    }
                }
                foreach (var iu in ii.EventControl)
                {

                    try
                    {
                        var b = uj.Controls.Find(iu.controlname, true)[0];

                        if (iu.controlEventname.ToLower().StartsWith("ena"))
                        {
                            b.Enabled = true;
                        }
                        if (iu.controlEventname.ToLower().StartsWith("dis"))
                        {
                            b.Enabled = false;
                        }
                        if (iu.controlEventname.ToLower().StartsWith("start"))
                        {
                            var h = b as RadWaitingBar;
                            if (h != null)
                            {
                                h.StartWaiting();
                            }

                        }
                        if (iu.controlEventname.ToLower().StartsWith("stop"))
                        {
                            var h = b as RadWaitingBar;
                            if (h != null)
                            {
                                h.StopWaiting();
                            }

                        }

                        if (iu.controlEventname.ToLower().StartsWith("read"))
                        {
                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = true;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = true;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = true;
                            }
                            var hhxx = b as RadRadioButton;
                            if (hhxx != null)
                            {
                                hhxx.ReadOnly = true;
                            }
                        }
                        if (iu.controlEventname.ToLower().StartsWith("click"))
                        {
                            var h = b as RadButton;
                            if (h != null)
                            {
                                h.PerformClick();
                            }
                        }
                        if (iu.controlEventname.ToLower().StartsWith("notread"))
                        {

                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = false;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = false;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = false;
                            }
                            var hhxx = b as RadRadioButton;
                            if (hhxx != null)
                            {
                                hhxx.ReadOnly = false;
                            }
                        }
                        if (iu.controlEventname.ToLower().StartsWith("cle"))
                        {
                            b.Text = "";
                        }
                        if (iu.controlEventname.ToLower().StartsWith("hid"))
                        {
                            b.Visible = false;
                        }
                        if (iu.controlEventname.ToLower().StartsWith("show"))
                        {
                            b.Visible = true;
                        }
                        // MessageBox.Show(anotherData.ToString());
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }

        }
        public void ReceveFroms(object anotherData)
        {
            var ii = anotherData as Eventhtml;

            processeventt(ii);

            var jjj = anotherData as EventOnchange;
            if (jjj != null)
            {

                foreach (var iu in jjj.datahtml.EventControl)
                {

                    try
                    {
                        var b = uj.Controls.Find(iu.controlname, true)[0];
                        var er = iu.controlEventname.Split('#');
                        if (er[1].ToLower().StartsWith("ena"))
                        {
                            b.Enabled = true;
                        }
                        if (er[1].ToLower().StartsWith("dis"))
                        {
                            b.Enabled = false;
                        }
                        if (er[1].ToLower().StartsWith("cle"))
                        {
                            b.Text = "";
                        }
                        if (er[1].ToLower().StartsWith("hid"))
                        {
                            b.Visible = false;
                        }
                        if (er[1].ToLower().StartsWith("read"))
                        {
                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = true;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = true;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = true;
                            }
                        }

                        if (er[1].ToLower().StartsWith("notread"))
                        {

                            var h = b as RadMaskedEditBox;
                            if (h != null)
                            {
                                h.ReadOnly = false;
                            }
                            var hh = b as RadDateTimePicker;
                            if (hh != null)
                            {
                                hh.ReadOnly = false;
                            }
                            var hhx = b as RadCheckBox;
                            if (hhx != null)
                            {
                                hhx.ReadOnly = false;
                            }
                        }
                        if (er[1].ToLower().StartsWith("show"))
                        {
                            b.Visible = true;
                        }
                        if (er[1].ToLower().StartsWith("set"))
                        {
                            bool ch = false;
                            var gg = b as RadCheckBox;
                            var hj = b as RadDateTimePicker;

                            var hjh = b as PictureBox;
                            var hjhn = b as RadMultiColumnComboBox;

                            var bvvv = b as FlowLayoutPanel;
                            if (bvvv != null)
                            {
                                ch = true;
                                try
                                {
                                    var j = (string)jjj.columnvalue.SelectToken(er[0]);
                                    var qqq = bvvv.Controls.OfType<RadRadioButton>().Where(ss => ss.Name.Equals(j)).FirstOrDefault();
                                    qqq.CheckState = CheckState.Checked;
                                }
                                catch (Exception ex)
                                {

                                }
                                //  getorsetMultiav(j, hjhn);
                            }

                            if (hjhn != null)
                            {
                                ch = true;
                                var j = (string)jjj.columnvalue.SelectToken(er[0]);
                                getorsetMultiav(j, hjhn);
                            }


                            if (hjh != null)
                            {
                                ch = true;
                                try
                                {
                                    var j = (string)jjj.columnvalue.SelectToken(er[0]);

                                    if (checkres(j))
                                    {

                                        var ee = em(j);
                                        hjh.Image = ee;

                                    }
                                    else
                                    {

                                        var dd = Convert.FromBase64String(j);
                                        var ee = ConvertBase64ToImage(dd);
                                        hjh.Image = ee;
                                    }

                                }
                                catch (Exception ex)
                                {

                                }
                            }

                            if (gg != null)
                            {
                                ch = true;
                                try
                                {
                                    var j = (bool)jjj.columnvalue.SelectToken(er[0]);
                                    gg.Checked = j;
                                }
                                catch (Exception ex)
                                {
                                    var f = jjj.columnvalue.SelectToken(er[0]).ToString();

                                    if (f.ToLower().StartsWith("1"))
                                    {
                                        gg.Checked = true;
                                    }
                                    else
                                    {
                                        gg.Checked = false;
                                    }

                                }
                            }

                            if (hj != null)
                            {
                                ch = true;
                                try
                                {
                                    var j = (DateTime)jjj.columnvalue.SelectToken(er[0]);
                                    hj.Value = j;
                                }
                                catch (Exception ex)
                                {


                                }
                            }
                            if (!ch)
                            {
                                var datresu = jjj.columnvalue.SelectToken(er[0]).ToString();

                                b.Text = datresu;
                            }
                        }
                        // MessageBox.Show(anotherData.ToString());
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }

        }
    }
}
