using System;
using System.Threading ;
using System.Runtime.Remoting ;
using System.Collections ;
using System.Windows.Forms ;
using System.Diagnostics ;
using AsyncUIHelper;

namespace AsyncUIBusinessLayer
{
	/// <summary>
	/// This class was created to seperate UI specific code from BusinessObject.  InvokeDelegateOnCorrectThread
	/// checks Delegate.Target to see if it is a control, and if so calls delegate via Control.Invoke.
	/// </summary>
	public class BusinessObjectSync: BusinessObjectSyncSimple
	{
		private EventHandler StillWorkingOnRequestInternal;

		public new event EventHandler StillWorkingOnRequest
		{
			add 
			{
				StillWorkingOnRequestInternal += value;
			}
			remove
			{
				StillWorkingOnRequestInternal -= value;
			}
		}


		protected override void FireStillWorkingOnRequest( object sender, EventArgs args)
		{
			AsyncUIHelper.Util.InvokeDelegateOnCorrectThread (StillWorkingOnRequestInternal, new object[] { sender, args } );
		}

	}
}