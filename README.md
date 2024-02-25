
# HTWFormConverter

This project contains a build script to build Convert html To windows Form. 
using .Net C# and use Windows  Form inside  Web browser 

# dependency 
This project using  Telerik lib 

https://telerik.com

AdminLTE

newtensoft.json

#### Example
```c#
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.control;

namespace winToWeb
{
    public partial class Form4 : RadForm, RecevDataFromWeb
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void shometh()
        {

            try
            {
                var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\tem.txt");
                // var vvv = new cutest();
                var con = new webproser(alldat, true,this);
                con.Dock = DockStyle.Fill;
                this.Controls.Add(con);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }
        private async void Form4_Load(object sender, EventArgs e)
        {
            

        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        public void ReceveFroms(object anotherData)
        {
            
        }

        public async void ReceivOpenForm(string Pagename, string TageName, string pageTitle, object anotherData, string showAsDailoge)
        {
            try {
                var res = JsonConvert.DeserializeObject<eventOpenFrom>(anotherData.ToString());
                var q = JsonConvert.DeserializeObject<webproser.getalertv>(res.Name_Form.ToString());
                if (q.Type_Event.Equals("1"))
                {
                   /* var laod = new Astoldesinger.Class.ConnectecedWithmain_ss(GORS.Instance.OpenForm.GetRadPageView());
                    await laod.load();*/
                }
                else
                {
                  //  Astoldesinger.Class.GetFormFromIDScreen vvb = new Astoldesinger.Class.GetFormFromIDScreen();

                    // RadForm child = await vvb.shoeformm("37", 0);
                 /*   RadForm child = await vvb.shoeformm(q.formname, 0);

                    GORS.Instance.OpenForm.ReceivOpenForm(child, q.Page_name, q.Tage_name, q.Title_name, anotherData, q.tyeForm.ToString());
                   */
                    //  myform1 k = new myform1();
                    // GORS.Instance.OpenForm.ReceveFroms(child, anotherData);
                }
            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ReceivAnotherData(string Pagename, string TageName, string pageTitle, string showAsDailoge, object[] another)
        {
          
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            GORS.Instance.Date_typ = 1;
            GORS.Instance.Date_fromate = "yyyy-dd-MM";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

//your Html file path
 var alldat = File.ReadAllText(@"C:\Users\Mypc\Documents\DynamicForms_src\projects.net\AutoFormPrototype\csForm\gg.html");
            var t = new customefinal(alldat, this);
            t.Dock = DockStyle.Fill;
            var ex = await t.inithh.loadForm();
            ex.Show();
        }
    }
}
```

# screenshot
![khj](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/28d4f771-4e95-4460-b765-01f2700490ab)
![ppl](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/621eefdf-f3a6-4130-985e-dd63fd0a9389)
![nmj](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/141195e2-a626-4d96-8240-846cdee8f87f)
