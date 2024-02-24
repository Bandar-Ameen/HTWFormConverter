using System;

using System.Collections;
using System.Data;

using System.Drawing;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace dynFormLib
{
	public class DynWebControl : IDynControl
	{
		public virtual System.Windows.Forms.Control GetWindowCtrl() {return null;}
		public virtual System.Web.UI.Control GetWebCtrl() {return ctrl;}

		public virtual void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl.Style["POSITION"]="absolute";
			ctrl.Style["LEFT"]=x.ToString()+"px";
			ctrl.Style["TOP"]=y.ToString()+"px";
			ctrl.Style["WIDTH"]=sx.ToString()+"px";
			ctrl.Style["HEIGHT"]=sy.ToString()+"px";
			ctrl.Font.Size=9;
			ctrl.Font.Name="MS Sans Serif";
		}

		public virtual void AddEvent(System.EventHandler ev) {}
		public virtual string GetCaption() {return "";}
		public virtual string GetAttribute() {return "";}
		public virtual uint GetStyle() {return 0;}

		public virtual void SetCaption(string s) {}
		public virtual void SetAttribute(string s) {}
		public virtual void SetStyle(uint style) {}

		protected System.Web.UI.WebControls.WebControl ctrl;
	}

	public class DynWebTextBox : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.TextBox();
			((System.Web.UI.WebControls.TextBox)ctrl).Text=text;
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWebLabel : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.Label();
			((System.Web.UI.WebControls.Label)ctrl).Text=text;
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWebButton : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.Button();
			((System.Web.UI.WebControls.Button)ctrl).Text=text;
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWebImageButton : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.ImageButton();
			ctrl.BorderStyle=System.Web.UI.WebControls.BorderStyle.Outset;
			ctrl.BorderWidth=1;
			((System.Web.UI.WebControls.ImageButton)ctrl).ImageUrl=text;
			base.Create(x+2, y+2, sx-4, sy-4, "", name);
		}

		protected System.Web.UI.WebControls.ImageButton obj;
	}

	public class DynWebGroupBox : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.Panel();
			ctrl.BorderStyle=System.Web.UI.WebControls.BorderStyle.Solid;
			ctrl.BorderWidth=1;
			base.Create(x, y, sx, sy, text, name);

			label=new System.Web.UI.WebControls.Label();
			label.Text=" "+text;
			label.Style["POSITION"]="absolute";
			label.Style["LEFT"]=15.ToString()+"px";
			label.Style["TOP"]=(-8).ToString()+"px";
			label.BackColor=System.Drawing.Color.WhiteSmoke;
			ctrl.Controls.Add(label);
		}

		protected System.Web.UI.WebControls.Label label;
	}

	public class DynWebCheckBox : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.CheckBox();
			((System.Web.UI.WebControls.CheckBox)ctrl).Text=text;
			base.Create(x, y, sx, sy, text, name);
		}

	}

	public class DynWebRadioButton : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.RadioButton();
			((System.Web.UI.WebControls.RadioButton)ctrl).Text=text;
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWebComboBox : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			ctrl=new System.Web.UI.WebControls.DropDownList();
			base.Create(x, y, sx, sy, text, name);
		}
	}

	public class DynWebListView : DynWebControl
	{
		public override void Create(int x, int y, int sx, int sy, string text, string name)
		{
			System.Web.UI.WebControls.DataGrid dg=new System.Web.UI.WebControls.DataGrid();
			ctrl=dg;
			dg.GridLines=GridLines.Both;
			dg.BorderColor=System.Drawing.Color.Teal;
			dg.ShowHeader=true;
			dg.HeaderStyle.BackColor=System.Drawing.Color.LightGray;
//			dg.BorderStyle=System.Web.UI.WebControls.BorderStyle.Inset;
			dg.HeaderStyle.Height=Unit.Pixel(15);
			dg.AllowPaging=true;
			dg.AutoGenerateColumns=false;				// we want a Columns collection, so we have to disable auto generate
			dg.PagerStyle.Mode=PagerMode.NextPrev;
			int rows=(sy/17)-2;
			dg.PageSize=rows;		// kludge for now

			// !!! All styles must be set before binding the data source !!!
			dg.DataSource=CreateDataSource(rows, text, dg);
			dg.DataBind();
			base.Create(x, y, sx, sy, "", name);
			ctrl.Style["WIDTH"]="";
			int n=dg.Columns.Count;
		}

		protected ICollection CreateDataSource(int rows, string text, System.Web.UI.WebControls.DataGrid dg) 
		{
			DataTable dt=new DataTable();
			DataRow dr;
 
			string[] colNames=text.Split(new Char[]{','});
			int cols=0;
			for (int i=0; i<colNames.Length; i++)
			{
				string[] colInfo=colNames[i].Split(new Char[]{':'});
				int width=Convert.ToInt32(colInfo[1]);
				dt.Columns.Add(new DataColumn(colInfo[0], typeof(string)));
				System.Web.UI.WebControls.BoundColumn column=new System.Web.UI.WebControls.BoundColumn();
				column.HeaderText=colInfo[0];
				column.ItemStyle.Height=Unit.Pixel(15);
				column.ItemStyle.Width=Unit.Pixel(width);
				column.HeaderStyle.Width=Unit.Pixel(width);
				column.ItemStyle.BorderColor=System.Drawing.Color.LightBlue;
				column.ItemStyle.BackColor=System.Drawing.Color.White;
				if (width==0)
				{
					column.Visible=false;
				}
				dg.Columns.Add(column);
				++cols;
			}

			for (int i=0; i<rows; i++) 
			{
				dr=dt.NewRow();
				for (int j=0; j<cols; j++)
				{
					dr[j]="";
				}
				dt.Rows.Add(dr);
			}
 
			DataView dv=new DataView(dt);
			return dv;
		}

	}
}
