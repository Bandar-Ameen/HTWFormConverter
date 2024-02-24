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
    public class ProteusBuilder
    
    {
        private Dictionary<string, ViewTypeParser<Control>> parsers = new Dictionary<string, protouse.ViewTypeParser<Control>>();
        private Dictionary<string, Function> functions = new Dictionary<string, Function>();


        public ProteusBuilder register(ViewTypeParser<Control> parser)
        {
        
            //string parentType = parser.getParentType();
           /* if (parentType != null && !parsers.TryGetValue().containsKey(parentType))
            {
                throw new IllegalStateException(parentType + " is not a registered type parser");
            }*/
            parsers.Add(parser.getType(), parser);
            return this;
        }
    
        private myreg DEFAULT_MODULE;
        public ProteusBuilder()
        {
            DEFAULT_MODULE = new myreg();
            DEFAULT_MODULE.registerWith(this);
        }
        public ProteusBuilder register(Function function)
        {
            functions.Add(function.getName(), function);
            return this;
        }
        public ProteusBuilder register( Module module)
        {
            module.registerWith(this);
            return this;
        }
        public ViewTypeParser<Control> get(string type)
        {
            ViewTypeParser<Control> f;
            parsers.TryGetValue(type, out f);
            return f;
        }
        public Proteus build()
        {
            Dictionary<string, Types> types = new Dictionary<string, Types>();

            int x = 0;
            foreach (var d in parsers) {

                Types k = new Types(x,d.Key,d.Value);
                x = x + 1;
                types.Add(d.Key,k);
            }
            /* for (Map.Entry<String, ViewTypeParser> entry : parsers.entrySet())
            {
                types.put(entry.getKey(), prepare(entry.getValue()));
            }*/
            return new Proteus(types, functions);
        }
        public interface Module
        {

            /**
             * @param builder
             */
            void registerWith(ProteusBuilder builder);

        }
    
        public class myreg : Module
        {
            public void registerWith(ProteusBuilder builder)
            {
                builder.register(new functin1());
                //var uy = ((Control)new RadButton);
                var ui = new protouse.ButtonParser<Control>();//<RadButton>();
            
                builder.register(ui);
               
            }
        }
    }
}
