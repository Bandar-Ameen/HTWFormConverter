using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;
using winToWeb.protouse;

namespace winToWeb.control
{
    public class viewSetting
    {
        public viewSetting() { }
        public string API_UserAgent { get { return GORS.Instance.API_UserAgent; } }
        /// <summary>
        /// تغير الاكسس توكن
        /// </summary>
   
        public System_seting_main_acount seting_sys
        {


            get
            {
            

                return GORS.Instance.seting_sys;
            }
        }
        

        public string System_seting_main { get { return GORS.Instance.System_seting_main; } }
        public int group_screennumber { get { return GORS.Instance.group_screennumber; } }
        public int sience_screennumber { get { return GORS.Instance.sience_screennumber; } }
        public int A_alfa { get { return GORS.Instance.A_alfa; } }
        public int A_stock { get { return GORS.Instance.A_stock; } }
        public int A_groub_connect { get { return GORS.Instance.A_groub_connect; } }
        public int company_screennumber { get { return GORS.Instance.company_screennumber; } }
        public int currancy_screennumber { get { return GORS.Instance.currancy_screennumber; } }
        public string Date_fromate { get { return GORS.Instance.Date_fromate; } }
        public int Date_typ { get { return GORS.Instance.Date_typ; } }
        public bool Date_enable { get { return GORS.Instance.Date_enable; } }
        public bool A_daloge { get { return GORS.Instance.A_daloge; } }

        public bool A_alert { get { return GORS.Instance.A_alert; } }
        public bool A_sound { get { return GORS.Instance.A_sound; } }
        public Boolean disablec { get { return GORS.Instance.disablec; } }

        public string fontnameeyeornot { get { return GORS.Instance.fontnameeyeornot; } }
        public string fontnamee { get { return GORS.Instance.fontnamee; } }

        public string Useridc { get { return GORS.Instance.Useridc; } }
        public string API_URL { get { return GORS.Instance.API_URL; } }
        public string API_Username { get { return GORS.Instance.API_Username; } }

        public string API_Ref { get { return GORS.Instance.API_Ref; } }
        public string API_AcessToken { get { return GORS.Instance.API_AcessToken; } }


        public int Use_type_barcode { get { return GORS.Instance.Use_type_barcode; } }
        public bool showMEssageStatuse { get { return GORS.Instance.showMEssageStatuse; } }
    
        public bool inforceShowConfirmMessage { get { return GORS.Instance.inforceShowConfirmMessage; } }

    }
    public class ReadTextAsHtml {

        public void ActualizarMenuss(HtmlNode radTreeView1)
        {

            foreach (HtmlNode node in radTreeView1.ChildNodes)
            {
                RunNodee(node);
                setatt(node);

            }
   //  root = new TreeviewPersist_json("root", parents,false,null,null);

   ;
        }
        public string GetPureHml(string htmltext)
        {
            string res = "0";
            HtmlAgilityPack.HtmlDocument ggf = new HtmlAgilityPack.HtmlDocument();
            string cc = Assembly.GetExecutingAssembly().Location;
            ggf.LoadHtml(htmltext);




            ActualizarMenuss(ggf.DocumentNode);


            //  MessageBox.Show(ssd);
            res = ggf.DocumentNode.InnerHtml;

            return res;
        }
        public string GetPureHmlToUrl(string htmltext)
        {
            try
            {
                var gettext = GetPureHml(htmltext);

                var ger = System.IO.Path.GetTempPath();
                var newguid = ger + @"" + Guid.NewGuid().ToString() + ".html";
                File.WriteAllText(newguid, gettext);
                var urllk = "file:///" + newguid.Replace(@"\", "/");

                return urllk;
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }
        private void RunNodee(HtmlNode node)
        {

            foreach (HtmlNode child in node.ChildNodes)
            {
                RunNodee(child);
                setatt(child);


            }

        }
        public bool checkres(string ttt)
        {

            try
            {
                if (Regex.IsMatch(ttt, @"^(http[s]{0,1}:\/\/|\\\\)"))
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {

                return false;
            }
        }
        private void setatt(HtmlNode node)
        {

            foreach (var yy in node.Attributes)
            {

                if (yy.Name.ToLower().Equals("src"))
                {
                    if (!checkres(yy.Value))
                    {
                        if (!yy.Value.StartsWith("#"))
                        {
                            if (yy.Value.StartsWith("/"))
                            {
                                yy.Value = Urllk + yy.Value;
                            }
                            else
                            {

                                yy.Value = Urllk + "/" + yy.Value;
                            }
                        }
                    }


                    //  MessageBox.Show(yy.Value);
                }
                else if (yy.Name.ToLower().Equals("href"))
                {
                    if (!checkres(yy.Value))
                    {
                        if (!yy.Value.StartsWith("#"))
                        {
                            if (yy.Value.StartsWith("/"))
                            {
                                yy.Value = Urllk + yy.Value;
                            }
                            else
                            {

                                yy.Value = Urllk + "/" + yy.Value;
                            }
                        }
                    }


                    //  MessageBox.Show(yy.Value);
                }
            }
        }

        private string urllk;
        public string Urllk
        {
            get
            {

                if (urllk == null)
                {
                    string cc = Assembly.GetExecutingAssembly().Location;



                    urllk = "file:///" + Path.GetDirectoryName(cc).Replace(@"\", "/");
                }
                return urllk;
            }


        }

    }
    public class AttributeJS {

        public string key { get; set; }
        public string value { get; set; }

    }
    public class AttributeJSwithhava
    {

        public string script { get; set; }
        public List<AttributeJS> attribute { get; set; }
        public bool withsrc { get; set; }

    }
    public class filedownload {

        public string filename { get; set; }
        public string fileurl { get; set; }
        public string virstion { get; set; }
    }
    public class getdependencys {



        private static string GetSitings;
        public static string getSetting
        {

            get
            {
                if (GetSitings == null) {
                    GetSitings = JsonConvert.SerializeObject(GORS.Instance);
                }
                return GetSitings;
                    }
        }
        public static void restSettings() {
            GetSitings = null;
        }
        public static void RestTemp() {

            try
            {
                DirectoryInfo em = new DirectoryInfo(System.IO.Path.GetTempPath());
                FileInfo[] inf = em.GetFiles("*.html");


                //var i = Path.GetDirectoryName(getdependencys.Urllk);
                foreach (var it in inf)
                {

                    it.Delete();

                    //  it.
                }
            }
            catch (Exception ex) {


            }
        }
        private static string themname;
        public static string GetThem {

            get {

                return themname;
            }
        }
        public static void setThem(string themnamex) {
            themname = themnamex;

        }
        public static string getFunction {

            get {
                string eeee = "alert('ggggggggggggggg');";
                string functiondat = @"

function darkthem() {
try{  

window.parent.postMessage({
    'func': 'parentFunc',
    'message': 'Message text from iframe.'
  }, "" * "");*/
  var t = window.external.geturl(""0"");
  $('body > link')[0].href = t + ""/plugins/kendo.default-main-darkk.min.css"";
  // alert(c);
  $(document.body).removeClass(""k-content"");
  $(document.body).addClass(""k-content"");
  $(document.body).addClass(""sc"");
  $('body').addClass('dark-mode');

                var $sidebar = $('.control-sidebar');
                var $sidebarr = $('.main-sidebar');
                var $sidebarrfooter = $('.main-footer');
  $sidebarrfooter.removeClass(""k-content"");
  $sidebarrfooter.addClass(""k-content"");
  $sidebarr.removeClass('sidebar-light-primary');
  $sidebarr.addClass('sidebar-dark-primary');
                var $main_header = $('.main-header');
  $main_header.removeClass('navbar-light');
  $main_header.addClass('navbar-dark');
  $sidebar.removeClass('control-sidebar-light');
  $sidebar.addClass('control-sidebar-dark');
                var t = JSON.stringify({ ""Name_Form"": ""Liget"", ""Event_Type"": ""Change_Them_Dark"" });
                myComComponent.sendComment(t.toString());
                window.external.sendEvent(t.toString());
}catch(ex){
alert('yttttttttttttttt');
}

            }


function lighthem() {
try{  

var t = window.external.geturl(""0"");

  $('body > link')[0].href = t + ""/plugins/kendo.default-main.minlight.css"";
  // alert(c);
  $(document.body).removeClass(""k-content"");
  $(document.body).removeClass(""sc"");
  $(document.body).addClass(""k-content"");
  $('body').removeClass('dark-mode');

                var $sidebar = $('.control-sidebar');
                var $sidebarr = $('.main-sidebar');

  $sidebarr.removeClass('sidebar-dark-primary');
  $sidebarr.addClass('sidebar-light-primary');

                var $sidebarrfooter = $('.main-footer');
  $sidebarrfooter.removeClass(""k-content"");
  $sidebarrfooter.addClass(""k-content"");
                var $main_header = $('.main-header');
  $main_header.removeClass('navbar-dark');
  $main_header.addClass('navbar-light');

  $sidebar.removeClass('control-sidebar-dark');
  $sidebar.addClass('control-sidebar-light');
                var t = JSON.stringify({ ""Name_Form"": ""Liget"", ""Event_Type"": ""Change_Them_Light"" });
                myComComponent.sendComment(t.toString());
                window.external.sendEvent(t.toString());



            }catch(ex){
alert('ytttttttttttttttmmmm');
}
            }
";
                return functiondat;
            }

        }

        private static string ThemeSystem;

        public static string ThemeType
        {
            get
            {
                if (ThemeSystem == null) {
                    ThemeSystem = "Light";
                }
               
                return ThemeSystem;
            }
        }
        public static void ChangeThem(string them) {

            ThemeSystem = them;

        }
        public static List<filedownload> filedownload
        {
            get
            {

                load();
                return filedownloadx;
            }
        }

        private static List<filedownload> filedownloadx;

        private static void load() {
            string filenameurl = "http://127.0.0.1:8080/wind/";
            string verstin = "0";
            if (filedownloadx == null) {

                filedownloadx = new List<control.filedownload>();
                /*  foreach (var ii in dependencyname)
                  {
                      filedownloadx.Add(new control.filedownload { filename = ii, fileurl = filenameurl+ii, virstion = verstin });
                  }*/
                var liburl = "https://drive.usercontent.google.com/download?id=1_-RfYZDxYEgFp92Zv-XkiNtsIIMvmP5M&export=download&confirm=t&uuid=0";
                filedownloadx.Add(new control.filedownload { filename = "web.zip", fileurl = filenameurl + "web.zip", virstion = verstin });
                filedownloadx.Add(new control.filedownload { filename = "lib.zip", fileurl = liburl, virstion = verstin });
             //   filedownloadx.Add(new control.filedownload { filename = "my.js", fileurl = filenameurl + "my.js", virstion = verstin });
              //  filedownloadx.Add(new control.filedownload { filename = "ex.txt", fileurl = filenameurl + "ex.txt", virstion = verstin });
               // filedownloadx.Add(new control.filedownload { filename = "exm.txt", fileurl = filenameurl + "exm.txt", virstion = verstin });
            }
           

        }
        public static string[] dependencyname = new string[] { "Telerik.WinControls.dll", "Telerik.WinControls.GridView.dll"
            ,"Telerik.WinControls.PdfViewer.dll","Telerik.WinControls.RadMap.dll","Telerik.WinControls.RichTextEditor.dll","Telerik.WinControls.Themes.CrystalDark.dll","Telerik.WinControls.Themes.Office2013Light.dll",
            "Telerik.WinControls.Themes.VisualStudio2012Dark.dll","Telerik.WinControls.Themes.VisualStudio2012Light.dll","Telerik.WinControls.UI.dll",
            "Telerik.Windows.Documents.Core.dll","Telerik.Windows.Documents.Fixed.dll","Telerik.Windows.Zip.dll","TelerikCommon.dll","UserControlInHtmll.dll",
            "Winforms.Plugins.Shared.dll","RestSharp.dll"

        };
        public static string urlDownload="https://github.com/ColorlibHQ/AdminLTE/archive/refs/tags/";//"http://127.0.0.1:8080/wind/";
        private static string urllk;
    public static string Urllk
    {
        get
        {

            if (urllk == null)
            {
                string cc = Assembly.GetExecutingAssembly().Location;



                    urllk = cc;//"file:///" + Path.GetDirectoryName(cc).Replace(@"\", "/");
            }
            return urllk;
        }
    }

    }
    public class datafile {

        public string url { get; set; }
        public string path { get; set; }
    }
    public class mmd5
    {




        public static string myMD5(string input, bool a = false)
        {
            if (a)
            {

                // Use input string to calculate MD5 hash
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }
            else
            {


                using (var md5Hash = MD5.Create())
                {
                    // Byte array representation of source string
                    var sourceBytes = Encoding.UTF8.GetBytes(input);

                    // Generate hash value(Byte Array) for input data
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);

                    // Convert hash byte array to string
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                    // Output the MD5 hash
                    return hash;
                }



            }
        }
    }

    public class MyTypeConverter : TypeConverter
    {
        public bool checkres(string ttt)
        {

            try
            {
                if (Regex.IsMatch(ttt, @"^([a-zA-Z]{0,1}:\\|http[s]{0,1}:\/\/|\\\\)"))
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {

                return false;
            }
        }
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType.Equals(typeof(Image)))
                return true;

            return base.CanConvertTo(context, destinationType);
        }
        public  Image ConvertBase64ToImage(byte[] bytes)
        {
            //  var bytes = Convert.FromBase64String(base64);

            using (var memory = new MemoryStream(bytes, 0, bytes.Length))
            {
                return Image.FromStream(memory, true);
            }
        }
        public override object ConvertTo(ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType.Equals(typeof(Image)))
            {

                if (checkres(value.ToString()))
                {
                    WebRequest request = System.Net.WebRequest.Create(value + "");

                    using (var response = request.GetResponse())
                    {
                        using (var stream = response.GetResponseStream())
                        {
                            return Bitmap.FromStream(stream);
                        }
                    }
                }
                else {
                  
                    var e = Convert.FromBase64String(value.ToString());
                   
                    return ConvertBase64ToImage(e);

                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
    public static class ExtensionMethods
    {
        public static string EncodeBase64(this string value)
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        }

        public static string DecodeBase64(this string value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }
    }
    public class respon_messages
    {
        public string message { get; set; }
        public string statuseCode { get; set; }

        public object Data { get; set; }
    }
    public class AA_PI
    {
     


        public class ref_a
        {

            public string oldtoken { get; set; }
            public string reftoken { get; set; }

        }
    

        public Task<IRestResponse> Getresponsee(string URL, RestRequest bb)
        {
            return Task.Run(() =>
            {


                try
                {
                    var client = new RestClient(URL);
                    // client.UserAgent = get_userAgent.User_agent();

                    client.Timeout = -1;



                    IRestResponse response = client.Execute(bb);


                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + URL);
                    return null;
                }

            });
        }
        public Task<IRestResponse> Getresponse(string URL, RestRequest bb)
        {
            return Task.Run(() =>
            {


                try
                {
                  //  MessageBox.Show(JsonConvert.SerializeObject(bb.Parameters));
                    var client = new RestClient(URL);
                   // client.UserAgent = get_userAgent.User_agent();

                    client.Timeout = -1;



                    IRestResponse response = client.Execute(bb);

                    try
                    {
                        var ggert = JsonConvert.DeserializeObject<respon_messages>(response.Content);
                        response.Content = ggert.Data.ToString();

                    }
                    catch (JsonSerializationException ex)
                    {

                    }
                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + URL);
                    return null;
                }

            });
        }
    }
    public class dynim
    {











   

    }


    public class fromDesignData {
        public string FormName { get; set; }
        public string ApiName { get; set; }
        private int rowcount = 1;
        public JToken FormDesign
        {
            get
            {
                return formDesign;
            }

            set
            {
                formDesign = value;
            }
        }

        public int Rowcount
        {
            get
            {
                return rowcount;
            }

            set
            {
                rowcount = value;
            }
        }

        private JToken formDesign = JToken.Parse("[]");


    }
    public enum evntype {

        load,save,delete,update,refresh,reload


    }
    public class data
    {
        public bool show { get; set; }
        public string DisName { get; set; }
        public string FieldName { get; set; }

        private JToken proper = JToken.Parse("[]");

        private JToken g=JToken.Parse("[]");
        private bool checknull=false;
        public string TypeName { get; set; }

        [JsonIgnore]
        public Type FieldType { get{
                Type t = null;
                if (TypeName.ToLower().StartsWith("in")) {

                   t= typeof(Int32);
                }
          
                if (TypeName.ToLower().StartsWith("boo"))
                {

                  t= typeof(bool);
                }
                if (TypeName.ToLower().StartsWith("st"))
                {

                   t= typeof(string);
                }
                if (TypeName.ToLower().StartsWith("date"))
                {

                    t = typeof(DateTime);
                }
                if (TypeName.ToLower().StartsWith("dec"))
                {

                    t = typeof(decimal);
                }
                if (TypeName.ToLower().StartsWith("dou"))
                {

                    t = typeof(double);
                }
                if (TypeName.ToLower().StartsWith("im"))
                {

                    t = typeof(Image);
                }

                if (TypeName.ToLower().StartsWith("enu"))
                {

                    var i = new Dictionary<string, int>();

                    foreach (var w in Enumvalue.ToArray()) {
                        int f = (int)w.SelectToken("id");
                        string nam = w.SelectToken("name").ToString();
                        i.Add(nam,f);
                    }

                    var h = MyTypeBuilder.getenum(i);
                    t = h.GetType();
                }

                return t;
            } }

        public JToken Enumvalue
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }

        public JToken Settings
        {
            get
            {
                return proper;
            }

            set
            {
                proper = value;
            }
        }

        public bool Checknull
        {
            get
            {
                return checknull;
            }

            set
            {
                checknull = value;
            }
        }
    }
        public static class MyTypeBuilder
    {
        public static void CreateNewObject()
        {
          //  var myType = CompileResultType();
            //var myObject = Activator.CreateInstance(myType);
        }

        public static object getclass(List<data> yourListOfFields) {
            var myType = CompileResultType(yourListOfFields);
            var myObject = Activator.CreateInstance(myType);

            return myObject;
        }
        public static Type CompileResultType(List<data> yourListOfFields)
        {
            System.Reflection.Emit.TypeBuilder tb = GetTypeBuilder();
            ConstructorBuilder constructor = tb.DefineDefaultConstructor(MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);

            // NOTE: assuming your list contains Field objects with fields FieldName(string) and FieldType(Type)
            foreach (var field in yourListOfFields)
                CreateProperty(tb, field.FieldName, field.FieldType,field.DisName,field.show);

            Type objectType = tb.CreateType();
            return objectType;
        }

        private static TypeBuilder GetTypeBuilder()
        {
            var typeSignature = "MyDynamicType";
            var an = new AssemblyName(typeSignature);
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
            TypeBuilder tb = moduleBuilder.DefineType(typeSignature,
                    TypeAttributes.Public |
                    TypeAttributes.Class |
                    TypeAttributes.AutoClass |
                    TypeAttributes.AnsiClass |
                    TypeAttributes.BeforeFieldInit |
                    TypeAttributes.AutoLayout,
                    null);
            
            return tb;
        }
        private static EnumBuilder GetTypeBuilderenum()
        {
            var typeSignature = "MyDynamicTypee";
            var an = new AssemblyName(typeSignature);
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModulee");
         var tb = moduleBuilder.DefineEnum("lang",TypeAttributes.Public,typeof(Int32));

            return tb;
        }
        public static Enum getenum(Dictionary<string,Int32> dat) {
            System.Reflection.Emit.EnumBuilder tb = GetTypeBuilderenum();
            foreach (var h in dat) {
                tb.DefineLiteral(h.Key,h.Value);
               
            }

            Type g = tb.CreateType();

            Enum vv = (Enum)Activator.CreateInstance(g);

            Type j = vv.GetType();
          //  DefaultValueAttribute[] att =(DefaultValueAttribute[]) j.GetCustomAttributes(typeof(DefaultValueAttribute), false);


            return vv;


        }
      
        private static void CreateProperty(TypeBuilder tb, string propertyName, Type propertyType,string displayname,bool b)
        {
            FieldBuilder fieldBuilder = tb.DefineField("_" + propertyName, propertyType, FieldAttributes.Private);

            PropertyBuilder propertyBuilder = tb.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);
            MethodBuilder getPropMthdBldr = tb.DefineMethod("get_" + propertyName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, propertyType, Type.EmptyTypes);
            ILGenerator getIl = getPropMthdBldr.GetILGenerator();

            getIl.Emit(OpCodes.Ldarg_0);
            getIl.Emit(OpCodes.Ldfld, fieldBuilder);
            getIl.Emit(OpCodes.Ret);

            MethodBuilder setPropMthdBldr =
                tb.DefineMethod("set_" + propertyName,
                  MethodAttributes.Public |
                  MethodAttributes.SpecialName |
                  MethodAttributes.HideBySig,
                  null, new[] { propertyType });

            ILGenerator setIl = setPropMthdBldr.GetILGenerator();
            System.Reflection.Emit.Label modifyProperty = setIl.DefineLabel();
            System.Reflection.Emit.Label exitSet = setIl.DefineLabel();
            
            setIl.MarkLabel(modifyProperty);
            setIl.Emit(OpCodes.Ldarg_0);
            setIl.Emit(OpCodes.Ldarg_1);
            setIl.Emit(OpCodes.Stfld, fieldBuilder);

            setIl.Emit(OpCodes.Nop);
            setIl.MarkLabel(exitSet);
            setIl.Emit(OpCodes.Ret);
            /*  object dd = "xxxxxxxx";
              if (propertyType.Name.Equals("String"))
              {
                  dd = "hhhhhhhhhh";
              }
              if (propertyType.Name.Equals("Int32"))
              {

              }
              if (propertyType.Name.Equals("Boolean"))
              {

                  dd = true;
              }
              MessageBox.Show(propertyType.Name + dd.ToString());
              Type[] gl = new Type[] { typeof(int) };
              dd = 0;
              ConstructorInfo kkm = typeof(RadRangeAttribute).GetConstructor(gl);

              CustomAttributeBuilder vvv = new CustomAttributeBuilder(kkm, new object[] { 0});
              propertyBuilder.SetCustomAttribute(vvv);*/
          /*  if (propertyType.Name.Equals("Int32"))
            {
                Type[] g = new Type[] { propertyType };

                ConstructorInfo k = typeof(RadRangeAttribute).GetConstructor(new Type[] { typeof(long), typeof(long) });
                  ConstructorInfo kk = typeof(RadRangeAttribute).GetConstructor(g);
                  

                CustomAttributeBuilder v = new CustomAttributeBuilder(k, new object[] { long.Parse("0"), long.Parse("50") });
                /*    CustomAttributeBuilder vv = new CustomAttributeBuilder(kk, new object[] { dd });
                    propertyBuilder.SetCustomAttribute(vv);
                
                propertyBuilder.SetCustomAttribute(v);
            }*/
        ConstructorInfo kk = typeof(DisplayNameAttribute).GetConstructor(new Type[] { typeof(string) });
        CustomAttributeBuilder vv = new CustomAttributeBuilder(kk, new object[] { displayname });

            ConstructorInfo kkm = typeof(BrowsableAttribute).GetConstructor(new Type[] { typeof(bool) });
            CustomAttributeBuilder vvv = new CustomAttributeBuilder(kkm, new object[] { b });
            propertyBuilder.SetCustomAttribute(vv);
            propertyBuilder.SetCustomAttribute(vvv);
            propertyBuilder.SetGetMethod(getPropMthdBldr);
            propertyBuilder.SetSetMethod(setPropMthdBldr);
        }
    }

    static class FieldsHelper
    {
        public static List<string> AddressFields = new List<string>() { "AddressLine1", "AddressLine2", "City", "StateProvince", "PostalCode", "ModifiedDate" };
        public static List<string> PurchaseOrderHeaderFields = new List<string>() { "OrderStatus", "OrderDate", "ShipDate", "SubTotal", "TaxAmt", "Freight", "TotalDue", "ModifiedDate", "ShipMethod", "Vendor" };
        public static List<string> VendorFields = new List<string> { "AccountNumber", "Name", "CreditRating", "PreferredVendorStatus", "ActiveFlag", "PurchasingWebServiceURL", "ModifiedDate" };
        public static List<string> InventoriesFields = new List<string> { "ProductNumber", "Product", "Quantity", "Color", "StockLevel", "Size", "Price", "Cost", "Shelf", "Bin", "Location" };
        public static List<string> WorkOrdersFields = new List<string> { "Product", "OrderQty", "StockedQty", "ScrappedQty", "StartDate", "EndDate", "DueDate", "ModifiedDate" };
        public static List<string> BillOfMaterialsFields = new List<string> { "Product", "Product1", "StartDate", "EndDate", "BOMLevel", "UnitMeasure", "PerAssemblyQty", "ModifiedDate" };
        public static List<string> OrdersFields = new List<string> { "SalesOrderNumber", "Customer", "DueDate", "OnlineOrderFlag", "AccountNumber", "SubTotal", "TaxAmt", "Freight", "TotalDue", "ShipMethod" };
        public static List<string> StoresFields = new List<string> { "AccountNumber", "CompanyName", "StoreContact", "EmailAddress", "Phone", "AddressLine1", "City", "State", "ModifiedDate" };
        public static List<string> IndividualsFields = new List<string> { "AccountNumber", "FirstName", "LastName", "EmailAddress", "Phone", "AddressLine1", "City", "State", "ModifiedDate" };
    }
    public class DataDialogCommandEventArgs : EventArgs
    {
        public bool SavaChanges { get; private set; }

        public DataDialogCommandEventArgs(bool saveChanges)
        {
            this.SavaChanges = saveChanges;
        }
    }
}
