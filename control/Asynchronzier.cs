using System;
using System.Threading;
using System.Runtime.Remoting;
using System.Collections; 
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection ;

namespace AsyncUIHelper
{
	[Serializable]
	public class AsynchronizerResult: IAsyncResult
	{	
		protected object[] resultArgs;
		protected object state;
		protected bool completed;
		protected Delegate resultMethod;
		protected ManualResetEvent evnt;
		protected object returnValue;
		protected AsyncCallback asyncCallBack;
		protected bool onControlThread = false;
		protected Control cntrl = null;
		protected ISynchronizeInvoke asynchronizer = null;
		protected bool resultCancel = false;
		protected bool canCancel = true;

		public AsynchronizerResult ( Delegate method, object[] args, 
			AsyncCallback callBack, object asyncState, ISynchronizeInvoke async, Control ctr )
		{
			state = asyncState;
			resultMethod = method;
			resultArgs =  args;
			evnt = new ManualResetEvent(false);
			completed = false;
			asyncCallBack = callBack;
			asynchronizer = async;
			cntrl = ctr;
			if ( ! ( cntrl == null ) ) 
			{
				onControlThread = true;
			}
		}

		#region IAsyncResult properties
		public object AsyncState
		{
			get
			{
				return state;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				return evnt;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		public bool IsCompleted
		{
			get
			{
				return completed;
			}
		}
		#endregion 

		//This method is called on a thread from the thread pool to execute the method

		public void DoInvoke(object state)
		{
			this.DoInvoke (resultMethod, resultArgs);
		}

		public void DoInvoke(Delegate method, object[] args) 
		{
			
			//can check here if cancelled and not make call

			returnValue = method.DynamicInvoke(args);

			canCancel = false;

			evnt.Set();
			
			completed = true;
			
			CallBackCaller();
		}

		private void CallBackCaller()
		{	
			
			if ( resultCancel == false )
			{
				if (onControlThread)
				{
					cntrl.Invoke ( asyncCallBack, new object [] { this } );
				}
				else
				{
					asyncCallBack ( this );		
				}
			}
		}

		public object MethodReturnedValue
		{
			get
			{
				return returnValue;
			}
		}

		public ISynchronizeInvoke SynchronizeInvoke
		{
			get
			{
				return this.asynchronizer ;
			}
		}
		
		//obviously cancel of transaction that updates data would have to be much much more involved
		public bool Cancel ()
		{
			if (canCancel ) 
			{
				resultCancel = true;
				return true; 
			}
			else
			{
				return false;
			}
		}
	}

	public class Asynchronizer: ISynchronizeInvoke
	{
		protected object state;
		protected AsyncCallback asyncCallBack;
		protected Control cntrl = null;

		#region ISynchronizeInvoke
		public bool InvokeRequired
		{
			get
			{
				return false;
			}
		}

		public IAsyncResult BeginInvoke(Delegate method, object[] args)
		{
			AsynchronizerResult result = new AsynchronizerResult ( method, args,  
				asyncCallBack, state, this, cntrl );
			WaitCallback callBack = new WaitCallback ( result.DoInvoke );
			ThreadPool.QueueUserWorkItem ( callBack ) ;
			return result;
		}

		public object EndInvoke(IAsyncResult result)
		{
			AsynchronizerResult asynchResult = (AsynchronizerResult) result;
			asynchResult.AsyncWaitHandle.WaitOne();
			return asynchResult.MethodReturnedValue;
		}

		public object Invoke(Delegate method, object[] args)
		{
			return method.DynamicInvoke(args);
		}

		#endregion

		//disable default contructor
		private Asynchronizer()
		{

		}

		public Asynchronizer( Control control, AsyncCallback callBack, object asyncState)
		{
			asyncCallBack = callBack;
			state = asyncState;
			cntrl = control;
		}

		public Asynchronizer( AsyncCallback callBack, object asyncState)
		{
			asyncCallBack = callBack;
			state = asyncState;
			if (callBack.Target.GetType().IsSubclassOf (typeof(System.Windows.Forms.Control)))
			{
				cntrl = (Control) callBack.Target ;
			}
		}


	}

	public class AsynchronizerSimple : ISynchronizeInvoke 
	{
		private delegate void Invoker(Delegate method, object[] args);
		private Invoker inv;
		protected object state;
		protected AsyncCallback asyncCallBack;
		protected Control cntrl = null;
		protected AsynchronizerResult simpleSyncInvokeResult = null;

		private AsynchronizerSimple()
		{
		}

		public AsynchronizerSimple( AsyncCallback callBack, object asyncState)
		{
			asyncCallBack = callBack;
			state = asyncState;

			if (callBack.Target.GetType().IsSubclassOf (typeof(System.Windows.Forms.Control)))
			{
				cntrl = (Control) callBack.Target ;
			}
		}

		public AsynchronizerSimple( AsyncCallback callBack, object asyncState, bool callBackIsSafe)
		{
			asyncCallBack = callBack;
			state = asyncState;

			if (callBackIsSafe)
			{
				if (callBack.Target.GetType().IsSubclassOf (typeof(System.Windows.Forms.Control)))
				{
					 cntrl = (Control) callBack.Target ;
				}
			}
		}

		public AsynchronizerSimple( Control control, AsyncCallback callBack, object asyncState)
		{
			asyncCallBack = callBack;
			state = asyncState;
			cntrl = control;
		}

		public IAsyncResult BeginInvoke(Delegate method, object[] args) 
		{

			simpleSyncInvokeResult = new AsynchronizerResult ( method, args,  
				asyncCallBack, state, this, cntrl );
			
			inv = new Invoker(simpleSyncInvokeResult.DoInvoke);

			//relies on begininvoke using threadpool behind the scenes
			return inv.BeginInvoke(method, args, null  , state);
		}

		public object EndInvoke(IAsyncResult result) 
		{
			AsynchronizerResult asynchResult = (AsynchronizerResult) result;
			asynchResult.AsyncWaitHandle.WaitOne();
			return asynchResult.MethodReturnedValue;
		}

		public object Invoke(Delegate method, object[] args) 
		{
			return method.DynamicInvoke(args);
		}

		public bool InvokeRequired { get { return false; } }
	}
	
	public class Util
	{
		public static void InvokeDelegateOnCorrectThread ( Delegate method, object[] args)
		{
			if (method != null)
			{
				foreach ( Delegate del in method.GetInvocationList())
				{
					if (del.Target.GetType().IsSubclassOf (typeof(System.Windows.Forms.Control)))
					{
						Control c = (Control) del.Target ;
						c.Invoke (del, args );
					}
					else
					{
						del.DynamicInvoke(args);
					}
				}
			}
		}
	}
}