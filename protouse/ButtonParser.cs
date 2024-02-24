using dynFormLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace winToWeb.protouse
{
    public class ButtonParser<T> : ViewTypeParser<T> where T : Control

    {
        public ButtonParser() {
        }
        public override string getParentType()
        {
            throw new NotImplementedException();
        }

        public override string getType()
        {
            throw new NotImplementedException();
        }

        public override Control getTypeControl()
        {
            return new ProteusButton();
        }
    }

   
}
