using dynFormLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.control
{
 public   class groupboxui
    {

        private string themname;
        private Dictionary<string, string> style;
        private List<Attributes> attribute;
        public groupboxui(Dictionary<string, string> stylee, List<Attributes> attributee) {
            this.style = stylee;
            this.attribute = attributee;
        }
        private void setLocations(Control con)
        {
            var locx = wid("locationX");
            var locy = wid("locationY");
            con.Location = new System.Drawing.Point(Convert.ToInt32(locx), Convert.ToInt32(locy));
            setSizebackground(con);
        }
        private void setSizebackground(Control con)
        {



            try
            {
                var locx = wid("background");
                if (locx.Equals(""))
                {
                }
                else if (locx.Equals("0"))
                {
                }
                else
                {

                    con.BackColor = ColorTranslator.FromHtml(locx);// ColorConverter.ConvertFromString();
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                var locx = wid("float");
                if (locx.Equals(""))
                {
                }
                else if (locx.Equals("0"))
                {
                }
                else
                {
                    if (locx.StartsWith("t"))
                    {
                        con.RightToLeft = RightToLeft.Yes;
                    }
                    else
                    {
                        con.RightToLeft = RightToLeft.No;
                    }
                    // = ColorTranslator.FromHtml(locx);// ColorConverter.ConvertFromString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setSize(Control con)
        {
            var locx = wid( "width");
            var locy = wid( "height");
            con.Size = new System.Drawing.Size(Convert.ToInt32(locx), Convert.ToInt32(locy));

            try
            {
                var getdock = getAttribute("name");
                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {

                    con.Name = getdock;
                }
            }
            catch (Exception ex)
            {

            }

        }


        public RadGroupBox getGroup() {

          var  con = new RadGroupBox();
            try
            {
                (con as RadGroupBox).ThemeName = getdependencys.GetThem;
            }
            catch (Exception ex) {
            }
                setLocations(con);
            setSize(con);
            setDock(con);
          
            var autosize = wid("autoSize");
            if (autosize.Equals(""))
            {
            }
            else if (autosize.Equals("0"))
            {
            }
            else
            {
                if (autosize.StartsWith("t"))
                {
                    (con as RadGroupBox).AutoSize = true;
                }
                else
                {
                    (con as RadGroupBox).AutoSize = false;
                }
            }
            return con;

        }
        private void setDock(Control con)
        {
            try
            {
                var getdock = getAttribute("dock");
                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {
                    DockStyle h;

                    Enum.TryParse<DockStyle>(getdock, out h);
                    con.Dock = h;
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void setText(Control con)
        {
            try
            {
                var getdock = getAttribute("text");
                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {
                    con.Text = getdock;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private string getAttribute(string key)
        {

            string ccm = "0";
            try
            {
                var getres = attribute.Where(dd => dd.AttributeNme.Equals(key)).ToList();
                if (getres.Count > 0)
                {

                    ccm = getres.ElementAt(0).AttributeValue;
                }


                // int k = Convert.ToInt32(ccm.ToString());
                return ccm;
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
        private string wid( string key)
        {

            string ccm = "0";
            try
            {
                style.TryGetValue(key, out ccm);
                if (ccm == null)
                {
                    ccm = "0";
                }
                // int k = Convert.ToInt32(ccm.ToString());
                return ccm;
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
    }
}
