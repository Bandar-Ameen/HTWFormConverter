using System;
using System.Threading;
using System.Runtime.Remoting ;
using System.Collections ;
using System.Windows.Forms ;
using System.Diagnostics ;
using AsyncUIHelper;

namespace AsyncUIBusinessLayer
{
	/// <summary>
	/// Summary description for BusinessObjectAsync.
	/// </summary>
	public class BusinessObjectAsync
	{
		protected delegate string MethodEventHandler(string append);
		protected delegate Customer[] GetNextChunkEventHandler(int chunksize);
		private BusinessObjectSync bo = new BusinessObjectSync();
		public event EventHandler StillWorkingOnRequest
		{
			add 
			{
				bo.StillWorkingOnRequest += value;
			}
			remove
			{
				bo.StillWorkingOnRequest -= value;
			}
		}

		#region Synchronous API

		public string Method(string append)
		{	
			return bo.Method (append);
		}

		public Customer[] GetNextChunk( int chunksize )
		{
			return bo.GetNextChunk (chunksize);
		}
		#endregion

		#region Async APIs

		public IAsyncResult BeginMethod( string append, AsyncCallback callback, Control ctr,object state)
		{
			Asynchronizer ssi = new Asynchronizer (ctr, callback, state);
			return ssi.BeginInvoke ( new MethodEventHandler ( this.Method )  , new Object [] { append }  );
		}

		public IAsyncResult BeginMethod( string append, AsyncCallback callback, object state)
		{
			Asynchronizer ssi = new Asynchronizer (callback, state);
			return ssi.BeginInvoke ( new MethodEventHandler ( this.Method )  , new Object [] { append }  );
		}

		public string EndMethod(IAsyncResult ar)
		{
			AsynchronizerResult   asr = ( AsynchronizerResult   ) ar;
			return (string ) asr.SynchronizeInvoke.EndInvoke ( ar);
		}

		public IAsyncResult BeginGetNextChunk( int chunksize, AsyncCallback callback, object state )
		{
			Asynchronizer ssi = new Asynchronizer( callback, state );
			return ssi.BeginInvoke ( new GetNextChunkEventHandler ( this.GetNextChunk )
				, new Object [] { chunksize }  );
		}

		public IAsyncResult BeginGetNextChunkUnsafe( int chunksize, AsyncCallback callback, object state )
		{

			///Running with safe flag set to false will not check whether callback is on a control;
			///therefore, callback will be on threadpool thread instead of control thread.  This is just for 
			///demo purposes and should not be in implementation of AsynchronizerSimple.
			AsynchronizerSimple ssi = new AsynchronizerSimple (callback, state, false);
			return ssi.BeginInvoke ( new GetNextChunkEventHandler  ( this.GetNextChunk )
				, new Object [] { chunksize }  );
		}

		public Customer[] EndGetNextChunk(IAsyncResult ar)
		{
			AsynchronizerResult   asr = ( AsynchronizerResult   ) ar;
			return ( Customer[] ) asr.SynchronizeInvoke.EndInvoke ( ar);
		}

		#endregion
	}
}
