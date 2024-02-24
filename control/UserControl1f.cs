using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms.Plugins.Shared;

namespace winToWeb.control
{
    public partial class UserControl1f : UserControlWithCallBack
    {
        public UserControl1f()
        {
            InitializeComponent();
        }

        private void UserControl1f_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
          
           
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
