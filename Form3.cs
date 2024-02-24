using BjSTools.File;
using ControlSystem;
using dynFormLib;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Html;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;
using winToWeb.html;
using winToWeb.som;

namespace winToWeb
{
    public partial class Form3 : RadForm, RecevDataFromWeb
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        public void ReceveFroms(object anotherData)
        {
            // var b = all.Controls.Find("b", true)[0];
          
          //  MessageBox.Show(b.Text);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           // winToWeb.control.getdependencys.setThem(this.ThemeName);
           mcon userControl = new mcon();
            BindingList<Person> list = new BindingList<Person>()
            {
                new Person(DateTime.Now, "Adam", "Johnson", Person.OccupationPositions.SuppliesManager, "(555) 222 3333", 1500),
                new Person(DateTime.Now, "Michael", "Philips", Person.OccupationPositions.StaffManager, "(555) 444 4567", 1450),
                new Person(DateTime.Now, "Paul", "Carter", Person.OccupationPositions.Consultant, "(555) 555 4567", 1499)
            };

           // baseGridControl1.gridControl.d.DataSource = list;

        }
       // Astoldesinger.allcontrols.APIcontrola aPI_WEB_MESSAGE = new Astoldesinger.allcontrols.APIcontrola();
        public void addto() {
            


        }
        /*
        public async void getdata(string typ, string typupdateordaelte, int disabelorenable, string nameop, string IDwhenupdate, string IDform, int typp)
        {

            //getdata("1", "1", Convert.ToInt32(radCheckBox6.Checked), radMaskedEditBox4.Text, IDwhenupdate, "0", 1);
            //@typ1 int,@typ2 nvarchar(max),@typ3 bit,@typ4 int,@typ5 nvarchar(100),@typ6 int,@typ7 int
            dynamic[] ppa = { typ, "nooo", disabelorenable.ToString(), typupdateordaelte, nameop, IDwhenupdate, IDform };
            string resul = aPI_WEB_MESSAGE.setdat("1", "1", "0", "0", ppa, "0", "0");
            // cacher / cacherbillgetadv

            await BbtnExecute_WebAPIDell("desin", "uidesin", resul, typp);
        }*/
       /* private async Task BbtnExecute_WebAPIDell(string apiname, string doman, string getdata, int typ)
        {

            //api/bill/deletbill

            //  typsegets = "0";
            //   api.CDatabase database = new api.CDatabase();

            try
            {
                // radWaitingBar1.Visible = true;
                //  radWaitingBar1.StartWaiting();
                string urll = GORS.Instance.API_URL + "" + apiname + "/" + doman + "";
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("username", GORS.Instance.API_Username);
                //   request.AddHeader("typs", typeforsuborcomb);
                request.AddHeader("refreshtoken", GORS.Instance.API_Ref);
                // request.AddHeader("alfra", alfraID);
                request.ReadWriteTimeout = -1;
                // request.AddHeader("stockID", stockID);
                request.AddHeader("Authorization", GORS.Instance.API_AcessToken);
                request.AddParameter("application/json", getdata, RestSharp.ParameterType.RequestBody);
                IRestResponse response = await aPI_WEB_MESSAGE.Getresponse(urll, request);


                MessageBox.Show(response.Content);
            }
            catch (Exception sqlError)
            {

                // radWaitingBar1.Visible = false;
                // radWaitingBar1.StopWaiting();
                MessageBox.Show(sqlError.Message);
            }

        }*/
        private string getautho()
        {
            string resultwith = radTextBox2.Text + ":" + mmd5.myMD5(mmd5.myMD5(radTextBox3.Text)).EncodeBase64();
            string mmv = "Basic  " + resultwith.EncodeBase64();

            return mmv;


        }
        private async Task BbtnExecute_WebAPI(string typs, int aa, int refe, string apiname, string authontic)
        {


            // database = new controlx();
            // MessageBox.Show("vvvvvvvvvvvvvvv");
            try
            {

                //  MessageBox.Show("ehh");
                string urll = "http://localhost:80/api/Astoolacount/" + apiname + "";
                var request = new RestRequest(Method.GET);
                //  var gg = new RestClient();

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("username", "nousernmaes");
                request.AddHeader("refreshtoken", "norefreshtokem");
                request.AddHeader("Authorization", getautho());
                //  request.AddHeader("User-Agent", "/vvvvvvvvvvvvvvmmmmmmmm");
                request.AddHeader("Accept", "*/*");
                // request.AddHeader("Host", "192.168.1.1");
                request.AddHeader("usertyp", Convert.ToInt32(radCheckBox1.Checked).ToString());
                request.AddHeader("email", radTextBox2.Text);
                //  RadMessageBox.Show(radMaskedEditBox1.Text.EncodeBase64());
                // request.AddParameter("application/json", insertdate2(typs, aa.ToString()), RestSharp.ParameterType.RequestBody);
                IRestResponse response = await database.Getresponse(urll, request);


                // MessageBox.Show(response.Content);

                // response.Content = "hhhhhhhhhhhhhh";
                //MessageBox.Show(response.Content);
                //Bearer 7WRwyliH1LYT19iDLlLhULtVkVsQv2IxucyusvBxwBSpHHucEFIcXZWwQ_0hUs4e6c8RlUjukN2EijTW_gtaZoFV8a5OuyqziH-XwA_tN3pHrEyaCg8VX36NSnm1YgZANG5ZdUnHPTmCRcvrntyLogsKg_KC6hMxigzauurM1oVaVhXF2V4xqwEJt6g292ZbRbejFyJpBnLAbHlFoSpYkvkFy0MW21N9Ilv-F0U33zGOS-w9tLwpPGdi72bh2cfzDg3-0Qid4mRcSzYrBpOTRyLnNV8hGxV7KjRvimzyAhDiT7-zzpy3HIwovHMs3QVVYcqtOBJ1GgdWX0qouq4v4A
                //  MessageBox.Show(response.Content+"fffffffffffffffffff");
                SetFromRequest(response, Convert.ToInt32(typs), refe);
            }
            catch (Exception ex)
            {
              //  logregister.registerece(ex);
                // radWaitingBar1.Visible = false;
                //radWaitingBar1.StopWaiting();
                // RadMessageBox.Show(sqlError.Message, "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
        AA_PI database = new AA_PI();
        public class Responselogin
        {

            public string AccessToken { get; set; }

            public string TokenType { get; set; }

            public int ExpiresIn { get; set; }

            public string RefreshToken { get; set; }

            public string Error { get; set; }


            public string clientid { get; set; }


            public string userName { get; set; }


            public string issued { get; set; }


            public string expires { get; set; }


            // [JsonProperty("userID")]
            public string userID { get; set; }
            //  [JsonProperty("usernames")]
            public string usernames { get; set; }
            // [JsonProperty("stockname")]
            public string stockname { get; set; }
            //  [JsonProperty("alfraname")]
            public string alfraname { get; set; }

            //  [JsonProperty("stockID")]
            public string stockID { get; set; }

            // [JsonProperty("alfraID")]
            public string alfraID { get; set; }

            //  [JsonProperty("cacherID")]
            public string cacherID { get; set; }
            // [JsonProperty("allafra")]
            public string allafra { get; set; }
            public string DateFormate { get; set; }
            public int DateType { get; set; }

            public bool? Dateenable { get; set; }
            public string profile { get; set; }

            public JObject extra
            {
                get
                {
                    return extr;
                }

                set
                {
                    extr = value;
                }
            }

            private JObject extr = new JObject();

        }
        public async void SetFromRequest(IRestResponse responsee, int type, int reff)
        {


            //  MessageBox.Show(responsee.Content);
            if (!string.IsNullOrEmpty(responsee.Content))
            {
              

                    if (type == 1)
                    {
                        string alldatesc = "[" + responsee.Content + "]";

                        var dattabklev = JsonConvert.DeserializeObject<List<Responselogin>>(alldatesc);//, (typeof(DataTable)));
                        //RadMessageBox.Show(alldates);
                        // RadMessageBox(responsee.Content);
                        string acesstokens = dattabklev.ElementAt(0).AccessToken.ToString();//acesstoken
                        string refreshtokens = dattabklev.ElementAt(0).RefreshToken;//dattabklev.Rows[0][3].ToString();//acesstoken
                        string usernames = dattabklev.ElementAt(0).userName;//dattabklev.Rows[0][6].ToString();//acesstoken
                        string userID = dattabklev.ElementAt(0).userID;//dattabklev.Rows[0][9].ToString();//acesstoken
                      
                        var picc = dattabklev.ElementAt(0).profile;
                   /* Astoldesinger.allcontrols.GORS.Instance.API_AcessToken = acesstokens;
                    Astoldesinger.allcontrols.GORS.Instance.API_Ref = refreshtokens;
                    Astoldesinger.allcontrols.GORS.Instance.API_Username = usernames;
                    Astoldesinger.allcontrols.GORS.Instance.API_URL = "http://localhost:80/api/";
                    var strinn = @"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\WindowsFormsApplication5\WindowsFormsApplication5\bin\Debug\setings\mainsys_sting.txt";
                    var textt = File.ReadAllText(strinn);*/
                  /*  Astoldesinger.allcontrols.GORS.Instance.System_seting_main = textt;
                    Astoldesinger.allcontrols.GORS.Instance.inforceShowConfirmMessage = true;
                    Astoldesinger.allcontrols.GORS.Instance.showMEssageStatuse = true;
                    Astoldesinger.allcontrols.GORS.Instance.A_daloge = true;
                    Astoldesinger.allcontrols.GORS.Instance.A_alert = false;
                    Astoldesinger.allcontrols.GORS.Instance.A_sound = false;
                    Astoldesinger.allcontrols.GORS.Instance.design_aurherize = this;
                   // Astoldesinger.allcontrols.GORS.Instance.API_UserAgent = "fffff";
                    // Astoldesinger.allcontrols.GORS.Instance.API_Ref = A.Instance.API_Ref;
                    Astoldesinger.allcontrols.GORS.Instance.Useridc = userID;

                    */
                    // radTextBox4.Text = acesstokens;
                    /*  try
                      {

                          var gggetv = Convert.FromBase64String(picc);
                          ImageConverter d = new ImageConverter();
                          var ggget = (Image)d.ConvertFrom(gggetv);

                         // var gggetv = System.Text.Encoding.UTF8.GetBytes(picc);
                         // var kk = ConvertBase64ToImagev(gggetv);

                          pictureBox1.Image = ggget;


                      }
                      catch(Exception ex) {
                          MessageBox.Show(ex.Message+"fffffffffff");
                      }
                      */

                    /* string stockname = dattabklev.Rows[0][11].ToString();//acesstoken
                     string alfraname = dattabklev.Rows[0][12].ToString();//acesstoken
                     string stockID = dattabklev.Rows[0][13].ToString();//acesstoken
                     string alfraID = dattabklev.Rows[0][14].ToString();//acesstoken

                     string cacherID = dattabklev.Rows[0][15].ToString();
                     string alfraall = dattabklev.Rows[0][16].ToString();
                     */


                    /* textBox1.Text = acesstokens;
                     textBox3.Text = refreshtokens;

                     radWaitingBar1.AssociatedControl = radListView1;
                     radWaitingBar1.StartWaiting();
                     mmrn();*/
                    //  jj = new IconnectionSigrR;
                    GORS.Instance.API_Username = usernames;
                    GORS.Instance.API_Ref = refreshtokens;
                   
                        //var y=  

                        GORS.Instance.API_AcessToken = string.Format("Bearer {0}", "" + acesstokens + "");
                        GORS.Instance.API_URL = "http://localhost/api/";

                        radTextBox1.Text = GORS.Instance.API_AcessToken;
                        /*  MessageBox.Show(dattabklev.ElementAt(0).usernames);
                          MessageBox.Show(dattabklev.ElementAt(0).userName);
                          MessageBox.Show(dattabklev.ElementAt(0).clientid);*/

                        //   MessageBox.Show("hjghjghjgsssssssssssss");


                        // MessageBox.Show("hjghjghjg");
                        //  astollchatcore cc = new astollchatcore();
                        // cc.showchat(textBox1.Text, acesstokens, "http://localhost/", refreshtokens, "reffHub");

                        // radMenuItem2.Enabled = true;


                        //lisddadd.Dock = DockStyle.Fill;

                        // RadMessageBox.Show("تم التصال");
                    }
                    else
                    {

                        RadMessageBox.Show("حدث خطا اثناء الاتصال");
                    }

              
            }
            else
            {
                RadMessageBox.Show("aaaaaaaaaaa");
            }
        }
        public class parent
        {
            public string Parentnamee { get; set; }
            public List<child> childs { get; set; }

        }
            public class child {
            private HtmlNode h;
            public child(HtmlNode htm) {
                h = htm;
            }
            public string namee
            {
                get
                {
                    return h.Name;
                }
            }
            private Dictionary<string, string> propert {
                get {
                    return gge();
                } }
            public parent parents { get; set; }

            private Dictionary<string, string> gge() {

                Dictionary<string, string> aa = new Dictionary<string, string>();
                foreach (var qqv in h.Attributes)
                {
                    try
                    {

                        aa.Add(qqv.Name, qqv.Value);
                    }
                    catch (Exception)
                    {

                    }

                }
                return aa;
            }
            
        }
 
        public Dictionary<string, object> addtoGroup(HtmlNode gg) {
            Dictionary<string, object> aa = new Dictionary<string, object>();
            Point poin = new Point(0,0);
            foreach (var qqv in gg.Attributes)
            {
                try
                {

                    if (qqv.Name.ToLower().Equals("style"))
                    {                   
                        var getsty = CssBlock(qqv.Value);
                        aa.Add("style", getsty);
                    }
                    else
                    {
                        aa.Add(qqv.Name, qqv.Value);
                    }
                }
                catch (Exception)
                {

                }

            }
          //  var ab = new ControlInfo("label", poin, new Size(80, 15), "lblLastName", "Last Name:", "", "");
         //   dd.Add(ab);
            return aa;

        }
        private int wid(Dictionary<string, object> aab,string key) {

           object ccm;
            try
            {
                aab.TryGetValue(key, out ccm);

                int k = Convert.ToInt32(ccm.ToString());
                return k;
            }
            catch (Exception ex) {
                return 0;
            }
        }

        public Dictionary<string, string>  CssBlock(string style)
           
        {
            Dictionary<string, string> Properties = new Dictionary<string, string>();

            //Extract property assignments
            MatchCollection matches = Parser.Match(Parser.CssProperties, style);

            //Scan matches
            foreach (Match match in matches)
            {
                //Split match by colon
                string[] chunks = match.Value.Split(':');

                if (chunks.Length != 2) continue;

                //Extract property name and value
                string propName = chunks[0].Trim();
                string propValue = chunks[1].Trim();

                //Remove semicolon
                if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                //Add property to list
                Properties.Add(propName, propValue);

             
            }

            return Properties;
        }

        private void ListControls(RadTreeNodeCollection nodes, Object parent)
        {

            Control control = parent as Control;
            RadTreeNode new_node = nodes.Add(
                control.Name + " (" +
                control.GetType().Name + ")");
            foreach (Control child in control.Controls)
            {
                ListControls(new_node.Nodes, child);
            }

        }
        private List<TreeviewPersist_json> RunNode(RadTreeNode node)
        {
            List<TreeviewPersist_json> nodeOut = new List<TreeviewPersist_json>();
            foreach (RadTreeNode child in node.Nodes)
            {
                List<TreeviewPersist_json> grandchild = RunNode(child);
              //  nodeOut.Add(new TreeviewPersist_json(child.Text, grandchild, child.Checked, null));
            }
            return nodeOut;
        }
        private Dictionary<string, object>  FindParentt(HtmlNode gg)
        {


            Dictionary<string, object> aab = addtoGroup(gg);
            if (gg.HasChildNodes)
            {


                var attributessv = new JObject();
              
                List<child> nch = new List<child>();
                foreach (var qq in gg.ChildNodes)
                {                   
                var k=  FindParentt(qq);
                  
                      
                  
                    try
                    {
                        aab.Add(gg.Name, k);
                      //  var x = wid(aab,"w");
                      //  var y = wid(aab, "y");
                      //  var ab = new ControlInfo("label", new Point(y, x), new Size(80, 15), "lblLastName", "Last Name:", "", "");
                      //  dd.Add(ab);

                    }
                    catch (Exception ex) {

                    }

                    //  ob.Add("jjj", attributes);
                    // FindParentt(qq);
                }


            
            }
            else {
            

            }
            
            return aab;
            //MessageBox.Show(JsonConvert.SerializeObject(aab));//.ChildNodes.ToDictionary<string,HtmlAgilityPack.HtmlNode>().ToList()));


        }

        public void op() {
            using (var k = new testForm(radTextBox1.Text))
            {
                k.Show();
            }
        }
        public class datshow : RecevDataFromWeb
        {
            string allcon;
            RadForm ra;
            string them;
          public  datshow(string allcon, string them)
            {
                this.allcon = allcon;
                this.them = them;
            }
            public void ReceveFroms(object anotherData)
            {
                var ii = anotherData as Eventhtml;
              
                if (ii != null) {

                    foreach (var iu in ii.EventControl)
                    {
                       
                        try
                        {
                            var b = ra.Controls.Find(iu.controlname, true)[0];
                           
                            if (iu.controlEventname.ToLower().StartsWith("ena")) {
                                b.Enabled = true;
                            }
                            if (iu.controlEventname.ToLower().StartsWith("dis"))
                            {
                                b.Enabled = false;
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
                        catch (Exception ex) {


                        }
                    }
                }

                var jjj = anotherData as EventOnchange;
                if (jjj != null) {

                    foreach (var iu in jjj.datahtml.EventControl)
                    {

                        try
                        {
                            var b = ra.Controls.Find(iu.controlname, true)[0];
                        var er=    iu.controlEventname.Split('#');
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
                                if (h != null) { 
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
                                if (gg != null) {
                                    ch = true;
                                    try
                                    {
                                        var j = (bool)jjj.columnvalue.SelectToken(er[0]);
                                        gg.Checked = j;
                                    }
                                    catch (Exception ex) {
                                     var f=   jjj.columnvalue.SelectToken(er[0]).ToString();

                                        if (f.ToLower().StartsWith("1"))
                                        {
                                            gg.Checked = true;
                                        }
                                        else {
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

            private void testForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason == CloseReason.UserClosing) {
                    e.Cancel = true;
                    ra.Hide();
                }
            }
            public async void show() {

               ra= new RadForm();
                ra.FormClosing += testForm_FormClosing;
                ra.ThemeName = them;
                //GORS.Instance.System_seting_main = them;
                if (ra.InvokeRequired)
                {
                    ra.Invoke(new MethodInvoker(async() =>
                    {
                        List<Eventhtml> ghh = new List<Eventhtml>();
                        HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
                        gg.LoadHtml(allcon);
                        try
                        {
                            var re = gg.DocumentNode.Descendants("event");
                        
                            foreach (var ik in re.ElementAt(0).Descendants("event"))
                            {
                                Eventhtml k = new Eventhtml();
                                string name = "0";
                                Dictionary<string, object> io = new Dictionary<string, object>();
                                foreach (var yy in ik.Attributes)
                                {
                                    if (yy.Name.Equals("id"))
                                    {
                                        name = yy.Value;
                                    }
                                    io.Add(yy.Name, yy.Value);

                                }
                                k.attEvent = io;
                                k.eventName = name;
                                k.DataEvent = ik.InnerText;
                                ghh.Add(k);

                            }
                            MessageBox.Show(JsonConvert.SerializeObject(ghh));
                        }
                        catch (Exception ex) {

                        }
                        var j = new List<ControlInfo>();
                        Radconverttojson f = new Radconverttojson(ghh);
                        var getrs =await f.ActualizarMenus(gg.DocumentNode);
                        var all = getrs.control;
                        ra.Controls.Add(all);
                        GORS.Instance.RecivDataFromWebs = this;
                        ra.Show();
                    }));
                }
                else {
                    HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
                    List<Eventhtml> ghh = new List<Eventhtml>();
                    gg.LoadHtml(allcon);
                    try
                    {
                        var re = gg.DocumentNode.Descendants("event");
                      
                        foreach (var ik in re.ElementAt(0).Descendants("event"))
                        {
                            Eventhtml k = new Eventhtml();
                            string name = "0";
                            Dictionary<string, object> io = new Dictionary<string, object>();
                            foreach (var yy in ik.Attributes) {
                                if (yy.Name.Equals("id")) {
                                    name = yy.Value;
                                }
                                io.Add(yy.Name,yy.Value);

                            }
                            k.attEvent = io;
                            k.eventName = name;
                            k.DataEvent = ik.InnerText;
                            ghh.Add(k);
                     
                        }
                       
                    }
                    catch (Exception ex)
                    {

                    }
                    var j = new List<ControlInfo>();
                    Radconverttojson f = new Radconverttojson(ghh);
                    var getrs = await f.ActualizarMenus(gg.DocumentNode);
                    var all = getrs.control;
                    ra.Controls.Add(all);
                    GORS.Instance.RecivDataFromWebs = this;
                    ra.Show();

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
        public async void parsee() {



            /*  MatchCollection tags = Parser.Match(Parser.HtmlTag, radTextBox1.Text);
              HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
                gg.LoadHtml(radTextBox1.Text);
              var j=new List<ControlInfo>();

              Radconverttojson f = new Radconverttojson();
              var getrs = f.ActualizarMenus(gg.DocumentNode);*/
          //  RadForm f = new RadForm();
           // f.ThemeName = this.ThemeName;
            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
            var t = new customefinal(alldat,this);
            t.Dock = DockStyle.Fill;
            var f = await t.inithh.loadForm();
            f.Show();
            //   f.Controls.Add(t);


            //  d.Show();
            // new datshow(radTextBox1.Text,this.ThemeName).show();


            //  var s=     JsonConvert.SerializeObject(gg.DocumentNode.ChildNodes,Newtonsoft.Json.Formatting.None,new JsonSerializerSettings() {ReferenceLoopHandling=ReferenceLoopHandling.Ignore });
            //     radTextBox1.Text = s;
            /*  JsonConvert.SerializeObject(FindParentt(gg.DocumentNode, new RadGroupBox(),j));
               DynWindowForm mainForm = new DynWindowForm();
               mainForm.Create(0, 0, 800, 600, "Dynamic Form", "dynForm");
               ControlInfo[] ctrlInfo = new ControlInfo[j.Count];
               for (int v = 0; v < j.Count(); v++)
               {
                   ctrlInfo[v] = j.ElementAt(vg

               }
               mainForm.LoadControls(ctrlInfo);
               mainForm.Show();*/
            // MessageBox.Show(cc);
            /* var f = new JObject();
             if (gg.DocumentNode.HasChildNodes)
             {

                 var attributess = new JObject();
                 var attributessv = new JObject();
                 Dictionary<string, object> aab = new Dictionary<string, object>();
                 foreach (var qq in gg.DocumentNode.ChildNodes)
                 {
                     Dictionary<string, string> aa = new Dictionary<string, string>();

                     foreach (var qqv in qq.Attributes)
                     {
                         try {

                             aa.Add(qqv.Name, qqv.Value);
                         }
                         catch (Exception) {

                         }

                     }
                     var hh = JToken.Parse(JsonConvert.SerializeObject(gg.));
                     attributessv.Add(qq.Name,hh);
                     FindParentt(qq,attributessv);
                 }

                 MessageBox.Show(JsonConvert.SerializeObject(attributessv));
             }*/


        }


        private void LoadData(string data)
        {
            BjSJsonObject json = new BjSJsonObject(data);

           radTreeView1.Nodes.Clear();

            RadTreeNode root = ConvertToTreeNode(json, String.Empty);
            foreach (RadTreeNode node in root.Nodes)
            {
                radTreeView1.Nodes.Add(node);
                node.Expand();
            }

           /* txtImportText.Text = json.ToJsonString(false);

            tabControl1.SelectedIndex = 1;*/
        }

        #region Helpers

        public class hhh {

            public string name { get; set; }
            public int child { get; set; }
            public int parent { get; set; }
        }

        private RadTreeNode ConvertToTreeNode(BjSJsonObject obj, string name)
        {
            RadTreeNode root = new RadTreeNode(String.Format(String.IsNullOrEmpty(name) ? "Object{{{1}}}" : "\"{0}\" : Object{{{1}}}", name, obj.Count));
            root.ImageIndex = 0;
          //  root.SelectedImageIndex = 0;

            foreach (BjSJsonObjectMember member in obj)
            {
                switch (member.ValueKind)
                {
                    case BjSJsonValueKind.Object:
                        root.Nodes.Add(ConvertToTreeNode(member.Value as BjSJsonObject, member.Name));
                        break;
                    case BjSJsonValueKind.Array:
                        root.Nodes.Add(ConvertToTreeNode(member.Value as BjSJsonArray, member.Name));
                        break;
                    case BjSJsonValueKind.String:
                        root.Nodes.Add(new RadTreeNode(String.Format("\"{0}\" : \"{1}\"", member.Name, member.Value)));// { ImageIndex = 2, SelectedImageIndex = 2 });
                        break;
                    case BjSJsonValueKind.Number:
                        root.Nodes.Add(new RadTreeNode(String.Format("\"{0}\" : {1}", member.Name, member.Value)));// { ImageIndex = 3, SelectedImageIndex = 3 });
                        break;
                    case BjSJsonValueKind.Boolean:
                        root.Nodes.Add(new RadTreeNode(String.Format("\"{0}\" : {1}", member.Name, member.Value)));// { ImageIndex = 4, SelectedImageIndex = 4 });
                        break;
                    case BjSJsonValueKind.Null:
                        root.Nodes.Add(new RadTreeNode(String.Format("\"{0}\" : null", member.Name)));// { ImageIndex = 5, SelectedImageIndex = 5 });
                        break;
                    default:
                        break;
                }
            }

            return root;
        }
        private RadTreeNode ConvertToTreeNode(BjSJsonArray arr, string name)
        {
            RadTreeNode root = new RadTreeNode(String.Format(String.IsNullOrEmpty(name) ? "Array[{1}]" : "\"{0}\" : Array[{1}]", name, arr.Count));
            root.ImageIndex = 1;
           // root.SelectedImageIndex = 1;

            for (int i = 0; i < arr.Count; i++)
            {
                var obj = arr[i];
                switch (BjSJsonHelper.GetValueKind(obj))
                {
                    case BjSJsonValueKind.Object:
                        root.Nodes.Add(ConvertToTreeNode(obj as BjSJsonObject, i.ToString()));
                        break;
                    case BjSJsonValueKind.Array:
                        root.Nodes.Add(ConvertToTreeNode(obj as BjSJsonArray, i.ToString()));
                        break;
                    case BjSJsonValueKind.String:
                        root.Nodes.Add(new RadTreeNode(String.Format("{0} : \"{1}\"", i, obj)));
                        break;
                    case BjSJsonValueKind.Number:
                        root.Nodes.Add(new RadTreeNode(String.Format("{0} : {1}", i, obj)));
                        break;
                    case BjSJsonValueKind.Boolean:
                        root.Nodes.Add(new RadTreeNode(String.Format("{0} : {1}", i, obj)));
                        break;
                    case BjSJsonValueKind.Null:
                        root.Nodes.Add(new RadTreeNode(String.Format("{0} : null", i)));
                        break;
                    default:
                        break;
                }
            }

            return root;
        }

        public static string WGet(string url)
        {
            string result = String.Empty;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.UserAgent = "Mozilla/5.0 (X11; Linux x86_64; rv:28.0) Gecko/20100101 Firefox/28.0";
            req.Timeout = 10000;
            req.Method = "GET";

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode == HttpStatusCode.OK)
            {
                StreamReader s = new StreamReader(res.GetResponseStream());
                result = s.ReadToEnd();
            }
            else
                throw new Exception(String.Format("{0}: {1}", res.StatusCode, res.StatusDescription));

            res.Close();

            return result;
        }

        #endregion
        public void ads() {

            ControlInfo[] ctrlInfo = new ControlInfo[46];

            // Customer Information GUI

            ctrlInfo[0] = new ControlInfo("label", new Point(20, 33), new Size(80, 15), "lblLastName", "Last Name:", "", "");
            ctrlInfo[1] = new ControlInfo("imageButton", new Point(100, 30), new Size(20, 20), "btnClearForm", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\clearForm.ico", "", "");
            ctrlInfo[2] = new ControlInfo("edit", new Point(120, 30), new Size(200, 20), "edLastName", "", "", "");
            ctrlInfo[3] = new ControlInfo("imageButton", new Point(320, 30), new Size(20, 20), "btnFind", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\binocs.ico", "", "");
            ctrlInfo[4] = new ControlInfo("imageButton", new Point(340, 30), new Size(20, 20), "btnNew", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\new.ico", "", "");
            ctrlInfo[5] = new ControlInfo("imageButton", new Point(360, 30), new Size(20, 20), "btnPrint", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\print.ico", "", "");
            ctrlInfo[6] = new ControlInfo("imageButton", new Point(380, 30), new Size(20, 20), "btnDelete", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\delete.ico", "", "");

            ctrlInfo[7] = new ControlInfo("label", new Point(425, 33), new Size(65, 15), "lblFirstName", "First Name:", "", "");
            ctrlInfo[8] = new ControlInfo("edit", new Point(490, 30), new Size(200, 20), "edFirstName", "", "", "");

            ctrlInfo[9] = new ControlInfo("label", new Point(20, 53), new Size(100, 15), "lblAddr1", "Address1:", "", "");
            ctrlInfo[10] = new ControlInfo("edit", new Point(120, 50), new Size(200, 20), "edAddr1", "", "", "");
            ctrlInfo[11] = new ControlInfo("label", new Point(20, 73), new Size(100, 15), "lblAddr2", "Address2:", "", "");
            ctrlInfo[12] = new ControlInfo("edit", new Point(120, 70), new Size(200, 20), "edAddr2", "", "", "");
            ctrlInfo[13] = new ControlInfo("label", new Point(20, 93), new Size(100, 15), "lblCity", "City:", "", "");
            ctrlInfo[14] = new ControlInfo("edit", new Point(120, 90), new Size(200, 20), "edCity", "", "", "");

            ctrlInfo[15] = new ControlInfo("label", new Point(340, 93), new Size(40, 15), "lblState", "State:", "", "");
            ctrlInfo[16] = new ControlInfo("edit", new Point(380, 90), new Size(50, 20), "edState", "", "", "");

            ctrlInfo[17] = new ControlInfo("label", new Point(450, 93), new Size(40, 15), "lblZip5", "Zip5:", "", "");
            ctrlInfo[18] = new ControlInfo("edit", new Point(490, 90), new Size(50, 20), "edZip5", "", "", "");

            ctrlInfo[19] = new ControlInfo("label", new Point(560, 93), new Size(40, 15), "lblZip4", "Zip4:", "", "");
            ctrlInfo[20] = new ControlInfo("edit", new Point(600, 90), new Size(50, 20), "edZip4", "", "", "");

            ctrlInfo[21] = new ControlInfo("label", new Point(20, 113), new Size(100, 15), "lblPhone", "Phone:", "", "");
            ctrlInfo[22] = new ControlInfo("edit", new Point(120, 110), new Size(200, 20), "edPhone", "", "", "");
            ctrlInfo[23] = new ControlInfo("label", new Point(330, 113), new Size(50, 15), "lblTaxID", "Tax ID:", "", "");
            ctrlInfo[24] = new ControlInfo("edit", new Point(380, 110), new Size(100, 20), "edTaxID", "", "", "");
            ctrlInfo[25] = new ControlInfo("checkBox", new Point(500, 113), new Size(150, 20), "ckTaxExempt", "Always tax exempt", "", "");

            ctrlInfo[26] = new ControlInfo("label", new Point(20, 133), new Size(100, 15), "lblEmail", "Email:", "", "");
            ctrlInfo[27] = new ControlInfo("edit", new Point(120, 130), new Size(200, 20), "edEmail", "", "", "");

            ctrlInfo[28] = new ControlInfo("groupBox", new Point(10, 10), new Size(730, 150), "gb1", "Customer Information:", "", "");

            // Customer/Yard Boats GUI

            ctrlInfo[29] = new ControlInfo("listView", new Point(20, 200), new Size(250, 120), "lcBoats", "ID:0,Boat Name:245", "", "");
            ctrlInfo[30] = new ControlInfo("imageButton", new Point(280, 200), new Size(20, 20), "btnAddBoat", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\add.ico", "", "");
            ctrlInfo[31] = new ControlInfo("imageButton", new Point(280, 220), new Size(20, 20), "btnRemoveBoat", "c:\\Users\\Mypc\\Documents\\DynamicForms_src\\projects.net\\AutoFormPrototype\\csform\\icons\\delete.ico", "", "");
            ctrlInfo[32] = new ControlInfo("groupBox", new Point(10, 180), new Size(400, 150), "gb2", "Customer/Yard Boats:", "", "");

            // Account Setup GUI

            ctrlInfo[33] = new ControlInfo("label", new Point(430, 203), new Size(100, 15), "lblCCType", "CC Type:", "", "");
            ctrlInfo[34] = new ControlInfo("comboBox", new Point(540, 200), new Size(150, 100), "cbCCType", "", "", "");
            ctrlInfo[35] = new ControlInfo("label", new Point(430, 223), new Size(100, 15), "lblCreditCard", "Credit Card:", "", "");
            ctrlInfo[36] = new ControlInfo("edit", new Point(540, 220), new Size(150, 20), "edCreditCard", "", "", "");
            ctrlInfo[37] = new ControlInfo("label", new Point(430, 243), new Size(100, 15), "lblExpDate", "Exp. Date:", "", "");
            ctrlInfo[38] = new ControlInfo("edit", new Point(540, 240), new Size(100, 20), "edExpDate", "", "", "");
            ctrlInfo[39] = new ControlInfo("checkBox", new Point(430, 280), new Size(100, 20), "ckTransient", "Transient?", "", "");
            ctrlInfo[40] = new ControlInfo("checkBox", new Point(540, 280), new Size(100, 20), "ckYardAcct", "Yard Account?", "", "");
            ctrlInfo[41] = new ControlInfo("label", new Point(430, 303), new Size(110, 15), "lblPMRate", "Parts/Material Rate:", "", "");
            ctrlInfo[42] = new ControlInfo("comboBox", new Point(540, 300), new Size(100, 100), "cbPMRate", "", "", "");

            ctrlInfo[43] = new ControlInfo("groupBox", new Point(420, 180), new Size(320, 150), "gb3", "Account Setup:", "", "");

            // Open WorkOrders GUI

            ctrlInfo[44] = new ControlInfo("listView", new Point(20, 370), new Size(690, 120), "lcBoats", "ID:0,WO #:100,Open Date:100,Close Date:100", "", "");
            ctrlInfo[45] = new ControlInfo("groupBox", new Point(10, 350), new Size(730, 150), "gb4", "Open Work Orders:", "", "");

            DynWindowForm mainForm = new DynWindowForm();
            mainForm.Create(0, 0, 800, 600, "Dynamic Form", "dynForm");
            mainForm.LoadControls(ctrlInfo);
            mainForm.Show();
        }
        private Popup _popup;

        private  Popup popup
        {
            get
            {
                return this._popup;
            }
         
            set
            {
                if (this._popup != null)
                {
                    this._popup.DropDownClosed -= this.PopupClosed;
                    this._popup.DropDown -= this.PopupDown;
                }
                this._popup = value;
                if (this._popup != null)
                {
                    this._popup.DropDownClosed += this.PopupClosed;
                    this._popup.DropDown += this.PopupDown;
                }
            }
        }

        public string Urllk
        {
            get
            {

                if (urllk == null) {
                    string cc = Assembly.GetExecutingAssembly().Location;



                    urllk = "file:///" + Path.GetDirectoryName(cc).Replace(@"\", "/");
                }
                return urllk;
            }

          
        }

        private void PopupDown(object Sender, EventArgs e)
        {
            this.Text = "Popup is open";
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000079E0 File Offset: 0x000069E0
        private void PopupClosed(object Sender, EventArgs e)
        {
            this.Text = "Popup is closed";
        }
        private string datexam()
        {

            string rr = "[{\"show\":true,\"DisName\":\"الصف بببببببالاسم\",\"FieldName\":\"mynamev\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo hello\",\"MaskText\":\"0\"}],\"Checknull\":true},{\"show\":true,\"DisName\":\"الصف ggggggggggggggggggggالاسم\",\"FieldName\":\"id\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":true},{\"show\":true,\"DisName\":\"الاسم\",\"FieldName\":\"mail\",\"TypeName\":\"bool\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاسم\",\"FieldName\":\"mailrrr\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo gggggg hello\",\"MaskText\":\"d\",\"MaskType\":\"Numeric\"}],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاhhhhhhسم\",\"FieldName\":\"maildd\",\"TypeName\":\"enu\",\"Enumvalue\":[{\"name\":\"bbbbb\",\"id\":1},{\"name\":\"bbbppppbb\",\"id\":2},{\"name\":\"bbbioooobb\",\"id\":3},{\"name\":\"bbbnmmmmmbb\",\"id\":4}],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"uuuuuu\",\"FieldName\":\"date\",\"TypeName\":\"date\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false}]";

            return rr;
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            //  getdata("4", "2", 0, "ff", "00", "0", 2);
           // ASTOOLTECHA.mainv.splashscreen d = new ASTOOLTECHA.mainv.splashscreen();
          //  AsyncUIPresentationLayer.Form2 d = new AsyncUIPresentationLayer.Form2();
         //   d.Show();
            //  getdata("4", "1", 0, "ff", "00", "0", 1);
            // GORS.Instance.API_UserAgent = "ggggggg";
            /*Astoldesinger.fromwithtelerk f = new Astoldesinger.fromwithtelerk();
            f.ShowDialog();*/
            /*   CacheClass.add("vv","hellllll");
               var get =(string)CacheClass.get("vv");
               MessageBox.Show(get);*/
            /* System_seting_main_acount re = new System_seting_main_acount();
             re.message_show = false;
            // re.barcodescanner = "gggggggggggggggggggggggggggggggggmmmmmmmmmmmmmmmmmmmmm";

            // var ii = "[" + JsonConvert.SerializeObject(re) + "]";
            // GORS.Instance.System_seting_main = ii;
             MessageBox.Show(GORS.Instance.System_seting_main);
             winToWeb.control.getdependencys.restSettings();
             var f = winToWeb.control.getdependencys.getSetting;*/
            //  formains.getins().Show();

            /* fromDesignData uui = new fromDesignData();

             uui.ApiName = "ttrrr";
             uui.FormName = "الاعدادات";
             uui.Rowcount = 1;
             uui.FormDesign = JToken.Parse(datexam());
             winToWeb.control.Form1 f = new control.Form1(uui);

            // var gg = JsonConvert.DeserializeObject<List<data>>(JsonConvert.SerializeObject(uui.FormDesign));
            // radCardView1.DataSource = gg;
             f.Show();*/

            /*  customalrtDalog r;
              contentAlertMessaage g = new contentAlertMessaage();

              RadLabel gg = new RadLabel();
              gg.Location = new Point(0,0);
              g.settexhtml(radTextBox1.Text);
              gg.Dock = DockStyle.Top;
              gg.Text = "<h1> tttttt</h1>";
              g.Dock = DockStyle.Fill;

              r = new customalrtDalog(g);
              r.FixedSize = new Size(Convert.ToInt32(radTextBox2.Text), Convert.ToInt32(radTextBox3.Text));
              r.AutoClose = true;
              r.AutoCloseDelay = 10;
              r.Show();*/
        }
        private async void btnExecute_WebAPI(string typ, int aa, int refe, string apiname, string authoa)
        {
            //  MessageBox.Show("ehhxxxxxxxxxxxmmmmmmmmm");
            await AbtnExecute_WebAPI(typ, aa, refe, apiname, authoa);
        }

        private async Task AbtnExecute_WebAPI(string typss, int aa, int refe, string apiname, string autho)
        {

            // MessageBox.Show("ehhxxxxxxxxxxx");

            await BbtnExecute_WebAPI(typss, aa, refe, apiname, autho);
        }
        private  void radButton2_Click(object sender, EventArgs e)
        {
            /* Form1 v = new Form1();
             v.Show();*/

            btnExecute_WebAPI("1", 1, 1, "login", "noo");
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            this.popup.Show();
        }
        WebBrowser we;
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
        public async Task<Image> getphoto(string Url)
        {
            Image imm;
            Dictionary<string, string> u = new Dictionary<string, string>();
            Url = urlpur(Url);
            string vv = ""; //Properties.Resources.placehold;
            var extension = Path.GetExtension(Path.GetFileName(Url)) + "file";
            var zzza = getfoldd(Path.GetFileName(Url), extension);
            //   MessageBox.Show(Url);
            byte[] iio = null;
            if (zzza[0].Equals("0"))
            {
                var er = em(Url);

                ImageConverter im = new ImageConverter();
                var fe = (byte[])im.ConvertTo(er,typeof(byte[]));
                // iio = File.ReadAllBytes(ss.Image_URL);
              //  iio = Encoding.UTF8.GetBytes(content);
                File.WriteAllBytes(zzza[1], fe);
                imm = Image.FromFile(zzza[1]);


            }
            else
            {
                imm = Image.FromFile(zzza[1]);
                // MessageBox.Show(Path.GetFileName(zzza[1]));
                // u.Add(Url, zzza[1]);
                // vv = File.ReadAllText(zzza[1]);
            }
            return imm;

        }
        public string[] getfoldd(string Filename, string typefolder)
        {

            string[] zz = new string[2];
            string fouldernanmee = "/iconimage/" + typefolder.Replace(".", "");
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
        private async void radButton3_Click(object sender, EventArgs e)
        {
            //GORS.Instance.Date_typ = 1;
            //GORS.Instance.Date_fromate = "yyyy-dd-MM";
          //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //  MessageBox.Show(JsonConvert.SerializeObject(h));
            /* RadControlSpyForm f = new RadControlSpyForm();
                f.Show();*/

            // radPropertyGrid1.SelectedObject = new TreeviewPersist_json();
            var d = File.ReadAllText(@"C:\Users\Mypc\Documents\TopView.json");

            List<hhh> gh = new List<hhh>();

            gh.Add(new hhh { child = 1, name = "ddddd", parent = 0 });
            gh.Add(new hhh { child = 2, name = "ddddfdfdd", parent = 1 });
            gh.Add(new hhh { child = 3, name = "dddfgddd", parent = 1 });
            gh.Add(new hhh { child = 4, name = "dddnnnnndd", parent = 1 });
            gh.Add(new hhh { child = 5, name = "dddnnnnndd", parent = 4 });
            gh.Add(new hhh { child = 6, name = "dddnnnnndd", parent = 5 });
            radTreeView1.DisplayMember = "name";
            radTreeView1.ChildMember = "child";
            radTreeView1.ParentMember = "parent";
            /*  radGridView2.DataSource = gh;
                  //MessageBox.Show(JsonConvert.SerializeObject(gh.ToLookup(x => x.parent)));
                  GridViewTemplate f = new GridViewTemplate();
                  f.Caption = "dddddddkkk";
                  f.DataSource = JToken.Parse(JsonConvert.SerializeObject(gh));

                  GridViewTemplate ff = new GridViewTemplate();
                  ff.Caption = "dddddddkkkss";
                  ff.DataSource = JToken.Parse(JsonConvert.SerializeObject(gh));
                  radGridView2.Templates.Add(f);
                  radGridView2.Templates.Add(ff);
                  GridViewRelation g = new GridViewRelation();
                  g.ChildTemplate = ff;
                  g.ParentTemplate = f;
                  g.ChildColumnNames.Add("child");
                  g.ParentColumnNames.Add("parent");
                  radGridView2.Relations.AddSelfReference(radGridView2.MasterTemplate,"child","parent");*///.Add(g);
                                                                                                          //  BindToObjectRelational();
                                                                                                          // radGridView1.AutoGenerateHierarchy = true;

            // radTreeView1.DataSource = JsonConvert.DeserializeObject(d);
            //LoadData(d);


            //   var dx = await getphoto(radTextBox1.Text);
            // radButton3.Image = dx;

            // RadSvgImage yu = RadSvgImage.FromXml(radRichTextEditor1.Text);
            //   radButton2.Image = yu.GetRasterImage();

            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
            var t = new customefinal(alldat,this);
            t.Dock = DockStyle.Fill;
          var ex=await t.inithh.loadForm();
            ex.Show();
         //   yy.Show();+


            //  BindToObjectRelational();
        }

        //public Task<RadForm> Dispatch()
        //{
        //    // Task.Run will capture the current execution context (which means async locals are captured in the callback)
        //   return Task.Run(() =>
        //    {

               
        //        var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
        //        var t = new customefinal(alldat, this.ThemeName);
        //        t.Dock = DockStyle.Fill;
        //      return t.showconn();
        //      //  return "hhh";
        //    });
        //}
        private void RunNodee(HtmlNode node)
        {
           
            foreach (HtmlNode child in node.ChildNodes)
            {
                 RunNodee(child);
                setatt(child);


            }
           
        }
        private string urllk;

        private void setatt(HtmlNode node) {

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
            List<TreeviewPersist_json> parents = new List<TreeviewPersist_json>();
            foreach (HtmlNode node in radTreeView1.ChildNodes)
            {
                 RunNodee(node);
                setatt(node);

            }
            //  root = new TreeviewPersist_json("root", parents,false,null,null);

           ;
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

        private GridViewTemplate TemplateTaple(DataTable c,string name) {

            GridViewTemplate productsLevel = new GridViewTemplate();
            productsLevel.DataSource = c;
            productsLevel.Caption = name;
            productsLevel.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            return productsLevel;
        }
        private GridViewRelation addreltion(string relaname,string parent,string child, GridViewTemplate childd, GridViewTemplate parentt) {

            GridViewRelation relationOrders = new GridViewRelation(parentt);
            relationOrders.ChildTemplate = childd;
            relationOrders.RelationName = relaname;
            relationOrders.ParentColumnNames.Add(parent);
            relationOrders.ChildColumnNames.Add(child);
            return relationOrders;
        }
        private void BindToObjectRelational()
        {
             Random rand = new Random();
             DataTable categories = new DataTable();
             categories.Columns.Add("CategoryID", typeof(int));
             categories.Columns.Add("Title", typeof(string));
             categories.Columns.Add("CreatedOn", typeof(DateTime));
             for (int i = 0; i < 5; i++)
             {
                 categories.Rows.Add(i, "Master" + i, DateTime.Now.AddDays(i));
             }

             DataTable productsTable = new DataTable();
             productsTable.Columns.Add("ProductID", typeof(int));
             productsTable.Columns.Add("CategoryID", typeof(int));
             productsTable.Columns.Add("Name", typeof(string));
             productsTable.Columns.Add("UnitPrice", typeof(decimal));
             for (int i = 0; i < 30; i++)
             {
                 productsTable.Rows.Add(i, rand.Next(0, 5), "Product" + i, 1.25 * i);
             }
            var y = TemplateTaple(productsTable, "ffffff");
            this.radGridView2.Columns.AddRange(y.Columns);
             this.radGridView2.MasterTemplate.Templates.Add(y);
            /* this.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

             GridViewTemplate productsLevel = new GridViewTemplate();
             productsLevel.DataSource = productsTable;

             productsLevel.Caption = "Products";
             productsLevel.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
             this.radGridView2.MasterTemplate.Templates.Add(productsLevel);

             GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate);
             relation.ChildTemplate = productsLevel;
             relation.RelationName = "CategoriesProducts";
             relation.ParentColumnNames.Add("CategoryID");
             relation.ChildColumnNames.Add("CategoryID");
           this.radGridView2.Relations.Add(relation);


             DataTable ordersTable = new DataTable();
             ordersTable.Columns.Add("OrderID", typeof(int));
             ordersTable.Columns.Add("ProductID", typeof(int));
             ordersTable.Columns.Add("OrderDate", typeof(DateTime));
             for (int i = 0; i < 100; i++)
             {
                 ordersTable.Rows.Add(i, rand.Next(0, 30), DateTime.Now.AddDays(-1 * i));
             }
             DataSet f = new DataSet();

             f.Tables.Add(categories);
             f.Tables.Add(productsTable);
             f.Tables.Add(ordersTable);
             DataRelation g = new DataRelation("mymy",  f.Tables[0].Columns["CategoryID"], f.Tables[1].Columns["CategoryIDD"],false);
             DataRelation gg = new DataRelation("mymfy", f.Tables[1].Columns["ProductID"], f.Tables[2].Columns["ProductIDx"], false);
             f.Relations.Add(g);
             f.Relations.Add(gg);
             radGridView2.AutoGenerateHierarchy = true;
             radGridView2.DataSource = f.Tables[0];
            GridViewTemplate ordersLevel = new GridViewTemplate();
             ordersLevel.DataSource = ordersTable;
             ordersLevel.Caption = "Orders";
             ordersLevel.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
             productsLevel.Templates.Add(ordersLevel);

             GridViewRelation relationOrders = new GridViewRelation(productsLevel);
             relationOrders.ChildTemplate = ordersLevel;
             relationOrders.RelationName = "ProductsOrders";
             relationOrders.ParentColumnNames.Add("ProductID");
             relationOrders.ChildColumnNames.Add("ProductID");
             this.radGridView2.Relations.Add(relationOrders);


            Random rand = new Random();
            DataTable categories = new DataTable();
            categories.Columns.Add("CategoryID", typeof(int));
            categories.Columns.Add("Title", typeof(string));
            categories.Columns.Add("CreatedOn", typeof(DateTime));
            for (int i = 0; i < 5; i++)
            {
                categories.Rows.Add(i, "Master" + i, DateTime.Now.AddDays(i));
            }

            DataTable productsTable = new DataTable();
            productsTable.Columns.Add("ProductID", typeof(int));
            productsTable.Columns.Add("CategoryID", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("UnitPrice", typeof(decimal));
            for (int i = 0; i < 30; i++)
            {
                productsTable.Rows.Add(i, rand.Next(0, 5), "Product" + i, 1.25 * i);
            }

            this.radGridView2.MasterTemplate.DataSource = categories;
            this.radGridView2.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            
            var ff = TemplateTaple(productsTable, "Products");
            this.radGridView2.MasterTemplate.Templates.Add(ff);

         
            var eer = addreltion("CategoriesProducts", "CategoryID", "CategoryID",ff, radGridView2.MasterTemplate);
            this.radGridView2.Relations.Add(eer);

            /*DataTable ordersTable = new DataTable();
            ordersTable.Columns.Add("OrderID", typeof(int));
            ordersTable.Columns.Add("ProductID", typeof(int));
            ordersTable.Columns.Add("OrderDate", typeof(DateTime));
            for (int i = 0; i < 100; i++)
            {
                ordersTable.Rows.Add(i, rand.Next(0, 30), DateTime.Now.AddDays(-1 * i));
            }

            GridViewTemplate ordersLevel = new GridViewTemplate();
            ordersLevel.DataSource = ordersTable;
            ordersLevel.Caption = "Orders";
            ordersLevel.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
          ff.Templates.Add(ordersLevel);

            GridViewRelation relationOrders = new GridViewRelation(ff);
            relationOrders.ChildTemplate = ordersLevel;
            relationOrders.RelationName = "ProductsOrders";
            relationOrders.ParentColumnNames.Add("ProductID");
            relationOrders.ChildColumnNames.Add("ProductID");
            this.radGridView2.Relations.Add(relationOrders);*/
        }
        private void addtempate(List<GridViewTemplate> temp) {

            GridViewTemplate f = new GridViewTemplate();
           
                //  MessageBox.Show(multt.MasterTemplate.Templates.Count.ToString());


            
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var iop = radGridView1.CurrentRow.DataBoundItem;
            if (iop != null)
            {
                radMaskedEditBox1.Text = JsonConvert.SerializeObject(iop);
            }
            else {
                Dictionary<string, object> k = new Dictionary<string, object>();
                foreach (var iuu in radGridView1.Columns)
                {
                    try
                    {
                        var t = radGridView1.CurrentRow.Cells[iuu.Name].Value;
                        k.Add(iuu.Name, t);
                    }
                    catch (Exception ex) {
                    }
                   
                }
                radMaskedEditBox1.Text = JsonConvert.SerializeObject(k);
            }
        }

        private void radGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

            }
        }

        public class ddd {
            public string url { get; set; }
            public string name { get; set; }
            public int gg { get; set; }
        }
        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            System_seting_main_acount re = new System_seting_main_acount();
            re.message_show = false;
            re.barcodescanner = "ggggggggggggggggggggggggggggggggg";
            GORS.Instance.fontnameeyeornot = "ffffffffffffffffffffffffffffff";
           var ii="["+JsonConvert.SerializeObject(re)+"]";
             GORS.Instance.System_seting_main =ii;
            MessageBox.Show(JsonConvert.SerializeObject(GORS.Instance));
         var f=   winToWeb.control.getdependencys.getSetting;
            DirectoryInfo em = new DirectoryInfo(System.IO.Path.GetTempPath());
            FileInfo[] inf = em.GetFiles("*.html");

           
            var i =Path.GetDirectoryName(getdependencys.Urllk);
            foreach (var it in inf) {

                it.Delete();

              //  it.
            }

            GORS.Instance.A_alert = true;
         
          
            GORS.Instance.A_sound = true;
          //  GORS.Instance.API_URL = "http://localhost:80/api/";
           /* control.customalrtDalog_alert_daloge dd = new control.customalrtDalog_alert_daloge ();

            dd.messge_aler(this.ThemeName,2,0,"ffffffffffff","Ok");
          */


            /* List<ddd> d = new List<ddd>();

             for (var index = 1; index <= 20; index++)
             {
                 ddd f = new ddd();

                 f.name = "Item" + index;
                 f.url = "http://localhost:80/uploads/08e51356-cff9-4f44-b729-9e52123774acIMG-20231130-WA0003.jpg";
                 f.gg = index;
                 d.Add(f);

             }
             adddatwithFilter(radMultiColumnComboBox1, new string[] { "name" });
             radMultiColumnComboBox1.DataSource = d;
             MessageBox.Show("ffffff");*/


        }
        public void adddatwithFilter(RadMultiColumnComboBox c, string[] colunfilter)
        {



            /*  c.DisplayMember = coulmndaa[0];


              foreach (var ff in coulmndaa)
              {
                  foreach (var xx in c.Columns)
                  {

                      if (ff.Equals(xx.Name))
                      {
                          xx.IsVisible = true;
                          xx.Width = 200;
                          xx.HeaderText = "";
                      }
                      else
                      {
                          xx.IsVisible = false;
                      }

                  }
              }*/
            c.AutoFilter = true;
            CompositeFilterDescriptor dd = new CompositeFilterDescriptor();


            foreach (var ddf in colunfilter)
            {

                FilterDescriptor prona = new FilterDescriptor(ddf, FilterOperator.Contains, "");
                dd.LogicalOperator = FilterLogicalOperator.Or;
                dd.FilterDescriptors.Add(prona);


            }



            c.EditorControl.FilterDescriptors.Add(dd);
        }
        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {

        }

        private void radRichTextEditor1_Click(object sender, EventArgs e)
        {

        }
        public void register(string acesstoken,string refreshToken) {
          
        }
        public void adto() {

          //  Astoldesinger.mainprog ff = new Astoldesinger.mainprog();
         
            //   Ballsalse.screennum = "1";
            // Ballsalse.billtyps = 3;
          //  ff.ShowDialog();
        }
        public void design_unthourize(string acesstoken, string refreshtoken)
        {
            GORS.Instance.API_AcessToken = acesstoken;
            GORS.Instance.API_Ref = refreshtoken;
           // MessageBox.Show(acesstoken);
        }

        private async void radButton4_Click(object sender, EventArgs e)
        {
            /* Astoldesinger.Class.GetFormFromIDScreen vvb = new Astoldesinger.Class.GetFormFromIDScreen();
           RadForm child = await vvb.shoeformm("37", 0);
              child.Show();*/

      
            ///  MessageBox.Show(child.GetType().Name);
       /*  var   laod = new ConnectecedWithmain_ss(radPageView1);
            await laod.load();*/
            // adto();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            adto();
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
