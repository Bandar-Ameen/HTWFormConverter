using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winToWeb.protouse
{
    public abstract class Value
    {

        /**
         * Returns a deep copy of this value. Immutable elements
         * like primitives and nulls are not copied.
         */
        public abstract Value copy();


    }
}
