using System;
using System.Threading ;
using System.Runtime.Remoting ;
using System.Collections ;
using System.Windows.Forms ;
using System.Diagnostics ;

namespace AsyncUIBusinessLayer
{
	public class BusinessObjectSyncSimple
	{
		public event EventHandler StillWorkingOnRequest;

		public string Method(string append)
		{	
			for ( int i = 0; i <= 4; i++)
			{
				Thread.Sleep (1000);
				FireStillWorkingOnRequest (this, EventArgs.Empty );
			}

			return "asyncstring: " + append;
		}

		public Customer[] GetNextChunk( int chunksize )
		{
			//simpulate getting data in pieces
			Random r = new Random ();
			Customer[] cus = new Customer [chunksize];
			Customer c = new Customer();

			for ( int i = 0 ; i < chunksize;  i ++ )
			{
				if (i%5==0) 
				{
					FireStillWorkingOnRequest (this, EventArgs.Empty );
				}

				cus[i].FirstName = r.Next(3000).ToString ();
				Thread.Sleep (200);
			}

			return cus;
		}

		protected virtual void FireStillWorkingOnRequest( object sender, EventArgs args)
		{
			StillWorkingOnRequest(this, args);
		}

	}
}