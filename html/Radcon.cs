using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Html;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace winToWeb.html
{
    



    public class Radcon
      : RadGroupBox
    {
        #region Fields

        private InitialContainer container;

        #endregion

        #region Ctor



        #endregion

      
        public override string ThemeClassName
        {
            get
            {
                return typeof(RadGroupBox).FullName;
            }


        }


        #region Fields
        protected InitialContainer _htmlContainer;

        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new HtmlPanel
        /// </summary>
        public Radcon()
        {
            _htmlContainer = new InitialContainer();

            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.Selectable, true);

            DoubleBuffered = true;

          
       

            HtmlRenderer.AddReference(Assembly.GetCallingAssembly());
        }

        #endregion

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override bool AutoScroll
        {
            get
            {
                return base.AutoScroll;
            }
            set
            {
                base.AutoScroll = value;
            }
        }

        /// <summary>
        /// Gets the Initial HtmlContainer of this HtmlPanel
        /// </summary>
        public InitialContainer HtmlContainer
        {
            get { return _htmlContainer; }
        }

     
        private string tex;

        /// <summary>
        /// Gets or sets the text of this panel
        /// </summary>
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Localizable(true), Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]

        public string Tex
        {
            get
            {
                return tex;
            }

            set
            {
                tex = value;
                CreateFragment();
                MeasureBounds();
                Invalidate();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates the fragment of HTML that is rendered
        /// </summary>
        protected virtual void CreateFragment()
        {
            _htmlContainer = new InitialContainer(Tex);
        }

        /// <summary>
        /// Measures the bounds of the container
        /// </summary>
        public virtual void MeasureBounds()
        {
            _htmlContainer.SetBounds(this is HtmlLabel ? new Rectangle(0, 0, 10, 10) : ClientRectangle);

            using (Graphics g = CreateGraphics())
            {
                _htmlContainer.MeasureBounds(g);
            }

            AutoScrollMinSize = Size.Round(_htmlContainer.MaximumSize);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Focus();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            MeasureBounds();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
         if (!(this is Radcon)) e.Graphics.Clear(SystemColors.Window);
            //  if (!(this is  HtmlLabel)) e.Graphics.Clear(SystemColors.Window);


            _htmlContainer.ScrollOffset = AutoScrollPosition;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            _htmlContainer.Paint(e.Graphics);

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            foreach (CssBox box in _htmlContainer.LinkRegions.Keys)
            {
                RectangleF rect = _htmlContainer.LinkRegions[box];
                if (Rectangle.Round(rect).Contains(e.X, e.Y))
                {
                    Cursor = Cursors.Hand;
                    return;
                }
            }

            Cursor = Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            foreach (CssBox box in _htmlContainer.LinkRegions.Keys)
            {
                RectangleF rect = _htmlContainer.LinkRegions[box];
                if (Rectangle.Round(rect).Contains(e.X, e.Y))
                {
                    CssValue.GoLink(box.GetAttribute("href", string.Empty));
                    return;
                }
            }

        }

        #endregion
    }
}
