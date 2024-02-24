using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace winToWeb.protouse
{
    public class Proteus
    {


        public FunctionManager functions;


        private Dictionary<string, Types> types;


        private Dictionary<string, ViewTypeParser<Control>> parsers;

       public Proteus(Dictionary<string, Types> types, Dictionary<string, Function> functions)
        {
            this.types = types;
            this.functions = new FunctionManager(functions);
            this.parsers = map(types);
        }
        private Dictionary<String, ViewTypeParser<Control>> map(Dictionary<String, Types> types)
        {
            Dictionary<String, ViewTypeParser<Control>> parsers = new Dictionary<string, ViewTypeParser<Control>>(types.Count);

            foreach(var e in types) { 
                parsers.Add(e.Key, e.Value.parser);
            }
            return parsers;
        }

    }

    public  class Types
    {

        public int id;
        public string type;
        public ViewTypeParser<Control> parser;

      

           public Types(int id, string type, ViewTypeParser<Control> parser)
        {
            this.id = id;
            this.type = type;
            this.parser = parser;
          
        }

      
    }
}
