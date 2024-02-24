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
	/// As an alternative to BusinessObjectAsync, the methods here make explicit effort to make callbacks
	/// on UI thread.  Using BusinessObjectAsyncExplicit.BeingMethodOnUIThread vs. BusinessObjectAsync.BeginMethod
	/// is a design decision to make.  There are pros and cons for each approach.
	/// </summary>
	public class BusinessObjectAsyncExplicit: BusinessObjectAsync
	{
		private IAsyncResult BeginMethodOnUIThread( 
			Control control, string append, AsyncCallback callback, object state)
		{
			Asynchronizer ssi = new Asynchronizer ( control, callback, state);
			return ssi.BeginInvoke (new MethodEventHandler ( this.Method ), new Object [] { append }  );
		}

		public string EndMethodOnUIThread(IAsyncResult ar)
		{
			return base.EndMethod (ar);
		}

		private IAsyncResult BeginGetNextChunkOnUIThread( Control control, int chunksize, 
			AsyncCallback callback, object state )
		{
			Asynchronizer ssi = new Asynchronizer ( control, callback, state);
			return ssi.BeginInvoke ( new GetNextChunkEventHandler  ( this.GetNextChunk )
				, new Object [] { chunksize }  );
		}

		private Customer[] EndGetNextChunkOnUIThread(IAsyncResult ar)
		{
			return base.EndGetNextChunk  ( ar ) ;
		}
	}
}
