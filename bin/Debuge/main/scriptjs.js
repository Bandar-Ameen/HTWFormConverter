function replaceContentInContainer(target, source, d) {
  if (d) {
    document.getElementById(target).innerHTML = document.getElementById(source).innerHTML;
  } else {
    document.getElementById(target).innerHTML = source;

  }
}

function reloadCss() {

  var links = document.getElementsByTagName("link");
  for (var cl in links) {
    var link = links[ cl ];
    if (link.rel === "stylesheet")
      alert(link.href);
    link.href = link.href;
  }
}

function myFunc(event) {
  window.alert(event.href);
}

/*

 <div id="windoesContiner"> <object style="z-index: 950;" id="myComComponent" name="myComComponent"
                  classid="clsid:32F9346E-D34A-47f3-8017-B62E7EEA6CB2" height="400" width="100%" VIEWASTEXT></object></object></div>
*/


function myButton_click(d) {


}

function lighthem() {
  var t = window.external.geturl("0");

  $('body > link')[ 0 ].href = t + "/plugins/kendo.default-main.minlight.css";
  // alert(c);
  $(document.body).removeClass("k-content");
  $(document.body).removeClass("sc");
  $(document.body).addClass("k-content");
  $('body').removeClass('dark-mode');

  var $sidebar = $('.control-sidebar');
  var $sidebarr = $('.main-sidebar');

  $sidebarr.removeClass('sidebar-dark-primary');
  $sidebarr.addClass('sidebar-light-primary');

  var $sidebarrfooter = $('.main-footer');
  $sidebarrfooter.removeClass("k-content");
  $sidebarrfooter.addClass("k-content");
  var $main_header = $('.main-header');
  $main_header.removeClass('navbar-dark');
  $main_header.addClass('navbar-light');

  $sidebar.removeClass('control-sidebar-dark');
  $sidebar.addClass('control-sidebar-light');
  var t = JSON.stringify({ "Name_Form": "Liget", "Event_Type": "Change_Them_Light" });
  myComComponent.sendComment(t.toString());
  window.external.sendEvent(t.toString());

}

function darkthem() {
  window.parent.postMessage({
    'func': 'parentFunc',
    'message': 'Message text from iframe.'
  }, "*");
  var t = window.external.geturl("0");
  $('body > link')[ 0 ].href = t + "/plugins/kendo.default-main-darkk.min.css";
  // alert(c);
  $(document.body).removeClass("k-content");
  $(document.body).addClass("k-content");
  $(document.body).addClass("sc");
  $('body').addClass('dark-mode');

  var $sidebar = $('.control-sidebar');
  var $sidebarr = $('.main-sidebar');
  var $sidebarrfooter = $('.main-footer');
  $sidebarrfooter.removeClass("k-content");
  $sidebarrfooter.addClass("k-content");
  $sidebarr.removeClass('sidebar-light-primary');
  $sidebarr.addClass('sidebar-dark-primary');
  var $main_header = $('.main-header');
  $main_header.removeClass('navbar-light');
  $main_header.addClass('navbar-dark');
  $sidebar.removeClass('control-sidebar-light');
  $sidebar.addClass('control-sidebar-dark');
  var t = JSON.stringify({ "Name_Form": "Liget", "Event_Type": "Change_Them_Dark" });
  myComComponent.sendComment(t.toString());
  window.external.sendEvent(t.toString());


}

function mre() {

  //   alert("ffffffff");

}
function myButton_clickk(a) {

  if (a == 1) {

    var tt = JSON.stringify({ "A_html": "openFormm.html#ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
    var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
    window.external.sendEvent(t.toString());

    /* var tt = JSON.stringify({"formname": "hh", "tyeForm": 3 });
// addm();
var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
window.external.sendEvent(t.toString());*/
    //   myComComponent.sendComment(t.toString());
  }
  if (a == 4) {

    try {
      alert("ffffffffffffffffmmmmmmmmmmmmmmmmkkkkkkkkkkkkkk");
      var tt = JSON.stringify({ "formname": "hh", "tyeForm": 4 });
      // addm();
      var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
      myComComponent.sendComment(t.toString());
      /* var tt = JSON.stringify({ "A_html": "<h1 style=\"color:red;\">ggggggg</h1>", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
       var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "Show_Alert" });
       window.external.sendEvent(t.toString());*/
      //  document.getElementById("imfrm").src = "openFormm.html#ex";

      /*  var tt = JSON.stringify({ "A_html": "<h1 style=\"color:red;\">ggggggg</h1>", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
        var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "Show_Alert" });
        window.external.sendEvent(t.toString());*/
      // alert("dddddddd");
    } catch (ex) {


      alert(ex.message);
    }
    /*  var htm="<div id=\"grid\"></div>";
        document.getElementById("webContiner").style.display="block";//.visibility = 'visible';
      document.getElementById("windoesContiner").style.display="none";//.visibility = 'hidden';
      replaceContentInContainer("webContiner", htm,false);
      reloadkk(0);*/

    /*var t = JSON.stringify({ "Name_Form": "d", "Event_Type": "Open_Formt" });
    myComComponent.sendComment(t.toString());*/
  }

  if (a == 5) {
    try {




      // document.getElementById("imfrm").src="openFormm.html#exm";

      /*
                    var tt = JSON.stringify({ "A_html": "openFormm.html#exm", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
                    var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
                    window.external.sendEvent(t.toString());*/

      //  document.location.url = "openFormm.html#exm";
      // myComComponent.sendComment(t.toString());
      /*  var tt = JSON.stringify({ "A_html": "<h1 style=\"color:red;\">ggggggg</h1>", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
        var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "Show_Alert" });
        window.external.sendEvent(t.toString());*/
      // alert("dddddddd");
    } catch (ex) {


      alert(ex.message);
    }
    /* document.getElementById("myIframe").srcdoc = "<h1 style='text-align:center; color:#9600fa'>Welcome hhhhhhhhhhhhhhhhhhhhhhhhhto iframes</h1>";
  
    var tt = JSON.stringify({ "A_html": "<h1 style=\"color:red;\">ggggggg</h1>", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
  var t = JSON.stringify({ "Name_Form":tt.toString(), "Event_Type": "Show_Alert"});
  myComComponent.sendComment(t.toString());*/
  }
  if (a == 2) {
    //   var t = JSON.stringify({ "Name_Form": "Dark", "Event_Type": "Change_Them_Dark" });
    // alert("ffffffffff");
    var tt = JSON.stringify({ "formname": "hh", "tyeForm": 3 });
    // addm();
    var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
    window.external.sendEvent(t.toString());
   // alert("ffffffffffffffffmmmmmmmmmmmmmmmm");
    // myComComponent.sendComment(t.toString());
    // myComComponent.sendComment(t.toString());
  }
  if (a == 3) {
    var gx = "<object style=\"z-index: 950; \" id=\"myComComponent\" name=\"myComComponent\"classid = \"clsid:32F9346E-D34A-47f3-8017-B62E7EEA6CB2\" height = \"400\" width = \"100%\" VIEWASTEXT ></object > ";


    // document.getElementById("windoesContiner").style.display = "block";
    //   document.getElementById("webContiner").style.display = "none";

    //  replaceContentInContainer("kkm", gx,false);
    var tt = JSON.stringify({ "formname": "hh", "tyeForm": 0 });
    // addm();
    var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
    window.external.sendEvent(t.toString());
    //  myComComponent.sendComment(t.toString());
    // alert("fffffffffffff");
    //  var t = JSON.stringify({ "Name_Form": "Liget", "Event_Type": "Change_Them_Light" });
    // myComComponent.sendComment(t.toString());
  }
}
function MyComComponent_onunload() {
  myComComponent.Disposee("r");
}


function elementChildren(element) {
  var childNodes = element.childNodes,
    children = [],
    i = childNodes.length;

  while (i--) {
    if (childNodes[ i ].nodeType == 1) {
      children.unshift(childNodes[ i ]);
    }
  }

  return children;
}
function search(mainmenu) {
  var input, ul, li, a, i, txtValue;

  li = document.getElementById("first");
  var g = elementChildren(li);
  // alert(g.length);
  for (i = 0; i < g.length; i++) {
    a = g[ i ];


    var idonl = a.getAttribute('id').split('A')[ 0 ];
    var onma = mainmenu.split('#')[ 0 ];
    if (idonl == onma) {


      //a.addClass('active');
      var allch = elementChildren(a);
      for (ik = 0; ik < allch.length; ik++) {

        var tt = allch[ ik ];
        var allchv = elementChildren(tt);
        var s = tt.getAttribute('onclick');
        var vall = tt.getAttribute('class');



      }


    } else {
      var urll = "0";
      var url = window.location;

      // for sidebar menu entirely but not cover treeview
      $('ul.sidebar-menu a').filter(function () {
        var hash = urlObj.hash;
        if (hash == '#' + urll) {
          //alert('ddddddddd');
          return true;
        } else {
          return false;
        }
      }).parent().siblings().removeClass('active').end().addClass('active');

      // for treeview
      $('ul.treeview-menu a').filter(function () {
        var hash = urlObj.hash;
        if (hash == '#' + urll) {
          //alert('ddddddddd');
          return true;
        } else {
          return false;
        }
      }).parentsUntil(".sidebar-menu > .treeview-menu").siblings().removeClass('active').end().addClass('active');
      alert(url);
    }






    var val = a.getAttribute('class');

    /*  txtValue = a.get.textContent || a.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        li[ i ].style.display = "";
      } else {
        li[ i ].style.display = "none";
      }*/
  }
}
admen();
//addm();
try {

  var checkboxx = document.getElementById('mm');
  var checkbox = document.getElementById('myCheckbox');

  checkbox.addEventListener('change', function (event) {
    if (event.currentTarget.checked) {
      //reloadCss(); 
      darkthem();

    } else {
      lighthem();
    }
  });
} catch (ex) {


}
window.addEventListener('hashchange', function () {


  $(function () {

    // alert(urll);

    var url = window.location;

    // for sidebar menu entirely but not cover treeview

    $('ul.nav-sidebar li a').filter(function () {
      if (this.href == url) {

        var tit = document.getElementById("tit");
        tit.innerText = this.innerText;

      }
      return this.href != url;
    }).removeClass('active');
    $('ul.nav-sidebar li a').filter(function () {


      return this.href == url;

    }).addClass('active');

    // for the treeview
    $('ul.nav-treeview a').filter(function () {

      return this.href == url || url.href.indexOf(this.href) == 0;

    }).parentsUntil(".nav-sidebar > .nav-treeview").addClass('menu-open').prev('a').addClass('active');


    var tt = JSON.stringify({ "A_html": decodeURI(url), "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
    var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
    //    window.external.sendEvent(t.toString());
    var tn = url.hash;//.split('#');
    var uin = tn.split("#")[ 1 ];
    if (uin == "exm") {
      //alert(uin);

      try {

      /*  var r = window.external.GetSetting();//.GetSetting();
      alert(r);  
      */

       // window.external.SaveToCache("bandar","gtttttttttttttrrgggggHelloBandar");
      var tt = JSON.stringify({ "formname": "hh", "tyeForm": "5" });
        // addm();
        var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
        window.external.sendEvent(t.toString());

        // myComComponent.sendComment(t.toString());
      } catch (e) {
        alert("vvvvvvvvvvvvvvvvvv" + e.message());
      }
    }
    //  alert(uin);
    if (uin == 41544) {


      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
      window.external.sendEvent(t.toString());

      

      // showwindowcontrol();
    }
    
    
    if (uin == 45654) {
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\pagea", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "Start_Wating" });
      window.external.sendEvent(t.toString());
    }
    if (uin == 4561524) {
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\pagea", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
      window.external.sendEvent(t.toString());
    }
    if (uin == 456514) {
    var r=  window.external.GetFromCache("bandar");

    alert(r);
   // var iu=  document.getElementsByTagName("head")[0].innerHTML;
      
     // var geturll = window.external.GetUrlFromString("main\\pagea.txt","0");
     // var geturll = window.external.GetHtmlFromString("main\\pagea.txt", iu,"1");
  //  var itk=  document.getElementById("mfram");//.setAttribute('src', geturll );
    //  itk.setAttribute('src', geturll);
     /* var doc = itk.contentDocument ? itk.contentDocument : itk.contentWindow.document;
   
    //  var t = window.external.getHtml(url);
      doc.open('text/html');
      doc.write(geturll);
      doc.close();
   */
    // window.location.href = geturll;
     
      /* var tt = JSON.stringify({ "A_html": "openFormm.html#main\\pagea", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_Page" });
      window.external.sendEvent(t.toString());*/
    }

    if (uin == 456534) {
/*
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());
*/

      var ttv = JSON.stringify({ "formname": "37", "tyeForm": "2", "Title_name": "mainA", "Tage_name": "mainA", "Page_name": "mainA", "Type_Event": "0" });
        // addm();
        var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "Open_Form" });
        window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 415447) {

      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "47", "tyeForm": "5", "Title_name": "mainB", "Tage_name": "mainB", "Page_name": "mainB", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "Open_Form" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 1) {
/*bill_salse, bill_salse_back, bill_salse_given, bill_salse_setting, bill_salse_given_setting
            , bill_salse_moraja, bill_salse_trhel, */
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "bill_salse", "tyeForm": "0", "Title_name": "المبيعات", "Tage_name": "salse", "Page_name": "salse", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "0" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 2) {
      /*bill_salse, bill_salse_back, bill_salse_given, bill_salse_setting, bill_salse_given_setting
                  , bill_salse_moraja, bill_salse_trhel, */
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "bill_salse_back", "tyeForm": "0", "Title_name": "المبيعات", "Tage_name": "salse", "Page_name": "salse", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "0" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 3) {
      /*bill_salse, bill_salse_back, bill_salse_given, bill_salse_setting, bill_salse_given_setting
                  , bill_salse_moraja, bill_salse_trhel, */
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "bill_salse_setting", "tyeForm": "0", "Title_name": "المبيعات", "Tage_name": "salse", "Page_name": "salse", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "0" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 4) {
      /*bill_salse, bill_salse_back, bill_salse_given, bill_salse_setting, bill_salse_given_setting
                  , bill_salse_moraja, bill_salse_trhel, */
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "bill_salse_trhel", "tyeForm": "0", "Title_name": "المبيعات", "Tage_name": "salse", "Page_name": "salse", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "0" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 5) {
      /*bill_salse, bill_salse_back, bill_salse_given, bill_salse_setting, bill_salse_given_setting
                  , bill_salse_moraja, bill_salse_trhel, */
      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "bill_salse_moraja", "tyeForm": "0", "Title_name": "المبيعات", "Tage_name": "salse", "Page_name": "salse", "Type_Event": "0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "0" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 415448) {

      var tt = JSON.stringify({ "A_html": "openFormm.html#main\\ex", "width": 400, "hi": 200, "dey": 10, "auto": 1, "location": "BottomCenter" });
      var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "New_form" });
      window.external.sendEvent(t.toString());

      var ttv = JSON.stringify({ "formname": "43", "tyeForm": "5", "Title_name": "إدارة", "Tage_name": "mainC", "Page_name": "mainC","Type_Event":"0" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "Open_Form" });
      window.external.sendEvent(tv.toString());
      // hidwindowcontrol();
    }
    if (uin == 4561540) {
      //var geturll = window.external.GetUrlFromString("index2.html", "0");
      var ttv = JSON.stringify({ "formname": "43", "tyeForm": "5", "Title_name": "mainC", "Tage_name": "mainC", "Page_name": "mainC", "Type_Event": "1" });
      // addm();
      var tv = JSON.stringify({ "Name_Form": ttv, "Event_Type": "Open_Form" });
      window.external.sendEvent(tv.toString());
    //  alert(geturll);
     // window.location.href = geturll;
    }
    //  myButton_clickk(uin);
    /*var q = document.getElementById("mm");
    try{
 
      var t = window.external.getHtml(url);
     
    
   var qa=   JSON.parse(t);
try{
   var hh1= qa.htmll;

var jsd=qa.jss;
    
if(jsd==undefined){
jsd="function ss(){}";
}
}catch(sd){


}

      
        q.innerHTML = hh1;
        createone(jsd);
        createonestyle(".vvcc{color:red;}");
        var ss = q.getElementsByTagName("script")[ 0 ].innerHTML;
        alert(ss);
     /* var ff=document.createElement("script");
        var inlinscx = document.createTextNode(jsd);
        q.innerHTML = hh1;
      ff.appendChild(inlinscx);
q.appendChild(ff);
    // xx();
    // nvv('55');
 }catch(ex){
//alert(ex.message);
try{
 
}catch(exx){

}
      }*/

  });



  // $('.content-wrapper').IFrame('createTab', 'Home', 'index.html, "index', true);
});
function showwindowcontrol() {
  var divv = document.getElementById("windoesContiner");
  $(divv).removeClass("windowhidden");
  $(divv).addClass("windowshow");

  var divvk = document.getElementById("webContiner");

  $(divvk).removeClass("webshow");
  $(divvk).addClass("webhidden");
}
function hidwindowcontrol() {
  var divv = document.getElementById("windoesContiner");
  $(divv).removeClass("windowshow");
  $(divv).addClass("windowhidden");

  var divvk = document.getElementById("webContiner");

  $(divvk).removeClass("webhidden");
  $(divvk).addClass("webshow");


}
function admen() {

  var iopk = [];

  var iopkk = [];
  var resul = [];
  var ma1a = getel("المبيعات", "55mer", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#45654", iopk, "right badge badge-danger", "جديد");
  var ma1b = getel("المشتريات", "55mera", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#456154", iopk, "0", "0");
var ma1bx = getel("المشتmmmmريات", "55merakm", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#4561540", iopk, "0", "0");
  iopkk.push(ma1a);
  iopkk.push(ma1b);
    iopkk.push(ma1bx);
  var ma1 = getel("إعدادات النظام", "55me", "k-icon k-i-settings", "right k-icon k-i-chevron-left", "#4564", iopkk, "0", "0");

  var ma2a = getel("فاتورة مبيعات", "55merv", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#1", iopk, "right badge badge-danger", "جديد");
  var ma2b = getel("مردود مبيعات", "55merav", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#2", iopk, "0", "0");
  var ma2c = getel("إعدادات", "55mervv", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#3", iopk, "right badge badge-danger", "جديد");
  var ma2d = getel("ترحيل", "55meravk", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#4", iopk, "0", "0");
  var ma2dd = getel("مراجعة الفواتير", "55meravkn", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#5", iopk, "0", "0");
  var ma2ddk = getel("المشتfرياsyyytockت", "55meravkny", "k-icon k-i-round-corners", "k-icon k-i-round-corners", "#415448", iopk, "0", "0");
  var iopkkv = [];
  iopkkv.push(ma2a);
  iopkkv.push(ma2b);
  iopkkv.push(ma2c);
  iopkkv.push(ma2d);
  iopkkv.push(ma2dd);
  //iopkkv.push(ma2ddk);
  var ma2 = getel("إدارة المبيعات", "55mey", "k-icon k-i-settings", "right k-icon k-i-chevron-left", "#45644", iopkkv, "0", "0");



  resul.push(ma1);
  resul.push(ma2);
  var tt = JSON.stringify(resul);

  // addm();
  var t = JSON.stringify({ "Name_Form": tt.toString(), "Event_Type": "menu" });
  // myComComponent.sendComment(t.toString());
  window.external.sendEvent(t.toString());
}
function getel(nam, id, a, b, he, lis, spanclass, spantext) {

  var o = new Object();
  o.menuname = nam;
  o.id = id;
  o.icona = a;
  o.iconb = b;
  o.herf = he;
  o.menulist = lis;
  o.spanclass = spanclass;
  o.spantext = spantext;
  return o;
}
function createone(jsd) {
  var q = document.getElementById("mm");
  var ss = q.getElementsByTagName("script")[ 0 ];
  if (ss == undefined) {
    var ff = document.createElement("script");
    var inlinscx = document.createTextNode(jsd);

    ff.appendChild(inlinscx);
    q.appendChild(ff);
  } else {
    var inlinscxx = document.createTextNode(jsd);
    ss.appendChild(inlinscxx);

  }

}

function createonestyle(jsd) {
  var q = document.getElementById("mm");
  var ss = q.getElementsByTagName("style")[ 0 ];
  if (ss == undefined) {
    var ff = document.createElement("style");
    var inlinscx = document.createTextNode(jsd);

    ff.appendChild(inlinscx);
    q.appendChild(ff);
  } else {
    var inlinscxx = document.createTextNode(jsd);
    ss.appendChild(inlinscxx);

  }

}
function checkforText(urll, d) {


}



function addm() {

  var ui = document.getElementById("first");





  var li = document.createElement("li");

  //li.appendChild(document.createTextNode("Four"));
  li.setAttribute("class", "nav-item");
  li.setAttribute("id", "element4");

  var a = document.createElement("a");
  a.setAttribute("class", "nav-link");
  a.setAttribute("href", "#88");


  var i = document.createElement("i");
  i.setAttribute("class", "nav-icon fas fa-tachometer-alt");
  a.appendChild(i);
  var p = document.createElement("p");
  p.appendChild(document.createTextNode("قائمة المبيعات"));
  // p.appendText("hhhhh");

  var ii = document.createElement("i");
  ii.setAttribute("class", "right fas fa-angle-left");
  p.appendChild(ii);
  a.appendChild(p);
  li.appendChild(a);

  li.appendChild(creatui('#748', 'uuu', '6665'));

  ui.appendChild(li);

}

function creatui(herff, idd, namm) {

  /*
  <li class="nav-item">
                      <a href="#" class="nav-link active">
                        <i class="far fa-circle nav-icon"></i>
                        <p>Active Page</p>
                      </a>
                    </li>
  */

  var lt = document.createElement("ul");
  lt.setAttribute("class", "nav nav-treeview");
  lt.appendChild(gcretli('#748', 'uuu', '6665'));
  lt.appendChild(gcretli('#76', 'cc', 'rrr'));
  lt.appendChild(gcretli('#759', '4dd', 'gggggg'));

  return lt;
}
function gcretli(herff, idd, namm) {
  var li = document.createElement("li");
  li.setAttribute("class", "nav-item");
  li.setAttribute("id", idd);

  var a = document.createElement("a");
  a.setAttribute("class", "nav-link");
  a.setAttribute("href", herff);
  var i = document.createElement("i");
  i.setAttribute("class", "far fa-circle nav-icon");
  a.appendChild(i);
  var p = document.createElement("p");
  p.appendChild(document.createTextNode(namm));
  a.appendChild(p);
  li.appendChild(a);
  return li;
}
$(document).ready(function () {

 var them= window.external.GetTheme();
  if (them=="Dark"){

    darkthem();
  }else{
    lighthem();

  }
  /*$("#notifications-switch").kendoSwitch();
$("#notifications-switch").data("kendoSwitch").bind("change", function (e) {
 
  if (e.checked) {
   // darkthem();
  }else{

    //lighthem();
  }
});*/



  var crudServiceBaseUrl = "https://demos.telerik.com/kendo-ui/service",
    dataSource = new kendo.data.DataSource({
      transport: {
        read: {
          url: crudServiceBaseUrl + "/detailproducts",
          dataType: "jsonp"
        },
        update: {
          url: crudServiceBaseUrl + "/detailproducts/Update",
          dataType: "jsonp"
        },
        destroy: {
          url: crudServiceBaseUrl + "/detailproducts/Destroy",
          dataType: "jsonp"
        },
        parameterMap: function (options, operation) {
          if (operation !== "read" && options.models) {
            return { models: kendo.stringify(options.models) };
          }
        }
      },
      batch: true,
      pageSize: 20,
      autoSync: true,
      aggregate: [ {
        field: "TotalSales",
        aggregate: "sum"
      } ],
      group: {
        field: "Category.CategoryName",
        dir: "desc",
        aggregates: [
          { field: "TotalSales", aggregate: "sum" }
        ]
      },
      schema: {
        model: {
          id: "ProductID",
          fields: {
            ProductID: { editable: false, nullable: true },
            Discontinued: { type: "boolean", editable: false },
            TotalSales: { type: "number", editable: false },
            TargetSales: { type: "number", editable: false },
            LastSupply: { type: "date" },
            UnitPrice: { type: "number" },
            UnitsInStock: { type: "number" },
            Category: {
              defaultValue: {
                CategoryID: 8,
                CategoryName: "Seafood"
              }
            },
            Country: {
              defaultValue: {
                CountryNameLong: "Bulgaria",
                CountryNameShort: "bg"
              }
            }
          }
        }
      }
    });

  $("#grid").kendoGrid({
    dataSource: dataSource,
    columnMenu: {
      filterable: false
    },
    height: 680,
    editable: "incell",
    pageable: true,
    sortable: true,
    navigatable: true,
    resizable: true,
    reorderable: true,
    groupable: true,
    filterable: true,
    dataBound: onDataBound,
    toolbar: [ "excel", "pdf", "search" ],
    columns: [ {
      selectable: true,
      width: 75,
      attributes: {
        "class": "checkbox-align",
      },
      headerAttributes: {
        "class": "checkbox-align",
      }
    }, {
      field: "ProductName",
      title: "Product Name",
      template: "<div class='product-photo' style='background-image: url(../content/web/foods/#:data.ProductID#.jpg);'></div><div class='product-name'>#: ProductName #</div>",
      width: 300
    }, {
      field: "UnitPrice",
      title: "Price",
      format: "{0:c}",
      width: 105
    }, {
      field: "Discontinued",
      title: "In Stock",
      template: "<span id='badge_#=ProductID#' class='badgeTemplate'></span>",
      width: 130,
    }, {
      field: "Category.CategoryName",
      title: "Category",
      editor: clientCategoryEditor,
      groupHeaderTemplate: "Category: #=data.value#, Total Sales: #=kendo.format('{0:c}', aggregates.TotalSales.sum)#",
      width: 125
    }, {
      field: "CustomerRating",
      title: "Rating",
      template: "<input id='rating_#=ProductID#' data-bind='value: CustomerRating' class='rating'/>",
      editable: returnFalse,
      width: 200
    }, {
      field: "Country.CountryNameLong",
      title: "Country",
      template: "<div class='k-text-center'><img src='../content/web/country-flags/#:data.Country.CountryNameShort#.png' alt='Kendo UI for jQuery Grid #: data.Country.CountryNameLong# Flag' title='#: data.Country.CountryNameLong#' width='30' /></div>",
      editor: clientCountryEditor,
      width: 120
    }, {
      field: "UnitsInStock",
      title: "Units",
      width: 105
    }, {
      field: "TotalSales",
      title: "Total Sales",
      format: "{0:c}",
      width: 140,
      aggregates: [ "sum" ],
    }, {
      field: "TargetSales",
      title: "Target Sales",
      format: "{0:c}",
      template: "<span id='chart_#= ProductID#' class='sparkline-chart'></span>",
      width: 220
    },
    { command: "destroy", title: "&nbsp;", width: 120 } ],
  });
});

function reloadkk(ff) {
  try {
    //var tt = JSON.stringify({ "formname": "hh", "tyeForm": 1 });
    // addm();
    //var t = JSON.stringify({ "Name_Form": tt, "Event_Type": "Open_Form" });
    // window.external.sendEvent(t.toString());
    // myComComponent.sendComment(t.toString());
    // var ggf = myComComponent.confirm("ffffffffffffffvxxxxxxvvvvvvvvyyyyyyyyyyyy","confrim data");
    ///  myComComponent.alert("ffffffffffffffvxxxxxxvvvvvvvvyyyyyyyyyyyy", "confrim data","2");

    //alert(ggf);
    var crudServiceBaseUrl = "https://demos.telerik.com/kendo-ui/service",
      dataSource = new kendo.data.DataSource({
        transport: {
          read: {
            url: crudServiceBaseUrl + "/detailproducts",
            dataType: "jsonp"
          },
          update: {
            url: crudServiceBaseUrl + "/detailproducts/Update",
            dataType: "jsonp"
          },
          destroy: {
            url: crudServiceBaseUrl + "/detailproducts/Destroy",
            dataType: "jsonp"
          },
          parameterMap: function (options, operation) {
            if (operation !== "read" && options.models) {
              return { models: kendo.stringify(options.models) };
            }
          }
        },
        batch: true,
        pageSize: 20,
        autoSync: true,
        aggregate: [ {
          field: "TotalSales",
          aggregate: "sum"
        } ],
        group: {
          field: "Category.CategoryName",
          dir: "desc",
          aggregates: [
            { field: "TotalSales", aggregate: "sum" }
          ]
        },
        schema: {
          model: {
            id: "ProductID",
            fields: {
              ProductID: { editable: false, nullable: true },
              Discontinued: { type: "boolean", editable: false },
              TotalSales: { type: "number", editable: false },
              TargetSales: { type: "number", editable: false },
              LastSupply: { type: "date" },
              UnitPrice: { type: "number" },
              UnitsInStock: { type: "number" },
              Category: {
                defaultValue: {
                  CategoryID: 8,
                  CategoryName: "Seafood"
                }
              },
              Country: {
                defaultValue: {
                  CountryNameLong: "Bulgaria",
                  CountryNameShort: "bg"
                }
              }
            }
          }
        }
      });
    $("#grid").kendoGrid({
      dataSource: dataSource,
      columnMenu: {
        filterable: false
      },
      height: 680,
      editable: "incell",
      pageable: true,
      sortable: true,
      navigatable: true,
      resizable: true,
      reorderable: true,
      groupable: true,
      filterable: true,
      dataBound: onDataBound,
      toolbar: [ "excel", "pdf", "search" ],
      columns: [ {
        selectable: true,
        width: 75,
        attributes: {
          "class": "checkbox-align",
        },
        headerAttributes: {
          "class": "checkbox-align",
        }
      }, {
        field: "ProductName",
        title: "Product Name",
        template: "<div class='product-photo' style='background-image: url(../content/web/foods/#:data.ProductID#.jpg);'></div><div class='product-name'>#: ProductName #</div>",
        width: 300
      }, {
        field: "UnitPrice",
        title: "Price",
        format: "{0:c}",
        width: 105
      }, {
        field: "Discontinued",
        title: "In Stock",
        template: "<span id='badge_#=ProductID#' class='badgeTemplate'></span>",
        width: 130,
      }, {
        field: "Category.CategoryName",
        title: "Category",
        editor: clientCategoryEditor,
        groupHeaderTemplate: "Category: #=data.value#, Total Sales: #=kendo.format('{0:c}', aggregates.TotalSales.sum)#",
        width: 125
      }, {
        field: "CustomerRating",
        title: "Rating",
        template: "<input id='rating_#=ProductID#' data-bind='value: CustomerRating' class='rating'/>",
        editable: returnFalse,
        width: 200
      }, {
        field: "Country.CountryNameLong",
        title: "Country",
        template: "<div class='k-text-center'><img src='../content/web/country-flags/#:data.Country.CountryNameShort#.png' alt='Kendo UI for jQuery Grid #: data.Country.CountryNameLong# Flag' title='#: data.Country.CountryNameLong#' width='30' /></div>",
        editor: clientCountryEditor,
        width: 120
      }, {
        field: "UnitsInStock",
        title: "Units",
        width: 105
      }, {
        field: "TotalSales",
        title: "Total Sales",
        format: "{0:c}",
        width: 140,
        aggregates: [ "sum" ],
      }, {
        field: "TargetSales",
        title: "Target Sales",
        format: "{0:c}",
        template: "<span id='chart_#= ProductID#' class='sparkline-chart'></span>",
        width: 220
      },
      { command: "destroy", title: "&nbsp;", width: 120 } ],
    });

  } catch (vv) {

    alert(vv.message);
  }

}
function onDataBound(e) {
  var grid = this;
  grid.table.find("tr").each(function () {
    var dataItem = grid.dataItem(this);
    var themeColor = dataItem.Discontinued ? 'success' : 'error';
    var text = dataItem.Discontinued ? 'available' : 'not available';

    $(this).find(".badgeTemplate").kendoBadge({
      themeColor: themeColor,
      text: text,
    });

    $(this).find(".rating").kendoRating({
      min: 1,
      max: 5,
      label: false,
      selection: "continuous"
    });

    $(this).find(".sparkline-chart").kendoSparkline({
      legend: {
        visible: false
      },
      data: [ dataItem.TargetSales ],
      type: "bar",
      chartArea: {
        margin: 0,
        width: 180,
        background: "transparent"
      },
      seriesDefaults: {
        labels: {
          visible: true,
          format: '{0}%',
          background: 'none'
        }
      },
      categoryAxis: {
        majorGridLines: {
          visible: false
        },
        majorTicks: {
          visible: false
        }
      },
      valueAxis: {
        type: "numeric",
        min: 0,
        max: 130,
        visible: false,
        labels: {
          visible: false
        },
        minorTicks: { visible: false },
        majorGridLines: { visible: false }
      },
      tooltip: {
        visible: false
      }
    });

    kendo.bind($(this), dataItem);
  });



}

function returnFalse() {
  return false;
}

function clientCategoryEditor(container, options) {
  $('<input required name="Category">')
    .appendTo(container)
    .kendoDropDownList({
      autoBind: false,
      dataTextField: "CategoryName",
      dataValueField: "CategoryID",
      dataSource: {
        data: categories
      }
    });
}

function clientCountryEditor(container, options) {
  $('<input required name="Country">')
    .appendTo(container)
    .kendoDropDownList({
      dataTextField: "CountryNameLong",
      dataValueField: "CountryNameShort",
      template: "<div class='dropdown-country-wrap'><img src='../content/web/country-flags/#:CountryNameShort#.png' alt='Kendo UI for jQuery Grid #: CountryNameLong# Flag' title='#: CountryNameLong#' width='30' /><span>#:CountryNameLong #</span></div>",
      dataSource: {
        transport: {
          read: {
            url: " https://demos.telerik.com/kendo-ui/service/countries",
            dataType: "jsonp"
          }
        }
      },
      autoWidth: true
    });
}

var categories = [ {
  "CategoryID": 1,
  "CategoryName": "Beverages"
}, {
  "CategoryID": 2,
  "CategoryName": "Condiments"
}, {
  "CategoryID": 3,
  "CategoryName": "Confections"
}, {
  "CategoryID": 4,
  "CategoryName": "Dairy Products"
}, {
  "CategoryID": 5,
  "CategoryName": "Grains/Cereals"
}, {
  "CategoryID": 6,
  "CategoryName": "Meat/Poultry"
}, {
  "CategoryID": 7,
  "CategoryName": "Produce"
}, {
  "CategoryID": 8,
  "CategoryName": "Seafood"
} ];
