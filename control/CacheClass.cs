using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace winToWeb.control
{
   

    public class CacheClass
    {

        private static Cache _chach = null;


        private static Cache cach
        {
            get
            {
                if (_chach == null)
                    _chach = (System.Web.HttpContext.Current == null) ? System.Web.HttpRuntime.Cache : System.Web.HttpContext.Current.Cache;

                return _chach;
            }
            set
            {

                _chach = value;


            }
        }


        public static object update(string key, object value)
        {
            cach.Remove(key);
            cach.Insert(key, value);
            return cach.Get(key);
        }
        public static void Remov(string key) {
            cach.Remove(key);
        }
        public static object get(string key)
        {

            return cach.Get(key);
        }
        public static void remove_alldata()
        {
            /*  var h = cach.GetEnumerator().Entry;
              foreach (var k in ) {


              }*/
            //  return cach.(key);
        }
        public static void add(string key, object value)
        {
            // CacheItemPriority priorty = CacheItemPriority.NotRemovable;
            // var expire = TimeSpan.FromMinutes(10);

            // cach.Insert(key,value,null,DateTime.MaxValue,expire,null);

            cach.Insert(key, value,null,DateTime.Now.AddHours(1),TimeSpan.Zero);

        }

        private static void gg(string key, object value, CacheItemRemovedReason reason)
        {
            
        }

        public static void remove(string key)
        {
            cach.Remove(key);

        }
    }
}
