using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Plugins.Shared;

namespace winToWeb.control
{
   

    public class tess : IPlugin
    {



        private ControlTemplate controlTemplate;
        private String name = String.Empty;

        //public DataGridViewPlugin()
        //{ }

        public tess(String name)
        {
            this.name = name;
            controlTemplate = new ControlTemplate("Ayuyu1", "hhffyuyuyuff",
                                                    new List<string>() { },
                                                    new UserControl1f());

        }

        public String Name()
        {
            return this.name;
        }

        public ControlTemplate PluginControls()
        {
            return controlTemplate;
        }


    }
}
