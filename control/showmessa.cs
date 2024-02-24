using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace winToWeb.control
{
  public  class showmessa
    {


        public void getmessage() {



        }
    }

    public class customalrtDalog_alert_daloge
    {
        // LightVisualElement lve;
        // private   RadChat radchat11;
        // private  RadTitleBar radTitleBar1 = new RadTitleBar();



        public void messge_aler(string thimname, int typ, int screennumber, string messagecontent, string messageTitle)
        {


            if (GORS.Instance.A_alert)
            {

                RadDesktopAlert ccc = new RadDesktopAlert();

                ccc.ThemeName = thimname;
                ccc.ShowOptionsButton = true;
                ccc.ShowCloseButton = true;
                ccc.ScreenPosition = AlertScreenPosition.BottomRight;
                ccc.PopupAnimation = false;
                ccc.AutoCloseDelay = 5;
                ccc.CanMove = true;
                ccc.AutoClose = true;
                ccc.CaptionText = messageTitle;

                if (typ == 1)
                {
                    ccc.ContentImage = Properties.Resources.Information_32x32;

                    ccc.Popup.AlertElement.CaptionElement.CaptionGrip.BackColor = Color.Green;
                    ccc.Popup.AlertElement.BorderColor = Color.Green;
                    //   ccc.PlaySound.SoundToPlay.
                    try
                    {
                        if (GORS.Instance.seting_sys.Playsond)
                        {

                            System.Media.SoundPlayer d = new System.Media.SoundPlayer(Properties.Resources.success_48018);
                            d.Play();
                        }
                    }
                    catch (Exception exx) {
                        try
                        {
                            if (GORS.Instance.A_sound)
                            {
                                System.Media.SoundPlayer d = new System.Media.SoundPlayer(Properties.Resources.success_48018);
                                d.Play();

                            }
                        }
                        catch (Exception ex) {

                        }
                    }
                    // ccc.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.ForeColor = Color.Red;

                }
                if (typ == 2)
                {
                    ccc.ContentImage = Properties.Resources.Delete_32x32;
                    // ccc.Popup.AlertElement.CaptionElement.TextAndButtonsElement.TextElement.ForeColor = Color.Red;
                    ccc.Popup.AlertElement.CaptionElement.CaptionGrip.BackColor = Color.Red;
                    ccc.Popup.AlertElement.BorderColor = Color.Red;
                    try { 
                    if (GORS.Instance.seting_sys.Playsond)
                    {

                        System.Media.SoundPlayer d = new System.Media.SoundPlayer(Properties.Resources.error_2_36058);
                        d.Play();
                    }

                    }
                    catch (Exception exx)
                    {
                        try
                        {
                            if (GORS.Instance.A_sound)
                            {
                                System.Media.SoundPlayer d = new System.Media.SoundPlayer(Properties.Resources.error_2_36058);
                                d.Play();

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                ccc.Popup.AlertElement.CaptionElement.CaptionGrip.GradientStyle = GradientStyles.Solid;
                ccc.Popup.AlertElement.ContentElement.Font = new Font("Cairo", 9.25F);
                ccc.Popup.AlertElement.ContentElement.TextImageRelation = TextImageRelation.ImageBeforeText;
                //ccc.Popup.AlertElement.BackColor = Color.Yellow;
                ccc.Popup.AlertElement.GradientStyle = GradientStyles.Solid;

                // ccc.Popup.AlertElement.BorderWidth = 10f;//.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders;






                ccc.ContentText = messagecontent;


                ccc.Show();

            }
            else
            {
                if (typ == 1)
                {
                    RadMessageBox.Show(messagecontent, messageTitle, MessageBoxButtons.OK, RadMessageIcon.Info);

                }
                if (typ == 2)
                {
                    RadMessageBox.Show(messagecontent, messageTitle, MessageBoxButtons.OK, RadMessageIcon.Error);

                }

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
