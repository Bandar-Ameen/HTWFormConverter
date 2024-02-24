using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using AsyncUIHelper;
using System.Threading;

namespace AsyncUIBusinessLayer
{
	public class BusinessObjectComponent : System.ComponentModel.Component
	{
		public class GetNextChunkEventArgs: EventArgs
		{
			public Customer[] Customers;
			public object State;
			public GetNextChunkEventArgs(Customer[] cus, object state)
			{
				Customers = cus;
				State = state;
			}
		}

		public class GetNextChunkState
		{
			public object State;
			public AsyncUIBusinessLayer.BusinessObjectAsync BO;
		}

		
		private System.ComponentModel.Container components = null;
		private AsyncUIBusinessLayer.BusinessObjectAsync bo;
		
		public delegate void GetNextChunkComponentEventHandler(object sender, GetNextChunkEventArgs args);
		public event GetNextChunkComponentEventHandler GetNextChunkCompleteEvent;
	
		private delegate string MethodEventHandler(string append);

		private delegate Customer[] GetNextChunkEventHandler(int chunksize);
		
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

		public BusinessObjectComponent(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();
			CreateBusinessObjectAsync ();
		}

		public BusinessObjectComponent()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();
			CreateBusinessObjectAsync ();
		}
		
		private void CreateBusinessObjectAsync()
		{
			bo = new AsyncUIBusinessLayer.BusinessObjectAsync ();
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion


		#region Synchronous API

		public string Method(string append)
		{	
			return bo.Method (append);
		}

		public Customer[] GetNextChunk( int chunksize )
		{
			return bo.GetNextChunk ( chunksize);
		}
		#endregion

		#region Async API

		private void ChunkReceived( IAsyncResult ar)
		{
			GetNextChunkState gState = (GetNextChunkState) ar.AsyncState ;
			AsyncUIBusinessLayer.BusinessObjectAsync  b = gState.BO ;
			Customer[] cus = b.EndGetNextChunk (ar);
			AsyncUIHelper.Util.InvokeDelegateOnCorrectThread ( GetNextChunkCompleteEvent, new object[] { this, new GetNextChunkEventArgs ( cus, gState.State) });
		}

		public void GetNextChunkAsync(int chunksize, object state )
		{

			if (GetNextChunkCompleteEvent==null)
			{
				throw new Exception ("Need to register event for callback.  bo.GetNextChunkEventHandler += new GetNextChunkComponentEventHandler (this.ChunkReceived );");
			}
			GetNextChunkState gState = new GetNextChunkState ();
			gState.State = state;
			gState.BO = bo;
			bo.BeginGetNextChunk (chunksize, new AsyncCallback (this.ChunkReceived ), gState);
		}

		#endregion
	}
	
}