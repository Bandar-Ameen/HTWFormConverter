using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;


namespace winToWeb
{
  


    public class customalrtDalog : RadDesktopAlert
    {
        // LightVisualElement lve;
        // private   RadChat radchat11;
        // private  RadTitleBar radTitleBar1 = new RadTitleBar();
        private UserControl radGroupBox1;
        private Point startPoint = new Point(0, 0);
        private bool drag = false;
        private int startx;
        private int starty;
        private Point iOld = new Point();
        private Point iclick = new Point();
      
        public customalrtDalog(UserControl radGroupBox11)
        {

            this.radGroupBox1 = radGroupBox11;
       
         
            this.ScreenPosition = AlertScreenPosition.BottomLeft;
            this.ShowPinButton = true;
            this.ShowOptionsButton = true;
            this.Popup.Opacity = 1;
            this.PopupAnimation = false;
            this.FixedSize = new Size(100, 100);
            gettitlbar();
            this.Popup.Controls.Add(this.radGroupBox1);



        }
       
        public void gettitlbar()
        {

            foreach (Control zzk in radGroupBox1.Controls)
            {
                var xxb = zzk as RadGroupBox;
                if (xxb != null)
                {
                    foreach (Control zz in xxb.Controls)
                    {
                        var xx = zz as RadTitleBar;
                        if (xx != null)
                        {

                            xx.Close += ccl;
                            xx.TitleBarElement.MaximizeButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                            xx.TitleBarElement.MinimizeButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                            xx.AllowDrop = true;
                            xx.MouseDown += new MouseEventHandler(Title_MouseDown);
                            xx.MouseUp += new MouseEventHandler(Title_MouseUp);
                            xx.MouseMove += new MouseEventHandler(Title_MouseMove);
                        }
                    }
                }
            }
        }
        private void ccl(object sender, EventArgs e)
        {
            
            this.Popup.ClosePopup(RadPopupCloseReason.CloseCalled);
            // this.Popup.Location = new Point(20,90);

        }

        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            //  this.startPoint = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                Point p = convertv(e.X, e.Y);
                iOld.X = p.X;
                iOld.Y = p.Y;
                iclick.X = e.X;
                iclick.Y = e.Y;

                startx = e.X;
                starty = e.Y;
                this.drag = true;

            }
        }

        private Point convertv(int x, int y)
        {

            Point p = new Point(x, y);
            //  this.Popup.Location = p;
            return p;


        }
        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point();
                p1.X = e.X + this.Popup.Left;
                p1.Y = e.Y + this.Popup.Top;
                this.Popup.Left = p1.X - iclick.X;
                this.Popup.Top = p1.Y - iclick.Y;
                /* Point p2 = PointToScreen(p1);
                 Point p3 = new Point(p2.X - this.startPoint.X,
                                      p2.Y - this.startPoint.Y);
                 this.Popup.Location = p1;*/
            }
        }

        private void Title_MouseMovee(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                int l = this.Popup.Left + e.X - startx;
                int t = this.Popup.Top + e.Y - starty;
                int w = this.Popup.Width;
                int h = this.Popup.Height;
                l = (l < 0) ? 0 : ((l + w > this.Popup.ClientRectangle.Width) ?
                  this.Popup.ClientRectangle.Width - w : l);
                t = (t < 0) ? 0 : ((t + h > this.Popup.ClientRectangle.Height) ?
                this.Popup.ClientRectangle.Height - h : t);
                this.Popup.Left = l;
                this.Popup.Top = t;
            }
        }
        //protected override DesktopAlertPopup CreatePopup()
        //{
        //    /* AlertWindowContentElement ss = new AlertWindowContentElement();
        //     ss.Children.
        //     this.Popup.AlertElement.ContentElement
        //         */

        //    lve = new LightVisualElement();
        //    lve.BackColor = Color.Red;
        //    lve.DrawFill = true;
        //    lve.StretchHorizontally = false;
        //    lve.StretchVertically = false;
        //    lve.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
        //    lve.Size = new Size(100,100);
        //    this.Popup.RootElement.Children.Add(lve);


        //    return base.CreatePopup();
        //}
    }
}
