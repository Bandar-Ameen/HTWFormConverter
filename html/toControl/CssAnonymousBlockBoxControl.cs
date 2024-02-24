using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Html;
using System.Text;
using System.Text.RegularExpressions;

namespace winToWeb.html.toControl
{


    /// <summary>
    /// Represents an anonymous block box
    /// </summary>
    /// <remarks>
    /// To learn more about anonymous block boxes visit CSS spec:
    /// http://www.w3.org/TR/CSS21/visuren.html#anonymous-block-level
    /// </remarks>
    public class CssAnonymousBlockBoxControl
        : CssBoxControl
    {
        public CssAnonymousBlockBoxControl(CssBoxControl parent)
            : base(parent,parent.HtmlTag)
        {
            Display = CssConstants.Block;
        }

        public CssAnonymousBlockBoxControl(CssBoxControl parent, CssBoxControl insertBefore)
            : this(parent)
        {
            int index = parent.Boxes.IndexOf(insertBefore);

            if (index < 0)
            {
                throw new Exception("insertBefore box doesn't exist on parent");
            }
            parent.Boxes.Remove(this);
            parent.Boxes.Insert(index, this);
        }
    }

    /// <summary>
    /// Represents an AnonymousBlockBox which contains only blank spaces
    /// </summary>
    public class CssAnonymousSpaceBlockBoxControl
        : CssAnonymousBlockBoxControl
    {
        public CssAnonymousSpaceBlockBoxControl(CssBoxControl parent)
            : base(parent)
        { Display = CssConstants.None; }

        public CssAnonymousSpaceBlockBoxControl(CssBoxControl parent, CssBoxControl insertBefore)
            : base(parent, insertBefore)
        { Display = CssConstants.None; }
    }
}
