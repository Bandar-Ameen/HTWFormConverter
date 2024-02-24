using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing.Html;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UserControlInHtmll;

namespace dynFormLib
{
    public class hedaervalue
    {
        public string hederkey { get; set; }
        public string hedervalue { get; set; }

    }
    public class controlEvent {
        public string controlname { get; set; }
        public string controlEventname { get; set; }

    }
    public class EventOnchange
    {
        public Eventhtml datahtml { get; set; }

        public JToken columnvalue { get; set; }

    }
        public class Eventhtml {

        public string eventName { get; set; }
        public Dictionary<string, object> attEvent { get; set; }
        public string DataEvent { get; set; }
        public string sourceid { get; set; }
        public List<controlEvent> EventControl
        {
            get
            {

                List<controlEvent> ut = new List<controlEvent>();
                try
                {
                    string daiop = "0";
                    foreach (var iiop in attEvent)
                    {
                        var valu = iiop.Value.ToString().Split(':');
                        if (valu.Length > 0)
                        {

                            daiop = iiop.Value.ToString();
                        }

                    }
                    if (!daiop.Equals("0"))
                    {

                        MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                        //Scan matches
                        foreach (Match match in matches)
                        {
                            //Split match by colon
                            string[] chunks = match.Value.Split(':');
                            controlEvent dd = new controlEvent();
                            if (chunks.Length != 2) continue;

                            //Extract property name and value
                            string propName = chunks[0].Trim();
                            string propValue = chunks[1].Trim();

                            //Remove semicolon
                            if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                            //Add property to list
                            dd.controlEventname = propValue;
                            dd.controlname = propName;

                            ut.Add(dd);

                        }

                    }
                }
                catch (Exception ex) {
                }
                return ut;



            }
        }

        public List<DataSource> datao{get;set;}

    }

    public class DataSource
    {

        public string sourceName { get; set; }
        public Dictionary<string, object> hedaer { get; set; }
        public Dictionary<string, object> queryurl { get; set; }
        public Dictionary<string, object> body { get; set; }

        public Dictionary<string, object> anotherdata { get; set; }
        public string data { get; set; }
        public string url { get; set; }
        public string methodtype { get; set; }
        public List<hedaervalue> headervalues
        {
            get
            {

                List<hedaervalue> ut = new List<hedaervalue>();
                try
                {
                    string daiop = "0";
                    foreach (var iiop in hedaer)
                    {
                        var valu = iiop.Value.ToString().Split(':');
                        if (valu.Length > 0)
                        {

                            daiop = iiop.Value.ToString();
                        }

                    }
                    if (!daiop.Equals("0"))
                    {

                        MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                        //Scan matches
                        foreach (Match match in matches)
                        {
                            //Split match by colon
                            string[] chunks = match.Value.Split(':');
                            hedaervalue dd = new hedaervalue();
                            if (chunks.Length != 2) continue;

                            //Extract property name and value
                            string propName = chunks[0].Trim();
                            string propValue = chunks[1].Trim();

                            //Remove semicolon
                            if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                            //Add property to list
                            dd.hedervalue = propValue;
                            dd.hederkey = propName;

                            ut.Add(dd);

                        }

                    }
                }
                catch (Exception ex)
                {
                }
                return ut;



            }
        }

        public List<hedaervalue> querydat
        {
            get
            {

                List<hedaervalue> ut = new List<hedaervalue>();
                try
                {
                    string daiop = "0";
                    foreach (var iiop in queryurl)
                    {
                        var valu = iiop.Value.ToString().Split(':');
                        if (valu.Length > 0)
                        {

                            daiop = iiop.Value.ToString();
                        }

                    }
                    if (!daiop.Equals("0"))
                    {

                        MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                        //Scan matches
                        foreach (Match match in matches)
                        {
                            //Split match by colon
                            string[] chunks = match.Value.Split(':');
                            hedaervalue dd = new hedaervalue();
                            if (chunks.Length != 2) continue;

                            //Extract property name and value
                            string propName = chunks[0].Trim();
                            string propValue = chunks[1].Trim();

                            //Remove semicolon
                            if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                            //Add property to list
                            dd.hedervalue = propValue;
                            dd.hederkey = propName;

                            ut.Add(dd);

                        }

                    }
                }
                catch (Exception ex)
                {
                }
                return ut;



            }
        }

        public List<hedaervalue> bodyata
        {
            get
            {

                List<hedaervalue> ut = new List<hedaervalue>();
                try
                {
                    string daiop = "0";
                    foreach (var iiop in body)
                    {
                        var valu = iiop.Value.ToString().Split(':');
                        if (valu.Length > 0)
                        {

                            daiop = iiop.Value.ToString();
                        }

                    }
                    if (!daiop.Equals("0"))
                    {

                        MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                        //Scan matches
                        foreach (Match match in matches)
                        {
                            //Split match by colon
                            string[] chunks = match.Value.Split(':');
                            hedaervalue dd = new hedaervalue();
                            if (chunks.Length != 2) continue;

                            //Extract property name and value
                            string propName = chunks[0].Trim();
                            string propValue = chunks[1].Trim();

                            //Remove semicolon
                            if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                            //Add property to list
                            dd.hedervalue = propValue;
                            dd.hederkey = propName;

                            ut.Add(dd);

                        }

                    }
                }
                catch (Exception ex)
                {
                }
                return ut;



            }
        }

        public List<hedaervalue> anotherdataget
        {
            get
            {

                List<hedaervalue> ut = new List<hedaervalue>();
                try
                {
                    string daiop = "0";
                    foreach (var iiop in anotherdata)
                    {
                        var valu = iiop.Value.ToString().Split(':');
                        if (valu.Length > 0)
                        {

                            daiop = iiop.Value.ToString();
                        }

                    }
                    if (!daiop.Equals("0"))
                    {

                        MatchCollection matches = Parser.Match(Parser.CssProperties, daiop);

                        //Scan matches
                        foreach (Match match in matches)
                        {
                            //Split match by colon
                            string[] chunks = match.Value.Split(':');
                            hedaervalue dd = new hedaervalue();
                            if (chunks.Length != 2) continue;

                            //Extract property name and value
                            string propName = chunks[0].Trim();
                            string propValue = chunks[1].Trim();

                            //Remove semicolon
                            if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                            //Add property to list
                            dd.hedervalue = propValue;
                            dd.hederkey = propName;

                            ut.Add(dd);

                        }

                    }
                }
                catch (Exception ex)
                {
                }
                return ut;



            }
        }

    }
    public   class Radconverttojson
    {
        private List<Eventhtml> evntnaml;
        private Telerik.WinControls.UI.RadValidationRule allnull;
        public Radconverttojson(List<Eventhtml> u) {
            evntnaml = u;
            imagesvggx = new Dictionary<string, object>();

            fromhtml = new Dictionary<string, object>();
        }
        private Dictionary<string, object> imagesvggx;
        private Dictionary<string, object> fromhtml;
        private RecevDataFromWeb getset;
        private winToWeb.control.OnReciveForm onform;
        public Radconverttojson(List<Eventhtml> u, Telerik.WinControls.UI.RadValidationRule alnulfex, Dictionary<string, object> imagesvgg, Dictionary<string, object> fromhtmlx)
        {
            evntnaml = u;
            allnull = alnulfex;
            imagesvggx = imagesvgg;
            this.fromhtml = fromhtmlx;
        }
        public Radconverttojson(List<Eventhtml> u, Telerik.WinControls.UI.RadValidationRule alnulfex, Dictionary<string, object> imagesvgg, Dictionary<string, object> fromhtmlx, RecevDataFromWeb getsett, winToWeb.control.OnReciveForm on)
        {
            getset = getsett;
            evntnaml = u;
            onform = on;
            allnull = alnulfex;
            imagesvggx = imagesvgg;
            this.fromhtml = fromhtmlx;
        }
        private TreeviewPersist_json root;
        public attribAnddStyle CssBlock(HtmlNode gg)

        {
            
            List<Attributes> k = new List<Attributes>();
            
            string style = "0";
            foreach (var qqv in gg.Attributes)
            {
                try
                {

                    if (qqv.Name.ToLower().Equals("style"))
                    {
                        style = qqv.Value;
                    }
                    else {
                        Attributes j = new Attributes();
                        j.AttributeNme = qqv.Name;
                        j.AttributeValue = qqv.Value;
                        k.Add(j);
                    }
                   
                }
                catch (Exception)
                {

                }

            }
            Dictionary<string, string> Properties = new Dictionary<string, string>();

            //Extract property assignments
            MatchCollection matches = Parser.Match(Parser.CssProperties, style);

            //Scan matches
            foreach (Match match in matches)
            {
                //Split match by colon
                string[] chunks = match.Value.Split(':');

                if (chunks.Length != 2) continue;

                //Extract property name and value
                string propName = chunks[0].Trim();
                string propValue = chunks[1].Trim();

                //Remove semicolon
                if (propValue.EndsWith(";")) propValue = propValue.Substring(0, propValue.Length - 1).Trim();

                //Add property to list
                Properties.Add(propName, propValue);


            }
            attribAnddStyle f = new attribAnddStyle();
            f.style = Properties;
            f.attr = k;
            return f;
        }
    
        private async Task<List<TreeviewPersist_json>> RunNode(HtmlNode node)
        {
            List<TreeviewPersist_json> nodeOut = new List<TreeviewPersist_json>();
            
            foreach (HtmlNode child in node.ChildNodes)
            {
                List<TreeviewPersist_json> grandchild =await RunNode(child);

                
                    var getpropertyes = CssBlock(child);
               
                if (!child.Name.Equals("#text"))
                {

                    nodeOut.Add(new TreeviewPersist_json(child.Name, grandchild, false, getpropertyes.style, getpropertyes.attr, evntnaml, allnull, imagesvggx,fromhtml, getset,onform));
                   await Task.Delay(50);
                }
                }
            return nodeOut;
        }

       public async Task<TreeviewPersist_json> ActualizarMenus(HtmlNode radTreeView1)
        {
            List<TreeviewPersist_json> parents = new List<TreeviewPersist_json>();
            foreach (HtmlNode node in radTreeView1.ChildNodes)
            {
                List<TreeviewPersist_json> childs =await RunNode(node);
                var getpropertyes = CssBlock(node);
                if (!node.Name.Equals("#text"))
                {
                    parents.Add(new TreeviewPersist_json(node.Name, childs, false, getpropertyes.style, getpropertyes.attr, evntnaml, allnull, imagesvggx,fromhtml, getset,onform));
                }
              
                }
          //  root = new TreeviewPersist_json("root", parents,false,null,null);

            return parents.ElementAt(0);
        }
    }

    public class Attributes {

        public string AttributeNme { get; set; }
        public string AttributeValue { get; set; }

    }

    public class attribAnddStyle {

        public Dictionary<string, string> style { get; set; }

        public List<Attributes> attr { get; set; }
    }
}
