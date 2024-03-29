﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Html;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace winToWeb.html.toControl
{
   
    

    public class InitialContainerControl
      : CssBoxControl
    {
        #region Fields
        private Dictionary<string, Dictionary<string, CssBlock>> _media_blocks;
        private string _documentSource;
        private bool _avoidGeometryAntialias;
        private Control mainControl;
        private SizeF _maxSize;
        private PointF _scrollOffset;
        private Dictionary<CssBoxControl, RectangleF> _linkRegions;
        private bool _avoidTextAntialias;
        #endregion

        #region Ctor

        public InitialContainerControl()
        {
        _initialContainer = this;
            _media_blocks = new Dictionary<string, Dictionary<string, CssBlock>>();
            _linkRegions = new Dictionary<CssBoxControl, RectangleF>();
            MediaBlocks.Add("all", new Dictionary<string, CssBlock>());

            Display = CssConstants.Block;

            FeedStyleSheet(CssDefaults.DefaultStyleSheet);
        }

        public InitialContainerControl(string documentSource,Control man)
            : this()
        {
            this.mainControl = man;
            _documentSource = documentSource;
           
        }

        public void startparse() {
            ParseDocument();
            CascadeStyles(this);
            BlockCorrection(this);

        }
        #endregion

        #region Props

        /// <summary>
        /// Gets the link regions of the container
        /// </summary>
        internal Dictionary<CssBoxControl, RectangleF> LinkRegions
        {
            get { return _linkRegions; }
        }


        /// <summary>
        /// Gets the blocks of style defined on this structure, separated by media type.
        /// General blocks are defined under the "all" Key.
        /// </summary>
        /// <remarks>
        /// Normal use of this dictionary will be something like:
        /// 
        /// MediaBlocks["print"]["strong"].Properties
        /// 
        /// - Or -
        /// 
        /// MediaBlocks["all"]["strong"].Properties
        /// </remarks>
        public Dictionary<string, Dictionary<string, CssBlock>> MediaBlocks
        {
            get { return _media_blocks; }
        }

        /// <summary>
        /// Gets the document's source
        /// </summary>
        public string DocumentSource
        {
            get { return _documentSource; }
        }

        /// <summary>
        /// Gets or sets a value indicating if antialiasing should be avoided 
        /// for geometry like backgrounds and borders
        /// </summary>
        public bool AvoidGeometryAntialias
        {
            get { return _avoidGeometryAntialias; }
            set { _avoidGeometryAntialias = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating if antialiasing should be avoided
        /// for text rendering
        /// </summary>
        public bool AvoidTextAntialias
        {
            get { return _avoidTextAntialias; }
            set { _avoidTextAntialias = value; }
        }

        /// <summary>
        /// Gets or sets the maximum size of the container
        /// </summary>
        public SizeF MaximumSize
        {
            get { return _maxSize; }
            set { _maxSize = value; }
        }

        /// <summary>
        /// Gets or sets the scroll offset of the document
        /// </summary>
        public PointF ScrollOffset
        {
            get { return _scrollOffset; }
            set { _scrollOffset = value; }
        }


        #endregion

        #region Methods

        /// <summary>
        /// Feeds the source of the stylesheet
        /// </summary>
        /// <param name="stylesheet"></param>
        public void FeedStyleSheet(string stylesheet)
        {
            if (string.IsNullOrEmpty(stylesheet)) return;

            //Convert everything to lower-case
            stylesheet = stylesheet.ToLower();

            #region Remove comments

            for (MatchCollection comments = Parser.Match(Parser.CssComments, stylesheet); comments.Count > 0; comments = Parser.Match(Parser.CssComments, stylesheet))
            {
                stylesheet = stylesheet.Remove(comments[0].Index, comments[0].Length);
            }

            #endregion

            #region Extract @media blocks

            //MatchCollection atrules = Parser.Match(Parser.CssAtRules, stylesheet);

            for (MatchCollection atrules = Parser.Match(Parser.CssAtRules, stylesheet); atrules.Count > 0; atrules = Parser.Match(Parser.CssAtRules, stylesheet))
            {
                Match match = atrules[0];

                //Extract whole at-rule
                string atrule = match.Value;

                //Remove rule from sheet
                stylesheet = stylesheet.Remove(match.Index, match.Length);

                //Just processs @media rules
                if (!atrule.StartsWith("@media")) continue;

                //Extract specified media types
                MatchCollection types = Parser.Match(Parser.CssMediaTypes, atrule);

                if (types.Count == 1)
                {
                    string line = types[0].Value;

                    if (line.StartsWith("@media") && line.EndsWith("{"))
                    {
                        //Get specified media types in the at-rule
                        string[] media = line.Substring(6, line.Length - 7).Split(' ');

                        //Scan media types
                        for (int i = 0; i < media.Length; i++)
                        {
                            if (string.IsNullOrEmpty(media[i].Trim())) continue;

                            //Get blocks inside the at-rule
                            MatchCollection insideBlocks = Parser.Match(Parser.CssBlocks, atrule);

                            //Scan blocks and feed them to the style sheet
                            foreach (Match insideBlock in insideBlocks)
                            {
                                FeedStyleBlock(media[i].Trim(), insideBlock.Value);
                            }
                        }
                    }
                }
            }

            #endregion

            #region Extract general blocks
            //This blocks are added under the "all" keyword

            MatchCollection blocks = Parser.Match(Parser.CssBlocks, stylesheet);

            foreach (Match match in blocks)
            {
                FeedStyleBlock("all", match.Value);
            }

            #endregion
        }

        /// <summary>
        /// Feeds the style with a block about the specific media.
        /// When no media is specified, "all" will be used
        /// </summary>
        /// <param name="media"></param>
        /// <param name="block"></param>
        private void FeedStyleBlock(string media, string block)
        {
            if (string.IsNullOrEmpty(media)) media = "all";

            int bracketIndex = block.IndexOf("{");
            string blockSource = block.Substring(bracketIndex).Replace("{", string.Empty).Replace("}", string.Empty);

            if (bracketIndex < 0) return;

            ///TODO: Only supporting definitions like:
            /// h1, h2, h3 {...
            ///Support needed for definitions like:
            ///* {...
            ///h1 h2 {...
            ///h1 > h2 {...
            ///h1:before {...
            ///h1:hover {...
            string[] classes = block.Substring(0, bracketIndex).Split(',');

            for (int i = 0; i < classes.Length; i++)
            {
                string className = classes[i].Trim(); if (string.IsNullOrEmpty(className)) continue;

                CssBlock newblock = new CssBlock(blockSource,0);

                //Create media blocks if necessary
                if (!MediaBlocks.ContainsKey(media)) MediaBlocks.Add(media, new Dictionary<string, CssBlock>());

                if (!MediaBlocks[media].ContainsKey(className))
                {
                    //Create block
                    MediaBlocks[media].Add(className, newblock);
                }
                else
                {
                    //Merge newblock and oldblock's properties

                    CssBlock oldblock = MediaBlocks[media][className];

                    foreach (string property in newblock.Properties.Keys)
                    {
                        if (oldblock.Properties.ContainsKey(property))
                        {
                            oldblock.Properties[property] = newblock.Properties[property];
                        }
                        else
                        {
                            oldblock.Properties.Add(property, newblock.Properties[property]);
                        }
                    }

                    oldblock.UpdatePropertyValuesControl();
                }
            }
        }

        /// <summary>
        /// Parses the document
        /// </summary>
        private void ParseDocument()
        {
        InitialContainerControl root = this;
            MatchCollection tags = Parser.Match(Parser.HtmlTag, DocumentSource);
            CssBoxControl curBox = root;
            curBox.ControlView = this.mainControl;
            int lastEnd = -1;

            foreach (Match tagmatch in tags)
            {
                string text = tagmatch.Index > 0 ? DocumentSource.Substring(lastEnd + 1, tagmatch.Index - lastEnd - 1) : string.Empty;

                if (!string.IsNullOrEmpty(text.Trim()))
                {
                    CssAnonymousBoxControl abox = new CssAnonymousBoxControl(curBox);
                    abox.Text = text;
                }
                else if (text != null && text.Length > 0)
                {
                    CssAnonymousSpaceBoxControl sbox = new CssAnonymousSpaceBoxControl(curBox);
                    sbox.Text = text;
                }

                HtmlTag tag = new HtmlTag(tagmatch.Value);
               
                if (tag.IsClosing)
                {
                   // curBox= new CssBoxControl(curBox, tag);
                    curBox = FindParent(tag.TagName, curBox);
                    //MessageBox.Show(tag.TagName);
                    
                 

                }
                else if (tag.IsSingle)
                {
                    CssBoxControl foo = new CssBoxControl(curBox, tag);
                }
                else
                {
                    curBox = new CssBoxControl(curBox, tag);
                }
              

                lastEnd = tagmatch.Index + tagmatch.Length - 1;
            }

            string finaltext = DocumentSource.Substring((lastEnd > 0 ? lastEnd + 1 : 0), DocumentSource.Length - lastEnd - 1 + (lastEnd == 0 ? 1 : 0));

            if (!string.IsNullOrEmpty(finaltext))
            {
                CssAnonymousBoxControl abox = new CssAnonymousBoxControl(curBox);
                
                abox.Text = finaltext;
            }
            

        }

        /// <summary>
        /// Recursively searches for the parent with the specified HTML Tag name
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="b"></param>
        private CssBoxControl FindParent(string tagName, CssBoxControl b)
        {

            if (b == null)
            {
                MessageBox.Show("dddd");
                return InitialContainerControl;
            }
            else if (b.HtmlTag != null && b.HtmlTag.TagName.Equals(tagName, StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                   
                    Control bk;
                if (b.HtmlTag.TagName.Equals(HtmlConstants.Controlname.ToLower()))
                {
                        MessageBox.Show(b.HtmlTag.TagName);
                        bk = new Button();
                    bk.Text = "fffffffff";
                    bk.Location = new Point(0, 0);
                    bk.Size = new System.Drawing.Size(50, 50);
                    //السطر 313
                }
                else {

                    bk = new Label();
                    bk.Text = "fffffffff";
                    bk.Location = new Point(0, 0);
                    bk.Size = new System.Drawing.Size(50, 50);
                }
              
                
                    b.ParentBox.ControlView.Controls.Add(bk);
                }
                catch (Exception ex) {

                }
                return b.ParentBox == null ? InitialContainerControl : b.ParentBox;
            }
            else
            {
                return FindParent(tagName, b.ParentBox);
            }

           /* if (b == null)
            {
                var t = InitialContainerControl;
                if (t.ControlView == null)
                {

                    t.ControlView = this.mainControl;
                }

                return t;
            }
            else if (b.HtmlTag != null && b.HtmlTag.TagName.Equals(tagName, StringComparison.CurrentCultureIgnoreCase))
            {
                var t= b.ParentBox == null ? InitialContainerControl : b.ParentBox;
                try
                {
                    if (t.ControlView == null)
                    {

                        t.ControlView = this.mainControl;
                    }
                    if (b.HtmlTag.TagName.Equals(HtmlConstants.Controlname))
                    {


                        Button bk = new Button();
                        bk.Text = "fffffffff";
                        bk.Location = new Point(0, 0);
                        bk.Size = new System.Drawing.Size(50, 50);
                        //السطر 313
                        t.ControlView.Controls.Add(bk);
                    }
                    else
                    {
                        Label bb = new Label();
                        bb.Text = "fffffffffddddddddddd";
                        bb.Location = new Point(0, 0);
                        bb.Size = new System.Drawing.Size(50, 50);

                     t.ControlView.Controls.Add(bb);

                    }
                }
                catch (Exception ex) {

                }
              //  mainControl.Controls.Add(curBox.ControlView);
                return t;
            }
            else
            {
                return FindParent(tagName, b.ParentBox);
            }*/
        }

        /// <summary>
        /// Applies style to all boxes in the tree
        /// </summary>
        private void CascadeStyles(CssBoxControl startBox)
        {
            bool someBlock = false;

            foreach (CssBoxControl b in startBox.Boxes)
            {
                b.InheritStyle();

                if (b.HtmlTag != null)
                {
                    //Check if tag name matches with a defined class
                    if (MediaBlocks["all"].ContainsKey(b.HtmlTag.TagName))
                    {
                        MediaBlocks["all"][b.HtmlTag.TagName].AssignTo(b);
                    }

                    //Check if class="" attribute matches with a defined style
                    if (b.HtmlTag.HasAttribute("class") &&
                        MediaBlocks["all"].ContainsKey("." + b.HtmlTag.Attributes["class"]))
                    {
                        MediaBlocks["all"]["." + b.HtmlTag.Attributes["class"]].AssignTo(b);
                    }

                    b.HtmlTag.TranslateAttributes(b);

                    //Check for the style="" attribute
                    if (b.HtmlTag.HasAttribute("style"))
                    {
                        CssBlock block = new CssBlock(b.HtmlTag.Attributes["style"],0);
                        block.AssignTo(b);
                    }

                    //Check for the <style> tag
                    if (b.HtmlTag.TagName.Equals("style", StringComparison.CurrentCultureIgnoreCase) &&
                        b.Boxes.Count == 1)
                    {
                        FeedStyleSheet(b.Boxes[0].Text);
                    }

                    //Check for the <link rel=stylesheet> tag
                    if (b.HtmlTag.TagName.Equals("link", StringComparison.CurrentCultureIgnoreCase) &&
                        b.GetAttribute("rel", string.Empty).Equals("stylesheet", StringComparison.CurrentCultureIgnoreCase))
                    {
                        FeedStyleSheet(CssValue.GetStyleSheet(b.GetAttribute("href", string.Empty)));
                    }
                }

                CascadeStyles(b);
            }

            if (someBlock)
            {
                foreach (CssBoxControl box in startBox.Boxes)
                {
                    box.Display = CssConstants.Block;
                }
            }

        }

        /// <summary>
        /// Makes block boxes be among only block boxes. 
        /// Inline boxes should live in a pool of Inline boxes only.
        /// </summary>
        /// <param name="startBox"></param>
        private void BlockCorrection(CssBoxControl startBox)
        {
            bool inlinesonly = startBox.ContainsInlinesOnly();

            if (!inlinesonly)
            {

                List<List<CssBoxControl>> inlinegroups = BlockCorrection_GetInlineGroups(startBox);

                foreach (List<CssBoxControl> group in inlinegroups)
                {
                    if (group.Count == 0) continue;

                    if (group.Count == 1 && group[0] is CssAnonymousSpaceBoxControl)
                    {
                        CssAnonymousSpaceBlockBoxControl sbox = new CssAnonymousSpaceBlockBoxControl(startBox, group[0]);

                        group[0].ParentBox = sbox;
                    }
                    else
                    {
                        CssAnonymousBlockBoxControl newbox = new CssAnonymousBlockBoxControl(startBox, group[0]);

                        foreach (CssBoxControl inline in group)
                        {
                            inline.ParentBox = newbox;
                        }
                    }
                }
            }

            foreach (CssBoxControl b in startBox.Boxes)
            {
                BlockCorrection(b);
            }
        }

        /// <summary>
        /// Scans the boxes (non-deeply) of the box, and returns groups of contiguous inline boxes.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private List<List<CssBoxControl>> BlockCorrection_GetInlineGroups(CssBoxControl box)
        {
            List<List<CssBoxControl>> result = new List<List<CssBoxControl>>();
            List<CssBoxControl> current = null;

            //Scan boxes
            for (int i = 0; i < box.Boxes.Count; i++)
            {
                CssBoxControl b = box.Boxes[i];

                //If inline, add it to the current group
                if (b.Display == CssConstants.Inline)
                {
                    if (current == null)
                    {
                        current = new List<CssBoxControl>();
                        result.Add(current);
                    }
                    current.Add(b);
                }
                else
                {
                    current = null;
                }
            }


            //If last list contains nothing, erase it
            if (result.Count > 0 && result[result.Count - 1].Count == 0)
            {
                result.RemoveAt(result.Count - 1);
            }

            return result;
        }

        public override void MeasureBounds(Control g)
        {
            LinkRegions.Clear();

            base.MeasureBounds(g);
        }

        #endregion
    }
}
