using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;

namespace winToWeb.som
{
    public partial class formains : RadForm
    {
        public formains()
        {
            InitializeComponent();
        }
        private static formains fromm;
        public static formains getins() {
            if (fromm == null) {

                fromm = new formains();
            }
            return fromm;
        }
        private void formains_Load(object sender, EventArgs e)
        {

        }



  
        private void radButton1_Click(object sender, EventArgs e)
        {
            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
            var t = new customefinal(alldat,this.ThemeName);
            t.Dock = DockStyle.Fill;
          //  f.FormClosing += testForm_FormClosing;
            //t.showcon();
            this.Controls.Add(t);



          
          //  GORS.Instance.OpenForm.ReceveFroms(f, anotherData);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            formains ff = new formains();
            ff.Show();
            
        }
    }
}
