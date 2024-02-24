using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace winToWeb.protouse
{
    public class ProteusButton : RadButton, ProteusView
    {
        public Control getAsView()
        {
            throw new NotImplementedException();
        }

        public Manager getViewManager()
        {
            throw new NotImplementedException();
        }

        public void setViewManager(Manager manager)
        {
            throw new NotImplementedException();
        }
    }
}
