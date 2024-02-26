
# HTWFormConverter

This project contains a build script to build Convert html To windows Form. 
using .Net C# and use Windows  Form inside  Web browser 

# dependency 
This project using  Telerik lib 

https://telerik.com

AdminLTE

newtensoft.json

 # require
 Win 64x
Enable ControlX from IE
 
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
#### html example
```html
<pageview class="ddddsssssssddd" dock="Fill" id="man"
    style="border:Fixed3D;float:false;stripbuttons:All;viewmode:Strip;StripAlignment:Top;ItemAlignment:Center;ItemFitMode:None; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
    <pageviewpage text="الصفحة" class="ddddsssssssddd" dock="Fill" id="man"
        style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">

        <flowlayout class="ddddsssssssdd" dock="Fill" id="man"
            style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
            <groupbox text="heeeeeee" class="dsssddvv" id="manv"
                style="locationX:50;locationY:50;width:550;autoSize:true; height:350;ccc:red;">
                <flowlayout class="ddddsssssssdd" dock="Top" id="man"
                    style="border:Fixed3D; direction:TopDown;locationX:200; locationY:200;width:100;height:150;ccc:red;">
                    <button text="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;background:#7b1aa5;"></button>

                    <button onclick="D" name="b" text="heeeeeeepppppppppppp" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;"></button>

                </flowlayout>

            </groupbox>

            <groupbox text="heeeeeee" class="dsssddvv" id="manv"
                style="locationX:50;autoSize:true;locationY:50;width:550;height:350;ccc:red;">
                <flowlayout class="ddddsssssssdd" dock="Top" id="man"
                    style="border:Fixed3D; direction:TopDown;locationX:200;autoSize:frue; locationY:200;width:700;height:450;ccc:red;">

                    <edittext name="va" placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </edittext>
                    <edittext placeHolder="iii" class="dsssddvv" name="myname"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </edittext>
                    <checkbox text="name" placeHolder="heeeeeee" class="dsssddvv" id="kk"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </checkbox>

                    <label text="name &quot; ffffffff" placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:150;height:50;ccc:red;">
                        kkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
                    </label>

                    <domainupdown text="0" placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:150;height:50;ccc:red;">
                    </domainupdown>
                    <textbutton text="nameffffffffff" placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </textbutton>
                    <radiobutton text="nameffffffffffxxxx" placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </radiobutton>


                    <datetime placeHolder="heeeeeee" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
                    </datetime>
                    <button onclick="B" text="heeeeeexx" class="dsssddvv" id="manvkk"
                        style="locationX:50;locationY:50;width:550;height:50;ccc:red;"></button>


                    <combobox onchange="C" datasource="ggddd" text="heeeeeeepppppppppppp" class="dsssddvv" id="manv"
                        style="locationX:50;locationY:50;width:200;height:50;ccc:red;"></combobox>
                </flowlayout>

            </groupbox>
        </flowlayout>
    </pageviewpage>
    <pageviewpage text="الويب" class="ddddsssssssddd" dock="Fill" id="manmn"
        style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
        <webbrowser fromtext="htmlone" fromurl="0" dock="Fill" enablealternatingrowcolor="true"
            colora="#7b1aa5" headerwidth="50" enablefit="true" enablepage="true" pagesize="30" showhorizontal="true"
            showvertical="true" enablegroup="true" name="griddfwebb" oncelldoubleclick="EB" onchange="EB"
            allowadd="true" allowedit="false" allowdelete="false" allowsearch="true" allowright="true"
            allowautosizerows="false" class="dsssddvv" id="manvkk"
            style="anchor_left:true;anchor_right:true;anchor_top:true;anchor_bottom:true;visibility:visible;padding-bottom:0;margin-bottom:0;padding-top:0;margin-top:0;locationX:0;locationY:0;width:950;height:250;ccc:red;">



        </webbrowser>
    </pageviewpage>
    <pageviewpage text="الffffصفحة" class="ddddsssssssddd" dock="Fill" id="man"
        style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
        <entry onclickg="B" class="dsssddvv" id="manvkk" style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
        </entry>
    </pageviewpage>
    <pageviewpage text="الfffrtrtrtصفحة" class="ddddsssssssddd" dock="Fill" id="man"
        style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
        <entry onclickg="B" class="dsssddvv" id="manvkk" style="locationX:50;locationY:50;width:550;height:50;ccc:red;">
        </entry>
    </pageviewpage>



    <pageviewpage text="الfffrtjghjrtrtصفحة" class="ddddsssssssddd" dock="Fill" id="mahn"
        style="border:Fixed3D; direction:TopUp;locationX:200; locationY:200;width:700;height:150;ccc:red;">
        <groupbox name="group1" dock="Fill" text="heeeeeee" class="dsssddvv" id="manv"
            style="locationX:50;autoSize:true;locationY:50;width:550;height:350;ccc:red;">
            <flowlayout name="contin" class="ddddsssssssdd" dock="Top" id="manj"
                style="float:talse;border:Fixed3D;direction:TopDown;locationX:200;autoSize:true; locationY:200;width:700;height:150;ccc:red;">


                <edittext checknull="true" name="a_unitname" placeHolder="unitname" class="dsssddvv" id="manvoo"
                    style="locationX:50;locationY:50;width:150;height:70;ccc:red;">
                </edittext>
                <edittext name="un" readonly="true" masktype="Numeric" mask="d" placeHolder="unitid" class="dsssddvv"
                    id="manvoo"
                    style="al:center;readonly:true; float:false;locationX:50;locationY:50;width:150;height:50;ccc:red;">
                </edittext>
                <edittext readonly="true" masktype="Numeric" mask="d" name="unn" placeHolder="unitid" class="dsssddvv"
                    id="manvoo" style="al:center; float:false;locationX:50;locationY:50;width:150;height:50;ccc:red;">
                </edittext>




                <flowlayout name="selctrad" class="ddddsssssssdd" id="manfrj"
                    style="float:talse;border:Fixed3D;direction:TopDown;locationX:200;autoSize:true; locationY:200;width:100;height:150;ccc:red;">

                    <radiobutton name="1" text="rad1" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>

                    <radiobutton name="2" text="rad2" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>
                    <radiobutton name="3" text="rad3" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>
                </flowlayout>
                <flowlayout class="ddddsssssssdd" id="manfrjj"
                    style="float:talse;border:Fixed3D;direction:TopDown;locationX:200;autoSize:true; locationY:200;width:100;height:150;ccc:red;">

                    <radiobutton name="rad12" text="rad12" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>

                    <radiobutton name="rad22" text="rad22" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>
                    <radiobutton name="rad32" text="rad32" class="dsssddvv" id="manvkkge"
                        style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                    </radiobutton>
                </flowlayout>
                <button name="btnew" onclick="Clen" text="جديد" class="dsssبببddvv" id="manvkkg"
                    style="locationX:50;locationY:50;width:50;height:30;ccc:red;"></button>
                <button name="btnref" onclick="EE#EA" text="تحديث" class="dsssddvv" id="manvkkg"
                    style="locationX:50;locationY:50;width:50;height:30;ccc:red;"></button>


                <button tooltiptext="hello hello" svgname="image1"
                    imagesrcc="https://raw.githubusercontent.com/Bandar-Ameen/Bandar/master/h_5.png" imagesizex="25"
                    imagesizey="25" imageonly="true" enable="false" name="btnsave" onclick="EventSave" text="حفظ"
                    class="dsssddvv" id="manvkkg" style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                </button>
                <button enable="false" name="btnedit" onclick="EventEdite" text="تعديل" class="dsssddvv" id="manvkkg"
                    style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                </button>

                <button enable="false" name="btndelete" text="حذف" class="dsssddvv" id="manvkkg"
                    style="locationX:50;locationY:50;width:50;height:30;ccc:red;">
                </button>
            </flowlayout>

            <cardviewf name="card" oncelldoubleclick="E" onchange="E" dock="Fill" allowadd="true" allowedit="false"
                allowdelete="false" allowsearch="true" allowright="true" allowautosizerows="false" class="dsssddvv"
                id="manvkk"
                style="padding-bottom:100;margin-bottom:-50;padding-top:100;margin-top:50;locationX:50;locationY:50;width:550;height:250;ccc:red;">

                <cardviewitem headertextalignment="MiddleCenter" visibleincolumnchooser="false" readonly="true"
                    fieldname="unit_name" typecolumn="text" class="Acol1" columnname="unit_name" text="إسم الوحدة">


                </cardviewitem>



            </cardviewf>
            <combobox displayname="unit_name" idselect="ID_unit" filter="unit_name" name="grid" oncelldoubleclick="E"
                onchange="E" dock="Fill" allowadd="true" allowedit="false" allowdelete="false" allowsearch="true"
                allowright="true" allowautosizerows="false" class="dsssddvv" id="manvkk"
                style="padding-bottom:100;margin-bottom:-50;padding-top:100;margin-top:50;locationX:50;locationY:50;width:550;height:250;ccc:red;">
                <column headertextalignment="MiddleCenter" visibleincolumnchooser="false" readonly="true"
                    fieldname="unit_name" typecolumn="text" class="Acol1" columnname="unit_name" text="إسم الوحدة">
                </column>
                <column headertextalignment="MiddleCenter" visibleincolumnchooser="false" readonly="true"
                    fieldname="ID_unit" width="100" typecolumn="text" class="Acol2" columnname="ID_unit" text="المعرف">
                </column>

            </combobox>
            <groupbox name="group1f" dock="Fill" text="heeeeeee" class="dsssddvv" id="manv"
                style="locationX:50;autoSize:true;locationY:50;width:550;height:50;">
                <webbrowserv fromtext="htmlone" fromurl="0" dock="Top" enablealternatingrowcolor="true" colora="#7b1aa5"
                    headerwidth="50" enablefit="true" enablepage="true" pagesize="30" showhorizontal="true"
                    showvertical="true" enablegroup="true" name="griddfweb" oncelldoubleclick="EB" onchange="EB"
                    allowadd="true" allowedit="false" allowdelete="false" allowsearch="true" allowright="true"
                    allowautosizerows="false" class="dsssddvv" id="manvkk"
                    style="anchor_left:true;anchor_right:true;anchor_top:true;anchor_bottom:true;visibility:visible;padding-bottom:0;margin-bottom:-150;padding-top:0;margin-top:60;locationX:0;locationY:0;width:950;height:250;ccc:red;">



                </webbrowserv>

                <datagridview enablealternatingrowcolor="true" colora="#7b1aa5" headerwidth="50" enablefit="true"
                    enablepage="true" pagesize="30" showhorizontal="true" showvertical="true" enablegroup="true"
                    name="gridd" oncelldoubleclick="EB" onchange="EB" allowadd="true" allowedit="false"
                    allowdelete="false" allowsearch="true" allowright="true" allowautosizerows="false" class="dsssddvv"
                    id="manvkk"
                    style="anchor_left:true;anchor_right:true;anchor_top:true;anchor_bottom:true;padding-bottom:100;margin-bottom:0;padding-top:0;margin-top:0;locationX:0;locationY:250;width:550;height:250;ccc:red;">
                    <column enableexpression="false" expression="no" svgname="image1" imagesizex="70" imagesizey="70"
                        imageonly="true" headertextalignment="MiddleCenter" visibleincolumnchooser="false"
                        readonly="true" fieldname="unit_name" typecolumn="text" class="Acol1" columnname="unit_name"
                        text="إسم الوحدة">
                    </column>
                    <column headertextalignment="MiddleCenter" visibleincolumnchooser="false" readonly="true"
                        fieldname="ID_unit" width="100" typecolumn="text" class="Acol2" columnname="ID_unit"
                        text="المعرف">
                    </column>


                </datagridview>
            </groupbox>
        </groupbox>

        <wating name="watingg" addcontrol="btnedit" class="dsssddvv" id="manvhhoo"
            style="al:center; float:false;locationX:50;locationY:50;width:200;height:200;ccc:red;">
        </wating>
    </pageviewpage>
</pageview>

<event>

    <event id="B" eventType="Click" controlEnab="kname:dis;ff:tt;">
        uuuuuuuu
    </event>
    <event id="D" eventType="Click" controlEnab="myname:ena;ff:tt;">
        uuuuuuuu
    </event>
    <event id="C" eventType="Click" controlEnab="myname:name#set;myname:name#read;va:value#set;">
        uuuuuuuu
    </event>
    <event id="E" eventType="Click" controlEnab="a_unitname:unit_name#set;unn:ID_unit#set;knamekk:hello3#set;">
        uuuuuuuuk
    </event>
    <event id="EB" eventType="Click"
        controlEnab="a_unitname:unit_name#set;getdatakk:ID_unit#click;selctrad:ID_unit#set;grid:ID_unit#set;un:ID_unit#set;knamekk:hello3#set;btnsave:ds#disabl;btnedit:ds#enable;btndelete:fd#enable;">
        uuuuuuuuk
    </event>
    <event id="EE" sourceid="refresha" eventType="Click" controlEnab="kname:mdis;gridd:sorc;">
        uuuuuuuukgggg
    </event>
    <event id="EA" sourceid="refresh" eventType="Click" controlEnab="kname:mdis;grid:sorc;">
        uuuuuuuukgggg
    </event>
    <event id="Clen" eventType="Click" controlEnab="a_unitname:cle;btnsave:enable;btnedit:disabl;btndelete:disabl;">
        uuuuuuuukgggg
    </event>
    <event id="EventSave" sourceid="save" eventType="Click" controlEnab="kname:mdis;grid:sorc;">
        uuuuuuuukgggg
    </event>

    <event id="EventEdite" sourceid="edit" eventType="Click" controlEnab="kname:mdis;grid:sorc;">
        uuuuuuuukgggg
    </event>
</event>

<datasource>
    <sources onstartmessagea="message:هل تريد الحفظ;" usenull="frue" onstop="watingg:watingg#stop;"
        onstart="watingg:watingg#start;" showasmessage="frue" selectresponse="response" url="desin/uidesin"
        method="POST" body="mykeyone:kname;mykey2:knamek;mykey3:knamekk;"
        query="kname:hello1;knamek:hello2;knamekk:hello3;" headr="kname:hello1;knamek:hello2;knamekk:hello3;"
        id="refresha" class="jhjh">
        {{
        "query":"hhh",
        "header":"hhhmmm",
        "body":
        [{{"head":[{{"typ1":"1","userID":"0","alfraID":"0","stockID":"0","username":"0","enab":"0","typ2":"0","IDforupdate":"0","allwith":"0","sandookID":"0","parcount":"0","parmnam":"24"}}],"pramname":[{{"paramvalue":["16","إختباريي
        ااخخخخخ","إختباريي ااخخخخخ","0","إختباريي ااخخخخخ","إختباريي ااخخخخخ","إختباريي ااخخخخخ","إختباريي
        ااخخخخخ","113"]}}]}}]
        }}
    </sources>

    <sources onstartmessagea="message:هل تريد الحفظ;" usenull="frue"
        onstop="watingg:watingg#stop;getdatakkk:getdatakkk#click;" onstart="watingg:watingg#start;" showasmessage="frue"
        selectresponseerror="response" selectresponse="response" url="desin/uidesin" method="POST"
        body="mykeyone:kname;mykey2:knamek;mykey3:knamekk;" query="kname:hello1;knamek:hello2;knamekk:hello3;"
        headr="kname:hello1;knamek:hello2;knamekk:hello3;" id="refresh" class="jhjh">
        {{
        "query":"hhh",
        "header":"hhhmmm",
        "body":
        [{{"head":[{{"typ1":"1","userID":"0","alfraID":"0","stockID":"0","username":"0","enab":"0","typ2":"0","IDforupdate":"0","allwith":"0","sandookID":"0","parcount":"0","parmnam":"24"}}],"pramname":[{{"paramvalue":["16","إختباريي
        ااخخخخخ","إختباريي ااخخخخخ","0","إختباريي ااخخخخخ","إختباريي ااخخخخخ","إختباريي ااخخخخخ","إختباريي
        ااخخخخخ","113"]}}]}}]
        }}
    </sources>
    <sources onstartmessage="message:هل تريد الحفظ;" usenull="true" onstop="btnref:btnref#click;"
        onstart="btnreff:btnreff#click;" showasmessage="true" selectresponseerror="response" selectresponse="response"
        url="desin/uidesin" method="POST" body="mykeyone:a_unitname;" query="kname:hello1;knamek:hello2;knamekk:hello3;"
        headr="kname:hello1;knamek:hello2;knamekk:hello3;" id="save" class="jhjh">
        {{
        "query":"hhh",
        "header":"hhhmmm",
        "body":
        [{{"head":[{{"typ1":"1","userID":"0","alfraID":"0","stockID":"0","username":"0","enab":"0","typ2":"0","IDforupdate":"0","allwith":"0","sandookID":"0","parcount":"0","parmnam":"24"}}],"pramname":[{{"paramvalue":["13","{0}","12","123","1234","12345","5555","6666","7777"]}}]}}]
        }}
    </sources>


    <sources onstartmessage="message:هل تريد التعديل" usenull="true" onstop="btnref:btnref#click;"
        onstart="btnreff:btnreff#click;watingg:watingg#start;" showasmessage="true" selectresponseerror="response"
        selectresponse="response" url="desin/uidesin" method="POST" body="mykeyone:a_unitname;un:un;"
        query="kname:hello1;knamek:hello2;knamekk:hello3;" headr="kname:a_unitname;knamek:hello2;knamekk:hello3;"
        id="edit" class="jhjh">
        {{
        "query":"hhh",
        "header":[{{"key":"Content-Type","value":"application/json"}}],
        "body":
        [{{"head":[{{"typ1":"1","userID":"0","alfraID":"0","stockID":"0","username":"0","enab":"0","typ2":"0","IDforupdate":"0","allwith":"0","sandookID":"0","parcount":"0","parmnam":"24"}}],"pramname":[{{"paramvalue":["14","{0}","0","159","159","159","159","159","{1}"]}}]}}]
        }}
    </sources>
</datasource>

<imagesvg>
    <imagesvgsorce id="image1">

        <svg version="1.1" id="svg1" width="1088.0604" height="1013.7092" viewBox="0 0 1088.0605 1013.7092"
            sodipodi:docname="3c.svg" inkscape:version="1.3.2 (091e20ef0f, 2023-11-25)"
            xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape"
            xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd" xmlns="http://www.w3.org/2000/svg"
            xmlns:svg="http://www.w3.org/2000/svg">
            <defs id="defs1" />
            <sodipodi:namedview id="namedview1" pagecolor="#ffffff" bordercolor="#000000" borderopacity="0.25"
                inkscape:showpageshadow="2" inkscape:pageopacity="0.0" inkscape:pagecheckerboard="0"
                inkscape:deskcolor="#d1d1d1" showgrid="false" inkscape:zoom="0.36172354" inkscape:cx="145.13847"
                inkscape:cy="454.76719" inkscape:window-width="1920" inkscape:window-height="1011" inkscape:window-x="0"
                inkscape:window-y="0" inkscape:window-maximized="1" inkscape:current-layer="layer2" />
            <g inkscape:groupmode="layer" id="layer2" inkscape:label="Layer 1">
                <path id="path1" style="fill:#000000"
                    d="M 1002.9705 87.117455 C 980.37588 85.869645 961.09278 97.319501 952.95681 117.64285 C 944.96416 137.60797 945.37233 156.51405 954.07595 169.44753 L 958.47048 175.97683 L 937.93923 197.65456 C 926.64633 209.57738 916.89353 219.33425 916.26735 219.33425 C 915.64116 219.33425 912.47204 216.07411 909.22438 212.09011 C 902.24747 203.53134 889.97272 194.78487 879.12087 190.64089 C 868.29345 186.50632 849.06162 185.58303 837.33376 188.63503 C 814.45996 194.58777 796.42983 211.07054 788.09352 233.6487 C 786.89127 236.90512 786.37475 237.15669 783.28688 235.98269 C 773.29468 232.18363 760.13843 236.47683 753.81618 245.59988 C 750.38629 250.54914 749.99978 252.19399 749.99977 261.88503 C 749.99978 270.73359 750.5978 273.8509 753.33376 279.2737 C 757.35429 287.24271 770.0734 301.20839 776.42556 304.62917 L 781.02517 307.10769 L 770.57985 313.38503 C 745.17109 328.6562 733.22171 341.72301 712.35134 377.05495 C 711.57261 378.3733 709.18304 377.69133 702.16384 374.14675 C 691.1022 368.56089 677.30467 365.88798 668.84743 367.69167 L 662.96462 368.94753 L 658.05446 356.54324 C 655.35467 349.72183 651.39263 341.72207 649.24977 338.76394 C 637.4809 322.51742 616.95101 321.22773 607.09743 336.11745 C 603.7945 341.10853 603.33376 343.05036 603.33376 351.97292 C 603.33376 366.14168 608.65087 376.57892 623.66384 391.87722 L 634.66579 403.09011 L 634.66579 410.7366 C 634.66579 433.16847 650.35605 455.27503 676.66579 469.91042 C 686.20436 475.21652 706.95882 483.05496 717.72829 485.42019 C 721.97843 486.35362 725.69541 487.50527 725.98806 487.97878 C 726.2807 488.45229 725.61094 491.94216 724.49977 495.73269 L 722.47829 502.62331 L 717.57204 500.52566 C 714.87375 499.37148 701.17701 493.71982 687.13454 487.96706 C 661.34202 477.40071 648.77851 471.54209 639.90993 465.94363 C 635.6098 463.22902 634.86734 461.9202 633.40602 454.49245 C 629.69176 435.61298 617.53579 420.27105 598.90407 410.94558 C 576.57995 399.77201 551.21429 400.15603 534.1072 411.92605 L 528.24392 415.95925 L 527.34548 408.98074 C 525.6211 395.60643 517.32601 359.20928 511.96462 341.49245 C 505.50328 320.14107 496.99041 298.17772 487.09938 277.33425 C 481.85708 266.28701 479.98108 260.8821 480.38845 258.00027 C 480.69942 255.80027 486.24046 235.39944 492.70095 212.66628 C 502.5697 177.93977 504.46153 169.73582 504.53493 161.33425 C 504.60297 153.54569 503.98929 150.15413 501.7654 146.00027 C 491.00055 125.89288 464.87406 121.88184 448.87477 137.88113 C 439.83102 146.92488 437.25863 154.29091 433.93337 180.66628 C 432.73147 190.19953 431.33824 198.4357 430.83767 198.96902 C 430.33711 199.50234 425.44456 198.30869 419.96462 196.31667 C 410.0702 192.72001 409.75366 192.69631 374.66579 192.68191 L 339.33376 192.66628 L 327.69509 196.8323 C 298.66829 207.2194 279.71382 224.21996 259.33571 258.1487 L 250.87477 272.23464 L 242.91188 255.78347 C 233.62067 236.59058 227.45268 228.02118 219.63454 223.43972 C 211.78484 218.83984 204.53178 217.93367 195.83571 220.46902 C 184.02949 223.91105 176.85911 229.30901 172.63845 237.93581 C 165.08119 253.3822 168.47374 265.13311 188.82595 294.00027 C 210.78314 325.14401 222.66579 343.01383 222.66579 344.89285 C 222.66579 345.96881 221.21439 352.6586 219.43923 359.75808 C 204.33959 420.14734 193.92552 505.58364 192.9197 577.32839 L 192.49977 607.32449 L 179.24977 612.11941 C 153.8443 621.31372 132.64099 634.16872 126.97048 643.81472 C 117.82054 659.3794 125.929 682.72535 143.51149 691.43581 C 154.04419 696.65381 174.05998 694.27586 190.99977 685.79324 C 194.4831 684.04895 197.33376 682.86284 197.33376 683.15652 C 197.33376 683.4502 198.55111 692.81266 200.03884 703.96316 C 210.76301 784.34096 231.16973 846.91502 261.40602 892.13308 L 269.07399 903.59988 L 258.64626 936.39675 C 252.91101 954.4349 247.51163 972.59706 246.64821 976.75613 C 243.79537 990.49839 247.66688 1003.8161 256.94509 1012.1721 C 263.9323 1018.4655 270.14215 1020.4051 281.28102 1019.7757 C 303.07684 1018.5441 311.41886 1005.2653 318.02321 961.27956 C 319.17487 953.60954 320.39135 946.02161 320.72829 944.41824 C 321.34036 941.5055 321.38087 941.50296 363.67165 941.06081 C 404.31635 940.63586 406.30772 940.49454 413.73806 937.5198 C 431.76948 930.30095 453.56952 911.35661 466.05446 892.05691 C 469.28295 887.06617 476.54323 873.62164 482.18727 862.17995 L 492.44899 841.37527 L 497.4861 849.0862 C 509.44253 867.38504 518.83266 874.60769 530.66579 874.60769 C 547.47752 874.60769 557.18172 862.4614 555.66188 843.31667 C 554.84867 833.07204 551.20015 825.89476 531.27321 795.33425 L 515.62282 771.33425 L 519.19509 752.66628 C 524.56899 724.58339 531.67052 677.19852 534.88063 648.00027 C 536.45283 633.70035 537.81688 621.88014 537.91188 621.73464 C 538.20586 621.28459 606.42904 617.48068 651.99977 615.37331 C 706.45309 612.85525 730.37494 611.12743 753.99977 608.00222 C 764.26636 606.6441 773.0238 605.93663 773.46071 606.43191 C 773.89763 606.92718 776.20171 613.00651 778.57985 619.93972 C 783.17497 633.33588 788.12949 643.9577 795.4861 656.18191 L 800.00954 663.69753 L 795.47438 680.24636 C 782.09944 729.04782 780.22482 763.46807 790.14626 778.08816 C 791.97154 780.77786 793.28576 783.12416 793.06618 783.30105 C 792.8466 783.47794 788.46701 784.90215 783.33376 786.46511 C 770.01564 790.52015 770.00619 790.52737 771.62087 798.20339 C 772.36858 801.75801 773.37828 805.5946 773.86306 806.72878 C 774.52808 808.28467 770.33945 811.65449 756.80056 820.4573 C 721.59888 843.34492 709.69904 862.61894 708.2986 899.0198 L 707.64431 916.03933 L 704.15602 916.80495 C 693.54919 919.13742 687.65439 921.84897 681.65407 927.15652 C 679.17365 929.35057 676.8164 929.80941 668.32009 929.74441 C 659.71004 929.67856 655.90126 928.84812 645.33376 924.7366 C 614.25493 912.64457 614.77259 912.78618 601.30446 912.72488 C 589.58372 912.67152 587.92701 913.00431 579.69509 917.05691 C 564.50528 924.53478 557.25874 936.29189 557.39235 953.24245 C 557.44416 959.81503 558.46746 964.09146 561.96267 972.33425 C 562.65728 973.97257 562.3425 974.66628 560.90602 974.66628 C 557.72526 974.66628 553.33376 981.22958 553.33376 985.98269 C 553.33376 993.36208 558.26746 998.76547 570.69899 1005.0042 C 586.53086 1012.949 598.03138 1014.6663 635.41188 1014.6663 C 669.62517 1014.6663 683.36764 1013.219 692.33376 1008.6721 C 698.27393 1005.6597 698.66579 1005.6159 698.66579 1007.9612 C 698.66579 1012.0495 704.96793 1018.3051 711.70485 1020.9046 C 723.28943 1025.3746 754.70695 1022.7955 767.99001 1016.2835 C 773.87751 1013.3972 775.95544 1009.2104 775.98024 1000.1917 C 775.99571 994.56875 776.69819 992.22223 779.28102 989.15261 C 785.72562 981.49372 785.4693 969.20174 778.63845 958.21316 C 775.33408 952.89754 774.72299 950.94204 775.86892 949.3616 C 780.68171 942.72343 780.65595 936.22048 775.79079 930.03542 C 772.13911 925.39315 766.4356 922.60271 755.33376 920.0237 L 745.99977 917.85574 L 746.41774 905.928 C 747.51504 874.53106 754.99552 862.03958 784.34938 842.60378 L 800.03493 832.21902 L 812.34938 838.67995 C 819.12334 842.23284 832.11135 848.18998 841.21071 851.91824 C 860.25423 859.72083 857.51495 860.22353 873.13063 846.06277 C 881.23924 838.70963 883.53547 837.29304 886.46267 837.84011 C 888.40772 838.20364 893.49521 838.88757 897.76735 839.35964 C 904.34396 840.08633 905.3898 840.55811 904.58962 842.44167 C 899.73032 853.88045 900.91182 863.77844 907.3572 865.62917 C 914.19539 867.5928 929.6121 870.34937 939.2029 871.32253 L 948.40602 872.25613 L 947.6111 895.41042 C 947.15271 908.75037 946.15587 919.85802 945.26149 921.6155 C 944.40766 923.2933 937.02543 931.42746 928.85524 939.68972 L 913.99977 954.7112 L 902.66579 953.87917 C 874.83534 951.83604 854.66579 962.1382 854.66579 978.39675 C 854.66579 981.57473 855.26329 985.28913 855.99196 986.65066 C 857.08989 988.70216 856.53406 989.60995 852.75173 991.94753 C 847.19294 995.38305 841.33376 1006.4756 841.33376 1013.5628 C 841.33376 1016.3344 840.13557 1020.566 838.67165 1022.9671 C 833.27659 1031.8159 836.50166 1042.0161 848.47829 1053.9768 C 852.24805 1057.7416 858.85405 1062.5422 863.15798 1064.6448 C 870.36662 1068.1665 871.44158 1068.3458 876.77907 1066.9182 C 882.55439 1065.3735 882.59978 1065.3902 891.22438 1071.9182 C 911.25807 1087.0818 932.66967 1096.6993 953.96852 1100.1018 C 962.92662 1101.5329 981.2654 1100.4324 991.24196 1097.8655 C 1012.9367 1092.2836 1031.8709 1078.4374 1045.6599 1058.0725 C 1051.475 1049.4842 1049.9926 1042.5533 1041.906 1040.5237 C 1038.8494 1039.7566 1038.6658 1039.1654 1038.6658 1030.0921 C 1038.6658 1016.4295 1035.7491 1009.0056 1026.781 999.84206 C 1015.4809 988.29588 1014.7713 988.20439 962.33376 991.4866 C 954.1273 992.00018 948.01955 991.87386 948.04665 991.19167 C 948.07264 990.53636 948.95182 988.49961 949.99977 986.66628 C 952.44029 982.39711 952.52615 974.56341 950.16774 971.33816 C 948.49041 969.04418 949.71846 967.4751 964.72048 952.75027 C 980.39001 937.3701 981.16812 936.34722 982.53298 929.33425 C 984.30095 920.24999 986.66579 890.88974 986.66579 878.02566 L 986.66579 868.43777 L 994.87282 866.15652 C 999.3862 864.90169 1007.8698 862.02627 1013.7263 859.76785 L 1024.3748 855.66238 L 1023.5447 843.49831 L 1022.7146 831.33425 L 1025.3806 834.66628 C 1029.5643 839.89625 1039.9077 858.53456 1043.449 867.22683 C 1045.2178 871.56827 1050.2815 889.8677 1054.7009 907.89285 C 1067.5702 960.37298 1067.7996 961.18096 1073.1873 972.678 C 1080.0373 987.29554 1087.8225 998.59891 1099.2361 1010.4964 C 1118.5158 1030.5921 1134.8641 1038.8555 1155.3338 1038.8655 C 1179.256 1038.8732 1198.7834 1027.4231 1207.865 1008.0608 C 1210.9748 1001.4307 1211.3214 999.15129 1211.2166 986.00027 C 1211.1124 972.91458 1210.6363 970.08888 1206.7986 959.78152 C 1199.819 941.03556 1191.9822 929.39486 1180.8006 921.16238 C 1172.5227 915.06813 1171.0962 916.60449 1177.9529 924.23074 C 1186.4794 933.71421 1194.2286 947.18989 1199.1091 961.02761 C 1202.5641 970.82201 1203.2224 974.6751 1203.2634 985.33425 C 1203.32 1000.0397 1200.5279 1007.4722 1191.5877 1016.4124 C 1166.9704 1041.0297 1121.127 1030.3947 1095.3865 994.09402 C 1082.7969 976.33964 1078.7775 965.11329 1065.3435 910.20339 C 1052.0529 855.87938 1047.0089 844.12456 1028.2341 823.71511 L 1018.4685 813.09988 L 1026.3123 804.88308 C 1068.4869 760.69824 1078.8133 699.48778 1051.1287 657.77956 C 1040.041 641.07532 1022.1743 626.70957 1002.2869 618.51003 C 992.98991 614.677 991.54836 613.3975 959.33376 580.37917 C 941.00059 561.5886 925.99978 545.7902 925.99977 545.27175 C 925.99978 544.75329 931.66499 540.53831 938.58962 535.90652 C 969.76663 515.05256 990.46172 484.2053 992.82399 455.06081 C 993.88361 441.98834 993.80426 442.08932 999.94704 445.96706 C 1002.8824 447.82012 1009.9455 450.93154 1015.6424 452.88308 C 1030.8336 458.08716 1048.2466 457.93437 1064.0584 452.45535 C 1070.3242 450.28415 1078.8802 446.22988 1083.072 443.44753 C 1098.5255 433.19016 1111.656 414.50497 1115.947 396.66628 C 1118.221 387.21284 1117.9022 369.31764 1115.2986 360.29714 C 1102.0459 314.38124 1049.9702 293.34985 1006.2478 316.25613 C 993.46036 322.9556 978.88167 338.21337 972.50954 351.56863 L 967.30837 362.47292 L 962.90993 357.23464 C 960.23063 354.04336 958.90782 351.34419 959.52517 350.33035 C 960.08252 349.41497 975.22105 331.86743 993.16579 311.33425 C 1011.1107 290.80108 1025.9516 273.78957 1026.1443 273.53152 C 1026.3371 273.27347 1029.3829 273.98151 1032.9138 275.10574 C 1053.8034 281.757 1069.222 277.59811 1086.1228 260.75613 C 1110.9192 236.04579 1113.5208 200.26916 1091.9334 180.85964 C 1085.883 175.41992 1085.3338 174.42665 1085.3338 168.93581 C 1085.3338 154.6141 1074.9965 131.68974 1062.9978 119.40066 C 1046.8462 102.85802 1029.0537 91.878106 1012.8338 88.441674 C 1009.4937 87.734048 1006.1983 87.295714 1002.9705 87.117455 z M 381.52321 303.97097 L 387.67556 308.31863 C 391.05976 310.7101 397.32606 315.96694 401.60134 320.00027 L 409.37477 327.33425 L 407.26931 334.00027 C 402.64926 348.62352 395.78006 386.01988 388.08767 438.42019 C 383.63991 468.71791 379.99977 493.76753 379.99977 494.0862 C 379.99978 494.40493 378.49913 494.66628 376.66579 494.66628 C 374.83246 494.66628 373.33376 494.2019 373.33376 493.63503 C 373.33376 492.20405 359.42604 467.28371 345.09352 443.03152 L 333.09548 422.73074 L 338.49001 402.99636 C 349.08493 364.22796 360.94406 334.89879 373.89431 315.43581 L 381.52321 303.97097 z M 441.75173 415.91433 C 441.79546 415.9036 441.82864 415.93152 441.85329 416.00027 C 444.35388 422.973 450.59352 464.44245 452.70681 488.14089 C 453.52358 497.30025 453.37102 498.35536 451.13845 499.03542 C 449.77885 499.44956 446.23533 501.30016 443.26345 503.14675 L 437.85915 506.50417 L 433.07985 501.428 C 430.02775 498.18703 426.58597 496.03114 423.55837 495.46316 L 418.81813 494.57449 L 420.80837 488.95339 C 423.82875 480.42558 429.02283 461.80187 435.39235 436.66628 C 438.35405 424.97883 441.09568 416.07534 441.75173 415.91433 z M 322.72243 496.01785 C 323.55884 496.00066 325.37276 498.04354 327.97438 501.9612 L 332.93142 509.42605 L 330.68923 517.61745 C 329.19125 523.08981 327.5984 526.14137 325.8904 526.81081 C 319.71331 529.23192 319.5957 528.92889 320.62087 513.1116 C 321.15157 504.92329 321.90913 497.38475 322.30251 496.35964 C 322.38913 496.1339 322.52941 496.02181 322.72243 496.01785 z M 633.46267 499.14675 C 633.5996 499.1086 633.72226 499.11163 633.82595 499.15652 C 634.65542 499.51561 643.07449 503.19378 652.53688 507.33035 C 669.96447 514.94887 708.428 528.35645 717.75563 530.06472 C 722.33506 530.9034 723.16549 531.71729 726.01931 538.17019 C 727.76378 542.11494 732.21346 548.53722 735.90798 552.44363 C 742.22289 559.12073 754.60626 566.66628 759.24977 566.66628 C 761.4735 566.66628 761.94775 568.96875 760.26931 571.60964 C 759.27462 573.17468 736.34345 575.11738 629.33376 582.7073 C 608.43393 584.18968 579.57309 585.7788 565.19899 586.23855 L 539.06423 587.07449 L 538.09352 557.42019 C 537.55959 541.11066 537.39101 527.4977 537.72048 527.16824 C 538.04994 526.83877 543.04723 528.21992 548.82595 530.23855 C 558.08196 533.47191 561.31719 533.91555 575.99977 533.95535 C 591.90722 533.99851 593.06187 533.81317 601.35915 529.88113 C 611.98021 524.84776 625.46731 512.65193 629.40212 504.5237 C 630.80485 501.62612 632.50412 499.41384 633.46267 499.14675 z M 455.66579 560.0198 C 456.8836 560.00488 457.33376 563.41095 457.33376 572.66628 L 457.33376 585.33425 L 453.58181 585.33425 L 449.8279 585.33425 L 450.20681 573.77175 C 450.57736 562.4194 451.50775 560.0707 455.66579 560.0198 z M 449.43923 621.33425 C 452.22751 621.33425 454.77376 621.78425 455.09743 622.33425 C 455.42111 622.88425 455.08339 632.63362 454.34743 644.00027 C 453.61147 655.36692 452.63275 665.05335 452.17165 665.52566 C 451.71055 665.99796 447.67113 660.75615 443.19509 653.87722 C 435.88483 642.64262 435.24144 641.10589 436.87087 638.77956 C 437.86856 637.35517 439.96364 632.84758 441.52712 628.76199 C 444.28804 621.54726 444.51544 621.33425 449.43923 621.33425 z M 320.39626 652.01589 C 320.89606 651.989 321.5917 652.31505 322.4822 652.50808 C 324.41662 652.92741 330.4998 653.96461 335.99977 654.81277 C 341.49977 655.66093 346.18419 656.51035 346.40993 656.69949 C 346.63567 656.88863 342.25598 669.83875 336.67751 685.47683 C 326.5881 713.76032 325.33381 716.82855 325.33181 713.22292 C 325.33136 712.18403 324.18046 700.83354 322.77321 688.00027 C 319.34269 656.71556 318.61127 652.11194 320.39626 652.01589 z M 392.42165 652.46706 C 392.60918 652.27953 395.07596 657.64817 397.90212 664.39675 C 407.38558 687.04252 424.90529 721.89932 432.4861 733.20339 C 436.61868 739.36564 439.99977 745.1686 439.99977 746.09792 C 439.99977 749.50561 431.59528 771.67676 425.74196 783.70925 C 414.12472 807.59061 401.99787 822.96332 391.22829 827.46316 C 385.56571 829.82913 376.35529 829.78203 371.91188 827.3655 C 367.9168 825.19277 358.66579 811.83483 358.66579 808.23855 C 358.66579 806.88066 361.68343 792.3217 365.37087 775.88503 C 369.05831 759.44843 376.57651 725.03222 382.0779 699.40456 C 387.57928 673.77697 392.23412 652.65459 392.42165 652.46706 z "
                    transform="translate(-123.17165,-87.025658)" />
                <path id="path9" style="fill:#ffcc00"
                    d="M 599.99977 919.37917 C 592.88019 919.38417 588.65623 920.09312 585.33376 921.84011 C 568.94925 930.45524 560.94625 950.87331 567.92751 966.25027 C 574.54689 980.83016 604.94602 991.80018 655.33376 997.79128 C 664.70859 998.90595 724.65267 998.5256 739.33376 997.25808 C 760.17764 995.45847 764.87558 994.10494 770.77907 988.20144 C 778.25772 980.72279 779.4321 966.05789 773.18923 958.12136 C 770.71796 954.97965 770.39263 954.91695 766.00954 956.74831 C 760.45452 959.06934 753.49226 959.21311 748.4197 957.1116 C 744.71946 955.57863 744.7616 955.54374 751.38454 954.62527 C 763.08206 953.00305 770.66579 947.34319 770.66579 940.2366 C 770.66579 933.65969 758.32457 925.36587 748.49782 925.34011 C 745.90991 925.33311 745.71857 925.88743 746.32009 931.66628 C 746.75349 935.83005 747.89371 938.72809 749.64821 940.12527 C 752.23563 942.18576 752.13963 942.32223 746.49196 944.5862 C 733.62756 949.74315 719.35089 948.27416 710.06227 940.83816 C 706.15227 937.70799 706.14456 937.67805 709.11696 936.73464 C 711.074 936.1135 711.89524 935.01396 711.48806 933.55886 C 711.1455 932.33467 710.48537 929.4416 710.02126 927.12917 C 709.19222 922.99844 709.09174 922.94782 704.25563 924.27566 C 694.50937 926.95166 683.99978 934.21775 683.99977 938.27956 C 683.99977 939.25874 686.47695 942.74596 689.50368 946.02956 L 695.00563 952.00027 L 691.03298 952.00027 C 685.694 952.00027 678.33459 946.83067 676.73806 941.95925 C 676.02447 939.78194 675.36467 937.84858 675.27126 937.66238 C 675.17786 937.47618 670.36294 936.72276 664.57204 935.98855 C 658.14586 935.17379 645.46173 931.67558 632.02126 927.01199 C 612.79573 920.34108 608.73016 919.3725 599.99977 919.37917 z M 905.99977 961.22488 L 893.33376 961.7073 C 869.37278 962.62071 855.81679 973.0079 863.42751 984.62331 C 864.57956 986.38157 869.52956 990.4025 874.42751 993.55886 C 883.24204 999.23918 883.29074 999.30197 879.1072 999.72488 C 876.52716 999.98569 872.33982 998.86508 868.35915 996.84792 L 861.83767 993.54324 L 857.66579 996.18581 C 853.20619 999.00944 847.99977 1008.1963 847.99977 1013.2425 C 847.99977 1020.7628 870.28309 1043.5447 886.90993 1053.0237 C 899.62008 1060.2697 933.26361 1072.9702 947.99977 1076.0843 C 962.05419 1079.0543 971.53934 1079.2062 982.42946 1076.6389 C 1002.2752 1071.9602 1021.4012 1058.6075 1027.7263 1045.0139 C 1032.1654 1035.4739 1031.8585 1021.4947 1026.9998 1011.9143 C 1022.6648 1003.3665 1014.5787 996.75274 1006.9783 995.53738 C 1004.0502 995.06915 995.35603 995.57168 987.65602 996.65261 C 979.95601 997.7335 966.23178 998.66992 957.15993 998.73464 C 948.08809 998.79934 938.21862 999.45563 935.22634 1000.1936 C 932.23405 1000.9315 927.73404 1001.3294 925.22634 1001.0764 C 920.70639 1000.6205 920.74233 1000.5804 929.41384 996.50613 C 939.02547 991.99012 944.01164 986.84932 943.98024 981.4866 C 943.93674 974.05778 942.06252 973.83713 934.42556 980.3616 C 921.11835 991.73029 902.46685 992.35254 888.66579 981.88894 C 886.09238 979.93785 886.3495 979.54245 895.99977 970.54714 L 905.99977 961.22488 z M 566.65602 979.40066 C 564.92135 979.46169 563.65662 980.61562 562.22634 982.88308 C 556.23188 992.38626 578.62991 1005.0522 606.54665 1007.9456 C 621.35513 1009.4804 675.77741 1008.2068 679.33376 1006.2425 C 681.43588 1005.0814 676.21251 1004.2848 654.66579 1002.4807 C 612.88829 998.98261 591.64169 993.71735 573.90798 982.47097 C 570.59567 980.37036 568.3907 979.33963 566.65602 979.40066 z M 768.59938 997.42019 C 768.15891 997.39411 767.49451 997.56661 766.54274 997.84206 C 756.46548 1000.7586 744.33383 1002.6536 731.35524 1003.3382 C 708.30184 1004.5541 704.84789 1005.1419 706.81813 1007.5159 C 713.308 1015.3357 729.24011 1017.2746 753.1072 1013.1487 C 762.9489 1011.4474 767.62156 1007.9827 768.87673 1001.4573 C 769.44702 998.49242 769.56842 997.47756 768.59938 997.42019 z M 846.61501 1023.7991 L 844.58181 1028.6643 C 842.2522 1034.2399 842.92639 1037.4205 847.79274 1043.8108 C 851.81761 1049.0961 864.10545 1058.7594 865.61501 1057.8264 C 866.19335 1057.469 866.66579 1054.2796 866.66579 1050.7405 C 866.66579 1045.3747 866.12197 1043.9501 863.38454 1042.1565 C 861.57906 1040.9735 857.06603 1036.3593 853.3572 1031.9026 L 846.61501 1023.7991 z M 1038.7322 1045.6702 C 1037.1881 1045.5067 1035.0813 1047.3316 1032.8924 1051.0667 C 1019.3255 1074.2168 983.48872 1089.0447 953.27126 1084.01 C 939.56102 1081.7257 919.27084 1074.8756 902.99977 1067.0393 C 895.48312 1063.4192 889.33376 1060.657 889.33376 1060.9007 C 889.33376 1061.1444 894.06093 1064.8503 899.83962 1069.135 C 919.0455 1083.3753 932.78523 1089.6787 949.5486 1091.9436 C 959.87332 1093.3385 977.77518 1092.4103 989.02907 1089.8948 C 1003.7539 1086.6035 1018.7068 1077.1954 1033.0896 1062.1741 C 1039.9032 1055.058 1041.4325 1052.6731 1041.0896 1049.6995 C 1040.7931 1047.128 1039.9332 1045.7974 1038.7322 1045.6702 z M 875.96657 1052.2053 C 874.95512 1052.1562 874.66579 1053.3578 874.66579 1056.0003 C 874.66579 1060.4064 877.22803 1061.3413 880.03493 1057.9593 C 881.43599 1056.2712 881.28996 1055.5845 879.19704 1054.0003 C 877.68804 1052.8581 876.65862 1052.239 875.96657 1052.2053 z "
                    transform="translate(-123.17165,-87.025658)" />
                <path id="path13" style="fill:#d40000"
                    d="m 987.33376,618.00027 -25.33399,0.0977 c -20.38685,0.0786 -28.58758,0.69609 -42,3.16016 -36.20502,6.65142 -82.29237,22.73444 -101.88085,35.55273 l -9.84766,6.44336 -6.71484,25.37305 c -8.93713,33.7761 -9.96506,39.27969 -9.96485,53.37305 2.2e-4,14.49605 2.85714,26.28753 9.13086,37.70117 2.53634,4.61429 4.61133,8.6703 4.61133,9.01172 0,0.34143 -1.3486,0.62109 -2.99609,0.62109 -5.5408,0 -23.67188,6.77204 -23.67188,8.8418 0,6.40762 8.9074,15.59899 25.55078,26.36719 15.29998,9.89901 29.33011,16.97726 40.86328,20.61718 l 9.42578,2.97461 5.23633,-2.66992 c 5.83489,-2.97674 13.5918,-9.12362 13.5918,-10.77148 0,-0.58865 -1.6513,-1.47766 -3.66797,-1.97461 -4.66795,-1.15027 -18.44881,-8.90502 -23.66602,-13.31641 l -4,-3.38086 7.78321,3.35742 c 12.31855,5.31389 32.0907,9.90218 49.89453,11.58008 14.01965,1.32126 16.28358,1.85022 15.52148,3.62695 -3.26001,7.60029 -4.42328,12.17575 -4.47461,17.61329 l -0.0586,6.20117 6.50781,1.56054 c 18.04099,4.32797 49.2572,4.66597 68.16016,0.73829 5.49999,-1.14279 14.43112,-3.37778 19.84764,-4.96875 l 9.8477,-2.89454 -0.7578,-16.75195 c -0.4176,-9.21352 -1.381,-18.77734 -2.1387,-21.2539 -1.3101,-4.28172 -1.0578,-4.86167 5.1269,-11.80079 33.0875,-37.12336 47.6873,-80.71459 38.7442,-115.68164 -6.6325,-25.93302 -26.7486,-47.6803 -60.00393,-64.86914 z m -73.30274,40.82422 c 18.08759,0.51312 34.88765,15.73719 32.03711,33.78711 -2.82691,17.90036 -24.44713,27.4407 -42.80859,18.89062 -13.42104,-6.24955 -21.33457,-20.47751 -18.10547,-32.55078 2.27992,-8.52435 5.84708,-12.8812 13.7832,-16.83594 4.8634,-2.42353 10.02923,-3.43469 15.09375,-3.29101 z m -86.22656,38.58398 c 13.43775,0.21125 26.09906,10.65941 26.13477,26.73242 0.0431,19.38329 -19.73629,32.11749 -37.27344,23.99805 -10.31295,-4.77474 -15.33203,-12.67802 -15.33203,-24.13867 0,-7.97878 1.74704,-12.83515 6.41797,-17.83594 5.76236,-6.16931 13.01391,-8.86651 20.05273,-8.75586 z"
                    transform="translate(-123.17165,-87.025658)" />
                <path id="path17" style="fill:#ffcc00"
                    d="M 912.52517 664.3616 C 904.91543 664.58677 897.58548 668.199 893.60915 676.00027 C 883.89226 695.06409 909.0063 715.20521 928.66188 704.1116 C 934.41592 700.86402 938.66579 693.91269 938.66579 687.75027 C 938.66579 673.01999 925.20805 663.98631 912.52517 664.3616 z M 827.50563 702.8362 C 824.56892 702.78278 821.5765 703.62314 818.08767 705.35183 C 811.01562 708.85597 807.71 713.61089 806.96657 721.34792 C 806.1571 729.77219 809.41618 736.409 816.49587 740.75417 C 823.27773 744.91656 832.12852 744.65694 838.51735 740.10769 C 850.76565 731.38614 849.74391 713.13943 836.59157 705.68972 C 833.32256 703.8381 830.44235 702.88963 827.50563 702.8362 z "
                    transform="translate(-123.17165,-87.025658)" />
                <path style="fill:#ff0000"
                    d="m 800.71982,537.93086 c 15.39865,-4.00942 37.64375,-17.81088 51.16245,-31.74258 4.93955,-5.09046 5.61259,-6.38702 4.19935,-8.08987 -5.54102,-6.67652 -39.61948,-1.74624 -60.415,8.7405 -9.13421,4.60619 -9.95545,2.86446 -2.07828,-4.40771 8.39517,-7.75037 6.31021,-8.9371 -16.96043,-9.65362 -10.24538,-0.31547 -21.68983,-0.98509 -25.43213,-1.48804 l -6.80417,-0.91447 -0.8625,4.31247 c -1.33009,6.65047 -1.04676,10.86619 1.25931,18.73713 2.64565,9.02997 14.19116,21.06101 23.29642,24.27614 7.7187,2.72552 22.64667,2.83075 32.63498,0.23005 z"
                    id="path37" transform="translate(-123.17165,-87.025658)" />
                <path id="path27" style="fill:#e3dbdb"
                    d="M 851.53688 300.10183 C 849.65999 300.02546 847.75662 300.02739 845.83181 300.1116 C 841.43223 300.30407 836.919 300.92341 832.34352 302.00222 C 818.49989 305.26629 800.33248 314.7189 785.33376 326.4612 L 781.99977 329.07058 L 782.46657 323.20144 C 782.84537 318.44738 782.51677 317.33425 780.73415 317.33425 C 775.83272 317.33425 757.77318 329.14992 746.16579 339.95144 L 739.66579 346.00027 L 743.49977 346.6741 C 747.02474 347.2934 747.36637 347.86545 747.74392 353.77761 C 748.31888 362.78101 742.33213 375.17573 732.80837 384.69949 L 725.50563 392.00027 L 728.77126 395.88113 C 732.03492 399.75975 735.99978 407.91582 735.99977 410.75027 C 735.99977 411.57654 733.87172 409.6453 731.27126 406.45925 C 716.19329 387.98596 692.22573 374.3937 674.24977 374.12331 C 664.68305 373.97941 665.02363 372.95973 668.84157 390.28738 C 671.23817 401.1642 671.2355 401.26724 668.49392 404.95339 C 665.07396 409.55164 657.33367 410.49236 648.28298 407.40847 C 644.53628 406.13185 641.66912 405.79772 640.91774 406.5491 C 639.06567 408.40117 642.30406 424.70786 645.95485 431.91238 C 656.28924 452.30633 683.68552 470.39187 716.97438 478.7991 C 742.05063 485.13218 760.95756 487.0694 789.33376 486.20925 C 833.70273 484.86432 859.75789 476.78007 879.62477 458.19558 C 884.23108 453.8866 887.99978 450.95767 887.99977 451.68777 C 887.99977 454.46723 880.87196 471.79488 875.25563 482.66628 C 853.91101 523.98262 810.49118 552.06931 776.38845 546.62136 C 759.62487 543.94336 744.34713 532.50627 740.01931 519.39285 C 738.07449 513.49997 737.69159 503.806 739.08181 495.66628 L 740.16384 489.33425 L 736.25563 489.33425 C 732.74011 489.33425 732.16063 489.96959 730.50563 495.66628 C 729.49368 499.14961 728.68631 507.40027 728.71071 514.00027 C 728.74801 524.08755 729.31307 527.20592 732.25759 533.56667 C 738.59131 547.24885 751.32147 558.32101 765.24001 562.25613 C 774.50946 564.87682 798.63623 563.68132 808.78884 560.09792 C 816.02635 557.54344 825.87799 552.34804 841.83767 542.67019 L 847.00954 539.53347 L 845.4236 542.49831 C 844.55105 544.12869 840.21409 548.27513 835.78688 551.71316 L 827.73806 557.96511 L 832.86892 559.09988 C 839.64915 560.60036 863.5687 559.28264 875.64431 556.74245 C 902.98796 550.99055 929.40592 537.13189 951.33767 517.03542 C 985.51251 485.72037 988.95749 447.52008 960.34352 417.18777 C 950.44504 406.69486 937.79922 399.58192 924.85915 397.23074 C 908.40785 394.24156 894.24086 399.53754 862.17556 420.66042 C 860.07267 422.04569 865.17333 416.31297 873.50954 407.92214 C 896.35982 384.92219 905.01114 367.6127 903.71852 347.47097 C 901.96492 320.14611 879.69034 301.24735 851.53688 300.10183 z M 786.51735 356.00027 C 787.96085 356.00027 790.15614 357.0121 791.39431 358.25027 C 796.6268 363.48276 789.03207 385.27614 776.69899 400.41628 C 765.32545 414.37851 750.96206 420.45906 747.96657 412.58035 C 746.15662 407.8198 746.2924 406.35806 749.40798 397.10964 C 755.96671 377.64033 775.50104 356.00027 786.51735 356.00027 z M 897.23024 422.81081 C 900.46086 422.82251 903.72908 423.27653 906.85524 424.21316 C 912.4393 425.88618 921.76387 433.15469 924.22438 437.75222 C 926.16078 441.37041 927.99513 449.36519 926.85915 449.23464 C 926.38638 449.18034 922.66178 445.62945 918.58181 441.34402 C 912.48756 434.94286 909.77375 433.14843 903.37868 431.28933 C 894.45774 428.69594 886.14746 429.32471 878.34743 433.18386 C 872.67525 435.99025 872.01599 435.24954 876.19313 430.76589 C 880.96329 425.64574 888.97423 422.78096 897.23024 422.81081 z M 847.53298 575.66042 C 846.80241 575.57291 845.0955 577.05424 841.66579 580.56081 C 831.67719 590.77324 819.4434 595.27404 793.33376 598.33816 L 783.33376 599.51199 L 787.99977 601.70339 C 794.06632 604.55304 797.22727 604.519 813.14235 601.43386 C 826.13244 598.91573 833.80633 595.85588 839.56227 590.90066 C 843.47015 587.53641 847.98975 579.93169 847.99587 576.70925 C 847.99712 576.06345 847.86505 575.7002 847.53298 575.66042 z "
                    transform="translate(-123.17165,-87.025658)" />
                <path id="path46" style="fill:#5599ff"
                    d="M 988.24977 154.85378 L 966.07009 178.26394 C 953.87148 191.1392 944.11431 202.34193 944.38649 203.15847 C 945.59844 206.79431 953.69202 209.65146 964.73024 210.34011 L 976.03102 211.04519 L 972.46462 217.18972 C 962.31231 234.67553 948.79269 248.15827 934.19313 255.35769 C 917.93273 263.37612 900.641 262.98612 897.96071 254.54128 C 897.11337 251.87157 896.78115 251.99547 891.75173 256.85964 C 888.82892 259.68642 880.40875 268.46477 873.04079 276.3655 C 860.32799 289.99755 859.75667 290.85438 861.86306 293.18191 C 863.08386 294.53088 869.22161 297.30699 875.50173 299.34988 C 900.16671 307.37329 925.30267 322.20894 947.33376 341.74636 L 952.66579 346.47488 L 955.46852 343.57058 C 957.00961 341.97311 979.75405 316.06691 1006.0115 286.00027 C 1032.2689 255.93363 1055.1686 229.78818 1056.9002 227.90066 L 1060.0486 224.46902 L 1055.8279 216.28347 C 1052.559 209.94535 1051.4636 205.8763 1050.9744 198.25417 L 1050.3416 188.41042 L 1040.6814 186.13308 C 1025.3004 182.507 1004.7501 171.71684 995.7947 162.56472 L 988.24977 154.85378 z M 776.90212 241.91042 C 770.80311 241.73177 765.60574 244.00313 761.45485 248.73074 C 758.06161 252.59543 757.33376 254.56703 757.33376 259.88308 C 757.33376 263.43467 758.18739 268.38641 759.2322 270.88699 C 761.62341 276.60998 771.56516 290.01808 777.49196 295.51199 C 780.97903 298.74436 788.16449 303.49683 790.24587 303.94753 C 790.38146 303.97693 792.05156 303.40823 793.95681 302.68386 C 801.73274 299.72745 825.58471 295.62057 839.53884 294.8362 L 854.41188 294.00027 L 830.32204 274.66628 C 817.07205 264.03295 802.42048 252.84114 797.76345 249.79519 C 790.00179 244.71863 783.00113 242.08908 776.90212 241.91042 z "
                    transform="translate(-123.17165,-87.025658)" />
                <path style="fill:#ffcc00"
                    d="m 932.72494,250.1011 c 7.42409,-3.66918 11.96335,-7.22505 19.47752,-15.25791 5.38861,-5.76058 10.84809,-12.30051 12.13218,-14.53318 l 2.33469,-4.0594 -7.00136,-0.92341 c -3.85075,-0.50787 -9.67263,-2.08417 -12.93752,-3.50287 l -5.93616,-2.57947 -4.86473,5.04424 c -2.6756,2.77433 -11.67607,12.17013 -20.00105,20.87955 l -15.13632,15.83531 3.27054,2.65122 c 4.90651,3.97738 16.27584,2.5676 28.66221,-3.55408 z"
                    id="path47" transform="translate(-123.17165,-87.025658)" />
                <path id="path43" style="fill:#ffb380"
                    d="M 471.09157 133.8948 C 469.09201 133.92595 467.12087 134.18506 465.2322 134.69363 C 458.08331 136.61862 449.00349 145.09706 445.58767 153.03738 C 443.08599 158.85268 440.08181 175.46003 437.91579 195.45535 L 437.03688 203.57839 L 443.32204 208.72878 C 451.21342 215.19518 462.20665 229.16842 469.53298 242.04519 C 472.63064 247.48963 475.33553 251.77584 475.54274 251.56863 C 475.74994 251.36143 480.21463 235.923 485.46462 217.26199 C 498.39096 171.31547 498.97532 168.66517 498.41774 158.5198 C 498.02547 151.38208 497.2276 148.7801 494.22243 144.84011 C 488.94891 137.92617 479.75634 133.75979 471.09157 133.8948 z M 359.2986 197.33425 C 337.0164 197.33425 317.28645 204.08578 298.87868 218.01199 C 285.99174 227.76148 269.211 249.49989 258.00954 270.95339 L 254.03102 278.57253 L 263.60134 297.61941 C 278.9369 328.1432 279.38045 334.36955 267.06227 346.20535 C 263.05886 350.05197 257.65999 353.89813 255.06618 354.75417 C 248.45585 356.93578 239.54739 355.60457 233.3572 351.50808 L 228.09548 348.02566 L 226.16188 354.53542 C 219.09089 378.34603 208.11261 442.24055 203.45876 486.66628 C 199.61983 523.31264 196.06497 597.90598 197.88454 603.63894 C 198.65341 606.06145 199.32017 606.19391 205.03298 605.07058 C 212.58513 603.58557 223.69772 604.61561 230.43142 607.4241 C 236.6589 610.02144 243.78546 616.75755 246.15993 622.29128 C 248.86298 628.59077 248.49445 640.46975 245.40993 646.51589 C 241.62817 653.92877 230.2217 663.64728 215.49782 672.00027 L 202.57009 679.33425 L 203.36306 688.00027 C 204.60224 701.54156 210.51646 739.07624 214.09743 756.12722 C 221.87441 793.15796 233.45811 828.17476 247.37087 856.70925 C 254.54361 871.42027 266.82361 892.35975 270.7029 896.49636 C 271.30311 897.13638 273.78485 895.39318 276.21852 892.62136 C 286.99316 880.34973 305.28236 879.34696 316.59548 890.40847 C 323.46905 897.12917 325.527 909.9118 322.80837 929.00027 L 321.81227 936.00027 L 347.7947 936.00027 C 362.08541 936.00027 373.52058 935.74373 373.20681 935.42995 C 372.89304 935.1162 367.89195 931.76209 362.09352 927.97683 C 340.4266 913.8325 330.14385 901.08711 312.83962 866.9241 C 290.00321 821.83915 281.91508 795.30736 273.34743 737.38308 C 264.70015 678.92048 262.04302 637.30132 263.08376 576.66628 C 265.52852 434.23053 287.75603 317.12469 324.76149 251.72488 C 338.20373 227.96839 351.91869 211.71721 366.63649 202.10378 L 373.93923 197.33425 L 359.2986 197.33425 z M 397.18337 198.03738 C 384.97101 198.43573 372.97037 202.99971 362.36501 211.80691 C 316.83288 249.61898 284.27592 349.6859 272.71852 487.33425 C 264.72824 582.4983 266.46492 654.47003 278.7654 737.8655 C 286.6143 791.07995 294.64679 817.9923 314.74587 858.41628 C 329.75057 888.59426 335.17902 897.22132 346.13259 908.28152 C 355.51923 917.75953 373.86386 930.30187 383.24977 933.66042 C 393.13454 937.19748 403.63218 936.15337 416.03688 930.3987 C 441.17728 918.73586 458.86494 898.35885 478.1111 858.88699 C 495.33267 823.56736 506.55323 789.83966 514.55642 749.33425 C 521.2217 715.6001 533.52965 623.75281 531.63845 621.8616 C 531.24059 621.46375 524.63677 621.55848 516.96267 622.07253 L 503.00954 623.00808 L 501.4197 639.17019 C 492.42878 730.58934 479.02397 780.33515 452.86892 819.33425 C 445.30941 830.606 432.53831 843.00074 423.96267 847.38894 C 413.17536 852.90885 397.74686 853.60605 387.74196 849.02566 C 383.78365 847.21348 378.28389 843.74403 375.51931 841.31667 C 364.59462 831.72467 346.04473 801.67346 335.93727 777.19167 C 325.05031 750.82181 317.67121 706.95362 313.21852 642.12527 C 309.2198 583.90631 314.82943 488.99745 325.41384 435.81277 C 333.93998 392.9705 349.92231 345.43836 363.77517 321.71902 C 381.39235 291.55423 397.26304 280.62508 418.44509 284.07253 C 429.47237 285.86727 437.11243 290.23281 447.44509 300.6448 C 455.35041 308.61081 458.23069 312.86642 465.11306 326.74831 C 478.94741 354.65264 489.27049 390.03177 495.24001 430.00027 C 501.51336 472.00303 507.24829 544.65489 506.44899 572.00027 L 505.99977 587.33425 L 519.87868 587.71511 L 533.75954 588.09792 L 532.86306 559.28152 C 531.65549 520.42785 528.42227 465.09223 525.93142 440.66628 C 519.24167 375.0653 504.50503 323.7107 475.96071 266.51785 C 463.53426 241.61957 454.31136 227.83687 442.82399 217.00027 C 428.93774 203.90066 412.88496 197.52521 397.18337 198.03738 z M 205.07204 224.35183 C 202.88375 224.34898 200.54171 224.64858 197.96657 225.22488 C 183.69661 228.41835 174.28493 239.23703 174.28493 252.44949 C 174.28493 262.76004 178.91959 271.00036 207.77907 312.00027 C 213.71521 320.43359 221.00872 330.80675 223.9861 335.05105 C 233.46435 348.56246 247.24652 354.33074 256.03688 348.46706 C 263.11905 343.74286 269.33253 336.69661 270.12087 332.49441 C 271.32421 326.08007 269.51463 321.62318 248.31813 278.77761 C 232.86006 247.53142 227.66963 238.27379 222.79079 233.24441 C 216.82184 227.09128 211.63691 224.36038 205.07204 224.35183 z M 412.43532 288.47292 C 410.62359 288.41392 408.84001 288.51073 407.09938 288.77175 C 400.81783 289.71373 387.33376 297.10436 387.33376 299.60574 C 387.33376 300.47427 392.63678 305.4753 399.11892 310.71902 C 410.68442 320.07493 410.94171 320.20208 412.86696 317.45339 C 417.40798 310.9702 429.90065 308.64003 439.22829 312.53738 C 445.87808 315.31583 454.30174 323.52204 456.10134 328.97488 C 458.50678 336.26343 456.81481 349.80307 450.11892 376.86745 L 444.13259 401.06863 L 448.57595 422.86745 C 451.01989 434.85682 454.01729 453.36696 455.2361 464.00027 C 459.1682 498.3052 458.40139 495.0223 462.25563 494.05495 C 471.66073 491.69443 472.6522 491.81493 479.11501 496.11355 C 487.17331 501.47335 491.55017 507.98474 493.44704 517.42995 C 496.42555 532.261 488.89322 544.09791 471.01735 552.67605 L 462.70095 556.66628 L 462.68337 571.62136 L 462.66579 586.57644 L 476.99977 587.00417 C 484.8831 587.2399 493.23953 587.56132 495.57009 587.71706 C 499.77358 587.99798 499.81498 587.93959 500.7654 580.33425 C 503.77789 556.22806 494.81395 451.89592 485.84352 406.66628 C 477.87985 366.51278 463.82341 329.77597 448.75759 309.7366 C 439.13232 296.93382 425.11745 288.88597 412.43532 288.47292 z M 428.92946 315.80105 C 424.83464 315.65715 421.13294 316.70989 418.9861 319.00027 C 412.45069 325.97264 404.45097 363.34191 393.4236 438.42019 C 388.97351 468.71806 385.33376 493.78953 385.33376 494.13308 C 385.33376 494.47662 391.73709 494.58732 399.56423 494.37917 L 413.79665 494.00027 L 418.30837 479.33425 C 422.69067 465.09272 441.66868 390.54853 448.57985 360.42995 C 454.39975 335.06716 453.07523 327.7367 441.23024 319.78152 C 437.51314 317.28507 433.0243 315.94495 428.92946 315.80105 z M 331.84157 432.01003 C 330.87184 431.99833 325.78582 463.1272 324.53102 476.75417 L 323.66188 486.17605 L 336.59157 505.08816 L 349.52126 524.00027 L 358.42751 524.13308 C 363.32563 524.20618 368.83246 524.74326 370.66579 525.32644 C 375.82098 526.96629 376.63552 526.25153 377.06618 519.70925 C 377.41623 514.39164 376.24256 511.21684 367.72438 494.47878 C 357.25014 473.89708 333.19892 432.02632 331.84157 432.01003 z M 471.35134 497.9612 C 465.76395 497.84082 447.55144 505.53594 440.32985 511.29324 C 440.14462 511.44092 441.19014 515.04001 442.65212 519.28933 C 444.1141 523.53864 446.33851 533.5371 447.59743 541.50808 C 448.85635 549.47907 450.50864 556.00027 451.26735 556.00027 C 452.02605 556.00027 458.31354 553.18778 465.24001 549.75027 C 486.66239 539.11862 491.94191 530.98877 487.4529 515.54714 C 485.31035 508.17703 478.17209 499.96005 472.29274 498.09402 C 472.03947 498.01363 471.72383 497.96923 471.35134 497.9612 z M 394.1111 500.00027 C 384.88334 500.00027 377.33376 500.25104 377.33376 500.55691 C 377.33376 500.86278 378.57783 504.01278 380.09938 507.55691 C 382.11072 512.24184 382.74829 516.11618 382.43337 521.75027 L 381.99977 529.49831 L 389.27907 534.51003 L 396.56032 539.52175 L 399.47438 527.98855 C 401.07786 521.64526 404.09892 513.20419 406.18727 509.22878 C 408.27563 505.25339 410.18864 501.55027 410.43727 501.00027 C 410.68592 500.45027 403.33885 500.00027 394.1111 500.00027 z M 422.59938 501.33425 C 420.43672 501.33425 417.48632 502.51373 416.0447 503.95535 C 411.56896 508.43107 406.67152 519.6284 403.79665 531.95535 L 401.03884 543.77566 L 405.51931 549.74441 C 407.98346 553.02772 410.68928 556.82784 411.53102 558.18972 C 412.94293 560.47401 413.18133 560.35636 414.61892 556.66628 C 422.34193 536.84242 437.33376 548.78952 437.33376 574.76785 C 437.33376 583.55084 437.98522 584.94261 442.22829 585.22878 C 443.08669 585.28668 444.20122 583.45061 444.70681 581.1487 C 446.05701 575.00121 444.18683 550.58494 441.23024 535.76589 C 436.92985 514.21136 429.96244 501.33425 422.59938 501.33425 z M 336.58962 515.94558 C 336.21886 515.96286 335.99495 516.2996 335.9822 517.00027 C 335.9722 517.55027 335.60211 519.35027 335.15993 521.00027 C 334.44983 523.64999 334.84882 524.00027 338.58571 524.00027 L 342.81813 524.00027 L 340.45485 520.00027 C 338.92836 517.41612 337.40528 515.90756 336.58962 515.94558 z M 213.20876 609.99245 C 206.17787 610.13213 198.13244 611.41921 189.99977 613.83425 C 176.43258 617.86311 149.23679 630.94074 139.56227 638.08816 C 132.63937 643.20273 128.079 651.11337 128.02907 658.09597 C 127.94697 669.57976 138.42337 684.9904 148.23415 687.81667 C 154.76231 689.69731 163.7352 689.54984 171.69118 687.43191 C 184.51565 684.01797 213.27097 668.81427 228.94509 657.16042 C 247.16194 643.61603 247.82964 622.36089 230.33181 613.03347 C 226.25628 610.86096 220.23965 609.85279 213.20876 609.99245 z M 413.81032 619.09792 L 411.04079 623.91042 C 408.47978 628.36029 408.42459 629.0206 410.2947 632.69363 C 413.48893 638.96739 418.86758 644.00027 422.38063 644.00027 C 424.24634 644.00027 427.193 642.29259 429.39821 639.93191 C 431.4886 637.69413 434.3661 632.74411 435.79274 628.93191 C 438.90077 620.62692 438.96543 620.67589 423.90602 619.73074 L 413.81032 619.09792 z M 461.45485 622.66628 L 460.7986 627.00027 C 460.43809 629.38358 459.4525 641.43551 458.60915 653.78152 L 457.07595 676.22878 L 461.43142 683.11355 C 474.90056 704.41483 478.66579 712.68455 478.66579 720.95144 C 478.66579 728.4854 470.82638 739.87754 461.80446 745.45339 C 458.99404 747.19034 454.71428 748.40996 451.07595 748.50808 L 445.02126 748.67019 L 441.20095 760.00222 C 436.00972 775.39912 423.12742 801.24055 414.76345 813.03347 C 404.78245 827.10636 393.43591 834.66628 382.29665 834.66628 L 376.9197 834.66628 L 379.46071 837.47488 C 380.8577 839.01958 384.40043 841.52589 387.33376 843.04324 C 397.99411 848.55761 407.627 848.61689 419.70876 843.24245 C 434.18876 836.80119 451.32746 815.99654 463.16384 790.49441 C 473.88809 767.38842 482.1669 738.44468 487.90212 704.00027 C 490.75231 686.88268 497.30138 632.88531 497.32204 626.33425 L 497.33376 622.66628 L 479.39431 622.66628 L 461.45485 622.66628 z M 404.79079 633.65261 L 399.06227 638.44167 C 395.91127 641.0756 393.33376 643.40413 393.33376 643.6155 C 393.33376 643.82688 397.25027 644.00027 402.03884 644.00027 L 410.74587 644.00027 L 407.76931 638.82644 L 404.79079 633.65261 z M 430.53884 647.81863 C 430.35457 647.80726 430.17573 647.82126 429.99977 647.85574 C 428.53313 648.14313 420.60734 648.74378 412.38649 649.18972 L 397.43923 650.00027 L 402.82595 662.66628 C 419.17885 701.12013 440.20951 739.10494 446.94313 742.34792 C 450.99788 744.30074 451.38676 744.29467 456.37673 742.19753 C 461.27585 740.13858 471.22997 729.85712 472.64626 725.3948 C 475.10562 717.64607 471.57885 709.20131 453.99977 680.74245 C 437.37667 653.83121 433.30285 647.98909 430.53884 647.81863 z M 385.99196 651.04714 C 385.57281 650.98858 384.99046 651.09108 384.33376 651.36941 C 376.56744 654.66092 370.19513 656.46733 361.51735 657.83816 L 351.7029 659.38894 L 347.7947 670.02761 C 345.64514 675.87882 340.30874 691.08379 335.93727 703.81667 L 327.99001 726.96902 L 331.45876 742.43191 C 333.36618 750.93643 336.44218 762.11704 338.2947 767.27956 C 342.42915 778.80136 353.13163 801.97976 353.94313 801.16824 C 354.26909 800.84228 357.60252 786.79482 361.34938 769.95339 C 370.57287 728.49579 386.66579 653.31989 386.66579 651.69558 C 386.66579 651.3255 386.41112 651.10571 385.99196 651.04714 z M 514.56423 780.8323 C 513.90121 780.77971 512.27615 784.52235 510.80642 789.56081 C 509.23869 794.93519 505.17282 807.0897 501.77126 816.56863 L 495.58571 833.803 L 498.75368 839.7737 C 503.41643 848.56307 514.27831 862.15376 519.11501 865.25222 C 524.26862 868.5537 535.67593 868.92483 541.37673 865.97683 C 550.92856 861.03738 552.99293 844.16504 545.77712 830.00027 C 542.19656 822.97156 517.41018 783.82758 514.68337 780.8948 C 514.64805 780.85682 514.60843 780.8358 514.56423 780.8323 z M 298.88454 888.2073 C 288.54179 887.83232 280.01989 893.55348 274.96267 904.35964 C 273.51106 907.4614 267.61801 925.00096 261.86696 943.33425 C 253.00764 971.5762 251.40337 978.10745 251.37087 986.10378 C 251.33757 994.29457 251.86449 996.40872 255.34938 1002.1038 C 260.56839 1010.6326 268.16157 1014.6663 279.00173 1014.6663 C 283.99624 1014.6663 288.54088 1013.7656 291.72048 1012.1428 C 297.38731 1009.2505 300.10368 1006.4596 303.19118 1000.3635 C 308.46182 989.95694 316.95787 942.60897 318.21071 916.66628 C 318.75013 905.49636 318.46138 902.59204 316.42751 898.76199 C 313.12014 892.53374 308.12143 889.16891 300.97634 888.36355 C 300.27113 888.28406 299.57406 888.2323 298.88454 888.2073 z "
                    transform="translate(-123.17165,-87.025658)" />
            </g>
        </svg>

    </imagesvgsorce>

</imagesvg>
<fromhtml>
    <htmldata id="htmlone">
        <!DOCTYPE html>
        <!--
This is a starter template page. Use this page to start your new project from
scratch. This page gets rid of all links and provides the needed markup only.
-->
        <html lang="en">

            <head>
                <meta charset="utf-8">
                <meta name="viewport" content="width=device-width, initial-scale=1">
                <meta http-equiv="x-ua-compatible" content="ie=edge">

                <title>AdminLTE 3 | Starter</title>

                <!-- Google Font: Source Sans Pro -->
                <link rel="stylesheet"
                    href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
                <!-- Font Awesome Icons -->
                <link rel="stylesheet" href="plugins/fontawesome-free/css/all.css">
                <!-- Theme style -->
                <link rel="stylesheet" href="dist/css/adminlte.min.css">

                <link href="plugins/kendo.default-main-darkk.min.css" rel="stylesheet" />
                <link rel="stylesheet" href="plugins/toastr/toastr.min.css">
                <!-- Theme style -->
                <link rel="stylesheet" href="dist/css/adminlte.min.css">
                <script src="plugins/jquery-1.12.44.min.js"></script>

                <script src="plugins/kendo.allk.min.js"></script>

                <style>
                    .sc {
                        scrollbar-face-color: #646464;
                        scrollbar-base-color: #646464;
                        scrollbar-3dlight-color: #646464;
                        scrollbar-highlight-color: #646464;
                        scrollbar-track-color: #000;
                        scrollbar-arrow-color: #646464;
                        scrollbar-shadow-color: #646464;
                        scrollbar-dark-shadow-color: #646464;
                    }

                    #windoesContiner.windowshow {
                        max-height: 100%;
                        max-width: 100%;
                        display: inline;
                    }

                    #windoesContiner.windowhidden {
                        max-height: 0;
                        max-width: 0;
                        display: none;
                    }

                    #webContiner.webshow {

                        display: block;
                        height: 500;
                    }

                    #webContiner.webhidden {

                        display: none;
                    }
                </style>
            </head>

            <body class="k-content hold-transition sidebar-mini-xs layout-fixed sc"
                onunload="MyComComponent_onunload();">
                <!--  <button id="myButton" onclick="myButton_click(4);">Com Method</button>
    <button id="myButton" onclick="myButton_click(2);">Com Method</button>
    <button id="myButton" onclick="myButton_click(3);">Com Method</button>
      -->

                <div class="wrapper">


                    <nav class="main-header navbar  navbar-expand navbar-dark navbar-light ">
                        <!-- Left navbar links -->
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link" data-widget="pushmenu" href="#" role="button"><i
                                        class="k-icon k-i-menu"></i></a>
                            </li>
                            <li class="nav-item d-none d-sm-inline-block">
                                <a href="index3.html" class="nav-link">Home</a>
                            </li>
                            <li class="nav-item d-none d-sm-inline-block">
                                <a href="#" class="nav-link">Contact</a>
                            </li>
                        </ul>

                        <!-- Right navbar links -->
                        <ul class="navbar-nav ml-auto">
                            <!-- Navbar Search -->


                            <!-- Messages Dropdown Menu -->
                            <li class="nav-item dropdown">
                                <a class="nav-link" data-toggle="dropdown" href="#">
                                    <i class="k-icon k-i-comment"></i>
                                    <span class="badge badge-danger navbar-badge">3</span>
                                </a>
                                <div class="dropdown-menu dropdown-menu-lg dropdown-menu-right">
                                    <a href="#" class="dropdown-item">
                                        <!-- Message Start -->
                                        <div class="media">
                                            <img src="dist/img/user1-128x128.jpg" alt="User Avatar"
                                                class="img-size-50 mr-3 img-circle">
                                            <div class="media-body">
                                                <h3 class="dropdown-item-title">
                                                    Brad Diesel
                                                    <span class="float-right text-sm text-danger"><i
                                                            class="fas fa-star"></i></span>
                                                </h3>
                                                <p class="text-sm">Call me whenever you can...</p>
                                                <p class="text-sm text-muted"><i class="far fa-clock mr-1"></i> 4 Hours
                                                    Ago</p>
                                            </div>
                                        </div>
                                        <!-- Message End -->
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item">
                                        <!-- Message Start -->
                                        <div class="media">
                                            <img src="dist/img/user8-128x128.jpg" alt="User Avatar"
                                                class="img-size-50 img-circle mr-3">
                                            <div class="media-body">
                                                <h3 class="dropdown-item-title">
                                                    John Pierce
                                                    <span class="float-right text-sm text-muted"><i
                                                            class="fas fa-star"></i></span>
                                                </h3>
                                                <p class="text-sm">I got your message bro</p>
                                                <p class="text-sm text-muted"><i class="far fa-clock mr-1"></i> 4 Hours
                                                    Ago</p>
                                            </div>
                                        </div>
                                        <!-- Message End -->
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item">
                                        <!-- Message Start -->
                                        <div class="media">
                                            <img src="dist/img/user3-128x128.jpg" alt="User Avatar"
                                                class="img-size-50 img-circle mr-3">
                                            <div class="media-body">
                                                <h3 class="dropdown-item-title">
                                                    Nora Silvester
                                                    <span class="float-right text-sm text-warning"><i
                                                            class="fas fa-star"></i></span>
                                                </h3>
                                                <p class="text-sm">The subject goes here</p>
                                                <p class="text-sm text-muted"><i class="far fa-clock mr-1"></i> 4 Hours
                                                    Ago</p>
                                            </div>
                                        </div>
                                        <!-- Message End -->
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item dropdown-footer">See All Messages</a>
                                </div>
                            </li>
                            <!-- Notifications Dropdown Menu -->
                            <li class="nav-item dropdown k-content">
                                <a class="nav-link" data-toggle="dropdown" href="#">
                                    <i class="k-icon k-i-bell"></i>
                                    <span class="badge badge-warning navbar-badge">15</span>
                                </a>
                                <div class="dropdown-menu dropdown-menu-lg dropdown-menu-right dark-mode"
                                    style="z-index: 900;">

                                    <span class="dropdown-header">15 Notifications</span>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item">
                                        <i class="fas fa-envelope mr-2"></i> 4 new messages
                                        <span class="float-right text-muted text-sm">3 mins</span>
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item">
                                        <i class="fas fa-users mr-2"></i> 8 friend requests
                                        <span class="float-right text-muted text-sm">12 hours</span>
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item">
                                        <i class="fas fa-file mr-2"></i> 3 new reports
                                        <span class="float-right text-muted text-sm">2 days</span>
                                    </a>
                                    <div class="dropdown-divider"></div>
                                    <a href="#" class="dropdown-item dropdown-footer">See All Notifications</a>
                                </div>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-widget="fullscreen" href="#" role="button">
                                    <i class="fas fa-expand-arrows-alt"></i>
                                </a>
                            </li>

                            <li class="nav-item">
                                <div class="custom-control custom-switch nav-link">
                                    <input type="checkbox" class="custom-control-input" id="myCheckbox">
                                    <label class="custom-control-label" for="myCheckbox"></label>
                                </div>
                            </li>



                        </ul>
                    </nav>
                    <!-- /.navbar -->

                    <!-- Main Sidebar Container -->
                    <aside class="main-sidebar sidebar-dark-primary elevation-4">
                        <!-- Brand Logo -->
                        <a href="index3.html" class="brand-link">
                            <img src="dist/img/AdminLTELogo.png" alt="AdminLTE Logo"
                                class="brand-image img-circle elevation-3" style="opacity: .8">
                            <span class="brand-text font-weight-light">اسطول التقنية</span>
                        </a>

                        <!-- Sidebar -->
                        <div class="sidebar">
                            <!-- Sidebar user panel (optional) -->
                            <div class="user-panel mt-3 pb-3 mb-3 d-flex">
                                <div class="image">
                                    <img src="dist/img/user2-160x160.jpg" class="img-circle elevation-2"
                                        alt="User Image">
                                </div>
                                <div class="info">
                                    <a href="#" class="d-block">Alexander Pierce</a>
                                </div>
                            </div>

                            <!-- SidebarSearch Form -->
                            <div class="form-inline">
                                <div class="input-group" data-widget="sidebar-search">
                                    <input class="form-control form-control-sidebar" type="search" placeholder="Search"
                                        aria-label="Search">
                                    <div class="input-group-append">
                                        <button class="btn btn-sidebar">
                                            <i class="fas fa-search fa-fw"></i>
                                        </button>
                                    </div>
                                </div>
                            </div>

                            <!-- Sidebar Menu -->
                            <nav class="mt-2">
                                <ul id="first" class="nav nav-pills nav-sidebar flex-column" data-widget="treeview"
                                    role="menu" data-accordion="false">
                                    <!-- Add icons to the links using the .nav-icon class
               with font-awesome or any other icon font library -->
                                    <li class="nav-item menu-open" id="0A">
                                        <a href="#" class="nav-link active">
                                            <i class="nav-icon k-icon k-i-home"></i>
                                            <p>
                                                الرئيسية
                                                <i class="right k-icon k-i-chevron-left"></i>
                                            </p>
                                        </a>
                                        <ul class="nav nav-treeview">
                                            <li class="nav-item">
                                                <a href="#0" class="nav-link active" onclick="myButton_click(0)">
                                                    <i class="k-icon k-i-round-corners"></i>
                                                    <p>الصفحة الرئيسية</p>
                                                </a>
                                            </li>
                                            <li class="nav-item">
                                                <a href="#1" class="nav-link" onclick="myButton_click(1)">
                                                    <i class="k-icon k-i-round-corners"></i>
                                                    <p>إظافة فورم</p>
                                                </a>
                                            </li>

                                            <li class="nav-item">
                                                <a href="#2" class="nav-link" onclick="myButton_click(2)">
                                                    <i class="k-icon k-i-round-corners"></i>
                                                    <p>وضع المضلم</p>
                                                </a>
                                            </li>

                                            <li class="nav-item">
                                                <a href="#3" class="nav-link" onclick="myButton_click(3)">
                                                    <i class="k-icon k-i-round-corners"></i>
                                                    <p>فتح فورم</p>
                                                </a>
                                            </li>

                                            <li class="nav-item">
                                                <a href="#ex" class="nav-link" onclick="myButton_click(4)">
                                                    <i class="k-icon k-i-round-corners"></i>
                                                    <p>إظافات اخري</p>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class="nav-item" id="1A">
                                        <a href="#exm" class="nav-link" onclick="myButton_click(5)">
                                            <i class="k-icon k-i-bell"></i>
                                            <p>
                                                الاشعارات
                                                <span class="right badge badge-danger">New</span>
                                            </p>
                                        </a>
                                    </li>


                                </ul>
                            </nav>
                            <!-- /.sidebar-menu -->
                        </div>
                        <!-- /.sidebar -->
                    </aside>

                </div>


                <!-- Content Wrapper. Contains page content -->
                <div class="content-wrapper k-content">
                    <!-- Content Header (Page header) -->
                    <div class="content-header" style="display: none;">
                        <div class="container-fluid">
                            <div class="row mb-2">
                                <div class="col-sm-6">
                                    <h1 id="tit" class="m-0">Starter Pageeeeeee</h1>
                                </div><!-- /.col -->
                                <div class="col-sm-6">
                                    <ol class="breadcrumb float-sm-right">
                                        <li class="breadcrumb-item"><a href="#">Home</a></li>
                                        <li class="breadcrumb-item active">Starter Page</li>
                                    </ol>
                                </div><!-- /.col -->
                            </div><!-- /.row -->
                        </div><!-- /.container-fluid -->
                    </div>
                    <!-- /.content-header -->

                    <!-- Main content -->


                    <div class="content k-content" id="mmki">


                        <div class="container-fluid k-content">




                            <div class="windowhidden" id="windoesContiner"> <object style="min-height: 100vh;"
                                    id="myComComponent" name="myComComponent"
                                    classid="clsid:32F9346E-D34A-47f3-8017-B62E7EEA6CB2" height="500" width="100%"
                                    VIEWASTEXT></object></object></div>





                            <div class="webshow" id="webContiner">

                                <div id="grid"></div>

                            </div><!-- /.container-fluid -->
                            <!-- /.row -->
                        </div><!-- /.container-fluid -->



                    </div>
                    <!-- /.content -->
                </div>
                <!-- /.content-wrapper -->


                <!-- Control Sidebar -->
                <aside class="control-sidebar control-sidebar-dark">
                    <!-- Control sidebar content goes here -->
                    <div class="p-3">
                        <h5>Title</h5>
                        <p>Sidebar content</p>
                    </div>
                </aside>







                <!-- Main Footer -->
                <footer class="main-footer k-content">
                    <!-- To the right -->
                    <div class="float-right d-none d-sm-inline">
                        thanks use our system
                    </div>
                    <!-- Default to the left -->
                    <strong>Copyright &copy; 2014-2024 <a href="#">اسطول التقنية</a>.</strong> All rights
                    reserved.
                </footer>
                </div>
                <!-- ./wrapper -->

                <!-- REQUIRED SCRIPTS -->

                <!-- jQuery -->

                <script src="plugins/jquery/jquery.min.js"></script>
                <!-- Bootstrap 4 -->
                <script src="plugins/bootstrap/js/bootstrap.bundle.min.js"></script>

                <!-- AdminLTE App -->
                <script src="dist/js/adminlte.min.js"></script>
                <link href="plugins/kendo.default-main-darkk.min.css" rel="stylesheet" />
                <script src="plugins/jquery-1.12.44.min.js"></script>

                <script src="plugins/kendo.allk.min.js"></script>


                <script for="myComComponent" event="MyFirstEvent(args)" language="javascript">
                    function myComComponent:: MyFirstEvent(args) {
                        appendText("myComComponent raised MyFirstEvent. args: ");
                        appendText(args);
                        appendText("\r\n");
                    }
                </script>
                <script>
                    $.support.cors = true;
                </script>
                <script src="main/my.js"></script>
                <script>

                    function setsource(contein, scr, type, msrc, attir) {
                        // alert("hhhhh");
                        //alert(JSON.stringify(attir));
                        var uipp = document.getElementById(contein);

                        var smy = document.createTextNode(scr);
                        var vm = document.createElement(type);
                        if (msrc == "0") {
                            vm.appendChild(smy);
                            try {
                                if (attir != "[]") {
                                    var iu = JSON.parse(attir);

                                    iu.forEach(function (element) {
                                        vm.setAttribute(element.key, element.value);
                                    });
                                }
                            } catch (ee) {

                                alert("fffffff");
                            }

                            uipp.appendChild(vm);
                            // alert(scr);
                        } else {
                            try {
                                if (attir != "[]") {
                                    var iu = JSON.parse(attir);
                                    iu.forEach(function (element) {
                                        vm.setAttribute(element.key, element.value);
                                    });
                                }
                            } catch (ee) {
                                alert("fffffffvvvvv");
                                //alert(ee.message);
                            }
                            //  vm.setAttribute('src',scr);
                            uipp.appendChild(vm);

                        }



                    }
                    /*
        var getscri= window.external.getHtmlDec('\\main\\scrip.txt');
        //alert(getscri);
        const v= document.createElement('script');
        var k=getscri;
        
         var sm=   document.createTextNode(k);
         v.appendChild(sm);
           // alert(k);
        //v.innerText=k;
        // v.async=true;
        document.head.appendChild(v);*/
                </script>


                <script src="plugins/sweetalert2/sweetalert2.min.js"></script>
                <!-- Toastr -->
                <script src="plugins/toastr/toastr.min.js"></script>
                <!-- AdminLTE App -->

                <!-- AdminLTE for demo purposes -->
                <script src="dist/js/demo.js"></script>

                <script type="text/javascript">


                    $(function () {
                        const Toast = Swal.mixin({
                            toast: true,
                            position: 'top-end',
                            showConfirmButton: false,
                            timer: 3000
                        });

                        $('.swalDefaultSuccess').click(function () {
                            Toast.fire({
                                type: 'success',
                                title: 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr.'
                            })
                        });
                        $('.swalDefaultInfo').click(function () {
                            Toast.fire({
                                type: 'info',
                                title: 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr.'
                            })
                        });
                        $('.swalDefaultError').click(function () {
                            Toast.fire({
                                type: 'error',
                                title: 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr.'
                            })
                        });
                        $('.swalDefaultWarning').click(function () {
                            Toast.fire({
                                type: 'warning',
                                title: 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr.'
                            })
                        });
                        $('.swalDefaultQuestion').click(function () {
                            Toast.fire({
                                type: 'question',
                                title: 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr.'
                            })
                        });

                        $('.toastrDefaultSuccess').click(function () {
                            toastr.success('Lorem ipsum dolor sit amet, consetetur sadipscing elitr.')
                        });
                        $('.toastrDefaultInfo').click(function () {
                            toastr.info('Lorem ipsum dolor sit amet, consetetur sadipscing elitr.')
                        });
                        $('.toastrDefaultError').click(function () {
                            toastr.error('Lorem ipsum dolor sit amet, consetetur sadipscing elitr.')
                        });
                        $('.toastrDefaultWarning').click(function () {
                            toastr.warning('Lorem ipsum dolor sit amet, consetetur sadipscing elitr.')
                        });
                    });

                </script>
            </body>

        </html>

    </htmldata>
</fromhtml>

```

# screenshot
![khj](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/28d4f771-4e95-4460-b765-01f2700490ab)
![ppl](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/621eefdf-f3a6-4130-985e-dd63fd0a9389)
![nmj](https://github.com/Bandar-Ameen/HTWFormConverter/assets/22500742/141195e2-a626-4d96-8240-846cdee8f87f)
