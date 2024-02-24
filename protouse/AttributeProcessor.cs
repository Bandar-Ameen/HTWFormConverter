using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using winToWeb.protouse;

namespace winToWeb.protouse
{
 public abstract   class AttributeProcessor<V> where V : Control
    {

      
public abstract void handleValue(V view, Value value);

        public abstract void handleResource(V view, object resource);

        public abstract void handleAttributeResource(V view, object attribute);

        public abstract void handleStyleResource(V view, object style);
    }
}
