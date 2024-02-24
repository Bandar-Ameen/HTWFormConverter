using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using winToWeb.protouse;

namespace winToWeb.protouse
{
  public abstract  class ViewTypeParser<V> where V :Control
    {
        public ViewTypeParser<V> parent;
        public abstract string getType();
        public  abstract  Control getTypeControl();
        /**
         * @return
         */

        public abstract string getParentType();

    }
}
