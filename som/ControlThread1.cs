using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace ControlSystem
{
    class ControlThread1
    {
        ControlModel model;

        
        //-----------------------------------------------------------------------------------------------------------------------//
        public ControlThread1(ControlModel paramModel)
        {
            model = paramModel;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void Start()
        {
            System.Diagnostics.Debug.WriteLine("ControlThread1.Start: starting");
            
            Random randObj = new Random(42);

            while (true)
            {
                model.Power = randObj.NextDouble();
                model.pauseFlag.WaitOne(-1, false);

                if (model.stopFlag.WaitOne(100, false))
                {
                    System.Diagnostics.Debug.WriteLine("ControlThread1.Start: stop signaled");
                    return;
                }

            }

        }

    }


}
