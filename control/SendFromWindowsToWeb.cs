using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winToWeb.control
{
  public  interface SendFromWindowsToWeb
    {

        void SendToJavaScript(string FunctionName,object[] paramter);
    }
}
