using dynFormLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;

namespace winToWeb.protouse
{
   

    public class ProtuseCheckBox<TT> : ViewTypeParser<TT> where TT :Control

    {
        private TreeviewPersist_json cc;

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                e.CellElement.Size = new Size(70,70);
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }
        }
        public ProtuseCheckBox(TreeviewPersist_json c)
        {
            this.cc = c;
        }
        private string wid(Dictionary<string, string> aab, string key)
        {

            string ccm = "0";
            try
            {
                aab.TryGetValue(key, out ccm);
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
        private void setSizebackground(Control con)
        {



            try
            {
                var locx = wid(cc.allproperty, "background");
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
                var locx = wid(cc.allproperty, "float");
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
        private void setLocations(Control con)
        {
            var locx = wid(cc.allproperty, "locationX");
            var locy = wid(cc.allproperty, "locationY");

         con.Font=   new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            con.Location = new System.Drawing.Point(Convert.ToInt32(locx), Convert.ToInt32(locy));
            setSizebackground(con);
            try
            {
                var ddd = getAttribute("checknull");

                if (ddd.StartsWith("t"))
                {

                    this.cc.alnulfex.Controls.Add(con);
                }
            }
            catch (Exception ex) {

            }

            try
            {
                var ddd = getAttribute("enable");

                if (ddd.StartsWith("t"))
                {

                    con.Enabled = true;
                }
                else if (ddd.StartsWith("f"))
                {
                    con.Enabled = false;

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
                var getres = cc.attribute.Where(dd => dd.AttributeNme.Equals(key)).ToList();
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
        public override string getParentType()
        {
            throw new NotImplementedException();
        }

        public override string getType()
        {
            throw new NotImplementedException();
        }
        private void setanckor(Control con)
        {

            var anker_left = wid(this.cc.allproperty, "anchor_left");
            var anker_right = wid(this.cc.allproperty, "anchor_right");
            var anker_top = wid(this.cc.allproperty, "anchor_top");
            var anker_bottom = wid(this.cc.allproperty, "anchor_bottom");
            if (anker_left.ToLower().StartsWith("t") & anker_right.ToLower().StartsWith("t") & anker_top.ToLower().StartsWith("t") & anker_bottom.ToLower().StartsWith("t"))
            {
                var ank = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                con.Anchor = ank;
            }
            else if (anker_left.ToLower().StartsWith("f") & anker_right.ToLower().StartsWith("t") & anker_top.ToLower().StartsWith("t") & anker_bottom.ToLower().StartsWith("t"))
            {
                var ank = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
                con.Anchor = ank;
            }
            else if (anker_left.ToLower().StartsWith("f") & anker_right.ToLower().StartsWith("f") & anker_top.ToLower().StartsWith("t") & anker_bottom.ToLower().StartsWith("t"))
            {
                var ank = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                con.Anchor = ank;
            }
            else if (anker_left.ToLower().StartsWith("f") & anker_right.ToLower().StartsWith("f") & anker_top.ToLower().StartsWith("f") & anker_bottom.ToLower().StartsWith("t"))
            {
                var ank = System.Windows.Forms.AnchorStyles.Bottom;
                con.Anchor = ank;
            }
            else if (anker_left.ToLower().StartsWith("f") & anker_right.ToLower().StartsWith("f") & anker_top.ToLower().StartsWith("t") & anker_bottom.ToLower().StartsWith("f"))
            {
                var ank = System.Windows.Forms.AnchorStyles.Top;
                con.Anchor = ank;
            }
        }
        private void setSize(Control con)
        {
            var locx = wid(cc.allproperty, "width");
            var locy = wid(cc.allproperty, "height");
            setanckor(con);
           var locyy = wid(cc.allproperty, "visibility");
            if (!locyy.Equals("0")) {
                if (locyy.ToLower().StartsWith("vis"))
                {

                    con.Visible = true;
                }
                else {
                    con.Visible = false;
                }

            }
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

            var locxn = wid(cc.allproperty, "enabled");
            if (!locxn.Equals("0"))
            {
                if (locxn.ToLower().StartsWith("f"))
                {
                    con.Enabled = false;
                }
                else {
                    con.Enabled = true;
                }

            }
            int top =  con.Margin.Top;
            int bottom =  con.Margin.Bottom;

            int left =  con.Margin.Left;
            int right =  con.Margin.Right;
            var locxnn = wid(cc.allproperty, "margin-top");
            if (!locxnn.Equals("0"))
            {
                try
                {
                    top = Convert.ToInt32(locxnn);
                }
                catch (Exception ex) {

                }

            }
           var locxnnc = wid(cc.allproperty, "margin-bottom");
            if (!locxnnc.Equals("0"))
            {
                try
                {
                    bottom = Convert.ToInt32(locxnnc);
                }
                catch (Exception ex)
                {

                }

            }
            var locxnncm = wid(cc.allproperty, "margin-left");
            if (!locxnncm.Equals("0"))
            {
                try
                {
                   left = Convert.ToInt32(locxnncm);
                }
                catch (Exception ex)
                {

                }

            }
            var locxnncmm = wid(cc.allproperty, "margin-right");
            if (!locxnncmm.Equals("0"))
            {
                try
                {
                    right = Convert.ToInt32(locxnncmm);
                }
                catch (Exception ex)
                {

                }

            }
            
            
            con.Padding=new Padding(left,top,right,bottom);
            //addpading(con);

        }
        private void addpading(Control con) {

            int top = con.Padding.Top;
            int bottom = con.Padding.Bottom;

            int left = con.Padding.Left;
            int right = con.Padding.Right;
            var locxnn = wid(cc.allproperty, "paddingtop");
            if (!locxnn.Equals("0"))
            {
                try
                {
                    top = Convert.ToInt32(locxnn);
                }
                catch (Exception ex)
                {

                }

            }
            var locxnnc = wid(cc.allproperty, "paddingbottom");
            if (!locxnnc.Equals("0"))
            {
                try
                {
                    bottom = Convert.ToInt32(locxnnc);
                }
                catch (Exception ex)
                {

                }

            }
            var locxnncm = wid(cc.allproperty, "paddingleft");
            if (!locxnncm.Equals("0"))
            {
                try
                {
                    left = Convert.ToInt32(locxnncm);
                }
                catch (Exception ex)
                {

                }

            }
            var locxnncmm = wid(cc.allproperty, "paddingright");
            if (!locxnncmm.Equals("0"))
            {
                try
                {
                    right = Convert.ToInt32(locxnncmm);
                }
                catch (Exception ex)
                {

                }

            }
            con.Padding = new Padding(left, top, right, bottom);
        }
        private void border(Control con)
        {
            var locx = wid(cc.allproperty, "border");

            if (locx.Equals(""))
            {
            }
            else if (locx.Equals("0"))
            {
            }
            else
            {
                var x = con as FlowLayoutPanel;

                BorderStyle h;

                Enum.TryParse<BorderStyle>(locx, out h);

                x.BorderStyle = h;

            }
            try
            {
                var locxx = wid(cc.allproperty, "direction");
                if (locxx.Equals(""))
                {
                }
                else if (locxx.Equals("0"))
                {
                }
                else
                {
                    try
                    {
                        var x = con as FlowLayoutPanel;

                        FlowDirection h;

                        Enum.TryParse<FlowDirection>(locxx, out h);
                        x.FlowDirection = h;
                    }
                    catch (Exception ex)
                    {
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setText(Control cv)
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
                    cv.Text = getdock;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setDock(Control k)
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
                    k.Dock = h;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setDockplace(Control c)
        {
            try
            {
                var getdock = getAttribute("placeholder");
                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {
                    var e = c as RadMaskedEditBox;
                    if (e != null)
                    {
                        e.NullText = getdock;

                    }
                }
            }
            catch (Exception ex)
            {

            }

            var reado = getAttribute("readonly");
            if (reado.ToLower().StartsWith("t"))
            {

                var e = c as RadMaskedEditBox;
                if (e != null)
                {
                    e.ReadOnly = true;

                }
            }
            else {

                var ef = c as RadMaskedEditBox;
                if (ef != null)
                {
                    ef.ReadOnly = false;

                }
            }

            var readod = getAttribute("masktype");
          

                var eff = c as RadMaskedEditBox;
                if (eff != null)
                {
                try
                {
                    MaskType mas;

                    Enum.TryParse<MaskType>(readod, out mas);
                    eff.MaskType = mas;

                    var readodd = getAttribute("mask");
                    eff.Mask = readodd;

                }
                catch (Exception ex) {

                }

                }
          
        }
        private class getdats
        {

            public string name { get; set; }
            public string value { get; set; }
        }

        private void Onselect(Control c) {
            //onchange
            string chan = "0";
            var cha = getAttribute("onchange");
            if (cha.Equals(""))
            {
            }
            else if (cha.Equals("0"))
            {
            }
            else
            {
                chan = cha;
            }
            if (!chan.Equals("0"))
            {
                var iii = c as RadMultiColumnComboBox;

                if (iii != null)
                {

                    iii.SelectedIndexChanged += delegate (object sender, EventArgs e) { radMultiColumnComboBox1_SelectedIndexChanged(sender, e, iii,chan); };
                }
                var iiix = c as RadGridView;

                if (iiix != null)
                {

                    iiix.KeyDown += delegate (object sender, KeyEventArgs e) { radMultiColumnComboBox1_SelectedIndexChanged(sender, e, iiix, chan); };
                }

                var iiixm = c as RadCardView;

                if (iiixm != null)
                {

                    iiixm.KeyDown += delegate (object sender, KeyEventArgs e) { radMultiColumnComboBox1_SelectedIndexChanged(sender, e, iiixm, chan); };
                }

            }


            string chanm = "0";
            var chank = getAttribute("oncelldoubleclick");
            if (chank.Equals(""))
            {
            }
            else if (chank.Equals("0"))
            {
            }
            else
            {
                chanm = chank;
                var iiix = c as RadGridView;

                if (iiix != null)
                {
                    iiix.CellDoubleClick += delegate (object sender, GridViewCellEventArgs e) { radGridView1_CellDoubleClick(sender, e, iiix, chanm); };
                }
            }
        }
        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e,RadMultiColumnComboBox cm,string nam)
        {
            try
            {
                GridViewDataRowInfo se = (GridViewDataRowInfo)cm.SelectedItem;

                var gettt = cc.allEventData.Where(ss => ss.eventName.Equals(nam)).ToList();

                if (gettt.Count > 0)
                {
                    var i = gettt.ElementAt(0);


                    EventOnchange y = new EventOnchange();
                    Dictionary<string, object> k = new Dictionary<string, object>();
                    foreach (var iuu in cm.Columns)
                    {
                        try
                        {
                            var t = se.Cells[iuu.Name].Value;
                            k.Add(iuu.Name, t);
                        }
                        catch (Exception ex)
                        {
                        }

                    }
                    y.columnvalue = JToken.Parse(se.DataBoundItem == null ? JsonConvert.SerializeObject(k) : JsonConvert.SerializeObject(se.DataBoundItem));
                    y.datahtml = i;
                    if (this.cc.Onform != null)
                    {
                        this.cc.Onform.ReceveFroms(y);
                        //  GORS.Instance.RecivDataFromWebs.ReceveFroms(y);
                    }
                    // kj.Click += delegate (object sender, EventArgs e) { events(sender, e, i); };

                }
            }
            catch (Exception ex) {

            }
        }
     
        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, KeyEventArgs e, RadGridView cm, string nam)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var se = cm.CurrentRow;

                    var gettt = cc.allEventData.Where(ss => ss.eventName.Equals(nam)).ToList();

                    if (gettt.Count > 0)
                    {
                        var i = gettt.ElementAt(0);


                        EventOnchange y = new EventOnchange();
                        Dictionary<string, object> k = new Dictionary<string, object>();
                        foreach (var iuu in cm.Columns)
                        {
                            try
                            {
                                var t = se.Cells[iuu.Name].Value;
                                k.Add(iuu.Name, t);
                            }
                            catch (Exception ex)
                            {
                            }

                        }
                        y.columnvalue = JToken.Parse(se.DataBoundItem == null ? JsonConvert.SerializeObject(k) : JsonConvert.SerializeObject(se.DataBoundItem));
                        y.datahtml = i;
                        if (this.cc.Onform != null)
                        {
                            this.cc.Onform.ReceveFroms(y);
                            //  GORS.Instance.RecivDataFromWebs.ReceveFroms(y);
                        }

                        // kj.Click += delegate (object sender, EventArgs e) { events(sender, e, i); };

                    }
                }
            }
            catch (Exception ex) {

            }
        }
        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, KeyEventArgs e, RadCardView cm, string nam)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var se = cm.SelectedItem.DataBoundItem;

                var gettt = cc.allEventData.Where(ss => ss.eventName.Equals(nam)).ToList();

                if (gettt.Count > 0)
                {
                    var i = gettt.ElementAt(0);


                    EventOnchange y = new EventOnchange();
                
                    y.columnvalue = JToken.Parse(JsonConvert.SerializeObject(cm.SelectedItem.DataBoundItem));// == null ? JsonConvert.SerializeObject(k) : JsonConvert.SerializeObject(se.DataBoundItem));
                    y.datahtml = i;
                    if (this.cc.Onform != null)
                    {
                        this.cc.Onform.ReceveFroms(y);
                        //  GORS.Instance.RecivDataFromWebs.ReceveFroms(y);
                    }

                    // kj.Click += delegate (object sender, EventArgs e) { events(sender, e, i); };

                }
            }

        }
        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e, RadGridView cm, string nam)
        {
            try
            {
                var se = cm.CurrentRow;

                var gettt = cc.allEventData.Where(ss => ss.eventName.Equals(nam)).ToList();

                if (gettt.Count > 0)
                {
                    var i = gettt.ElementAt(0);


                    EventOnchange y = new EventOnchange();
                    Dictionary<string, object> k = new Dictionary<string, object>();
                    foreach (var iuu in cm.Columns)
                    {
                        try
                        {
                            var t = se.Cells[iuu.Name].Value;
                            k.Add(iuu.Name, t);
                        }
                        catch (Exception ex)
                        {
                        }

                    }
                    y.columnvalue = JToken.Parse(se.DataBoundItem == null ? JsonConvert.SerializeObject(k) : JsonConvert.SerializeObject(se.DataBoundItem));
                    y.datahtml = i;
                    if (this.cc.Onform != null)
                    {
                        this.cc.Onform.ReceveFroms(y);
                        //  GORS.Instance.RecivDataFromWebs.ReceveFroms(y);
                    }

                    // kj.Click += delegate (object sender, EventArgs e) { events(sender, e, i); };

                }
            }
            catch (Exception ex) {


            }
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

            try
            {
                c.AutoFilter = true;
                CompositeFilterDescriptor dd = new CompositeFilterDescriptor();


               foreach (var ddf in colunfilter)
                {

                   
                        foreach (var xx in c.Columns)
                        {

                        MessageBox.Show(xx.Name+xx.FieldName);
                          

                        
                    }

                    FilterDescriptor prona = new FilterDescriptor("name", FilterOperator.Contains, "");
                    dd.LogicalOperator = FilterLogicalOperator.Or;
                    dd.FilterDescriptors.Add(prona);


                }



                c.EditorControl.FilterDescriptors.Add(dd);
            }
            catch (Exception ex) {
                //  var tr = getfold("mm","txt");
               // getfold("fff",".txt");
               /* string cc = Assembly.GetExecutingAssembly().Location;

                var ssd = Path.GetDirectoryName(cc) + "ttt.txt";
                //var fi = @"C:\Users\Mypc\Documents\Visual Studio 2015\Projects\winToWeb\winToWeb\bin\Debug\ttt.txt";
                if (!Directory.Exists(ssd))
                {

                    Directory.CreateDirectory(ssd);
                }
                File.WriteAllText(ssd, ex.Message);*/
                //MessageBox.Show(ex.Message);
            }
        }
        public string[] getfold(string Filename, string typefolder)
        {

            string[] zz = new string[2];
            string fouldernanmee = "/fileDeshinfff/" + typefolder.Replace(".", "");
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
        private void setTextDataSource(Control c)
        {
            try
            {
                var getdock = getAttribute("idselect");

                c.Tag = getdock;
            }
            catch (Exception ex)
            {

            }
            try { 
            var ww = c as RadMultiColumnComboBox;
            var getdockk = getAttribute("filter").Split('#');

                var getdockkk = getAttribute("displayname");
                ww.DisplayMember = getdockkk;
           
              /*  List<Form3.ddd> d = new List<Form3.ddd>();

                for (var index = 1; index <= 20; index++)
                {
                    Form3.ddd f = new Form3.ddd();

                    f.name = "Item" + index;
                    f.url = "http://localhost:80/uploads/08e51356-cff9-4f44-b729-9e52123774acIMG-20231130-WA0003.jpg";
                    f.gg = index;
                    d.Add(f);

                }*/
            //  
               // ww.DataSource = d;
                adddatwithFilter(ww, getdockk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        public void auto(Control v) {

            var autosize = wid(cc.allproperty, "autoSize");
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

                    (v as RadControl).AutoSize = true;
                }
                else
                {
                    (v as RadControl).AutoSize = false;
                }
            }
        }
        private void events(object sender, EventArgs e, List<Eventhtml> ev)
        {

            var io = (Control)sender;
            foreach (var ee in ev)
            {

                if (this.cc.Onform != null)
                {
                    this.cc.Onform.ReceveFroms(ee);
                    //  GORS.Instance.RecivDataFromWebs.ReceveFroms(y);
                }
            }
        }
        private void setClick(RadControl kj)
        {
            try
            {
                var getdock = getAttribute("onclick");


                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {

                    List<Eventhtml> gettt = new List<Eventhtml>();

                    var getrss = getdock.Split('#');
                    foreach (var h in getrss)
                    {
                        var getttm = cc.allEventData.Where(ss => ss.eventName.Equals(h)).ToList();
                        gettt.AddRange(getttm);
                    }
                    if (gettt.Count > 0)
                    {
                       // var i = gettt.ElementAt(0);

                        kj.Click += delegate (object sender, EventArgs e) { events(sender, e, gettt); };

                    }


                }
            }
            catch (Exception ex)
            {

            }
        }
        private string datexam()
        {

            string rr = "[{\"show\":true,\"DisName\":\"الصف بببببببالاسم\",\"FieldName\":\"mynamev\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo hello\",\"MaskText\":\"0\"}],\"Checknull\":true},{\"show\":true,\"DisName\":\"الصف ggggggggggggggggggggالاسم\",\"FieldName\":\"id\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":true},{\"show\":true,\"DisName\":\"الاسم\",\"FieldName\":\"mail\",\"TypeName\":\"bool\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاسم\",\"FieldName\":\"mailrrr\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo gggggg hello\",\"MaskText\":\"d\",\"MaskType\":\"Numeric\"}],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاhhhhhhسم\",\"FieldName\":\"maildd\",\"TypeName\":\"enu\",\"Enumvalue\":[{\"name\":\"bbbbb\",\"id\":1},{\"name\":\"bbbppppbb\",\"id\":2},{\"name\":\"bbbioooobb\",\"id\":3},{\"name\":\"bbbnmmmmmbb\",\"id\":4}],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"uuuuuu\",\"FieldName\":\"date\",\"TypeName\":\"date\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false}]";

            return rr;
        }
        Valdation ss = new Valdation();
        private async void entery1_eventData(object Sender, evntype type,entery entery1)
        {



            // ss.changefont(entery1);
            if (type == evntype.refresh)
            {


            }
            else if (type == evntype.save)
            {
                var sss = await ss.CheckValdation(entery1.radValidationProvider1);
                if (sss)
                {
                    if (GORS.Instance.inforceShowConfirmMessage)
                    {
                        if (RadMessageBox.Show("هــل تريد  الحفظ  ", "تأكيد", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                        {

                            entery1.SaveDate();
                            //S_IDDD

                            //  apiSave("0");

                        }
                    }
                    else
                    {
                        MessageBox.Show(Sender.ToString());


                    }
                }
            }
            else if (type == evntype.update)
            {
                var sss = await ss.CheckValdation(entery1.radValidationProvider1);
                if (sss)
                {
                    if (GORS.Instance.inforceShowConfirmMessage)
                    {
                        if (RadMessageBox.Show("هــل تريد  التعديل  ", "تأكيد", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                        {
                            var u = "fffff";
                            var rr = "[{\"id\":99,\"mail\":true,\"mailrrr\":\"" + u + "\",\"maildd\":1},{\"id\":959,\"mail\":true,\"mailrrr\":\"" + u + "\",\"maildd\":2}]";

                            entery1.addTodataSurce(rr);
                            //S_IDDD

                            //  apiSave("0");

                        }
                    }
                    else
                    {
                        MessageBox.Show(Sender.ToString());


                    }
                }
            }
            else if (type == evntype.delete)
            {
                entery1.getWating().StartWaiting();
                if (GORS.Instance.inforceShowConfirmMessage)
                {
                    if (RadMessageBox.Show("هــل تريد  الحذف  ", "تأكيد", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                    {

                        MessageBox.Show(Sender.ToString());
                        entery1.getWating().StopWaiting();
                        //S_IDDD

                        //  apiSave("0");

                    }
                }
                else
                {
                    MessageBox.Show(Sender.ToString());


                }

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
        public async Task<Image> GetImageAsync(string url,int x,int y)
        {
            var tcs = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith(task =>
                {
                    var webResponse = (HttpWebResponse)task.Result;
                    Stream responseStream = webResponse.GetResponseStream();


                    if (responseStream != null) webImage = Image.FromStream(responseStream);
                    tcs.TrySetResult(webImage);
                    webResponse.Close();
                    responseStream.Close();
                });

            return (Image)(new Bitmap(tcs.Task.Result, new Size(x, y)));

        }
        public async Task<Image> getphoto(string Url,string x,string y)
        {
            int xx = 40;
            int yy = 40;

            try
            {
                xx = Convert.ToInt32(x);
                yy = Convert.ToInt32(y);
            }
            catch (Exception ex) {

            }
            try
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
                    var er = await GetImageAsync(Url,xx,yy);

                    ImageConverter im = new ImageConverter();
                    var fe = (byte[])im.ConvertTo(er, typeof(byte[]));
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
                return (Image)(new Bitmap(imm, new Size(xx, yy)));
            }
            catch (Exception ex) {
                return Properties.Resources.formula32;

            }
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
        public Image ConvertBase64ToImage(byte[] bytes)
        {
            //  var bytes = Convert.FromBase64String(base64);

            using (var memory = new MemoryStream(bytes, 0, bytes.Length))
            {
                return Image.FromStream(memory, true);
            }
        }
        private async void  loadd(Control cd,string url) {
          string x=  getAttribute("imagesizex");
            if (x.Equals("0")) {
                x = "40";
            }
            string y = getAttribute("imagesizey");
            if (y.Equals("0"))
            {
                y = "40";
            }


            var dx = await getphoto(url,x,y);

            if (dx != null) {

                var t = cd as RadButton;
                if (t != null)
                {

                 
                    t.Image = dx;

                    string showimageonly = getAttribute("imageonly");


                    if (showimageonly.ToLower().StartsWith("t"))
                    {
                        t.DisplayStyle = DisplayStyle.Image;
                        t.AutoSize = true;

                    }
                    //  t.BackgroundImageLayout = ImageLayout.Zoom;
                }
               
            }

        }
        private void radButton1_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            // MessageBox.Show(sender.GetType().Name);
            var Item = sender as RadButtonElement;
            var Item1 = sender as RadMaskedEditBoxElement;
            var Item2 = sender as RadMultiColumnComboBoxElement;
            var Item3 = sender as RadDateTimePickerElement;
            if (Item != null)
            {


                e.ToolTipText = Item.ToolTipText;

            }
            if (Item1 != null)
            {


                e.ToolTipText = Item1.ToolTipText;

            }

            if (Item2 != null)
            {


                e.ToolTipText = Item2.ToolTipText;

            }
            if (Item3 != null)
            {


                e.ToolTipText = Item3.ToolTipText;

            }
        }
        private  void loaddx(Control cd)
        {
            string x = getAttribute("imagesizex");
            if (x.Equals("0"))
            {
                x = "40";
            }
            string y = getAttribute("imagesizey");
            if (y.Equals("0"))
            {
                y = "40";
            }
            int xx = 40;
            int yy = 40;

            try
            {
                xx = Convert.ToInt32(x);
                yy = Convert.ToInt32(y);
            }
            catch (Exception ex)
            {

            }
            string namesvg = getAttribute("svgname");
          

            if (!namesvg.ToLower().Equals("0"))
            {

                var t = cd as RadButton;
                if (t != null)
                {
                    object kj;
                    this.cc.imagesvgg.TryGetValue(namesvg,out kj);
                    if (kj != null)
                    {
                        try
                        {
                           //var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\km.svg");
                          //  MessageBox.Show(alldat);
                            RadSvgImage yu = RadSvgImage.FromXml(kj.ToString());
                            var getim = yu.GetRasterImage(new Size(xx, yy)); //(Image)(new Bitmap(, new Size(20, 20)));


                            t.Image = getim;

                            string showimageonly = getAttribute("imageonly");


                            if (showimageonly.ToLower().StartsWith("t"))
                            {
                                t.DisplayStyle = DisplayStyle.Image;
                                t.AutoSize = true;

                            }
                        }
                        catch (Exception ex) {

                           // MessageBox.Show(ex.Message);
                        }
                    }
               
                }
                var tt = cd as PictureBox;
                if (tt != null)
                {
                    object kj;
                    this.cc.imagesvgg.TryGetValue(namesvg, out kj);
                    if (kj != null)
                    {
                        try
                        {
                            //var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\km.svg");
                            //  MessageBox.Show(alldat);
                            RadSvgImage yu = RadSvgImage.FromXml(kj.ToString());
                            var getim = yu.GetRasterImage(new Size(xx, yy)); //(Image)(new Bitmap(, new Size(20, 20)));


                            tt.Image = getim;

                            
                        }
                        catch (Exception ex)
                        {

                            // MessageBox.Show(ex.Message);
                        }
                    }
                    /*   string showimageonly = getAttribute("imageonly");


                       if (showimageonly.ToLower().StartsWith("t"))
                       {
                           t.DisplayStyle = DisplayStyle.Image;
                           t.AutoSize = true;

                       }*/
                    //  t.BackgroundImageLayout = ImageLayout.Zoom;
                }

            }

        }
        public  override Control getTypeControl()
        {
            RadControl u = null;
            var uu = typeof(TT);
            if (uu == typeof(RadCheckBox)) {
                u = new RadCheckBox();
            }
            if (uu == typeof(RadRadioButton))
            {
                u = new RadRadioButton();
            }
            if (uu == typeof(RadGridView))
            {
               var eu = new RadGridView();
             var dd=  getAttribute("headerwidth");
                if (!dd.Equals("0"))
                {
                    eu.TableElement.RowHeaderColumnWidth = Convert.ToInt32(dd);
                }
                var ddv = getAttribute("enablealternatingrowcolor");
                if (ddv.ToLower().StartsWith("t"))
                {
                    eu.EnableAlternatingRowColor = true;
                    try
                    {
                        var ddvv = getAttribute("colora");
                        // this.radGridView3.TableElement.AlternatingRowColor = Color.DarkOliveGreen;
                        eu.TableElement.AlternatingRowColor = ColorTranslator.FromHtml(ddvv);
                    }
                    catch (Exception ex) {

                    }
                }
                var ddve = getAttribute("enablefit");
                if (ddve.ToLower().StartsWith("t"))
                {
                    eu.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                }
                var ddvee = getAttribute("enablegroup");
                if (ddvee.ToLower().StartsWith("t"))
                {
                    eu.EnableCustomGrouping = true;
                }
                var ddveev = getAttribute("enablepage");
                if (ddveev.ToLower().StartsWith("t"))
                {
                    eu.EnablePaging = true;
                   
                }
                var ddveevk = getAttribute("showhorizontal");
                if (ddveevk.ToLower().StartsWith("t"))
                {
                    eu.HorizontalScrollState = ScrollState.AlwaysShow;

                }
                var ddveevkk = getAttribute("showvertical");
                if (ddveevkk.ToLower().StartsWith("t"))
                {
                    eu.VerticalScrollState = ScrollState.AlwaysShow;

                }
                try
                {
                    var ddveevp = getAttribute("pagesize");

                    eu.PageSize = Convert.ToInt32(ddveevp);
                }
                catch (Exception ex) {


                }
                eu.AllowAddNewRow = false;
                eu.ViewCellFormatting+= radGridView1_ViewCellFormatting;
                u = eu;
                Onselect(u);
            }
            if (uu == typeof(RadCardView))
            {
                u = new RadCardView();
                Onselect(u);
            }
            if (uu == typeof(RadMaskedEditBox))
            {
                u = new RadMaskedEditBox();
                setDockplace(u);
            }

            
                   if (uu == typeof(RadDomainUpDown))
            {
                u = new RadDomainUpDown();
            }
            if (uu == typeof(RadButton))
            {
              var  ux = new RadButton();

               
                loaddx(ux);
                u = ux;
            }
            if (uu == typeof(RadButtonTextBox))
            {
                u = new RadButtonTextBox();

            }
            if (uu == typeof(RadWaitingBar))
            {
              var  uuu = new RadWaitingBar();
                Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement dotsSpinnerWaitingBarIndicatorElement1 = new DotsSpinnerWaitingBarIndicatorElement();
                uuu.WaitingIndicators.Add(dotsSpinnerWaitingBarIndicatorElement1);
              uuu.WaitingSpeed = 100;
               uuu.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
                uuu.Tag = getAttribute("addcontrol");
                u = uuu;
            }
            if (uu == typeof(entery))
            {
              var yt=  new entery();
                fromDesignData uui = new fromDesignData();

                uui.ApiName = "ttrrr";
                uui.FormName = "الاعدادات";
                uui.Rowcount = 1;
                uui.FormDesign = JToken.Parse(datexam());
                GORS.Instance.inforceShowConfirmMessage = true;
                yt.eventData += delegate (object sender, evntype e) { entery1_eventData(sender, e, yt); };
                yt.refre(uui);
                u = yt.radGroupBox1;

            }
            
            if (uu == typeof(RadMultiColumnComboBox))
            {
                u = new RadMultiColumnComboBox();
               
                Onselect(u);

            }
            if (uu == typeof(RadDateTimePicker))
            {
               var uk = new RadDateTimePicker();
                Valdation v = new Valdation();
                v.adddatetime(uk);

                u = uk;

            }
            if (uu == typeof(RadLabel))
            {
                u = new RadLabel();

            }
            //RadDateTimePicker
            // as Control;// as RadCheckBox();// .ThemeName;
            try
            {
                u.ThemeName = getdependencys.GetThem;
            }
            catch (Exception ex)
            {
            }
        
            setLocations(u);
            setSize(u);
            setText(u);
            setDock(u);
            auto(u);
            var eyy = getAttribute("tooltiptext");

            if (!eyy.Equals("0"))
            {
                u.RootElement.ToolTipText = eyy;
                u.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(this.radButton1_ToolTipTextNeeded);
            }
            var iuu = getAttribute("imagesrc");

            if (!iuu.Equals("0"))
            {

                try
                {
                   // loadd(u, iuu);

                }
                catch (OutOfMemoryException ex)
                {


                }
            }
          
            setClick(u);

            var ee = u as RadMultiColumnComboBox;
            if (ee != null) {

                setTextDataSource(u);
            }
            ss.changefont(u);
            return u;
        }
    }
}
