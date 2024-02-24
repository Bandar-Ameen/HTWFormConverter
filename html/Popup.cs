

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace winToWeb.html
{
    // Token: 0x02000003 RID: 3
    public class Popup : Component
    {
        // Token: 0x14000002 RID: 2
        // (add) Token: 0x06000012 RID: 18 RVA: 0x00007A10 File Offset: 0x00006A10
        // (remove) Token: 0x06000013 RID: 19 RVA: 0x00007A2C File Offset: 0x00006A2C
        public event Popup.DropDownClosedEventHandler DropDownClosed;

        // Token: 0x14000001 RID: 1
        // (add) Token: 0x06000014 RID: 20 RVA: 0x00007A48 File Offset: 0x00006A48
        // (remove) Token: 0x06000015 RID: 21 RVA: 0x000079F4 File Offset: 0x000069F4
        public event Popup.DropDownEventHandler DropDown;

        // Token: 0x06000016 RID: 22 RVA: 0x00007A64 File Offset: 0x00006A64
        public Popup(Control UserControl = null, Control parent = null)
        {
            this.mResizable = false;
            this.mPlacement = Popup.ePlacement.BottomLeft;
            this.mBorderColor = Color.DarkGray;
            this.mAnimationSpeed = 150;
            this.mShowShadow = true;
            this.mParent = parent;
            this.mUserControl = UserControl;
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00007AB4 File Offset: 0x00006AB4
        public void Show()
        {
            Popup.PopupForm.mShowShadow = this.mShowShadow;
            if (this.mForm != null)
            {
                this.mForm.DoClose();
            }
            this.mForm = new Popup.PopupForm(this);
            this.OnDropDown(this.mParent, new EventArgs());
        }
      

        // Token: 0x06000018 RID: 24 RVA: 0x00007AF4 File Offset: 0x00006AF4
        protected virtual void OnDropDown(object Sender, EventArgs e)
        {
            if (this.DropDown != null)
            {
                this.DropDown(RuntimeHelpers.GetObjectValue(Sender), e);
            }
        }
     
        // Token: 0x06000019 RID: 25 RVA: 0x00007B10 File Offset: 0x00006B10
        protected virtual void OnDropDownClosed(object Sender, EventArgs e)
        {
            if (this.DropDownClosed != null)
            {
                this.DropDownClosed(RuntimeHelpers.GetObjectValue(Sender), e);
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600001A RID: 26 RVA: 0x00007B2C File Offset: 0x00006B2C
        // (set) Token: 0x0600001B RID: 27 RVA: 0x00007B40 File Offset: 0x00006B40
        [DefaultValue(false)]
        public bool Resizable
        {
            get
            {
                return this.mResizable;
            }
            set
            {
                this.mResizable = value;
            }
        }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x0600001C RID: 28 RVA: 0x00007B4C File Offset: 0x00006B4C
        // (set) Token: 0x0600001D RID: 29 RVA: 0x00007B60 File Offset: 0x00006B60
        [Browsable(false)]
        public Control UserControl
        {
            get
            {
                return this.mUserControl;
            }
            set
            {
                this.mUserControl = value;
            }
        }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x0600001E RID: 30 RVA: 0x00007B6C File Offset: 0x00006B6C
        // (set) Token: 0x0600001F RID: 31 RVA: 0x00007B80 File Offset: 0x00006B80
        [Browsable(false)]
        public Control Parent
        {
            get
            {
                return this.mParent;
            }
            set
            {
                this.mParent = value;
            }
        }
        [Browsable(false)]
        public RadMenuItem Parentt
        {
            get
            {
                return this.mParentt;
            }
            set
            {
                this.mParentt = value;
            }
        }
        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000020 RID: 32 RVA: 0x00007B8C File Offset: 0x00006B8C
        // (set) Token: 0x06000021 RID: 33 RVA: 0x00007BA0 File Offset: 0x00006BA0
        [DefaultValue(typeof(Popup.ePlacement), "BottomLeft")]
        public Popup.ePlacement HorizontalPlacement
        {
            get
            {
                return this.mPlacement;
            }
            set
            {
                this.mPlacement = value;
            }
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000022 RID: 34 RVA: 0x00007BAC File Offset: 0x00006BAC
        // (set) Token: 0x06000023 RID: 35 RVA: 0x00007BC0 File Offset: 0x00006BC0
        [DefaultValue(typeof(Color), "DarkGray")]
        public Color BorderColor
        {
            get
            {
                return this.mBorderColor;
            }
            set
            {
                this.mBorderColor = value;
            }
        }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000024 RID: 36 RVA: 0x00007BCC File Offset: 0x00006BCC
        // (set) Token: 0x06000025 RID: 37 RVA: 0x00007BE0 File Offset: 0x00006BE0
        [DefaultValue(true)]
        public bool ShowShadow
        {
            get
            {
                return this.mShowShadow;
            }
            set
            {
                this.mShowShadow = value;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000026 RID: 38 RVA: 0x00007BEC File Offset: 0x00006BEC
        // (set) Token: 0x06000027 RID: 39 RVA: 0x00007C00 File Offset: 0x00006C00
        [DefaultValue(150)]
        public int AnimationSpeed
        {
            get
            {
                return this.mAnimationSpeed;
            }
            set
            {
                this.mAnimationSpeed = value;
            }
        }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000029 RID: 41 RVA: 0x00007C28 File Offset: 0x00006C28
        // (set) Token: 0x06000028 RID: 40 RVA: 0x00007C0C File Offset: 0x00006C0C
        internal virtual PictureBox CornerPicture
        {
            get
            {
                return this._CornerPicture;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._CornerPicture != null)
                {
                }
                this._CornerPicture = value;
                if (this._CornerPicture != null)
                {
                }
            }
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00007C3C File Offset: 0x00006C3C
        private void InitializeComponent()
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Popup));
            this.CornerPicture = new PictureBox();
            this.CornerPicture.Image = (Image)resourceManager.GetObject("CornerPicture.Image");
            Control cornerPicture = this.CornerPicture;
            Point location = new Point(17, 17);
            cornerPicture.Location = location;
            this.CornerPicture.Name = "CornerPicture";
            this.CornerPicture.TabIndex = 0;
            this.CornerPicture.TabStop = false;
        }

        // Token: 0x04000007 RID: 7
        [AccessedThroughProperty("CornerPicture")]
        private PictureBox _CornerPicture;

        // Token: 0x04000009 RID: 9
        private bool mResizable;

        // Token: 0x0400000A RID: 10
        private Control mUserControl;

        // Token: 0x0400000B RID: 11
        private Control mParent;
        private RadMenuItem mParentt;
        

        // Token: 0x0400000C RID: 12
        private Popup.ePlacement mPlacement;

        // Token: 0x0400000D RID: 13
        private Color mBorderColor;

        // Token: 0x0400000E RID: 14
        private int mAnimationSpeed;

        // Token: 0x0400000F RID: 15
        private bool mShowShadow;

        // Token: 0x04000010 RID: 16
        private Popup.PopupForm mForm;

        // Token: 0x02000004 RID: 4
        public interface IPopupUserControl
        {
            // Token: 0x0600002B RID: 43
            bool AcceptPopupClosing();
        }

        // Token: 0x02000005 RID: 5
        public enum ePlacement
        {
            // Token: 0x04000012 RID: 18
            Left = 1,
            // Token: 0x04000013 RID: 19
            Right,
            // Token: 0x04000014 RID: 20
            Top = 4,
            // Token: 0x04000015 RID: 21
            Bottom = 8,
            // Token: 0x04000016 RID: 22
            TopLeft = 5,
            // Token: 0x04000017 RID: 23
            TopRight,
            // Token: 0x04000018 RID: 24
            BottomLeft = 9,
            // Token: 0x04000019 RID: 25
            BottomRight
        }

        // Token: 0x02000006 RID: 6
        private class PopupForm : Form
        {
            // Token: 0x14000003 RID: 3
            // (add) Token: 0x0600002D RID: 45 RVA: 0x00007D14 File Offset: 0x00006D14
            // (remove) Token: 0x0600002C RID: 44 RVA: 0x00007CC0 File Offset: 0x00006CC0
            public event Popup.PopupForm.DropDownEventHandler DropDown;

            // Token: 0x14000004 RID: 4
            // (add) Token: 0x0600002E RID: 46 RVA: 0x00007CF8 File Offset: 0x00006CF8
            // (remove) Token: 0x0600002F RID: 47 RVA: 0x00007CDC File Offset: 0x00006CDC
            public event Popup.PopupForm.DropDownClosedEventHandler DropDownClosed;

            // Token: 0x1700000D RID: 13
            // (get) Token: 0x06000030 RID: 48 RVA: 0x00007DE4 File Offset: 0x00006DE4
            // (set) Token: 0x06000031 RID: 49 RVA: 0x00007D30 File Offset: 0x00006D30
            internal virtual Panel mResizingPanel
            {
                get
                {
                    return this._mResizingPanel;
                }
                [MethodImpl(MethodImplOptions.Synchronized)]
                set
                {
                    if (this._mResizingPanel != null)
                    {
                        this._mResizingPanel.MouseDown -= this.mResizingPanel_MouseDown;
                        this._mResizingPanel.MouseMove -= this.mResizingPanel_MouseMove;
                        this._mResizingPanel.MouseUp -= this.mResizingPanel_MouseUp;
                    }
                    this._mResizingPanel = value;
                    if (this._mResizingPanel != null)
                    {
                        this._mResizingPanel.MouseDown += this.mResizingPanel_MouseDown;
                        this._mResizingPanel.MouseMove += this.mResizingPanel_MouseMove;
                        this._mResizingPanel.MouseUp += this.mResizingPanel_MouseUp;
                    }
                }
            }

            // Token: 0x06000032 RID: 50 RVA: 0x00007DF8 File Offset: 0x00006DF8
            public PopupForm(Popup popup)
            {
                this.mPopup = popup;
                this.SetStyle(ControlStyles.ResizeRedraw, true);
                this.FormBorderStyle = FormBorderStyle.None;
                this.StartPosition = FormStartPosition.Manual;
                this.ShowInTaskbar = false;
                this.DockPadding.All = 1;
                this.mControlSize = this.mPopup.mUserControl.Size;
                this.mPopup.mUserControl.Dock = DockStyle.Fill;
                this.Controls.Add(this.mPopup.mUserControl);
                checked
                {
                    this.mWindowSize.Width = this.mControlSize.Width + 2;
                    this.mWindowSize.Height = this.mControlSize.Height + 2;
                    Form form = this.mPopup.mParent.FindForm();
                    if (form != null)
                    {
                        form.AddOwnedForm(this);
                    }
                    if (this.mPopup.mResizable)
                    {
                        this.mResizingPanel = new Panel();
                        if (Popup.PopupForm.mBackgroundImage == null)
                        {
                            ResourceManager resourceManager = new ResourceManager(typeof(Popup));
                            Popup.PopupForm.mBackgroundImage = (Image)resourceManager.GetObject("CornerPicture.Image");
                        }
                        this.mResizingPanel.BackgroundImage = Popup.PopupForm.mBackgroundImage;
                        Panel mResizingPanel = this.mResizingPanel;
                        mResizingPanel.Width = 12;
                        mResizingPanel.Height = 12;
                        mResizingPanel.BackColor = Color.Red;
                        mResizingPanel.Left = this.mPopup.mUserControl.Width - 15;
                        mResizingPanel.Top = this.mPopup.mUserControl.Height - 15;
                        mResizingPanel.Cursor = Cursors.SizeNWSE;
                        mResizingPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        mResizingPanel.Parent = this;
                        mResizingPanel.BringToFront();
                    }
                    this.mPlacement = this.mPopup.mPlacement;
                    this.ReLocate();
                    Rectangle workingArea = Screen.FromControl(this.mPopup.mParent).WorkingArea;
                    if (this.mNormalPos.X + this.Width > workingArea.Right)
                    {
                        if ((this.mPlacement & Popup.ePlacement.Right) != (Popup.ePlacement)0)
                        {
                            this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-3)) | Popup.ePlacement.Left);
                        }
                    }
                    else if (this.mNormalPos.X < workingArea.Left && (this.mPlacement & Popup.ePlacement.Left) != (Popup.ePlacement)0)
                    {
                        this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-2)) | Popup.ePlacement.Right);
                    }
                    if (this.mNormalPos.Y + this.Height > workingArea.Bottom)
                    {
                        if ((this.mPlacement & Popup.ePlacement.Bottom) != (Popup.ePlacement)0)
                        {
                            this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-9)) | Popup.ePlacement.Top);
                        }
                    }
                    else if (this.mNormalPos.Y < workingArea.Top && (this.mPlacement & Popup.ePlacement.Top) != (Popup.ePlacement)0)
                    {
                        this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-5)) | Popup.ePlacement.Bottom);
                    }
                    if (this.mPlacement != this.mPopup.mPlacement)
                    {
                        this.ReLocate();
                    }
                    if (this.mNormalPos.X + this.mWindowSize.Width > workingArea.Right)
                    {
                        this.mNormalPos.X = workingArea.Right - this.mWindowSize.Width;
                    }
                    else if (this.mNormalPos.X < workingArea.Left)
                    {
                        this.mNormalPos.X = workingArea.Left;
                    }
                    if (this.mNormalPos.Y + this.mWindowSize.Height > workingArea.Bottom)
                    {
                        this.mNormalPos.Y = workingArea.Bottom - this.mWindowSize.Height;
                    }
                    else if (this.mNormalPos.Y < workingArea.Top)
                    {
                        this.mNormalPos.Y = workingArea.Top;
                    }
                    this.mProgress = 0.0;
                    if (this.mPopup.mAnimationSpeed > 0)
                    {
                        this.mTimer = new Timer();
                        this.mTimer.Interval = 40;
                        this.mTimerStarted = DateTime.Now;
                        this.mTimer.Tick += this.Showing;
                        this.mTimer.Start();
                        this.Showing(null, null);
                    }
                    else
                    {
                        this.SetFinalLocation();
                    }
                    this.Show();
                    this.mPopup.OnDropDown(this.mPopup.mParent, new EventArgs());
                }
            }

            public PopupForm(Popup popup,bool f)
            {
                this.mPopup = popup;
                this.SetStyle(ControlStyles.ResizeRedraw, true);
                this.FormBorderStyle = FormBorderStyle.None;
                this.StartPosition = FormStartPosition.Manual;
                this.ShowInTaskbar = false;
                this.DockPadding.All = 1;
                this.mControlSize = this.mPopup.mUserControl.Size;
                this.mPopup.mUserControl.Dock = DockStyle.Fill;
                this.Controls.Add(this.mPopup.mUserControl);
                checked
                {
                    this.mWindowSize.Width = this.mControlSize.Width + 2;
                    this.mWindowSize.Height = this.mControlSize.Height + 2;
                    Form form = this.mPopup.mParentt.OwnerControl.FindForm();
                    if (form != null)
                    {
                        form.AddOwnedForm(this);
                    }
                    if (this.mPopup.mResizable)
                    {
                        this.mResizingPanel = new Panel();
                        if (Popup.PopupForm.mBackgroundImage == null)
                        {
                            ResourceManager resourceManager = new ResourceManager(typeof(Popup));
                            Popup.PopupForm.mBackgroundImage = (Image)resourceManager.GetObject("CornerPicture.Image");
                        }
                        this.mResizingPanel.BackgroundImage = Popup.PopupForm.mBackgroundImage;
                        Panel mResizingPanel = this.mResizingPanel;
                        mResizingPanel.Width = 12;
                        mResizingPanel.Height = 12;
                        mResizingPanel.BackColor = Color.Red;
                        mResizingPanel.Left = this.mPopup.mUserControl.Width - 15;
                        mResizingPanel.Top = this.mPopup.mUserControl.Height - 15;
                        mResizingPanel.Cursor = Cursors.SizeNWSE;
                        mResizingPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        mResizingPanel.Parent = this;
                        mResizingPanel.BringToFront();
                    }
                    this.mPlacement = this.mPopup.mPlacement;
                    this.ReLocate();
                    Rectangle workingArea = Screen.FromControl(this.mPopup.mParentt.ElementTree.Control).WorkingArea;
                    if (this.mNormalPos.X + this.Width > workingArea.Right)
                    {
                        if ((this.mPlacement & Popup.ePlacement.Right) != (Popup.ePlacement)0)
                        {
                            this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-3)) | Popup.ePlacement.Left);
                        }
                    }
                    else if (this.mNormalPos.X < workingArea.Left && (this.mPlacement & Popup.ePlacement.Left) != (Popup.ePlacement)0)
                    {
                        this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-2)) | Popup.ePlacement.Right);
                    }
                    if (this.mNormalPos.Y + this.Height > workingArea.Bottom)
                    {
                        if ((this.mPlacement & Popup.ePlacement.Bottom) != (Popup.ePlacement)0)
                        {
                            this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-9)) | Popup.ePlacement.Top);
                        }
                    }
                    else if (this.mNormalPos.Y < workingArea.Top && (this.mPlacement & Popup.ePlacement.Top) != (Popup.ePlacement)0)
                    {
                        this.mPlacement = ((this.mPlacement & (Popup.ePlacement)(-5)) | Popup.ePlacement.Bottom);
                    }
                    if (this.mPlacement != this.mPopup.mPlacement)
                    {
                        this.ReLocate();
                    }
                    if (this.mNormalPos.X + this.mWindowSize.Width > workingArea.Right)
                    {
                        this.mNormalPos.X = workingArea.Right - this.mWindowSize.Width;
                    }
                    else if (this.mNormalPos.X < workingArea.Left)
                    {
                        this.mNormalPos.X = workingArea.Left;
                    }
                    if (this.mNormalPos.Y + this.mWindowSize.Height > workingArea.Bottom)
                    {
                        this.mNormalPos.Y = workingArea.Bottom - this.mWindowSize.Height;
                    }
                    else if (this.mNormalPos.Y < workingArea.Top)
                    {
                        this.mNormalPos.Y = workingArea.Top;
                    }
                    this.mProgress = 0.0;
                    if (this.mPopup.mAnimationSpeed > 0)
                    {
                        this.mTimer = new Timer();
                        this.mTimer.Interval = 40;
                        this.mTimerStarted = DateTime.Now;
                        this.mTimer.Tick += this.Showing;
                        this.mTimer.Start();
                        this.Showing(null, null);
                    }
                    else
                    {
                        this.SetFinalLocation();
                    }
                    this.Show();
                    this.mPopup.OnDropDown(this.mPopup.mParent, new EventArgs());
                }
            }

            // Token: 0x06000033 RID: 51 RVA: 0x0000820C File Offset: 0x0000720C
            public static bool DropShadowSupported()
            {
                OperatingSystem osversion = Environment.OSVersion;
                return osversion.Platform == PlatformID.Win32NT & osversion.Version.CompareTo(new Version(5, 1, 0, 0)) >= 0;
            }

            // Token: 0x1700000E RID: 14
            // (get) Token: 0x06000034 RID: 52 RVA: 0x00008244 File Offset: 0x00007244
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams createParams = base.CreateParams;
                    if (Popup.PopupForm.mShowShadow && Popup.PopupForm.DropShadowSupported())
                    {
                        createParams.ClassStyle |= 131072;
                    }
                    return createParams;
                }
            }

            // Token: 0x06000035 RID: 53 RVA: 0x0000827C File Offset: 0x0000727C
            protected override void Dispose(bool disposing)
            {
                if (disposing && this.mTimer != null)
                {
                    this.mTimer.Dispose();
                }
                base.Dispose(disposing);
            }

            // Token: 0x06000036 RID: 54 RVA: 0x0000829C File Offset: 0x0000729C
            private void ReLocate()
            {
                int width = this.mWindowSize.Width;
                int height = this.mWindowSize.Height;
                this.mNormalPos = this.mPopup.mParent.PointToScreen(default(Point));
                checked
                {
                    switch (this.mPlacement)
                    {
                        case Popup.ePlacement.Left:
                        case Popup.ePlacement.Right:
                            this.mNormalPos.Y = this.mNormalPos.Y + (this.mPopup.mParent.Height - height) / 2;
                            break;
                        case Popup.ePlacement.Top:
                        case Popup.ePlacement.TopLeft:
                        case Popup.ePlacement.TopRight:
                            this.mNormalPos.Y = this.mNormalPos.Y - height;
                            break;
                        case Popup.ePlacement.Bottom:
                        case Popup.ePlacement.BottomLeft:
                        case Popup.ePlacement.BottomRight:
                            this.mNormalPos.Y = this.mNormalPos.Y + this.mPopup.mParent.Height;
                            break;
                    }
                    switch (this.mPlacement)
                    {
                        case Popup.ePlacement.Left:
                            this.mNormalPos.X = this.mNormalPos.X - width;
                            break;
                        case Popup.ePlacement.Right:
                            this.mNormalPos.X = this.mNormalPos.X + this.mPopup.mParent.Width;
                            break;
                        case Popup.ePlacement.Top:
                        case Popup.ePlacement.Bottom:
                            this.mNormalPos.X = this.mNormalPos.X + (this.mPopup.mParent.Width - width) / 2;
                            break;
                        case Popup.ePlacement.TopLeft:
                        case Popup.ePlacement.BottomLeft:
                            this.mNormalPos.X = this.mNormalPos.X + (this.mPopup.mParent.Width - width);
                            break;
                    }
                }
            }

            // Token: 0x06000037 RID: 55 RVA: 0x00008460 File Offset: 0x00007460
            private void Showing(object sender, EventArgs e)
            {
                this.mProgress = DateTime.Now.Subtract(this.mTimerStarted).TotalMilliseconds / (double)this.mPopup.mAnimationSpeed;
                if (this.mProgress >= 1.0)
                {
                    this.mTimer.Stop();
                    this.mTimer.Tick -= this.Showing;
                    this.AnimateForm(1.0);
                }
                else
                {
                    this.AnimateForm(this.mProgress);
                }
            }

            // Token: 0x06000038 RID: 56 RVA: 0x000084EC File Offset: 0x000074EC
            protected override void OnDeactivate(EventArgs e)
            {
                base.OnDeactivate(e);
                if (!this.mClosing)
                {
                    if (this.mPopup.mUserControl is Popup.IPopupUserControl)
                    {
                        this.mClosing = ((Popup.IPopupUserControl)this.mPopup.mUserControl).AcceptPopupClosing();
                    }
                    else
                    {
                        this.mClosing = true;
                    }
                    if (this.mClosing)
                    {
                        this.DoClose();
                    }
                }
            }

            // Token: 0x06000039 RID: 57 RVA: 0x0000854C File Offset: 0x0000754C
            protected override void OnPaintBackground(PaintEventArgs e)
            {
                checked
                {
                    e.Graphics.DrawRectangle(new Pen(this.mPopup.mBorderColor), 0, 0, this.Width - 1, this.Height - 1);
                }
            }

            // Token: 0x0600003A RID: 58 RVA: 0x0000857C File Offset: 0x0000757C
            private void SetFinalLocation()
            {
                this.mProgress = 1.0;
                this.AnimateForm(1.0);
                this.Invalidate();
            }

            // Token: 0x0600003B RID: 59 RVA: 0x000085A4 File Offset: 0x000075A4
            private void AnimateForm(double Progress)
            {
                if (Progress <= 0.1)
                {
                    Progress = 0.1;
                }
                double num=0;
                double num2=0;
                switch (this.mPlacement)
                {
                    case Popup.ePlacement.Left:
                    case Popup.ePlacement.Right:
                        num = 0.0;
                        num2 = 1.0;
                        break;
                    case Popup.ePlacement.Top:
                    case Popup.ePlacement.TopLeft:
                    case Popup.ePlacement.TopRight:
                        num = 1.0 - Progress;
                        num2 = Progress;
                        break;
                    case Popup.ePlacement.Bottom:
                    case Popup.ePlacement.BottomLeft:
                    case Popup.ePlacement.BottomRight:
                        num = 0.0;
                        num2 = Progress;
                        break;
                }
                double num3=0;
                double num4=0;
                switch (this.mPlacement)
                {
                    case Popup.ePlacement.Left:
                    case Popup.ePlacement.TopLeft:
                    case Popup.ePlacement.BottomLeft:
                        num3 = 1.0 - Progress;
                        num4 = Progress;
                        break;
                    case Popup.ePlacement.Right:
                    case Popup.ePlacement.TopRight:
                    case Popup.ePlacement.BottomRight:
                        num3 = 0.0;
                        num4 = Progress;
                        break;
                    case Popup.ePlacement.Top:
                    case Popup.ePlacement.Bottom:
                        num3 = 0.0;
                        num4 = 1.0;
                        break;
                }
                checked
                {
                    this.mCurrentBounds.X = this.mNormalPos.X + (int)Math.Round(unchecked(num3 * (double)this.mControlSize.Width));
                    this.mCurrentBounds.Y = this.mNormalPos.Y + (int)Math.Round(unchecked(num * (double)this.mControlSize.Height));
                    this.mCurrentBounds.Width = (int)Math.Round(unchecked(num4 * (double)this.mControlSize.Width)) + 2;
                    this.mCurrentBounds.Height = (int)Math.Round(unchecked(num2 * (double)this.mControlSize.Height)) + 2;
                    this.Bounds = this.mCurrentBounds;
                }
            }

            // Token: 0x0600003C RID: 60 RVA: 0x00008740 File Offset: 0x00007740
            internal void DoClose()
            {
                Popup popup = this.mPopup;
                try
                {
                    popup.OnDropDownClosed(popup.mParent, new EventArgs());
                }
                finally
                {
                    popup.mUserControl.Parent = null;
                    popup.mUserControl.Size = this.mControlSize;
                    popup.mForm = null;
                    Form form = this.mPopup.mParent.FindForm();
                    if (form != null)
                    {
                        form.RemoveOwnedForm(this);
                    }
                    form.Focus();
                    this.Close();
                }
                popup = null;
            }

            // Token: 0x0600003D RID: 61 RVA: 0x000087C8 File Offset: 0x000077C8
            private void mResizingPanel_MouseUp(object sender, MouseEventArgs e)
            {
                this.mResizing = false;
                this.Invalidate();
            }

            // Token: 0x0600003E RID: 62 RVA: 0x000087D8 File Offset: 0x000077D8
            private void mResizingPanel_MouseMove(object sender, MouseEventArgs e)
            {
                checked
                {
                    if (this.mResizing)
                    {
                        Size size = this.Size;
                        size.Width += e.X - this.mx;
                        size.Height += e.Y - this.my;
                        this.Size = size;
                    }
                }
            }

            // Token: 0x0600003F RID: 63 RVA: 0x00008834 File Offset: 0x00007834
            private void mResizingPanel_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.mResizing = true;
                    this.mx = e.X;
                    this.my = e.Y;
                }
            }

            // Token: 0x06000040 RID: 64 RVA: 0x00008864 File Offset: 0x00007864
            protected override void OnLoad(EventArgs e)
            {
                base.OnLoad(e);
                this.Bounds = this.mCurrentBounds;
            }

            // Token: 0x0400001C RID: 28
            [AccessedThroughProperty("mResizingPanel")]
            private Panel _mResizingPanel;

            // Token: 0x0400001D RID: 29
            public static bool mShowShadow;

            // Token: 0x0400001E RID: 30
            private bool mClosing;

            // Token: 0x0400001F RID: 31
            private const int BORDER_MARGIN = 1;

            // Token: 0x04000020 RID: 32
            private Timer mTimer;

            // Token: 0x04000021 RID: 33
            private Size mControlSize;

            // Token: 0x04000022 RID: 34
            private Size mWindowSize;

            // Token: 0x04000023 RID: 35
            private Point mNormalPos;

            // Token: 0x04000024 RID: 36
            private Rectangle mCurrentBounds;

            // Token: 0x04000025 RID: 37
            private Popup mPopup;

            // Token: 0x04000026 RID: 38
            private Popup.ePlacement mPlacement;

            // Token: 0x04000027 RID: 39
            private DateTime mTimerStarted;

            // Token: 0x04000028 RID: 40
            private double mProgress;

            // Token: 0x04000029 RID: 41
            private int mx;

            // Token: 0x0400002A RID: 42
            private int my;

            // Token: 0x0400002B RID: 43
            private bool mResizing;

            // Token: 0x0400002C RID: 44
            private const int CS_DROPSHADOW = 131072;

            // Token: 0x0400002D RID: 45
            private static Image mBackgroundImage;

            // Token: 0x02000007 RID: 7
            // (Invoke) Token: 0x06000044 RID: 68
            public delegate void DropDownEventHandler(object Sender, EventArgs e);

            // Token: 0x02000008 RID: 8
            // (Invoke) Token: 0x06000048 RID: 72
            public delegate void DropDownClosedEventHandler(object Sender, EventArgs e);
        }

        // Token: 0x02000009 RID: 9
        // (Invoke) Token: 0x0600004C RID: 76
        public delegate void DropDownEventHandler(object Sender, EventArgs e);

        // Token: 0x0200000A RID: 10
        // (Invoke) Token: 0x06000050 RID: 80
        public delegate void DropDownClosedEventHandler(object Sender, EventArgs e);
    }
}

