using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace ControlSystem
{
    public enum PreampEnum
    {
        OFF, LOW, MEDIUM, HIGH       
    }

    class ControlModel : System.ComponentModel.INotifyPropertyChanged, IDisposable 
    {
        System.Timers.Timer timer1;
        ArrayList observers = new ArrayList();
        ControlThread1 controlThread;
        Thread t1 = null;

        public AutoResetEvent stopFlag = new AutoResetEvent(false);
        public EventWaitHandle pauseFlag = new EventWaitHandle(false, EventResetMode.ManualReset);

        public ComboBindingList<PreampEnum> preampList = new ComboBindingList<PreampEnum>();

        private PreampEnum preampSetting = PreampEnum.OFF;
        public PreampEnum PreampSetting { get { return preampSetting; } set { preampSetting = value; } }


        //-----------------------------------------------------------------------------------------------------------------------//
        public ControlModel()
        {
            timer1 = new System.Timers.Timer();
            timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
            
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            GC.KeepAlive(timer1);

            preampList.Add(new ComboHelper<PreampEnum>("Off", PreampEnum.OFF));
            preampList.Add(new ComboHelper<PreampEnum>("Low", PreampEnum.LOW));
            preampList.Add(new ComboHelper<PreampEnum>("Medium", PreampEnum.MEDIUM));
            preampList.Add(new ComboHelper<PreampEnum>("High", PreampEnum.HIGH));



        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void AddObserver(Control paramControl)
        {
            lock (observers.SyncRoot)
            {
                if (paramControl != null)
                    if (!observers.Contains(paramControl))
                        observers.Add(paramControl);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void RemoveObserver(Control paramControl)
        {
            lock (observers.SyncRoot)
            {
                if (paramControl != null)
                    if (observers.Contains(paramControl))
                        observers.Remove(paramControl);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void StartControlThread1()
        {
            if(t1 != null && t1.ThreadState == System.Threading.ThreadState.Running)
                return;

            controlThread = new ControlThread1(this);
            t1 = new Thread(controlThread.Start);
            t1.IsBackground = true;
            t1.Start();

        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void StopControlThread1()
        {
            if (t1 != null)
            {
                stopFlag.Set();
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------//
        #region INotifyPropertyChanged Members

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        #endregion

        //-----------------------------------------------------------------------------------------------------------------------//
        static bool stateFlag = false;
        public bool StateFlag
        {
            get { return stateFlag; }
            set
            {
                stateFlag = value;
                UpdateObservers("StateFlag", StateFlag);

                if(stateFlag)
                    pauseFlag.Set();
                else
                    pauseFlag.Reset();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        static bool controlThreadEnable = false;
        public bool ControlThreadEnable
        {
            get { return controlThreadEnable; }
            set
            {
                controlThreadEnable = value;
                //UpdateObservers("StateFlag", StateFlag);

                if (controlThreadEnable)
                    StartControlThread1();
                else
                    StopControlThread1();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        int scrollValue = 0;
        public int ScrollValue
        {
            get { return scrollValue; }
            set
            {
                scrollValue = value;
                // Not being set from a worker thread, so 
                // UpdateObservers not required, let the 
                // default binding occur.
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        double power = 0;
        public double Power
        {
            get { return power; }
            set
            {
                power = value;
                UpdateObservers("Power", power);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        System.Drawing.Color powerColor = System.Drawing.SystemColors.Control;
        public System.Drawing.Color PowerColor
        {
            get
            {
                if (stateFlag)
                    return System.Drawing.Color.Yellow;
                else
                    return System.Drawing.SystemColors.Control;
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public System.Drawing.Color PreampColor
        {
            get
            {

                switch (PreampSetting)
                {
                    case PreampEnum.OFF:
                        return System.Drawing.Color.Black;
                    case PreampEnum.LOW:
                        return System.Drawing.Color.Yellow;
                    case PreampEnum.MEDIUM:
                        return System.Drawing.Color.Orange;
                    case PreampEnum.HIGH:
                        return System.Drawing.Color.Red;
                    default:
                        return System.Drawing.Color.Black;
                }
                
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private void UpdateObservers(string propertyName, object value)
        {
            Array copy;
            lock (observers.SyncRoot)
            {
                copy = observers.ToArray();
            }

            for (int n = 0; n < copy.Length; n++)
            {
                Control control = (Control)copy.GetValue(n);

                // Handle must exist.
                if (!control.IsHandleCreated)
                    continue;

                if (control.IsDisposed)
                    continue;

                switch (propertyName)
                {
                    case "Power":
                        control.Invoke(((MainForm)control).PowerDelegate, new object[] { (double)value });
                        break;

                    case "StateFlag":
                        control.Invoke(((MainForm)control).PowerButtonDelegate, new object[] { (bool)value });
                        break;
                }

             }

            // Original version.
            //
            //for (int n = 0; n < copy.Length; n++)
            //{
            //    try
            //    {
            //        Control control = (Control)copy.GetValue(n);

            //        if (PropertyChanged != null)
            //        {
            //            if (control.InvokeRequired)
            //            {
            //                if (propertyName == "Power")
            //                    control.Invoke(((MainForm)control).PowerDelegate, new object[] { (double)value });
            //                else if (propertyName == "StateFlag")
            //                    control.Invoke(((MainForm)control).PowerButtonDelegate, new object[] { (bool)value });
            //                else
            //                    control.Invoke(PropertyChanged, new object[] { this, new PropertyChangedEventArgs(propertyName) });
            //            }
            //            else
            //            {
            //                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}

        } // UpdateObservers

        //-----------------------------------------------------------------------------------------------------------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            StateFlag = !StateFlag;
        }

        #region IDisposable Members

        public void Dispose()
        {
            stopFlag.Set();

        }

        #endregion
    }
}
