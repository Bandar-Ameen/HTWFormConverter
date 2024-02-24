namespace dynFormLib
{
	public interface IDynControl
	{
		void AddEvent(System.EventHandler ev);

		System.Windows.Forms.Control GetWindowCtrl();
		System.Web.UI.Control GetWebCtrl();

		string GetCaption();
		string GetAttribute();
		uint GetStyle();
		void SetCaption(string caption);
		void SetAttribute(string attribute);
		void SetStyle(uint style);
	}
}