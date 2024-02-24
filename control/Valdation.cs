using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.control
{
  public  class Valdation
    {

 
        public async Task<bool> CheckValdation(RadValidationProvider bbn)
        {


            bool vvm = true;
     
            //  var c = allprovide(bbn, contro);
            foreach (var dd in bbn.AssociatedControls)
            {
                
               
                    var vv = bbn.Validate(dd);

                    if (vv == false)
                    {
                        vvm = false;
                        break;



                    }
                

            }
            return vvm;



        }



        public void changefont(Control v) {

            var km = v as RadForm;
            if (km != null)
            {
                if (km.Modal)
                {
                    cachengefont(v);
                }
            }
            var cont = FindControls<RadMultiColumnComboBox>(v);
            foreach (var f in cont) {
                f.EditorControl.TableElement.Font = f.Font;
            }
          //  settootltex(v);

            var contt = FindControls<RadDateTimePicker>(v);
            var contnt = FindControls<RadGridView>(v);
            foreach (var f in cont)
            {
                f.EditorControl.TableElement.Font = f.Font;
            }

            foreach (var ff in contt)
            {
                adddatetime(ff);
            }

            foreach (var ddf in contnt)
            {

                adddatetimes(ddf);
            }
        }

        public void adddatetimes(RadGridView vv)
        {

            foreach (var ssdf in vv.Columns)
            {

                var ss = ssdf as GridViewDateTimeColumn;
                if (ss != null)
                {


                    if (GORS.Instance.Date_typ.Equals(1))
                    {



                        ss.FormatInfo = CultureInfo.GetCultureInfo("ar-AE");



                        ss.FormatString = "{0:" + GORS.Instance.Date_fromate + "}";
                    }
                    if (GORS.Instance.Date_typ.Equals(2))
                    {

                        ss.FormatInfo = CultureInfo.GetCultureInfo("ar-AE");



                        ss.FormatString = "{0:" + GORS.Instance.Date_fromate + "}";

                    }
                    if (GORS.Instance.Date_typ.Equals(3))
                    {


                        ss.FormatInfo = CultureInfo.GetCultureInfo("ar-SA");

                        ss.FormatString = "{0:" + GORS.Instance.Date_fromate + "}";
                    }
                    if (GORS.Instance.Date_typ.Equals(4))
                    {

                        ss.FormatInfo = CultureInfo.GetCultureInfo("ar-SA");




                        ss.FormatString = "{0:" + GORS.Instance.Date_fromate + "}";

                    }
                }

            }

        }

        public void cachengefont(Control v)
        {

            try
            {
                if (GORS.Instance.seting_sys.usecustomstyle)
                {

                    var radmulti = FindControls<RadMultiColumnComboBox>(v);
                    foreach (var f in radmulti)
                    {
                        f.Font = GORS.Instance.seting_sys.font_multicolumn;
                    }

                    var Datetim = FindControls<RadDateTimePicker>(v);
                    foreach (var f in Datetim)
                    {
                        f.Font = GORS.Instance.seting_sys.font_Datetime;
                    }

                    var gridview = FindControls<RadGridView>(v);

                    foreach (var f in gridview)
                    {
                        f.Font = GORS.Instance.seting_sys.font_gridview;
                    }

                    var label = FindControls<RadLabel>(v);

                    foreach (var f in label)
                    {
                        f.Font = GORS.Instance.seting_sys.font_label;
                    }

                    var edtbox = FindControls<RadMaskedEditBox>(v);

                    foreach (var f in edtbox)
                    {
                        f.Font = GORS.Instance.seting_sys.font_TextBox;
                    }

                    var button = FindControls<RadButton>(v);

                    foreach (var f in button)
                    {
                        f.Font = GORS.Instance.seting_sys.font_button;
                    }


                    var buttoncheck = FindControls<RadCheckBox>(v);

                    foreach (var f in buttoncheck)
                    {
                        f.Font = GORS.Instance.seting_sys.font_chebox;
                    }


                    var pageview = FindControls<RadPageView>(v);

                    foreach (var f in pageview)
                    {
                        /* if (GORS.Instance.seting_sys.ChangDisp != controla.change_manpage_vieww.defualt)
                         {

                             int i = (int)GORS.Instance.seting_sys.ChangDisp;
                             //  f.ViewMode =(int) Telerik.WinControls.UI.PageViewMode.Outlook;
                             f.ViewMode = (Telerik.WinControls.UI.PageViewMode)i - 1;  //Telerik.WinControls.UI.PageViewMode.Strip;

                         }
                         else
                         {
                             if (GORS.Instance.seting_sys.Dispaymodea != controla.NavigationViewDisplayModesaa.defualt)
                             {
                                 int i = (int)GORS.Instance.seting_sys.Dispaymodea;
                                 RadPageViewStripElement dd = f.ViewElement as RadPageViewStripElement;
                                 dd.ItemFitMode = (Telerik.WinControls.UI.StripViewItemFitMode)i - 1;
                             }
                         }*/
                        f.Font = GORS.Instance.seting_sys.font_pageview;
                    }
                  
                }
            }
            catch
            {

            }
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
        private List<dynamic> FindControls<dynamic>(Control control) where dynamic : Control
        {
            var controls = control.Controls.Cast<Control>();



            return controls.SelectMany(ctrl => FindControls<dynamic>(ctrl))
                           .Concat(controls)
                           .Where(c => c.GetType() == typeof(dynamic))
                           .Cast<dynamic>()
                           .ToList();





            //ff.ViewMode
        }

        public void settootltex(Control v)
        {

            var cont = FindControls<RadButton>(v);
          
            foreach (var f in cont)
            {
                if (f.Tag.ToString() != null)
                {
                    f.ButtonElement.ToolTipText = f.Tag.ToString();
                    f.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(this.radButton1_ToolTipTextNeeded);
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
    }
}
