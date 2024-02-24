using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Diagnostics;
using AsyncUIBusinessLayer;
using System.IO;
using winToWeb.control;

namespace AsyncUIPresentationLayer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private IAsyncResult CurrentAsyncResult;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private Thread timerThread;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCallback;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components;
		private AsyncUIBusinessLayer.BusinessObjectComponent businessObjectComponent1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnBadUICall;
		private System.Windows.Forms.Button btnAsyncOnUI;
		private System.Windows.Forms.Button btnCtlInvokeOnForm;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnSynchronousCall;
		private System.Windows.Forms.Button btnAsyncThroughComponent;
		private System.Windows.Forms.Button btnAsyncThroughComponent2;

		public delegate void delUpdateGrid ( AsyncUIBusinessLayer.Customer[] cus);
		private delUpdateGrid CallUpdateGrid;


		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.label1.Text = "Form Thread = " + Thread.CurrentThread.GetHashCode ();
			StartProgressBar ();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btnBadUICall = new System.Windows.Forms.Button();
			this.btnAsyncOnUI = new System.Windows.Forms.Button();
			this.btnCtlInvokeOnForm = new System.Windows.Forms.Button();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.button4 = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnAsyncThroughComponent = new System.Windows.Forms.Button();
			this.btnAsyncThroughComponent2 = new System.Windows.Forms.Button();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCallback = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnSynchronousCall = new System.Windows.Forms.Button();
			this.businessObjectComponent1 = new AsyncUIBusinessLayer.BusinessObjectComponent(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(184, 80);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(208, 312);
			this.dataGrid1.TabIndex = 0;
			// 
			// btnBadUICall
			// 
			this.btnBadUICall.Location = new System.Drawing.Point(8, 112);
			this.btnBadUICall.Name = "btnBadUICall";
			this.btnBadUICall.Size = new System.Drawing.Size(160, 23);
			this.btnBadUICall.TabIndex = 1;
			this.btnBadUICall.Text = "Bad UI Call";
			this.btnBadUICall.Click += new System.EventHandler(this.btnBadUICall_Click);
			// 
			// btnAsyncOnUI
			// 
			this.btnAsyncOnUI.Location = new System.Drawing.Point(8, 176);
			this.btnAsyncOnUI.Name = "btnAsyncOnUI";
			this.btnAsyncOnUI.Size = new System.Drawing.Size(160, 23);
			this.btnAsyncOnUI.TabIndex = 3;
			this.btnAsyncOnUI.Text = "AsyncOnUIThread";
			this.btnAsyncOnUI.Click += new System.EventHandler(this.btnAsyncOnUI_Click);
			// 
			// btnCtlInvokeOnForm
			// 
			this.btnCtlInvokeOnForm.Location = new System.Drawing.Point(8, 144);
			this.btnCtlInvokeOnForm.Name = "btnCtlInvokeOnForm";
			this.btnCtlInvokeOnForm.Size = new System.Drawing.Size(160, 23);
			this.btnCtlInvokeOnForm.TabIndex = 6;
			this.btnCtlInvokeOnForm.Text = "Control.Invoke on Form";
			this.btnCtlInvokeOnForm.Click += new System.EventHandler(this.btnCtlInvokeOnForm_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 400);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(648, 22);
			this.statusBar1.TabIndex = 7;
			this.statusBar1.Text = "statusBar1";
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(-248, 210);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(153, 40);
			this.button4.TabIndex = 9;
			this.button4.Text = "Start!";
			// 
			// btnStop
			// 
			this.btnStop.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnStop.Location = new System.Drawing.Point(592, 32);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(48, 40);
			this.btnStop.TabIndex = 8;
			this.btnStop.Text = "Stop!";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.progressBar1.Location = new System.Drawing.Point(72, 32);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(512, 40);
			this.progressBar1.TabIndex = 10;
			this.progressBar1.Text = "Start!";
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.btnStart.Location = new System.Drawing.Point(8, 32);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(56, 40);
			this.btnStart.TabIndex = 12;
			this.btnStart.Text = "Start!";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnAsyncThroughComponent
			// 
			this.btnAsyncThroughComponent.Location = new System.Drawing.Point(8, 208);
			this.btnAsyncThroughComponent.Name = "btnAsyncThroughComponent";
			this.btnAsyncThroughComponent.Size = new System.Drawing.Size(160, 23);
			this.btnAsyncThroughComponent.TabIndex = 13;
			this.btnAsyncThroughComponent.Text = "Async through Component";
			this.btnAsyncThroughComponent.Click += new System.EventHandler(this.btnAsyncThroughComponent_Click);
			// 
			// btnAsyncThroughComponent2
			// 
			this.btnAsyncThroughComponent2.Location = new System.Drawing.Point(8, 240);
			this.btnAsyncThroughComponent2.Name = "btnAsyncThroughComponent2";
			this.btnAsyncThroughComponent2.Size = new System.Drawing.Size(160, 32);
			this.btnAsyncThroughComponent2.TabIndex = 14;
			this.btnAsyncThroughComponent2.Text = "Async through Component pass state";
			this.btnAsyncThroughComponent2.Click += new System.EventHandler(this.btnAsyncThroughComponent2_Click);
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(432, 80);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(208, 312);
			this.dataGrid2.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 24);
			this.label1.TabIndex = 16;
			this.label1.Text = "label1";
			// 
			// lblCallback
			// 
			this.lblCallback.Location = new System.Drawing.Point(152, 0);
			this.lblCallback.Name = "lblCallback";
			this.lblCallback.Size = new System.Drawing.Size(136, 23);
			this.lblCallback.TabIndex = 17;
			this.lblCallback.Text = "Callback";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(288, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "ProgressBar";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.ForeColor = System.Drawing.Color.Blue;
			this.lblStatus.Location = new System.Drawing.Point(8, 288);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(160, 32);
			this.lblStatus.TabIndex = 19;
			// 
			// btnSynchronousCall
			// 
			this.btnSynchronousCall.Location = new System.Drawing.Point(8, 80);
			this.btnSynchronousCall.Name = "btnSynchronousCall";
			this.btnSynchronousCall.Size = new System.Drawing.Size(160, 23);
			this.btnSynchronousCall.TabIndex = 20;
			this.btnSynchronousCall.Text = "Synchronous Call";
			this.btnSynchronousCall.Click += new System.EventHandler(this.btnSynchronousCall_Click);
			// 
			// businessObjectComponent1
			// 
			this.businessObjectComponent1.GetNextChunkCompleteEvent += new AsyncUIBusinessLayer.BusinessObjectComponent.GetNextChunkComponentEventHandler(this.businessObjectComponent1_GetNextChunkComplete);
			this.businessObjectComponent1.StillWorkingOnRequest += new System.EventHandler(this.businessObjectComponent1_StillWorkingOnRequest);
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 422);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnSynchronousCall,
																		  this.lblStatus,
																		  this.label3,
																		  this.lblCallback,
																		  this.label1,
																		  this.dataGrid2,
																		  this.btnAsyncThroughComponent2,
																		  this.btnAsyncThroughComponent,
																		  this.btnStart,
																		  this.button4,
																		  this.btnStop,
																		  this.progressBar1,
																		  this.statusBar1,
																		  this.btnCtlInvokeOnForm,
																		  this.btnAsyncOnUI,
																		  this.btnBadUICall,
																		  this.dataGrid1});
			this.Name = "Form2";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public void ChunkReceivedFromComponent (object sender, BusinessObjectComponent.GetNextChunkEventArgs args)
		{
			AsyncUIBusinessLayer.BusinessObjectComponent bo = ( AsyncUIBusinessLayer.BusinessObjectComponent ) sender;
			AsyncUIBusinessLayer.Customer[] cus = args.Customers ;
			this.dataGrid1.DataSource = cus;
			this.dataGrid1.Refresh ();
			this.lblCallback.Text = "Callback thread = " + Thread.CurrentThread.GetHashCode ();
			this.statusBar1.Text = "Request Finished";
		}

		public void ChunkReceived (IAsyncResult ar)
		{
			this.lblCallback.Text = "Callback thread = " + Thread.CurrentThread.GetHashCode ();
			AsyncUIBusinessLayer.BusinessObjectAsync bo = (AsyncUIBusinessLayer.BusinessObjectAsync  ) ar.AsyncState ;
			AsyncUIBusinessLayer.Customer [] cus =  bo.EndGetNextChunk( ar );
			this.dataGrid1.DataSource = cus;
			this.dataGrid1.Refresh ();
			this.statusBar1.Text = "Request Finished";
		}

		public void UpdateGrid (AsyncUIBusinessLayer.Customer[] cus)
		{
			this.lblCallback.Text = "Callback thread = " + Thread.CurrentThread.GetHashCode ();
			this.dataGrid1.DataSource = cus;
			this.dataGrid1.Refresh ();
			this.statusBar1.Text = "Request Finished";

		}

		//Have to call control.Invoke if business object is not thread safe to use on controls
		public void ChunkReceivedCallbackSafe(IAsyncResult ar)
		{
			this.lblCallback.Text = "Callback thread = " + Thread.CurrentThread.GetHashCode ();
			AsyncUIBusinessLayer.BusinessObjectAsync bo = (AsyncUIBusinessLayer.BusinessObjectAsync ) ar.AsyncState ;
			AsyncUIBusinessLayer.Customer [] cus =  bo.EndGetNextChunk( ar );
			if (this.InvokeRequired )
			{
				this.Invoke( new delUpdateGrid (this.UpdateGrid ), new object[] {cus});
			}
			else
			{
				UpdateGrid (cus);
			}
		}

		public void OnStillWorkingOnRequest (object sender, EventArgs args)
		{
		
			lblStatus.Text = "Still working on request.  Thread = " + Thread.CurrentThread.GetHashCode ();
			if ( lblStatus.ForeColor == Color.Yellow   )
			{
				lblStatus.ForeColor = Color.Blue ;
				lblStatus.BackColor = Color.Yellow ;
			}
			else if ( lblStatus.ForeColor == Color.Blue  )
			{
				lblStatus.ForeColor = Color.Yellow  ;
				lblStatus.BackColor = Color.Blue ;
			}
		}

		private void btnBadUICall_Click(object sender, System.EventArgs e)
		{
			AsyncUIBusinessLayer.BusinessObjectAsync bo = new AsyncUIBusinessLayer.BusinessObjectAsync ();
			bo.BeginGetNextChunkUnsafe (20, new AsyncCallback ( this.ChunkReceived ), bo );
			this.statusBar1.Text = "Request Sent";
		}

		private void btnAsyncOnUI_Click(object sender, System.EventArgs e)
		{
			AsyncUIBusinessLayer.BusinessObjectAsync bo = new AsyncUIBusinessLayer.BusinessObjectAsync ();
			bo.StillWorkingOnRequest  += new EventHandler (this.OnStillWorkingOnRequest );
			CurrentAsyncResult = bo.BeginGetNextChunk (20, new AsyncCallback ( this.ChunkReceived ), bo );
			this.statusBar1.Text = "Request Sent";

		}
	
		private void btnCtlInvokeOnForm_Click(object sender, System.EventArgs e)
		{
			AsyncUIBusinessLayer.BusinessObjectAsync bo = new AsyncUIBusinessLayer.BusinessObjectAsync ();
			bo.BeginGetNextChunkUnsafe (20, new AsyncCallback ( this.ChunkReceivedCallbackSafe ), bo );
			this.statusBar1.Text = "Request Sent";
			this.label1.Text = "Form Thread = " + Thread.CurrentThread.GetHashCode ();
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			StartProgressBar ();
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			StopProgressBar ();
		}

		private void StartProgressBar()
		{
			StopThread();
			timerThread = new Thread(new ThreadStart(ThreadProc));
			timerThread.IsBackground = true;
			timerThread.Start();
		}

		private void StopProgressBar()
		{
			StopThread();
		}

		public void ThreadProc() 
		{
			try 
			{
				MethodInvoker mi = new MethodInvoker(this.UpdateProgress);
				
				while (true) 
				{
					this.BeginInvoke(mi);
					Thread.Sleep(500) ;
				}
			}
			catch (ThreadInterruptedException) 
			{
			}
			catch (System.InvalidOperationException ex)
			{
				StartProgressBar (); //keep trying until window handle created
			}
			catch (Exception ex) 
			{
			}
		}

		private void UpdateProgress() 
		{
			label3.Text = "ProgressBar Update thread = " + Thread.CurrentThread.GetHashCode ();
			if (progressBar1.Value == progressBar1.Maximum) 
			{
				progressBar1.Value = progressBar1.Minimum ;
			}

			progressBar1.PerformStep() ;
		}

		private void StopThread()
		{
			if (timerThread != null)
			{
				timerThread.Interrupt();
				timerThread = null;
			}
		}

		private void btnAsyncThroughComponent_Click(object sender, System.EventArgs e)
		{
			//added event handler by hand.
			AsyncUIBusinessLayer.BusinessObjectComponent bo = new AsyncUIBusinessLayer.BusinessObjectComponent ();
			bo.GetNextChunkCompleteEvent += new BusinessObjectComponent.GetNextChunkComponentEventHandler (this.ChunkReceivedFromComponent  );
			bo.StillWorkingOnRequest += new EventHandler (this.OnStillWorkingOnRequest );
			bo.GetNextChunkAsync (15, null);
			this.statusBar1.Text = "Request Sent";
		}


		private void btnSynchronousCall_Click(object sender, System.EventArgs e)
		{
			AsyncUIBusinessLayer.BusinessObjectSync bo = new AsyncUIBusinessLayer.BusinessObjectSync ();
			AsyncUIBusinessLayer.Customer [] cus = bo.GetNextChunk (20);
			this.dataGrid1.DataSource = cus;
		}

		private void btnAsyncThroughComponent2_Click(object sender, System.EventArgs e)
		{
            var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\tem.txt");
            // var vvv = new cutest();
           
           // businessObjectComponent1.GetNextChunkAsync (50, new webproser(alldat, true) );
			this.statusBar1.Text = "Request Sent";
		}

		private void businessObjectComponent1_GetNextChunkComplete(object sender, BusinessObjectComponent.GetNextChunkEventArgs args)
		{
			this.lblCallback.Text = "Callback thread = " + Thread.CurrentThread.GetHashCode ();
            MessageBox.Show("fffffffffff");
            /*AsyncUIBusinessLayer.Customer[] cus = args.Customers ;
			DataGrid grid = (DataGrid) args.State ;
			grid.DataSource = cus;
			grid.Refresh ();*/

		}

		private void businessObjectComponent1_StillWorkingOnRequest(object sender, System.EventArgs e)
		{
			this.OnStillWorkingOnRequest ( sender, e );	
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}