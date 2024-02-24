using dynFormLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Html;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.html
{
    public partial class testForm : RadForm,RecevDataFromWeb
    {
        string c;
        public testForm(string k)
        {
            c = k;
            InitializeComponent();
          //  GORS.Instance.System_seting_main = this.ThemeName;
            GORS.Instance.RecivDataFromWebs = this;
        }

        public void ReceveFroms(object anotherData)
        {
            MessageBox.Show(all.Controls.Count.ToString());
          var b=  all.Controls.Find("b",true)[0];

            MessageBox.Show(b.Text);
        }
        private Control all;
        private  async void testForm_Load(object sender, EventArgs e)
        {
           
            HtmlAgilityPack.HtmlDocument gg = new HtmlAgilityPack.HtmlDocument();
            gg.LoadHtml(c);
            var j = new List<ControlInfo>();
            List<Eventhtml> ghh = new List<Eventhtml>();
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

            }
            catch (Exception ex)
            {

            }
            Radconverttojson f = new Radconverttojson(ghh);
            var getrs =await f.ActualizarMenus(gg.DocumentNode);
            all = getrs.control;
                 this.Controls.Add(all);
        }

        private void testForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
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
