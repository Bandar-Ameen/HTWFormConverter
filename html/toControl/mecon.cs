using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winToWeb.html.toControl
{
    public partial class mecon : Form
    {
        HtmlPanelControl k;
        public mecon()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k =new HtmlPanelControl(radTextBox1.Text);
         var   _htmlContainer = new InitialContainerControl(radTextBox1.Text, groupBox1);
            _htmlContainer.startparse();
            //k.Dock = DockStyle.Fill;
            /// k.HtmlContainer.startparse();
            // groupBox1.Controls.Add(k);

        }
    }
}
