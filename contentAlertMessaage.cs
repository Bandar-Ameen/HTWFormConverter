using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winToWeb
{
    public partial class contentAlertMessaage : UserControl
    {
        public contentAlertMessaage()
        {
            InitializeComponent();
            
        }

        public void settexhtml(string t)
        {

            this.radcon1.Tex = t;
        }

        private void radTitleBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
