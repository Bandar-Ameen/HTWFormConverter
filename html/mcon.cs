
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace winToWeb.html
{
    // Token: 0x0200000B RID: 11
    public class mcon : UserControl, Popup.IPopupUserControl
    {
        // Token: 0x06000051 RID: 81 RVA: 0x0000887C File Offset: 0x0000787C
        public mcon()
        {
            base.Load += this.UserControl1_Load;
            this.InitializeComponent();
        }

        // Token: 0x06000052 RID: 82 RVA: 0x000088A0 File Offset: 0x000078A0
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000054 RID: 84 RVA: 0x000088C0 File Offset: 0x000078C0
        // (set) Token: 0x06000053 RID: 83 RVA: 0x000088D4 File Offset: 0x000078D4
        internal virtual Button Button1
        {
            get
            {
                return this._Button1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button1 != null)
                {
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                }
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000056 RID: 86 RVA: 0x00008944 File Offset: 0x00007944
        // (set) Token: 0x06000055 RID: 85 RVA: 0x000088F0 File Offset: 0x000078F0
        internal virtual Button Button2
        {
            get
            {
                return this._Button2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button2 != null)
                {
                    this._Button2.Click -= this.Button2_Click;
                }
                this._Button2 = value;
                if (this._Button2 != null)
                {
                    this._Button2.Click += this.Button2_Click;
                }
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000057 RID: 87 RVA: 0x00008974 File Offset: 0x00007974
        // (set) Token: 0x06000058 RID: 88 RVA: 0x00008958 File Offset: 0x00007958
        internal virtual RadioButton rbNorth
        {
            get
            {
                return this._rbNorth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._rbNorth != null)
                {
                }
                this._rbNorth = value;
                if (this._rbNorth != null)
                {
                }
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x06000059 RID: 89 RVA: 0x00008988 File Offset: 0x00007988
        // (set) Token: 0x0600005A RID: 90 RVA: 0x0000899C File Offset: 0x0000799C
        internal virtual RadioButton rbWest
        {
            get
            {
                return this._rbWest;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._rbWest != null)
                {
                }
                this._rbWest = value;
                if (this._rbWest != null)
                {
                }
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x0600005B RID: 91 RVA: 0x000089D4 File Offset: 0x000079D4
        // (set) Token: 0x0600005C RID: 92 RVA: 0x000089B8 File Offset: 0x000079B8
        internal virtual RadioButton rbSouth
        {
            get
            {
                return this._rbSouth;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._rbSouth != null)
                {
                }
                this._rbSouth = value;
                if (this._rbSouth != null)
                {
                }
            }
        }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x0600005E RID: 94 RVA: 0x000089E8 File Offset: 0x000079E8
        // (set) Token: 0x0600005D RID: 93 RVA: 0x000089FC File Offset: 0x000079FC
        internal virtual RadioButton rbEast
        {
            get
            {
                return this._rbEast;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._rbEast != null)
                {
                }
                this._rbEast = value;
                if (this._rbEast != null)
                {
                }
            }
        }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x0600005F RID: 95 RVA: 0x00008A18 File Offset: 0x00007A18
        // (set) Token: 0x06000060 RID: 96 RVA: 0x00008A2C File Offset: 0x00007A2C
        internal virtual Label Label1
        {
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label1 != null)
                {
                }
                this._Label1 = value;
                if (this._Label1 != null)
                {
                }
            }
        }

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000061 RID: 97 RVA: 0x00008A48 File Offset: 0x00007A48
        // (set) Token: 0x06000062 RID: 98 RVA: 0x00008A5C File Offset: 0x00007A5C
        internal virtual Label Label2
        {
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label2 != null)
                {
                }
                this._Label2 = value;
                if (this._Label2 != null)
                {
                }
            }
        }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x06000064 RID: 100 RVA: 0x00008A94 File Offset: 0x00007A94
        // (set) Token: 0x06000063 RID: 99 RVA: 0x00008A78 File Offset: 0x00007A78
        internal virtual Label Label3
        {
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label3 != null)
                {
                }
                this._Label3 = value;
                if (this._Label3 != null)
                {
                }
            }
        }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000065 RID: 101 RVA: 0x00008AC4 File Offset: 0x00007AC4
        // (set) Token: 0x06000066 RID: 102 RVA: 0x00008AA8 File Offset: 0x00007AA8
        internal virtual Label Label4
        {
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Label4 != null)
                {
                }
                this._Label4 = value;
                if (this._Label4 != null)
                {
                }
            }
        }

        // Token: 0x17000019 RID: 25
        // (get) Token: 0x06000068 RID: 104 RVA: 0x00008AD8 File Offset: 0x00007AD8
        // (set) Token: 0x06000067 RID: 103 RVA: 0x00008AEC File Offset: 0x00007AEC
        internal virtual RadioButton RbNone
        {
            get
            {
                return this._RbNone;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._RbNone != null)
                {
                }
                this._RbNone = value;
                if (this._RbNone != null)
                {
                }
            }
        }

        // Token: 0x1700001A RID: 26
        // (get) Token: 0x06000069 RID: 105 RVA: 0x00008B08 File Offset: 0x00007B08
        // (set) Token: 0x0600006A RID: 106 RVA: 0x00008B1C File Offset: 0x00007B1C
        internal virtual Button Button3
        {
            get
            {
                return this._Button3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button3 != null)
                {
                }
                this._Button3 = value;
                if (this._Button3 != null)
                {
                }
            }
        }

        // Token: 0x1700001B RID: 27
        // (get) Token: 0x0600006B RID: 107 RVA: 0x00008B8C File Offset: 0x00007B8C
        // (set) Token: 0x0600006C RID: 108 RVA: 0x00008B38 File Offset: 0x00007B38
        internal virtual TrackBar TrackBar1
        {
            get
            {
                return this._TrackBar1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll -= this.TrackBar1_Scroll;
                }
                this._TrackBar1 = value;
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll += this.TrackBar1_Scroll;
                }
            }
        }

        // Token: 0x0600006D RID: 109 RVA: 0x00008BA0 File Offset: 0x00007BA0
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.rbWest = new RadioButton();
            this.rbSouth = new RadioButton();
            this.rbNorth = new RadioButton();
            this.rbEast = new RadioButton();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.RbNone = new RadioButton();
            this.Button3 = new Button();
            this.TrackBar1 = new TrackBar();
            ((ISupportInitialize)this.TrackBar1).BeginInit();
            this.SuspendLayout();
            Control button = this.Button1;
            Point location = new Point(8, 8);
            button.Location = location;
            this.Button1.Name = "Button1";
            this.Button1.TabIndex = 6;
            this.Button1.Text = "This is";
            Control button2 = this.Button2;
            location = new Point(88, 8);
            button2.Location = location;
            this.Button2.Name = "Button2";
            this.Button2.TabIndex = 7;
            this.Button2.Text = "a sample";
            Control rbWest = this.rbWest;
            location = new Point(40, 120);
            rbWest.Location = location;
            this.rbWest.Name = "rbWest";
            Control rbWest2 = this.rbWest;
            Size size = new Size(12, 12);
            rbWest2.Size = size;
            this.rbWest.TabIndex = 10;
            Control rbSouth = this.rbSouth;
            location = new Point(56, 136);
            rbSouth.Location = location;
            this.rbSouth.Name = "rbSouth";
            Control rbSouth2 = this.rbSouth;
            size = new Size(12, 12);
            rbSouth2.Size = size;
            this.rbSouth.TabIndex = 9;
            this.rbNorth.Checked = true;
            Control rbNorth = this.rbNorth;
            location = new Point(56, 104);
            rbNorth.Location = location;
            this.rbNorth.Name = "rbNorth";
            Control rbNorth2 = this.rbNorth;
            size = new Size(12, 12);
            rbNorth2.Size = size;
            this.rbNorth.TabIndex = 8;
            this.rbNorth.TabStop = true;
            Control rbEast = this.rbEast;
            location = new Point(72, 120);
            rbEast.Location = location;
            this.rbEast.Name = "rbEast";
            Control rbEast2 = this.rbEast;
            size = new Size(12, 12);
            rbEast2.Size = size;
            this.rbEast.TabIndex = 11;
            Control label = this.Label1;
            location = new Point(24, 72);
            label.Location = location;
            this.Label1.Name = "Label1";
            Control label2 = this.Label1;
            size = new Size(63, 24);
            label2.Size = size;
            this.Label1.TabIndex = 12;
            this.Label1.Text = "North";
            this.Label1.TextAlign = ContentAlignment.BottomCenter;
            Control label3 = this.Label2;
            location = new Point(32, 152);
            label3.Location = location;
            this.Label2.Name = "Label2";
            Control label4 = this.Label2;
            size = new Size(56, 16);
            label4.Size = size;
            this.Label2.TabIndex = 13;
            this.Label2.Text = "South";
            this.Label2.TextAlign = ContentAlignment.TopCenter;
            Control label5 = this.Label3;
            location = new Point(88, 104);
            label5.Location = location;
            this.Label3.Name = "Label3";
            Control label6 = this.Label3;
            size = new Size(48, 40);
            label6.Size = size;
            this.Label3.TabIndex = 14;
            this.Label3.Text = "East";
            this.Label3.TextAlign = ContentAlignment.MiddleLeft;
            Control label7 = this.Label4;
            location = new Point(0, 104);
            label7.Location = location;
            this.Label4.Name = "Label4";
            Control label8 = this.Label4;
            size = new Size(32, 40);
            label8.Size = size;
            this.Label4.TabIndex = 15;
            this.Label4.Text = "West";
            this.Label4.TextAlign = ContentAlignment.MiddleRight;
            Control rbNone = this.RbNone;
            location = new Point(160, 144);
            rbNone.Location = location;
            this.RbNone.Name = "RbNone";
            Control rbNone2 = this.RbNone;
            size = new Size(88, 16);
            rbNone2.Size = size;
            this.RbNone.TabIndex = 11;
            this.RbNone.Text = "Not decided";
            Control button3 = this.Button3;
            location = new Point(168, 8);
            button3.Location = location;
            this.Button3.Name = "Button3";
            this.Button3.TabIndex = 16;
            this.Button3.Text = "usercontrol";
            Control trackBar = this.TrackBar1;
            location = new Point(0, 40);
            trackBar.Location = location;
            this.TrackBar1.Name = "TrackBar1";
            Control trackBar2 = this.TrackBar1;
            size = new Size(248, 45);
            trackBar2.Size = size;
            this.TrackBar1.TabIndex = 17;
            this.BackColor = SystemColors.Control;
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.rbWest);
            this.Controls.Add(this.rbSouth);
            this.Controls.Add(this.rbNorth);
            this.Controls.Add(this.rbEast);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.RbNone);
            this.Name = "UserControl1";
            size = new Size(248, 176);
            this.Size = size;
            ((ISupportInitialize)this.TrackBar1).EndInit();
            this.ResumeLayout(false);
        }

        // Token: 0x0600006E RID: 110 RVA: 0x000091CC File Offset: 0x000081CC
        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x0600006F RID: 111 RVA: 0x000091D0 File Offset: 0x000081D0
        private void Button1_Click(object sender, EventArgs e)
        {
            this.FindForm().Invalidate();
        }

        // Token: 0x06000070 RID: 112 RVA: 0x000091E0 File Offset: 0x000081E0
        private void Button2_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000071 RID: 113 RVA: 0x000091E4 File Offset: 0x000081E4
        public bool AcceptPopupClosing()
        {
            if (this.RbNone.Checked)
            {
              //  CustomTooltip.ShowTooltip(this.Label3, Popup.ePlacement.Right, "You must select a direction\r\nThe popup won't disappear until you make a choice");
                return false;
            }
            return true;
        }

        // Token: 0x06000072 RID: 114 RVA: 0x00009214 File Offset: 0x00008214
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
        }

        // Token: 0x0400002E RID: 46
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x0400002F RID: 47
        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        // Token: 0x04000030 RID: 48
        [AccessedThroughProperty("TrackBar1")]
        private TrackBar _TrackBar1;

        // Token: 0x04000031 RID: 49
        [AccessedThroughProperty("RbNone")]
        private RadioButton _RbNone;

        // Token: 0x04000032 RID: 50
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x04000033 RID: 51
        [AccessedThroughProperty("rbNorth")]
        private RadioButton _rbNorth;

        // Token: 0x04000034 RID: 52
        [AccessedThroughProperty("rbWest")]
        private RadioButton _rbWest;

        // Token: 0x04000035 RID: 53
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000036 RID: 54
        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        // Token: 0x04000037 RID: 55
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000038 RID: 56
        [AccessedThroughProperty("rbSouth")]
        private RadioButton _rbSouth;

        // Token: 0x04000039 RID: 57
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x0400003A RID: 58
        [AccessedThroughProperty("rbEast")]
        private RadioButton _rbEast;

        // Token: 0x0400003B RID: 59
        private IContainer components;
    }
}
