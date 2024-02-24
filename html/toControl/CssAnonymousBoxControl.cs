using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winToWeb.html.toControl
{
    /// <summary>
    /// Represents an anonymous inline box
    /// </summary>
    /// <remarks>
    /// To learn more about anonymous inline boxes visit:
    /// http://www.w3.org/TR/CSS21/visuren.html#anonymous
    /// </remarks>
    public class CssAnonymousBoxControl
        : CssBoxControl
    {
        #region Ctor

        public CssAnonymousBoxControl(CssBoxControl parentBox)
            : base(parentBox,parentBox.HtmlTag)
        {

        }

        #endregion
    }

    /// <summary>
    /// Represents an anonymous inline box which contains nothing but blank spaces
    /// </summary>
    public class CssAnonymousSpaceBoxControl
        : CssAnonymousBoxControl
    {
        public CssAnonymousSpaceBoxControl(CssBoxControl parentBox)
            : base(parentBox)
        {

        }
    }
}
