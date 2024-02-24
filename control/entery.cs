using ERP.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.control
{
    public partial class entery : UserControl
    {
        private Type c;
        private BindingSource f;
        private BindingSource bindingSource1;
        private List<data> listt;
        public entery()
        {
            InitializeComponent();
            f = new BindingSource();
            bindingSource1 = new BindingSource();
            this.radDataEntry1.EditorInitializing += new EditorInitializingEventHandler(radDataEntry1_EditorInitializing);
            this.radDataEntry1.ItemInitialized += new ItemInitializedEventHandler(radDataEntry1_ItemInitialized);
            this.radDataEntry1.BindingCreated += new BindingCreatedEventHandler(radDataEntry1_BindingCreated);
            radGridView1.DataSource = bindingSource1;
            radButton7.Tag = "1";
            inslisprovid();
            
        }

        public delegate void myEvent(object Sender, evntype type);
        public event myEvent eventData;
        private void radDataEntry1_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            /*  if (e.DataMember == "Salary")
              {
                  e.Binding.Parse += new ConvertEventHandler(Binding_Parse);
              }*/
        }
        public RadWaitingBar getWating() {

            return this.radWaitingBar1;
        }
        private void radDataEntry1_ItemInitialized(object sender, ItemInitializedEventArgs e)
        {

            foreach (Control k in e.Panel.Controls)
            {
                k.Font = radGridView1.Font;
             
                var ff = k as RadMaskedEditBox;

                if (ff != null)
                {
                    ff.RightToLeft =RightToLeft.No;
                    ff.TextAlign = HorizontalAlignment.Center;
                    ff.Font = radGridView1.Font;
                    // MessageBox.Show("gggggggg");
                    //new Size(50, ff.Height);
                    //  ff.Invalidate();
                   
                }
            }
            if (e.Panel.Location.Y + e.Panel.Height > this.radDataEntry1.Height) {

                this.radDataEntry1.Height += e.Panel.Location.Y +e.Panel.Height-this.radDataEntry1.Height+ this.radDataEntry1.ItemSpace;
            }

            int si = flowLayoutPanel1.Height + e.Panel.Height;
         //  = new Size(radGroupBox3.Width, e.Panel.con);
             SizeF scaleFactor = this.radDataEntry1.RootElement.DpiScaleFactor;
             SizeF descaleFactor = new SizeF(1 / scaleFactor.Width, 1 / scaleFactor.Height);
            radGroupBox3.Size =new Size(radGroupBox3.Width, radGroupBox3.Height+ e.Panel.Height);
             // e.Panel.Location = new Point(e.Panel.Location.X, e.Panel.Location.Y - TelerikDpiHelper.ScaleInt(35, scaleFactor));
             //  radGroupBox3.Size = new Size(e.Panel.Size.Width, TelerikDpiHelper.ScaleInt(100, scaleFactor));
             /*  var w = new RadButton();
               w.Text = "vvvvv";
               w.Location = new Point(0,0);
               e.Panel.BackColor = Color.Red;
               e.Panel.Controls.Add(w);

               if (e.Panel.Controls[0] is RadDateTimePicker)
               {
                   e.Panel.Controls[0].ForeColor = Color.MediumVioletRed;
               }

               if (e.Panel.Controls[1].Text == "Note")
               {
                   e.Panel.Size = new Size(e.Panel.Size.Width, TelerikDpiHelper.ScaleInt(100, scaleFactor));
                   (e.Panel.Controls[0] as RadTextBox).Multiline = true;
               }

               e.Panel.Controls[1].Font = new Font(e.Panel.Controls[1].Font.Name, 12.0F, FontStyle.Bold);
               e.Panel.Controls[1].ForeColor = Color.Red;*/
        }

        private void radDataEntry1_EditorInitializing(object sender, EditorInitializingEventArgs e)
        {

            foreach (var hh in listt) {

                if (e.Property.Name.Equals(hh.FieldName)) {

                    if (hh.TypeName.ToLower().StartsWith("st")| hh.TypeName.ToLower().StartsWith("in")| hh.TypeName.ToLower().StartsWith("dec")) {

                        RadMaskedEditBox radMaskedEditBox = new RadMaskedEditBox();

                        foreach (var tt in hh.Settings) {
                            if (tt.SelectToken("NullText").ToString() != null) {
                                radMaskedEditBox.NullText = tt.SelectToken("NullText").ToString();

                            }
                            try
                            {
                                if (tt.SelectToken("Password").ToString() != null)
                                {

                                    radMaskedEditBox.PasswordChar = tt.SelectToken("Password").ToString().ToCharArray()[0];
                                }
                            }
                            catch (Exception ex) {

                            }
                            if (tt.SelectToken("MaskText").ToString() != null)
                            {
                               
                                
                                    
                                if (!tt.SelectToken("MaskText").ToString().Equals("0"))
                                {
                                    if (tt.SelectToken("MaskType").ToString() != null)
                                    {

                                        try
                                        {
                                            MaskType ii;
                                            var du = Enum.TryParse<MaskType>(tt.SelectToken("MaskType").ToString(),out ii);
                                            radMaskedEditBox.MaskType = ii;
                                        }
                                        catch (Exception ex) {


                                        }
                                    }
                                       
                                    radMaskedEditBox.Mask = tt.SelectToken("MaskText").ToString();
                                }

                            }

                        }

                      
                        radMaskedEditBox.MaskedEditBoxElement.StretchVertically = true;
                        radMaskedEditBox.RightToLeft = RightToLeft.No;
                        radMaskedEditBox.TextAlign = HorizontalAlignment.Center;
                        radMaskedEditBox.Font = radGridView1.Font;
                        e.Editor = radMaskedEditBox;
                        e.Editor.Size = new Size(100, 20);
                        e.Editor.Invalidate();
                    }


                    if (hh.TypeName.ToLower().StartsWith("date"))
                    {
                        RadDateTimePicker t = new RadDateTimePicker();
                        t.Value = DateTime.Now;
                        adddatetime(t);
                        e.Editor = t;
                        e.Editor.Size = new Size(100, 20);
                        e.Editor.Invalidate();

                    }
                    if (hh.Checknull)
                    {
                        if (radValidationRule1 != null)
                        {
                            radValidationRule1.Controls.Add(e.Editor);
                        }
                    }

                }
            }
        
            if (e.Property.Name == "mailrrgr")
            {

                RadMultiColumnComboBox radMaskedEditBox = new RadMultiColumnComboBox();
              //  radMaskedEditBox.NullText = "يرجي";
                var hh = new List<dat>();
                dat j = new dat();
                j.kk = "fgg";
                j.mmn = "uuio";
                hh.Add(j);
              //  radMaskedEditBox.ValueMember = "mmn";
                radMaskedEditBox.DataSource = hh;
               // radMaskedEditBox.DisplayMember = "kk";
                // radMaskedEditBox.MaskedEditBoxElement.StretchVertically = true;

                e.Editor = radMaskedEditBox;
                e.Editor.Size = new Size(100, 20);
               // e.Editor.Invalidate();
            }
            
            if (e.Property.Name == "Password")
            {
                (e.Editor as RadTextBox).PasswordChar = '*';
            }
        }
        public class dat {
            public string kk { get; set; }
            public string mmn { get; set; }

        }

        public enum datt
        {
          fff,hh,ll

        }
        public List<data> allist()
        {
            if (listt == null)
            {

               /* data d = new data();
                d.FieldName = "mynamev";
                d.show = true;
                d.Checknull = true;
                d.DisName = "الصف بببببببالاسم";
                d.TypeName = "st";// typeof(string);
                var q = "[{\"NullText\":\"helllo hello\",\"MaskText\":\"0\"}]";
                d.Settings = JToken.Parse(q);
                data dd = new data();
                dd.show = true;
                dd.FieldName = "id";
                dd.Checknull = true;
                dd.DisName = "الصف ggggggggggggggggggggالاسم";
                dd.TypeName ="st";
                data dmd = new data();
                dmd.show = true;
                dmd.FieldName = "mail";
                dmd.DisName = "الاسم";
                dmd.TypeName = "bool";

                data dmdy = new data();
                dmdy.show = true;
                dmdy.FieldName = "date";
                dmdy.DisName = "uuuuuu";
                dmdy.TypeName = "date";


                data dmdx = new data();
                dmdx.show = true;
                dmdx.FieldName = "mailrrr";
                dmdx.DisName = "اjjjلاسم";
                dmdx.TypeName = "st";// typeof(dat);
                var qq = "[{\"NullText\":\"helllo  gggggg hello\",\"MaskText\":\"d\",\"MaskType\":\"Numeric\"}]";
                dmdx.Settings = JToken.Parse(qq);
                string hg = "[{\"name\":\"bbbbb\",\"id\":1},{\"name\":\"bbbppppbb\",\"id\":2},{\"name\":\"bbbioooobb\",\"id\":3},{\"name\":\"bbbnmmmmmbb\",\"id\":4}]";
                data dmdd = new data();
                dmdd.show = true;
                dmdd.FieldName = "maildd";
                dmdd.DisName = "اjjjلاhhhhhhسم";
                dmdd.Enumvalue = JToken.Parse(hg);
                dmdd.TypeName = "enu";
                var vx = new List<data>();
                vx.Add(d);
                vx.Add(dd);
                vx.Add(dmd);
                vx.Add(dmdx);
                vx.Add(dmdd);
                vx.Add(dmdy);
                
                Clipboard.SetText(JsonConvert.SerializeObject(vx));*/
                var gg = JsonConvert.DeserializeObject<List<data>>(setData);
                listt = gg;
                return listt;
            }
            else
            {
                return listt;
            }
        }

        private string setData = "[]";
     
        private void radGridView1_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("column1"))
            {


              //  var rr = JsonConvert.SerializeObject(); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";

                eventData.Invoke(e.Row.DataBoundItem, evntype.delete);
                //  MessageBox.Show(rr);
                /*var xx = JsonConvert.DeserializeObject(rr, c);
                f.DataSource = xx;*/
                /*  var dialog = new ERPDataForm();

                  dialog.DataEntry.DataSource = e.Row.DataBoundItem;

                  if (dialog.ShowDialog() == DialogResult.OK)
                  {


                  }*/
            }
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }


        public void addTodataSurce(string da) {
            Type ddxc = typeof(List<>);
            Type lis = ddxc.MakeGenericType(c);
            var xx = JsonConvert.DeserializeObject(da, lis);



            bindingSource1.DataSource = xx;//JToken.Parse(ggg);

        }
        private void radButton3_Click(object sender, EventArgs e)
        {
           //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
          // c = MyTypeBuilder.CompileResultType(allist());
          
            bindingSource1.MoveFirst();
            /*if (eventData != null)
            {

                eventData.Invoke("5555555", evntype.refresh);
            }*/
        }
        public void adddatetime(RadDateTimePicker vv)
        {

            vv.Value = DateTime.Now;
            if (GORS.Instance.Date_typ.Equals(1))
            {



                vv.Culture = CultureInfo.GetCultureInfo("ar-AE");
                if (GORS.Instance.Date_enable)
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    vv.CustomFormat = GORS.Instance.Date_fromate;

                }
                else
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                }
            }
            if (GORS.Instance.Date_typ.Equals(2))
            {

                vv.Culture = CultureInfo.GetCultureInfo("ar-AE");

                if (GORS.Instance.Date_enable)
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    vv.CustomFormat = GORS.Instance.Date_fromate;
                }
                else
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                }
            }
            if (GORS.Instance.Date_typ.Equals(3))
            {


                vv.Culture = CultureInfo.GetCultureInfo("ar-SA");

                if (GORS.Instance.Date_enable)
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    vv.CustomFormat = GORS.Instance.Date_fromate;
                }
                else
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                }
            }
            if (GORS.Instance.Date_typ.Equals(4))
            {

                vv.Culture = CultureInfo.GetCultureInfo("ar-SA");



                if (GORS.Instance.Date_enable)
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    vv.CustomFormat = GORS.Instance.Date_fromate;
                }
                else
                {
                    vv.Format = System.Windows.Forms.DateTimePickerFormat.Long;
                }
            }


        }

        public void SaveDate() {

            var rr = JsonConvert.SerializeObject(f.Current); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
            
            //  MessageBox.Show(rr);
            var xx = JsonConvert.DeserializeObject(rr, c);
            bindingSource1.Add(xx);
        }
        public void updateDate()
        {

            var rr = JsonConvert.SerializeObject(f.Current); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                                                             //  MessageBox.Show(rr);
            var xx = JsonConvert.DeserializeObject(rr, c);
            bindingSource1.Add(xx);
        }
        private void radButton7_Click(object sender, EventArgs e)
        {
           
            if (radButton7.Tag.ToString().Equals("0"))
            {
              
                eventData.Invoke(this.radDataEntry1.CurrentObject, evntype.save);
            }
            else {
                eventData.Invoke(this.radDataEntry1.CurrentObject, evntype.update);
            }

           
           
           // radWaitingBar1.StartWaiting();
        }
        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var fff = radGridView1.CurrentRow.DataBoundItem;
                var rr = JsonConvert.SerializeObject(fff); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                                                           //  MessageBox.Show(rr);
                var xx = JsonConvert.DeserializeObject(rr, c);
                f.DataSource = xx;
                radButton7.Image = Properties.Resources.Text_Edit_icon;
                radButton7.Tag = "1";
                radButton7.Enabled = true;
            }
            catch (Exception ex)
            {


            }
        }
        private void commandBarButton1_Click(object sender, EventArgs e)
        {

            try
            {
                //  var fff = radGridView1.CurrentRow.DataBoundItem;
                // var rr = "[]";// JsonConvert.SerializeObject(fff); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                //  MessageBox.Show(rr);

                //   var rr = JsonConvert.SerializeObject(e.Row.DataBoundItem); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";


                var rr = JsonConvert.SerializeObject(allist().ElementAt(0)); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                                                           //  MessageBox.Show(rr);
                var xx = JsonConvert.DeserializeObject(rr, c);
                f.DataSource = xx;//  MessageBox.Show(rr);
                                  //var xx = JsonConvert.DeserializeObject(rr, ui);
               
                radButton7.Image = Properties.Resources.floppy_save_icon__1_;
                radButton7.Enabled = true;
                radButton7.Tag = "0";
                //  f.DataSource = xx;
            }
            catch (Exception ex)
            {


            }

            // bindingSource1.ne
            /* var rr = JsonConvert.SerializeObject(f.Current); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                                                              //  MessageBox.Show(rr);
             var xx = JsonConvert.DeserializeObject(rr, c);
             bindingSource1.Add(xx);*/
            //  MessageBox.Show(JsonConvert.SerializeObject(bindingSource1.Current));

            // this.bindingSource1.Remove(this.bindingSource1.Current);
        }

        private fromDesignData dataDesign;
        public void refre(fromDesignData v) {
            DataDesign = v;
            var gg = JsonConvert.DeserializeObject<List<data>>(JsonConvert.SerializeObject(DataDesign.FormDesign));
            radDataEntry1.ColumnCount = DataDesign.Rowcount;
            listt = gg;
            SetupControlss(true);
           
        }
        private string datexam()
        {

            string rr = "[{\"show\":true,\"DisName\":\"الصف بببببببالاسم\",\"FieldName\":\"mynamev\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo hello\",\"MaskText\":\"0\"}],\"Checknull\":true},{\"show\":true,\"DisName\":\"الصف ggggggggggggggggggggالاسم\",\"FieldName\":\"id\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":true},{\"show\":true,\"DisName\":\"الاسم\",\"FieldName\":\"mail\",\"TypeName\":\"bool\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاسم\",\"FieldName\":\"mailrrr\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo gggggg hello\",\"MaskText\":\"d\",\"MaskType\":\"Numeric\"}],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاhhhhhhسم\",\"FieldName\":\"maildd\",\"TypeName\":\"enu\",\"Enumvalue\":[{\"name\":\"bbbbb\",\"id\":1},{\"name\":\"bbbppppbb\",\"id\":2},{\"name\":\"bbbioooobb\",\"id\":3},{\"name\":\"bbbnmmmmmbb\",\"id\":4}],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"uuuuuu\",\"FieldName\":\"date\",\"TypeName\":\"date\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false}]";

            return rr;
        }
        private void SetupControlss(bool a)
        {
           

            // vx.Add(dmdd);
            dynamic uii = MyTypeBuilder.CompileResultType(allist());//.getclass(vx);
            dynamic ui = Activator.CreateInstance(uii);
            dynamic uib = Activator.CreateInstance(uii);         
            //  g.Add(a12);
            var s = Activator.CreateInstance(uii);
            c = MyTypeBuilder.CompileResultType(allist());
            Type ddxc = typeof(List<>);
            Type lis = ddxc.MakeGenericType(c);
            //  var ggf = new List<c>();        
            var rr = "[]";//"[{\"id\":99,\"mail\":true,\"mailrrr\":\""+u+ "\",\"maildd\":1},{\"id\":959,\"mail\":true,\"mailrrr\":\"" + u + "\",\"maildd\":2}]";//"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
            var xx = JsonConvert.DeserializeObject(rr, lis);

         //   MessageBox.Show(JsonConvert.SerializeObject(xx));
            var xxx = JsonConvert.DeserializeObject(rr, lis);
            //this.radDataEntry1.ItemDefaultSize = new Size(150, 30);
           // this.radDataEntry1.ColumnCount = 2;
            this.radDataEntry1.FlowDirection = FlowDirection.LeftToRight;

         
                f.DataSource = xxx;
            
                bindingSource1.DataSource = xx;//JToken.Parse(ggg);
            

            // = false;
            //   bindingSource1.AddingNew
            this.radDataEntry1.DataSource = f;//this.bindingSource1;
         

        }
     public Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        Telerik.WinControls.UI.RadValidationRule radValidationRule1;

        public string SetData
        {
            get
            {
                return setData;
            }

            set
            {
                setData = value;
              /*  var gg = JsonConvert.DeserializeObject<List<data>>(value);
                listt = gg;
                SetupControlss(true);*/

            }
        }

        public fromDesignData DataDesign
        {
            get
            {
                return dataDesign;
            }

            set
            {
                dataDesign = value;
            }
        }

        public void inslisprovid() {

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
           // this.radValidationProvider1.SetValidationRule(this.namee, radValidationRule1);
        }
        private void radButton5_Click(object sender, EventArgs e)
        {

            if (eventData != null)
            {
                eventData.Invoke(this.radDataEntry1.CurrentObject, evntype.refresh);
            }
        }



        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
