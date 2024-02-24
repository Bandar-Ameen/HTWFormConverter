using ERP.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.control
{


    public partial class Form1 : RadForm
    {
        private Type c;
        private fromDesignData designdat;
        public Form1(fromDesignData designdatt)
        {
            this.designdat = designdatt;
            InitializeComponent();
          //  radDataEntry1.AutoSize = true;

      




            //this.radDataEntry1.ItemDefaultSize = new Size(100,30);
            //new Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500);
        }

        public Form1()
        {
           
            InitializeComponent();
            //  radDataEntry1.AutoSize = true;






            //this.radDataEntry1.ItemDefaultSize = new Size(100,30);
            //new Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500);
        }


        public dynamic ddx(List<data> vx, string name, int id, bool n)
        {
            dynamic uii = MyTypeBuilder.CompileResultType(vx);//.getclass(vx);
            dynamic ui = Activator.CreateInstance(uii);
            ui.myname = name;
            ui.id = id;
            //  ui.maildd = DateTime.Now;
            ui.mail = n;
            return ui;
        }
        public dynamic ddx(dynamic ui, string name, int id, bool n)
        {

            ui.myname = name;
            ui.id = id;
            //  ui.maildd = DateTime.Now;
            ui.mail = n;
            return ui;
        }
        private void radDataEntry1_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            /*  if (e.DataMember == "Salary")
              {
                  e.Binding.Parse += new ConvertEventHandler(Binding_Parse);
              }*/
        }

        private void radDataEntry1_ItemInitialized(object sender, ItemInitializedEventArgs e)
        {

            foreach (Control k in e.Panel.Controls) {

                var ff = k as RadMaskedEditBox;

                if (ff != null)
                {
                   // MessageBox.Show("gggggggg");
                    ff.Size = new Size(50,ff.Height);
                    ff.Invalidate();

                }
            }

            /* SizeF scaleFactor = this.radDataEntry1.RootElement.DpiScaleFactor;
             SizeF descaleFactor = new SizeF(1 / scaleFactor.Width, 1 / scaleFactor.Height);

             // e.Panel.Location = new Point(e.Panel.Location.X, e.Panel.Location.Y - TelerikDpiHelper.ScaleInt(35, scaleFactor));
            e.Panel.Size = new Size(e.Panel.Size.Width, TelerikDpiHelper.ScaleInt(100, scaleFactor));
             var w = new RadButton();
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
            
            if (e.Property.Name == "myname")
            {

                RadMaskedEditBox radMaskedEditBox = new RadMaskedEditBox();
                radMaskedEditBox.NullText = "يرجي";
                radMaskedEditBox.MaskedEditBoxElement.StretchVertically = true;
             
                e.Editor = radMaskedEditBox;
                e.Editor.Size = new Size(100,20);
                e.Editor.Invalidate();
            }

            if (e.Property.Name == "Password")
            {
                (e.Editor as RadTextBox).PasswordChar = '*';
            }
        }
    

     

        private void radBindingNavigator1_ContextMenuOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void Binding_Parse(object sender, ConvertEventArgs e)
        {
            /* int salary = int.Parse(e.Value.ToString(), NumberStyles.Currency);
             e.Value = salary;*/
        }

        /*  public override void OnThemeChanged()
          {
              base.OnThemeChanged();

              if (this.IsTouchTheme())
              {
                  Size newItemSize = new Size(460, 32);
                  if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
                  {
                      newItemSize.Height = 36;
                  }

                  this.radDataEntry1.ItemDefaultSize = newItemSize;
                  this.radDataEntry1.Size = TelerikDpiHelper.ScaleSize(new Size(489, 464), this.radDataEntry1.RootElement.DpiScaleFactor);

                  this.SuspendLayout();
                  this.radDataEntry1.DataSource = null;
                  this.radDataEntry1.DataSource = new Person(DateTime.Now, "Iva", "Ivanova", Person.OccupationPositions.SuppliesManager, "(555) 123 456", 1500);
                  this.ResumeLayout();
              }
          }

          private bool IsTouchTheme()
          {
            //  return TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || this.CurrentThemeName == "TelerikMetroTouch";
          }
          */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = this.designdat.FormName;
            GORS.Instance.inforceShowConfirmMessage = true;
            
           entery1.refre(this.designdat);
        }
        private string datexam()
        {

            string rr = "[{\"show\":true,\"DisName\":\"الصف بببببببالاسم\",\"FieldName\":\"mynamev\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo hello\",\"MaskText\":\"0\"}],\"Checknull\":true}]";//,{\"show\":true,\"DisName\":\"الصف ggggggggggggggggggggالاسم\",\"FieldName\":\"id\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":true},{\"show\":true,\"DisName\":\"الاسم\",\"FieldName\":\"mail\",\"TypeName\":\"bool\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاسم\",\"FieldName\":\"mailrrr\",\"TypeName\":\"st\",\"Enumvalue\":[],\"Settings\":[{\"NullText\":\"helllo gggggg hello\",\"MaskText\":\"d\",\"MaskType\":\"Numeric\"}],\"Checknull\":false},{\"show\":true,\"DisName\":\"اjjjلاhhhhhhسم\",\"FieldName\":\"maildd\",\"TypeName\":\"enu\",\"Enumvalue\":[{\"name\":\"bbbbb\",\"id\":1},{\"name\":\"bbbppppbb\",\"id\":2},{\"name\":\"bbbioooobb\",\"id\":3},{\"name\":\"bbbnmmmmmbb\",\"id\":4}],\"Settings\":[],\"Checknull\":false},{\"show\":true,\"DisName\":\"uuuuuu\",\"FieldName\":\"date\",\"TypeName\":\"date\",\"Enumvalue\":[],\"Settings\":[],\"Checknull\":false}]";

            return rr;
        }

        private void addnwwwBing(object sendere, AddingNewEventArgs c)
        {


        }
        private void radBindingNavigator1AddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().Name);
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {

            try
            {
                //  var fff = radGridView1.CurrentRow.DataBoundItem;
               // var rr = "[]";// JsonConvert.SerializeObject(fff); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                              //  MessageBox.Show(rr);

                //   var rr = JsonConvert.SerializeObject(e.Row.DataBoundItem); //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
              
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_AddingNew(object sender, AddingNewEventArgs e)
        {
            var d = sender as BindingSource;
            d.CancelEdit();

            // MessageBox.Show(sender.GetType().Name);
        }

        private void bindingSource1_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void bindingSource1_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void radGridView1_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("column1"))
            {


                /*  var dialog = new ERPDataForm();

                  dialog.DataEntry.DataSource = e.Row.DataBoundItem;

                  if (dialog.ShowDialog() == DialogResult.OK)
                  {


                  }*/
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            // bindingSource1.in
        }

        private void bindingSource1_DataSourceChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("fffffffff");
        }

        private void bindingSource1_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            //  e.ListChangedType==ListChangedType.
            //  MessageBox.Show("fffffffff"+ e.ListChangedType );
        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {

        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
              
              
            }
            catch (Exception ex)
            {


            }
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {

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

        private void radButton3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
          
           //"[{\"myname\":\"hello aa\",\"id\":99,\"mail\":true},{\"myname\":\"hellofffffffuuuu aa\",\"id\":9779,\"mail\":false},{\"myname\":\"helloffffff bb\",\"id\":8899,\"mail\":false}]";
                                                             //  MessageBox.Show(rr);
      
        }

        private void radButton5_Click(object sender, EventArgs e)
        {

           /* foreach (Control k in radDataEntry1.PanelContainer.Controls)
            {

                var ff = k as RadMaskedEditBox;

                if (ff != null)
                {
                    // MessageBox.Show("gggggggg");
                    ff.Size = new Size(50, ff.Height);
                    ff.Invalidate();

                }
            }*/
        }
        Valdation ss = new Valdation();
        private async void entery1_eventData(object Sender, evntype type)
        {



            // ss.changefont(entery1);
            if (type == evntype.refresh)
            {


                RadControlSpyForm f = new RadControlSpyForm();
                f.Show();
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
    }
}
