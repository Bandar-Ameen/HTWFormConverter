using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using winToWeb.html.toControl;

namespace System.Drawing.Html
{
    public class HtmlTag
    {
        #region Fields

        private string _tagName;
        private bool _isClosing;
        private bool _isStarter;
        private Dictionary<string, string> _attributes;

        #endregion

        #region Ctor

        private HtmlTag()
        {
            _attributes = new Dictionary<string, string>();
        }

        public HtmlTag(string tags)
            : this()
        {
          var  tag = tags.Substring(1, tags.Length - 2);

            int spaceIndex = tag.IndexOf(" ");

            //Extract tag name
            if (spaceIndex < 0)
            {
                _tagName = tag;
            }
            else
            {
                _tagName = tag.Substring(0, spaceIndex);
            }

            //Check if is end tag
            if (_tagName.StartsWith("/"))
            {
                _isClosing = true;
                _tagName = _tagName.Substring(1);
            }
            if (tags.StartsWith("<"))
            {
                _isStarter = true;
             
            }
            _tagName = _tagName.ToLower();

            //Extract attributes
            MatchCollection atts = Parser.Match(Parser.HmlTagAttributes, tag);

            foreach (Match att in atts)
            {
                //Extract attribute and value
                string[] chunks = att.Value.Split('=');

                if (chunks.Length == 1)
                {
                    if(!Attributes.ContainsKey(chunks[0]))
                        Attributes.Add(chunks[0].ToLower(), string.Empty);
                }
                else if (chunks.Length == 2)
                {
                    string attname = chunks[0].Trim();
                    string attvalue = chunks[1].Trim();

                    if (attvalue.StartsWith("\"") && attvalue.EndsWith("\"") && attvalue.Length > 2)
                    {
                        attvalue = attvalue.Substring(1, attvalue.Length - 2);
                    }

                    if (!Attributes.ContainsKey(attname))
                        Attributes.Add(attname, attvalue);
                }
            }
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the dictionary of attributes in the tag
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return _attributes; }
        }


        /// <summary>
        /// Gets the name of this tag
        /// </summary>
        public string TagName
        {
            get { return _tagName; }
        }

        /// <summary>
        /// Gets if the tag is actually a closing tag
        /// </summary>
        public bool IsClosing
        {
            get { return _isClosing; }
        }
        public bool IsStart
        {
            get { return _isStarter; }
        }
        

        /// <summary>
        /// Gets if the tag is single placed; in other words it doesn't need a closing tag; 
        /// e.g. &lt;br&gt;
        /// </summary>
        public bool IsSingle
        {
            get
            {
                return TagName.StartsWith("!")
                    || (new List<string>(
                            new string[]{
                             "area", "base", "basefont", "br", "col",
                             "frame", "hr", "img", "input", "isindex",
                             "link", "meta", "param"
                            }
                        )).Contains(TagName)
                    ;
            }
        }

        internal void TranslateAttributes(CssBox box)
        {
            string t = TagName.ToUpper();

            foreach (string att in Attributes.Keys)
            {
                string value = Attributes[att];
              
                switch (att)
                {
                    case HtmlConstants.align:
                        if (value == HtmlConstants.left || value == HtmlConstants.center || value == HtmlConstants.right || value == HtmlConstants.justify)
                            box.TextAlign = value;
                        else
                            box.VerticalAlign = value;
                        break;
                    case HtmlConstants.background:
                            box.BackgroundImage = value;
                        break;
                    case HtmlConstants.bgcolor:
                        box.BackgroundColor = value;
                        break;
                    case HtmlConstants.border:
                        box.BorderWidth = TranslateLength(value);
                        
                        if (t == HtmlConstants.TABLE)
                        {
                            ApplyTableBorder(box, value);
                        }
                        else
                        {
                            box.BorderStyle = CssConstants.Solid;
                        }
                        break;
                    case HtmlConstants.bordercolor:
                        box.BorderColor = value;
                        break;
                    case HtmlConstants.cellspacing:
                        box.BorderSpacing = TranslateLength(value);
                        break;
                    case HtmlConstants.cellpadding:
                        ApplyTablePadding(box, value);
                        break;
                    case HtmlConstants.color:
                        box.Color = value;
                        break;
                    case HtmlConstants.dir:
                        box.Direction = value;
                        break;
                    case HtmlConstants.face:
                        box.FontFamily = value;
                        break;
                    case HtmlConstants.height:
                        box.Height = TranslateLength(value);
                        break;
                    case HtmlConstants.hspace:
                        box.MarginRight = box.MarginLeft = TranslateLength(value);
                        break;
                    case HtmlConstants.nowrap:
                        box.WhiteSpace = CssConstants.Nowrap;
                        break;
                    case HtmlConstants.size:
                        if (t == HtmlConstants.HR)
                            box.Height = TranslateLength(value);
                        break;
                    case HtmlConstants.valign:
                        box.VerticalAlign = value;
                        break;
                    case HtmlConstants.vspace:
                        box.MarginTop = box.MarginBottom = TranslateLength(value);
                        break;
                    case HtmlConstants.width:
                        box.Width = TranslateLength(value);
                        break;

                }
            }
        }
        internal void TranslateAttributes(CssBoxControl box)
        {
            string t = TagName.ToUpper();

            foreach (string att in Attributes.Keys)
            {
                string value = Attributes[att];

             
                switch (att)
                {
                    case HtmlConstants.align:
                        if (value == HtmlConstants.left || value == HtmlConstants.center || value == HtmlConstants.right || value == HtmlConstants.justify)
                            box.TextAlign = value;
                        else
                            box.VerticalAlign = value;
                        break;
                    case HtmlConstants.background:
                        box.BackgroundImage = value;
                        break;
                    case HtmlConstants.bgcolor:
                        box.BackgroundColor = value;
                        break;
                    case HtmlConstants.border:
                        box.BorderWidth = TranslateLength(value);

                        if (t == HtmlConstants.TABLE)
                        {
                            ApplyTableBorder(box, value);
                        }
                        else
                        {
                            box.BorderStyle = CssConstants.Solid;
                        }
                        break;
                    case HtmlConstants.bordercolor:
                        box.BorderColor = value;
                        break;
                    case HtmlConstants.cellspacing:
                        box.BorderSpacing = TranslateLength(value);
                        break;
                    case HtmlConstants.cellpadding:
                        ApplyTablePadding(box, value);
                        break;
                    case HtmlConstants.color:
                        box.Color = value;
                        break;
                    case HtmlConstants.dir:
                        box.Direction = value;
                        break;
                    case HtmlConstants.face:
                        box.FontFamily = value;
                        break;
                    case HtmlConstants.height:
                        box.Height = TranslateLength(value);
                        break;
                    case HtmlConstants.hspace:
                        box.MarginRight = box.MarginLeft = TranslateLength(value);
                        break;
                    case HtmlConstants.nowrap:
                        box.WhiteSpace = CssConstants.Nowrap;
                        break;
                    case HtmlConstants.size:
                        if (t == HtmlConstants.HR)
                            box.Height = TranslateLength(value);
                        break;
                    case HtmlConstants.valign:
                        box.VerticalAlign = value;
                        break;
                    case HtmlConstants.vspace:
                        box.MarginTop = box.MarginBottom = TranslateLength(value);
                        break;
                    case HtmlConstants.width:
                        box.Width = TranslateLength(value);
                        break;

                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts an HTML length into a Css length
        /// </summary>
        /// <param name="htmlLength"></param>
        /// <returns></returns>
        private string TranslateLength(string htmlLength)
        {
            CssLength len = new CssLength(htmlLength);

            if (len.HasError)
            {
                return htmlLength + "px";
            }

            return htmlLength;
        }

        /// <summary>
        /// Cascades to the TD's the border spacified in the TABLE tag.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="border"></param>
        private void ApplyTableBorder(CssBox table, string border)
        {
            foreach (CssBox box in table.Boxes)
            {
                foreach (CssBox cell in box.Boxes)
                {
                    cell.BorderWidth = TranslateLength(border);
                }
            }
        }
        /// <summary>
        /// Cascades to the TD's the border spacified in the TABLE tag.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="border"></param>
        private void ApplyTableBorder(CssBoxControl table, string border)
        {
            foreach (CssBoxControl box in table.Boxes)
            {
                foreach (CssBoxControl cell in box.Boxes)
                {
                    cell.BorderWidth = TranslateLength(border);
                }
            }
        }
        /// <summary>
        /// Cascades to the TD's the border spacified in the TABLE tag.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="border"></param>
        private void ApplyTablePadding(CssBox table, string padding)
        {
            foreach (CssBox box in table.Boxes)
            {
                foreach (CssBox cell in box.Boxes)
                {
                    cell.Padding = TranslateLength(padding);

                }
            }
        }
        /// <summary>
        /// Cascades to the TD's the border spacified in the TABLE tag.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="border"></param>
        private void ApplyTablePadding(CssBoxControl table, string padding)
        {
            foreach (CssBoxControl box in table.Boxes)
            {
                foreach (CssBoxControl cell in box.Boxes)
                {
                    cell.Padding = TranslateLength(padding);

                }
            }
        }
        /// <summary>
        /// Gets a boolean indicating if the attribute list has the specified attribute
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool HasAttribute(string attribute)
        {
            return Attributes.ContainsKey(attribute);
        }

        public override string ToString()
        {
            return string.Format("<{1}{0}>", TagName, IsClosing ? "/" : string.Empty);
        }

        #endregion
    }
}
