using System;
using System.Drawing;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace dynFormLib
{
	public struct ControlInfo
	{
		public ControlInfo(string type, Point pos, Size size, string name, string text, string var, string varList)
		{
			this.type=type;
			this.pos=pos;
			this.size=size;
			this.name=name;
			this.text=text;
			this.var=var;
			this.varList=varList;
		}

		public string type;
		public Point pos;
		public Size size;
		public string name;
		public string text;
		public string var;
		public string varList;
	}

	public interface IDynForm
	{
		void AddControl(IDynControl ctrl);
	}

	public class DynWindowForm : System.Windows.Forms.Form, IDynForm
	{
		public DynWindowForm() {}
		public void Create(int x, int y, int sx, int sy, string caption, string name)
		{
			AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			StartPosition=FormStartPosition.Manual;
			Location=new Point(x, y);
			ClientSize=new Size(sx, sy);
			Text=caption;
			Name=name;
			//			KA.Info.Forms.AddForm(this);
		}

		public void AddControl(IDynControl ctrl)
		{
			Controls.Add(ctrl.GetWindowCtrl());
			//			controls.Add(ctrl, ctrl.Name);
		}

		public void LoadControls(ControlInfo[] ctrlInfo)
		{
			for (int i=0; i<ctrlInfo.Length; i++)
			{
				DynWindowControl ctrl=null;
				switch(ctrlInfo[i].type)
				{
					case "label":
					{
						ctrl=new DynWindowLabel();
						break;
					}
					case "edit":
					{
						ctrl=new DynWindowTextBox();
						break;
					}

					case "button":
					{
						ctrl=new DynWindowButton();
						break;
					}

					case "imageButton":
					{
						ctrl=new DynWindowImageButton();
						break;
					}

					case "groupBox":
					{
						ctrl=new DynWindowGroupBox();
						break;
					}

					case "checkBox":
					{
						ctrl=new DynWindowCheckBox();
						break;
					}

					case "radioButton":
					{
						ctrl=new DynWindowRadioButton();
						break;
					}
					
					case "comboBox":
					{
						ctrl=new DynWindowComboBox();
						break;
					}

					case "listView":
					{
						ctrl=new DynWindowListView();
						break;
					}
				}

				if (ctrl != null)
				{
					ctrl.Create(ctrlInfo[i].pos.X, ctrlInfo[i].pos.Y, ctrlInfo[i].size.Width, ctrlInfo[i].size.Height, ctrlInfo[i].text, ctrlInfo[i].name);
					AddControl(ctrl);
				}
			}
		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DynWindowForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DynWindowForm";
            this.Load += new System.EventHandler(this.DynWindowForm_Load);
            this.ResumeLayout(false);

        }

        private void DynWindowForm_Load(object sender, EventArgs e)
        {

        }
    }


    public class DynWebForm : IDynForm
	{
		public DynWebForm() {}
		public void Init(System.Web.UI.WebControls.Label lbl)
		{
			frame=lbl;
		}

		public void AddControl(IDynControl ctrl)
		{
			frame.Controls.Add(ctrl.GetWebCtrl());
		}

		public void LoadControls(ControlInfo[] ctrlInfo)
		{
			for (int i=0; i<ctrlInfo.Length; i++)
			{
				DynWebControl ctrl=null;
				switch(ctrlInfo[i].type)
				{
					case "label":
					{
						ctrl=new DynWebLabel();
						break;
					}
					
					case "edit":
					{
						ctrl=new DynWebTextBox();
						break;
					}
					
					case "button":
					{
						ctrl=new DynWebButton();
						break;
					}
					
					case "groupBox":
					{
						ctrl=new DynWebGroupBox();
						break;
					}
					
					case "checkBox":
					{
						ctrl=new DynWebCheckBox();
						break;
					}

					case "imageButton":
					{
						ctrl=new DynWebImageButton();
						break;
					}

					case "radioButton":
					{
						ctrl=new DynWebRadioButton();
						break;
					}

					case "comboBox":
					{
						ctrl=new DynWebComboBox();
						break;
					}

					case "listView":
					{
						ctrl=new DynWebListView();
						break;
					}
				}
				if (ctrl != null)
				{
					ctrl.Create(ctrlInfo[i].pos.X, ctrlInfo[i].pos.Y, ctrlInfo[i].size.Width, ctrlInfo[i].size.Height, ctrlInfo[i].text, ctrlInfo[i].name);
					AddControl(ctrl);
				}
			}
		}
		
		public void Run() {}

		public System.Web.UI.WebControls.Label frame;
	}
}