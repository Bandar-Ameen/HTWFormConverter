using System;
using System.Drawing;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace dynFormLib
{
	public class DynWindowControl : IDynControl
	{
		public virtual System.Windows.Forms.Control GetWindowCtrl() {return ctrl;}
		public virtual System.Web.UI.Control GetWebCtrl() {return null;}

		public virtual void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl.Location=new Point(x, y);
			ctrl.Size=new Size(sx, sy);
			ctrl.Text=text;
			ctrl.Name=name;
           
		}

		public virtual void AddEvent(System.EventHandler ev) {}
		public virtual string GetCaption() {return ctrl.Text;}
		public virtual string GetAttribute() {return "";}
		public virtual uint GetStyle() {return 0;}

		public virtual void SetCaption(string s) {ctrl.Text=s;}
		public virtual void SetAttribute(string s) {}
		public virtual void SetStyle(uint style) {}

		protected System.Windows.Forms.Control ctrl;
	}

	public class DynWindowTextBox : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.TextBox();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowLabel : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.Label();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowButton : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.Button();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	// This is a button with no text--just a bitmap
	public class DynWindowImageButton : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.Button();
			System.Drawing.Image image=System.Drawing.Image.FromFile(text);
			((System.Windows.Forms.Button)ctrl).Image=image;
			((System.Windows.Forms.Button)ctrl).ImageAlign=ContentAlignment.MiddleCenter;
			base.Create(x, y, sx, sy, "", name);
		}
	}

	public class DynWindowGroupBox : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.GroupBox();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowCheckBox : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.CheckBox();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowRadioButton : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.RadioButton();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowComboBox : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Windows.Forms.ComboBox();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWindowListView : DynWindowControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			System.Windows.Forms.ListView lv=new System.Windows.Forms.ListView();
			ctrl=lv;
			lv.GridLines=true;
			lv.View= System.Windows.Forms.View.Details;
			lv.FullRowSelect=true;

			string[] colNames=text.Split(new Char[]{','});
			for (int i=0; i<colNames.Length; i++)
			{
				string[] colInfo=colNames[i].Split(new Char[]{':'});
				ColumnHeader ch=new ColumnHeader();
				ch.Text=colInfo[0];
				ch.Width=Convert.ToInt32(colInfo[1]);
				if (ch.Width != 0)
				{
					lv.Columns.Add(ch);
				}
			}

//			ListViewItem item1=new ListViewItem("Grace", 0);
//			ListViewItem item2=new ListViewItem("Aardvark", 0);
//			lv.Items.Add(item1);
//			lv.Items.Add(item2);
			//			ListView.ColumnHeaderCollection col=((System.Windows.Forms.ListView)ctrl).Columns;
			base.Create(x, y, sx, sy, "", name);
		}
	}
}
