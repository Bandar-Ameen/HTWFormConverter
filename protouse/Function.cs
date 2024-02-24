using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace winToWeb.protouse
{
    public abstract  class Function
    {


        
    

    public abstract object call(RadForm context, object data, int dataIndex, params object[] y);// throw Exception;

        public abstract string getName();
    }

    public sealed class functin1 : Function
    {
        public override object call(RadForm context, object data, int dataIndex, params object[] y)
        {
            return "f";
        }

        public override string getName()
        {
            throw new NotImplementedException();
        }
    }

    public class FunctionManager
    {

       
  private Dictionary<String, Function> functions;

        public FunctionManager(Dictionary<String, Function> functions)
        {
            this.functions = functions;
        }

       
  public Function get( String name)
        {
            Function function;
              functions.TryGetValue(name,out function);
            if (function == null)
            {
                function = new functin1();
            }
            return function;
        }
    }
}
