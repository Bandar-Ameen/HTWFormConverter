using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Html;
using System.Drawing;

namespace winToWeb.html.toControl
{


    public class HtmlPanelControl
      : GroupBox
    {
        #region Fields
        protected InitialContainerControl _htmlContainer;

        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new HtmlPanel
        /// </summary>
      
        #endregion

        #region Properties

    

       // [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
 

        /// <summary>
        /// Gets the Initial HtmlContainer of this HtmlPanel
        /// </summary>
        public InitialContainerControl HtmlContainer
        {
            get { return _htmlContainer; }
        }

     

        #endregion

        #region Methods

        /// <summary>
        /// Creates the fragment of HTML that is rendered
        /// </summary>
       public HtmlPanelControl(string t)
        {
           
            MeasureBounds();
          
            _htmlContainer = new InitialContainerControl(t,this);
            Invalidate();
            loadcontrol();
        }

        /// <summary>
        /// Measures the bounds of the container
        /// </summary>
        public virtual void MeasureBounds()
        {
           /* _htmlContainer.SetBounds(this is HtmlLabel ? new Rectangle(0, 0, 10, 10) : ClientRectangle);

            using (Graphics g = CreateGraphics())
            {
                _htmlContainer.MeasureBounds(g);
            }*/

           // AutoScrollMinSize = Size.Round(_htmlContainer.MaximumSize);
        }




        public void loadcontrol() {

            _htmlContainer.Paint(this);
        }
   

        #endregion
    }
}
