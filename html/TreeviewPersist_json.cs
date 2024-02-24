using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using System.Drawing;
using winToWeb.protouse;
using Telerik.WinControls;
using winToWeb.control;
using System.IO;
using System.Data;

namespace dynFormLib
{
    public class TreeviewPersist_json
    {
        private string vvvv;
        public TreeviewPersist_json()
        {
            this.children = new List<TreeviewPersist_json>();
        }
        public TreeviewPersist_json(string valll)
        {
            vvvv = valll;
        }
        [JsonIgnore]
        public Telerik.WinControls.UI.RadValidationRule alnulfex { get; set; }

        [JsonIgnore]
        public   Dictionary<string, object> imagesvgg { get; set; }
        [JsonIgnore]
        public  Dictionary<string, object> fromhtml { get; set; }
        public TreeviewPersist_json(string _value, List<TreeviewPersist_json> _children, bool _isChecked, Dictionary<string, string> _allproperty, List<Attributes> _attribute, List<Eventhtml> i, Telerik.WinControls.UI.RadValidationRule alnulfexx,Dictionary<string, object> imagesvg, Dictionary<string, object> ht, RecevDataFromWeb even, OnReciveForm onformm)
        {
            if (even != null) {
                getsetdt=even;
            }
            if (onformm != null) {
                Onform = onformm;
            }
            Tage_name = _value;
            isChecked = _isChecked;
            if (_children != null)
            {
                children = _children;
            }
            allproperty = _allproperty;
            attribute = _attribute;
            allEventData = i;
            alnulfex = alnulfexx;
            this.imagesvgg = imagesvg;
            this.fromhtml = ht;
        }
        [JsonIgnore]
        public RecevDataFromWeb getsetdt { get; set; }
        [JsonIgnore]
        public OnReciveForm Onform { get; set; }
        
        public List<Eventhtml> allEventData { get; set; }
        [JsonProperty("TageName")]
        public string Tage_name { get; set; }

        [JsonProperty("style")]
        public Dictionary<string,string> allproperty { get; set; }

        [JsonProperty("attribute")]
        public List<Attributes> attribute { get; set; }
        
        [JsonProperty("isChecked")]
        public bool isChecked { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<TreeviewPersist_json> children { get; set; }
        private string wid(Dictionary<string, string> aab, string key)
        {

           string ccm="0";
            try
            {
                aab.TryGetValue(key, out ccm);
                if (ccm == null) {
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
      
        private string getAttribute(string key)
        {

            string ccm="0";
            try
            {
                var getres = attribute.Where(dd=>dd.AttributeNme.Equals(key)).ToList();
                if (getres.Count > 0) {

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
        private string getAttribute(string key, List<Attributes> attributess)
        {

            string ccm = "0";
            try
            {
                var getres = attributess.Where(dd => dd.AttributeNme.Equals(key)).ToList();
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
        private void setLocations(Control con) {
            var locx = wid(allproperty, "locationX");
            var locy = wid(allproperty, "locationY");
            con.Location = new System.Drawing.Point(Convert.ToInt32(locx), Convert.ToInt32(locy));
            setSizebackground(con);
        }
        private void setLocations(RadElement con)
        {
            var locx = wid(allproperty, "locationX");
            var locy = wid(allproperty, "locationY");
            con.Location = new System.Drawing.Point(Convert.ToInt32(locx), Convert.ToInt32(locy));
            setSizebackground(con);
        }
        private void setSizebackground(RadElement con)
        {



          /*  try
            {
                var locx = wid(allproperty, "background");
                if (locx.Equals(""))
                {
                }
                else if (locx.Equals("0"))
                {
                }
                else
                {

                    con = ColorTranslator.FromHtml(locx);// ColorConverter.ConvertFromString();
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                var locx = wid(allproperty, "float");
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

            }*/
        }
        private void setSizebackground(Control con)
        {
          
          

            try
            {
                var locx = wid(allproperty, "background");
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
                var locx = wid(allproperty, "float");
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
                    else {
                        con.RightToLeft = RightToLeft.No;
                    }
                    // = ColorTranslator.FromHtml(locx);// ColorConverter.ConvertFromString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setanckor(Control con)
        {

            var anker_left = wid(allproperty, "anchor_left");
            var anker_right = wid(allproperty, "anchor_right");
            var anker_top = wid(allproperty, "anchor_top");
            var anker_bottom = wid(allproperty, "anchor_bottom");
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
            var locx = wid(allproperty, "width");
            var locy = wid(allproperty, "height");
            var locyy = wid(allproperty, "visibility");
            setanckor(con);
            if (!locyy.Equals("0"))
            {
                if (locyy.ToLower().StartsWith("vis"))
                {

                    con.Visible = true;
                }
                else
                {
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

            var locxn = wid(allproperty, "enabled");
            if (!locxn.Equals("0"))
            {
                if (locxn.ToLower().StartsWith("f"))
                {
                    con.Enabled = false;
                }
                else
                {
                    con.Enabled = true;
                }

            }
            int top = con.Margin.Top;
            int bottom = con.Margin.Bottom;

            int left = con.Margin.Left;
            int right = con.Margin.Right;
            var locxnn = wid(allproperty, "margin-top");
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
            var locxnnc = wid(allproperty, "margin-bottom");
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
            var locxnncm = wid(allproperty, "margin-left");
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
            var locxnncmm = wid(allproperty, "margin-right");
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
            //addpading(con);

        }

        private void setSize(RadElement con)
        {
            var locx = wid(allproperty, "width");
            var locy = wid(allproperty, "height");
          
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

                var filedname = getAttribute("fieldname");
                if (filedname.Equals(""))
                {
                }
                else if (filedname.Equals("0"))
                {
                }
                else
                {
                    var uoo = con as CardViewGroupItem;

                    if (uoo != null)
                    {
                        uoo.FieldName = filedname;
                    }

                    var uook = con as CardViewItem;

                    if (uook != null)
                    {
                        uook.FieldName = filedname;
                       
                    }
                    
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void border(Control con)
        {
            var locx = wid(allproperty, "border");
         
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
                var locxx = wid(allproperty, "direction");
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
                     catch (Exception ex) {
                     }
                  

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void setDock() {
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
            catch (Exception ex) {

            }
        }
 

        private void setText()
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

        private class getdats {

            public string name { get; set; }
            public string value { get; set; }
        }
        private void setTextDataSource()
        {
            try
            {
                var getdock = getAttribute("datasource");
                if (getdock.Equals(""))
                {
                }
                else if (getdock.Equals("0"))
                {
                }
                else
                {
                    var ee = new List<getdats>();
                    getdats f = new getdats();
                    f.name = "fgffg";
                    f.value = "5555";
                    getdats f2 = new getdats();
                    f2.name = "fgffgrrrr";
                    f2.value = "5555rrr";
                    ee.Add(f);
                    ee.Add(f2);
                    (con as RadMultiColumnComboBox).DataSource = ee;
                }
            }
            catch (Exception ex)
            {

            }
        }

     
        //datasource
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
        }
        private GridViewRelation addreltion(string relaname, string parent, string child, GridViewTemplate childd, GridViewTemplate parentt)
        {

            GridViewRelation relationOrders = new GridViewRelation(parentt);
            relationOrders.ChildTemplate = childd;
            relationOrders.RelationName = relaname;
            relationOrders.ParentColumnNames.Add(parent);
            relationOrders.ChildColumnNames.Add(child);
            return relationOrders;
        }
        private void setcolumnDatagrid() {
            var xv = control as RadGridView;
            if (xv != null)
            {
               
              var ge=  getAttribute("allowautosizerows");
                if (ge.ToLower().StartsWith("t")) {
                    xv.AutoSizeRows = true;
                }
                var gee = getAttribute("allowright");
                if (gee.ToLower().StartsWith("t"))
                {
                    xv.RightToLeft = RightToLeft.Yes;
                }
                var geev = getAttribute("allowsearch");
                if (geev.ToLower().StartsWith("t"))
                {
                    xv.AllowSearchRow = true;
                }

                var geevm = getAttribute("allowdelete");
                if (geevm.ToLower().StartsWith("t"))
                {
                    xv.AllowDeleteRow = true;
                }
                else {
                    xv.AllowDeleteRow = false;
                }

                var geevmk = getAttribute("allowedit");
                if (geevmk.ToLower().StartsWith("t"))
                {
                    xv.AllowEditRow = true;
                }
                else
                {
                    xv.AllowEditRow = false;
                }
                var geevmkf = getAttribute("allowadd");
                if (geevmkf.ToLower().StartsWith("t"))
                {
                    xv.AllowAddNewRow = true;
                }
                else
                {
                    xv.AllowAddNewRow = false;
                }

            }

                foreach (var z in children)
            {
                var x = control as RadGridView;
                if (x != null)
                {
                    if (z.Tage_name.ToLower().Equals("template"))
                    {
                        var itt = TemplateTaple(z.children);
                        x.MasterTemplate.Templates.Add(itt);
                        var rela=   addreltion("gggg", "ProductID","ID_unit",x.MasterTemplate,itt);

                        x.Relations.Add(rela);
                   

                        
                    }
                    else {
                        var e = getcolumn(z.attribute);
                        if (e != null)
                        {
                            x.Columns.Add(e);
                        }

                    }
                    //x.DataSource = itt.DataSource;
                    /* if (Tage_name.ToLower().Equals("template")) {

                      var it=   TemplateTaple();
                         x.Templates.Add(it);
                     }
                    else if (z.Tage_name.ToLower().Equals("column"))
                     {
                         var e = getcolumn(z.attribute);
                         if (e != null)
                         {
                             x.Columns.Add(e);
                         }
                     }*/
                    /*  var e=    getcolumn(z.attribute);
                          if (e != null)
                          {
                              x.Columns.Add(e);
                          }*/
                }

            }
            }

        private GridViewTemplate TemplateTaple(List<TreeviewPersist_json> en)
        {

            GridViewTemplate productsLevel = new GridViewTemplate();
            var nameee = getAttribute("caption");
            foreach (var z in en)
            {
                
                 



                        var e = getcolumn(z.attribute);
                        if (e != null)
                        {
                    //MessageBox.Show(z.Tage_name);
                        productsLevel.Columns.Add(e);
                        }
                    
                

            }
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

            productsLevel.DataSource = productsTable;
            //productsLevel.DataSource = c;
            productsLevel.Caption = nameee;
            
           // productsLevel.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            return productsLevel;
        }
        private void setcolumnDatagridcrd()
        {
            var xv = control as RadCardView;
            if (xv != null)
            {

                var ge = getAttribute("allowautosizerows");
                if (ge.ToLower().StartsWith("t"))
                {
                  //  xv.AutoSizeRows = true;
                }
                var gee = getAttribute("allowright");
                if (gee.ToLower().StartsWith("t"))
                {
                    xv.RightToLeft = RightToLeft.Yes;
                }
                var geev = getAttribute("allowsearch");
                if (geev.ToLower().StartsWith("t"))
                {
                   // xv.AllowSearchRow = true;
                }

                var geevm = getAttribute("allowdelete");
                if (geevm.ToLower().StartsWith("t"))
                {
                   // xv.AllowDeleteRow = true;
                }
                else
                {
                   // xv.AllowDeleteRow = false;
                }

                var geevmk = getAttribute("allowedit");
                if (geevmk.ToLower().StartsWith("t"))
                {
                   // xv.AllowEditRow = true;
                }
                else
                {
                    //xv.AllowEditRow = false;
                }
                var geevmkf = getAttribute("allowadd");
                if (geevmkf.ToLower().StartsWith("t"))
                {
                    //xv.AllowAddNewRow = true;
                }
                else
                {
                  //  xv.AllowAddNewRow = false;
                }

            }

            foreach (var z in children)
            {
                var x = control as RadCardView;
                if (x != null)
                {

                    var e = addpropertis(z.attribute);
                    if (e != null)
                    {


                        x.Columns.Add(e);
                    }
                }

            }
        }


     
        private GridViewDataColumn getcolumn(List<Attributes> attributessv) {
            GridViewDataColumn m=null;
            var typec = getAttribute("typecolumn", attributessv);
            if (typec.ToLower().Equals("check"))
            {
              var  mm = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
                addpropertis(attributessv, mm);
                m = mm;
            }

            if (typec.ToLower().Equals("text"))
            {
               var mm = new Telerik.WinControls.UI.GridViewTextBoxColumn();
                addpropertis(attributessv, mm);
                m = mm;
            }
            if (typec.ToLower().Equals("date"))
            {
               var mm = new Telerik.WinControls.UI.GridViewDateTimeColumn();
                addpropertis(attributessv, mm);
                m = mm;
            }
            if (typec.ToLower().Equals("image"))
            {
                var mm = new Telerik.WinControls.UI.GridViewImageColumn();
                mm.DataTypeConverter = new MyTypeConverter();
               mm.ImageLayout = ImageLayout.Zoom;
                addpropertis(attributessv, mm);
                m = mm;
            }
            if (typec.ToLower().Equals("decimal"))
            {
               var mm = new Telerik.WinControls.UI.GridViewDecimalColumn();
                addpropertis(attributessv,mm);
                 m = mm;
            }
            if (typec.ToLower().Equals("textmask"))
            {
                var mm = new Telerik.WinControls.UI.GridViewMaskBoxColumn();
                
                var text = getAttribute("mask", attributessv);
                if (!text.Equals("0"))
                {
                    mm.Mask = text;
                }
                var textt = getAttribute("masktype", attributessv);
                if (!textt.Equals("0"))
                {
                    try
                    {
                        MaskType ty;

                        Enum.TryParse<MaskType>(textt, out ty);
                        mm.MaskType = ty;
                    }
                    catch (Exception ex) {

                    }
                }
                addpropertis(attributessv, mm);
                m = mm;
            }
            return m;
        }

     

        private void addpropertis(List<Attributes> attributessv, GridViewDataColumn mm) {

            var text = getAttribute("text", attributessv);
            var textt = getAttribute("columnname", attributessv);
            var fie = getAttribute("fieldname", attributessv);
            var from = getAttribute("format", attributessv);
            var reado = getAttribute("readonly", attributessv);
            var vis = getAttribute("visibleincolumnchooser", attributessv);
            var visv = getAttribute("headertextalignment", attributessv);
            string namesvg = getAttribute("svgname",attributessv);
            var enabexpirestion = getAttribute("enableexpression", attributessv);


            if (!visv.Equals("0"))
            {
                try
                {
                    ContentAlignment ty;

                    Enum.TryParse<ContentAlignment>(visv, out ty);
                    mm.HeaderTextAlignment = ty;
                }
                catch (Exception ex)
                {

                }
            }
           
            if (!from.Equals("0"))
            {
                mm.FormatString = from;
            }
            var widh = getAttribute("width", attributessv);
            if (!widh.Equals("0"))
            {
                try
                {
                    mm.Width = Convert.ToInt32(widh);
                }
                catch
                {
                }
            }
            else {
                mm.BestFit();
            }
            if (!reado.Equals("0"))
            {
                if (reado.ToLower().StartsWith("t"))
                {
                    mm.ReadOnly = true;
                }
                else {
                    mm.ReadOnly = false;
                }
              
            }

            if (vis.ToLower().StartsWith("f")) {
                mm.VisibleInColumnChooser = false;
            }
            if (!namesvg.ToLower().Equals("0"))
            {
                string x = getAttribute("imagesizex",attributessv);
                if (x.Equals("0"))
                {
                    x = "40";
                }
                string y = getAttribute("imagesizey",attributessv);
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
                object kj;
           imagesvgg.TryGetValue(namesvg, out kj);
                if (kj != null)
                {
                    try
                    {
                        //var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\km.svg");
                        //  MessageBox.Show(alldat);
                        RadSvgImage yu = RadSvgImage.FromXml(kj.ToString());
                        var getim = yu.GetRasterImage(new Size(xx, yy)); //(Image)(new Bitmap(, new Size(20, 20)));


                        mm.HeaderImage = getim;

                        string showimageonly = getAttribute("imageonly",attributessv);


                        if (showimageonly.ToLower().StartsWith("t"))
                        {
                           /* mm.ImageLayout = ImageLayout.Stretch;
                            mm.DisplayStyle = DisplayStyle.Image;
                            t.AutoSize = true;*/

                        }
                    }
                    catch (Exception ex)
                    {

                        // MessageBox.Show(ex.Message);
                    }
                }
            }
            if (enabexpirestion.ToLower().StartsWith("t"))
            {
                mm.EnableExpressionEditor = true;
                var enabexpirestionr = getAttribute("expression", attributessv);

                if (!enabexpirestionr.Equals("0"))
                {
                    mm.Expression = enabexpirestionr;
                }
            }
          
          
            mm.HeaderText = text;
            mm.FieldName = fie;
            mm.Name = textt;
           
        }

        private ListViewDetailColumn addpropertis(List<Attributes> attributessv)
        {

            var text = getAttribute("text", attributessv);
            var textt = getAttribute("columnname", attributessv);
           
            var fie = getAttribute("fieldname", attributessv);

            ListViewDetailColumn mm = new ListViewDetailColumn(fie, text);
            var from = getAttribute("format", attributessv);
            var reado = getAttribute("readonly", attributessv);
            var vis = getAttribute("visibleincolumnchooser", attributessv);
            var visv = getAttribute("headertextalignment", attributessv);
            if (!visv.Equals("0"))
            {
                try
                {
                    ContentAlignment ty;

                    Enum.TryParse<ContentAlignment>(visv, out ty);
                   // mm.HeaderTextAlignment = ty;
                }
                catch (Exception ex)
                {

                }
            }

            if (!from.Equals("0"))
            {
               // mm.FormatString = from;
            }
            var widh = getAttribute("width", attributessv);
            if (!widh.Equals("0"))
            {
                try
                {
                  //  mm.Width = Convert.ToInt32(widh);
                }
                catch
                {
                }
            }
            else
            {
               // mm.BestFit();
            }
            if (!reado.Equals("0"))
            {
                if (reado.ToLower().StartsWith("t"))
                {
                  //  mm.ReadOnly = true;
                }
                else
                {
                   // mm.ReadOnly = false;
                }

            }

            if (vis.ToLower().StartsWith("f"))
            {
               // mm.VisibleInColumnChooser = false;
            }

            return mm;

        }
        private void loaddx(Control cd)
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
                    imagesvgg.TryGetValue(namesvg, out kj);
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
                        catch (Exception ex)
                        {

                            // MessageBox.Show(ex.Message);
                        }
                    }

                }
                var tt = cd as PictureBox;
                if (tt != null)
                {
                    object kj;
                    imagesvgg.TryGetValue(namesvg, out kj);
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
        private void addtogroup() {
            try
            {
                foreach (var z in children)
                {
                   // MessageBox.Show("ffffff");
                var x = control as RadGroupBox;
                    if (x != null)
                    {
                     x.Controls.Add(z.control);
                    }
                    var h =control as FlowLayoutPanel;
                  
                    if (h != null)
                    {
                       
                        h.Controls.Add(z.control);
                    }
                    var hh = control as RadPageView;
                  
                    if (hh != null)
                    {
                     
                        var pagers = z.control as RadPageViewPage;
                        if (pagers != null) {
                            hh.Pages.Add(pagers);
                        }
                       
                    }

                   /* var hhk = control as RadCardView;

                    if (hhk != null)
                    {

                        var pagers = z.elemtcontrol as CardViewGroupItem;
                        if (pagers != null)
                        {
                            hhk.CardTemplate.Items.Add(pagers);
                        }
                        var pagersc = elemtcontrol as CardViewGroupItem;// CardViewItem;
                        if (pagersc != null)
                        {
                            var hy = z.elemtcontrol as CardViewItem;
                            if (hy != null)
                            {
                                pagersc.Items.Add(hy);
                            }
                        }
                    }*/
                    //   var hhk = control as RadButtonTextBox;

                    /* if (hhk != null)
                     {

                         var pagers = z.control as RadElement;
                         if (pagers != null)
                         {
                             hhk.LeftButtonItems.Add(pagers);
                         }

                     }*/
                    var hhx = control as RadPageViewPage;

                    if (hhx != null)
                    {
                       
                        hhx.Controls.Add(z.control);

                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private Control con = null;

        private RadElement elemtcontrol = null;

        private void mult() {
            

        }


        private void propertyPageview(RadPageView con)
        {
            try
            {
                var locx = wid(allproperty, "viewmode");
                PageViewMode n;
                Enum.TryParse<PageViewMode>(locx, out n);
                con.ViewMode = n;
                var locy = wid(allproperty, "stripbuttons");
                StripViewButtons nn;
                Enum.TryParse<StripViewButtons>(locy, out nn);
                ((Telerik.WinControls.UI.RadPageViewStripElement)(con.GetChildAt(0))).StripButtons = nn;//Telerik.WinControls.UI.StripViewButtons.None;

                var locym = wid(allproperty, "StripAlignment");
                StripViewAlignment nnm;
                Enum.TryParse<StripViewAlignment>(locym, out nnm);

                ((Telerik.WinControls.UI.RadPageViewStripElement)(con.GetChildAt(0))).StripAlignment = nnm;
            }
            catch (Exception ex) {

            }
            try { 

            var locymx = wid(allproperty, "ItemAlignment");
            StripViewItemAlignment nnmx;
            Enum.TryParse<StripViewItemAlignment>(locymx, out nnmx);

            ((Telerik.WinControls.UI.RadPageViewStripElement)(con.GetChildAt(0))).ItemAlignment = nnmx;
        }
            catch (Exception ex) {

            }
            try
            {

                var locymxv = wid(allproperty, "ItemFitMode");
                StripViewItemFitMode nnmxv;
                Enum.TryParse<StripViewItemFitMode>(locymxv, out nnmxv);

                ((Telerik.WinControls.UI.RadPageViewStripElement)(con.GetChildAt(0))).ItemFitMode = nnmxv;
            }
            catch (Exception ex) {

            }
          

        }
        public string OpenFile(string caption, string filter = "All files (*.*)|*.*")
        {
            System.Windows.Forms.OpenFileDialog diag = new System.Windows.Forms.OpenFileDialog();
            diag.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            diag.Title = caption;
            diag.Filter = filter;
            diag.CheckFileExists = true;
            diag.CheckPathExists = true;
            diag.RestoreDirectory = true;
            diag.ShowDialog();


            return diag.FileName;
            //  return string.Empty;
        }
        private async void A_img_Click(object sender, EventArgs e)
        {


            PictureBox ss = (PictureBox)sender;
          

           
                    var ppth = OpenFile("s");


                    if (ppth != null)
                    {
                        var img = await Task.Run(() => File.ReadAllBytes(ppth));

                        try
                        {
                            Bitmap mm;
                            using (var ms = new MemoryStream(img))
                            {
                                mm = new Bitmap(Bitmap.FromStream(ms));
                                ss.Image = mm;
                            }
                            // var recepient = _selectedParticipant.Name;

                        }
                        catch
                        {
                        }
                    }
           

        }
        [JsonIgnore]
        public Control control {
            get {
                if (con != null)
                {
                  //  MessageBox.Show("ghgggggg");
                }
                else
                {
                    if (typeTage == typeTage.GroupBox)
                    {
                        con = new RadGroupBox();
                        try
                        {
                            (con as RadGroupBox).ThemeName = getdependencys.GetThem;
                        }
                        catch (Exception ex) {
                        }
                            setLocations(con);
                        setSize(con);
                        setDock();
                        addtogroup();
                        var autosize = wid(allproperty, "autoSize");
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

                    }
                  else  if (typeTage == typeTage.FlowLayout)
                    {
                        con = new FlowLayoutPanel();
                        
                        setLocations(con);
                        setSize(con);
                        setDock();
                        addtogroup();
                        border(con);
                        var autosize = wid(allproperty, "autoSize");
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
                                (con as FlowLayoutPanel).AutoSize = true;
                            }
                            else
                            {
                                (con as FlowLayoutPanel).AutoSize = false;
                            }
                        }

                    }
                    else if (typeTage == typeTage.Label)
                    {
                        con = new ProtuseCheckBox<RadLabel>(this).getTypeControl();
                    }

                    else if (typeTage == typeTage.Radio)
                    {
                        con = new ProtuseCheckBox<RadRadioButton>(this).getTypeControl();
                      
                    }
                    else if (typeTage == typeTage.checkBox)
                    {
                        con = new ProtuseCheckBox<RadCheckBox>(this).getTypeControl();// new RadCheckBox();
                      
                       
                    }
                    else if (typeTage == typeTage.DomainUpDown)
                    {
                        con = new ProtuseCheckBox<RadDomainUpDown>(this).getTypeControl();// new RadCheckBox();


                    }
                    
                    else if (typeTage == typeTage.DateTime)
                    {
                        con = new ProtuseCheckBox<RadDateTimePicker>(this).getTypeControl();
                    }
                    else if (typeTage == typeTage.PageView)
                    {
                        con = new RadPageView();
                        var w = (con as RadPageView);
                        try
                        {
                            w.ThemeName = getdependencys.GetThem;
                        }
                        catch (Exception ex)
                        {
                        }


                        setLocations(con);
                        setSize(con);
                        setText();
                        setDock();
                        addtogroup();
                        propertyPageview(w);
                    }

                    else if (typeTage == typeTage.page)
                    {
                        con = new RadPageViewPage();

                      
                        setLocations(con);
                        setSize(con);
                        setText();
                        setDock();
                        addtogroup();

                        var autosize = wid(allproperty, "Title");
                        if (autosize.Equals(""))
                        {
                        }
                        else if (autosize.Equals("0"))
                        {
                        }
                        else
                        {
                          
                                (con as RadPageViewPage).Text = autosize;
                           
                        }
                    }
                    else if (typeTage == typeTage.TextBox)
                    {

                        con = new ProtuseCheckBox<RadMaskedEditBox>(this).getTypeControl();
                      

                    }
                    else if (typeTage == typeTage.Textbutton)
                    {

                        con = new ProtuseCheckBox<RadButtonTextBox>(this).getTypeControl();
                        var x = (con as RadButtonTextBox);

                       

                    }
                    else if (typeTage == typeTage.entery)
                    {

                        con = new ProtuseCheckBox<entery>(this).getTypeControl();
                       // var x = (con as RadButtonTextBox);



                    }
                    else if (typeTage == typeTage.imageview)
                    {
                        var y = new PictureBox();
                        try
                        {
                            var t = getAttribute("sizestyle");
                            ImageLayout er;
                            Enum.TryParse<ImageLayout>(t, out er);
                            y.BackgroundImageLayout = er;
                        }
                        catch (Exception ex) {

                        }
                        loaddx(y);
                        y.DoubleClick += A_img_Click;
                        con = y;
                        setLocations(con);
                        setSize(con);
                        setText();
                        setDock();
                      
                        // var x = (con as RadButtonTextBox);



                    }
                    else if (typeTage == typeTage.dataGridView)
                    {

                        con = new ProtuseCheckBox<RadGridView>(this).getTypeControl();
                        // var x = (con as RadButtonTextBox);

                        setcolumnDatagrid();

                    }
                    else if (typeTage == typeTage.wating)
                    {

                        con = new ProtuseCheckBox<RadWaitingBar>(this).getTypeControl();
                        // var x = (con as RadButtonTextBox);

                      

                    }
                    else if (typeTage == typeTage.card)
                    {

                        con = new ProtuseCheckBox<RadCardView>(this).getTypeControl();
                         var x = (con as RadCardView);

                       
                    setcolumnDatagridcrd();


                    }
                    else if (typeTage == typeTage.proswe)
                    {

                      string fr=  getAttribute("fromurl");
                        if (!fr.Equals("0"))
                        {
                            con = new webproser(fr, getsetdt);
                        }
                       
                        string frr = getAttribute("fromtext");
                        if (!frr.Equals("0"))
                        {
                            object va;
                            this.fromhtml.TryGetValue(frr,out va);

                            if (va != null) {

                                con = new webproser(va.ToString(),true, getsetdt);
                            }
                        }
                        if (con == null) {

                            con = new webproser(getsetdt);
                        }
                        setLocations(con);
                        setSize(con);
                       // setText();
                        setDock();


                    }

                    else if (typeTage == typeTage.Multicombo)
                    {

                        con = new ProtuseCheckBox<RadMultiColumnComboBox>(this).getTypeControl();
                 
                    }
                    else if (typeTage == typeTage.Botton)
                    {
                        con = new ProtuseCheckBox<RadButton>(this).getTypeControl();
                    
                        

                      

                        
                    }
                }
                return con;
            }
        }

        [JsonIgnore]
        public string JSon
        {
            get
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        private typeTage ty;
        public typeTage typeTage
        {
           
            get
            {
                

              

                switch (Tage_name.ToLower())
                {
                    case "groupbox":
                        ty = typeTage.GroupBox;

                        break;
                    case "label":
                        ty = typeTage.Label;

                        break;

                    case "button":
                        ty = typeTage.Botton;

                        break;

                    case "flowlayout":
                        ty = typeTage.FlowLayout;

                        break;
                    case "edittext":
                        ty = typeTage.TextBox;

                        break;
                    case "checkbox":
                        ty = typeTage.checkBox;

                        break;
                    case "cardview":
                        ty = typeTage.card;

                        break;
                    case "cardviewgroup":
                        ty = typeTage.cardgroup;

                        break;
                    case "cardviewitem":
                        ty = typeTage.carditem;

                        break;
                    case "pageview":
                        ty = typeTage.PageView;

                        break;
                    case "entry":
                        ty = typeTage.entery;

                        break;

                    case "pageviewpage":
                        ty = typeTage.page;

                        break;
                    case "radiobutton":
                        ty = typeTage.Radio;

                        break;

                    case "datetime":
                        ty = typeTage.DateTime;

                        break;
                    case "combobox":
                        ty = typeTage.Multicombo;

                        break;

                    case "textbutton":
                        ty = typeTage.Textbutton;

                        break;
                    case "domainupdown":
                        ty = typeTage.DomainUpDown;

                        break;
                    case "datagridview":
                        ty = typeTage.dataGridView;

                        break;

                    case "imageview":
                        ty = typeTage.imageview;

                        break;
                    case "wating":
                        ty = typeTage.wating;

                        break;
                    case "webbrowser":
                        ty = typeTage.proswe;

                        break;
                    default:
                        ty = typeTage.None;
                        break;
                }
                return ty;
            }
        }
     


        [JsonIgnore]
        public TreeviewPersist_json fromJSon
        {
            get
            {
                return JsonConvert.DeserializeObject<TreeviewPersist_json>(vvvv);
            }
        }
    }

    public enum typeTage {
        None,GroupBox,Botton,Label,FlowLayout,TextBox,PageView,page,checkBox,Radio,DateTime,Multicombo,Textbutton, DomainUpDown,entery,dataGridView,wating,card,cardgroup,carditem,imageview,proswe

    }
}
