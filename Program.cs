using ControlSystem;
using Html_Demo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using winToWeb.control;
using winToWeb.html.toControl;
using System.Reflection;
using System.Net;

namespace winToWeb
{
    static class Program
    {

        public static ControlModel Model = new ControlModel();

      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

          //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
            var i = Path.GetDirectoryName(getdependencys.Urllk);
            var ff = 0;
            List<datafile> down = new List<datafile>();
             foreach (var it in getdependencys.filedownload)
             {
                 var c = i + @"\" + it.filename + "";
                if (!File.Exists(c))
                {

                    down.Add(new datafile {url= it.fileurl + "",path=c });
                
                  
                    
                }
              
                 //  it.
             }

            if (down.Count == 0) {
                ddrt();

            }
            else {
                
                downloadFile_Demo.frmMain d = new downloadFile_Demo.frmMain(down);
                        d.ShowDialog();

            }
          /*  if (ff == 0)
            {
                Application.Run(new downloadFile_Demo.frmMain());
                Application.Run(new Form3());
            }
            else {
             
                Application.Run(new downloadFile_Demo.frmMain());
                Application.Run(new Form3());
            }*/
         
           
        }
        private static void ddrt() {
            try
            {
                Application.Run(new Form3());
            }
            catch (FileNotFoundException ex)
            {

            }
        }

      
    }
}
