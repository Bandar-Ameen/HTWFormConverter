using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winToWeb
{
 public   class EventFromWeb
    {

        public string EventType { get; set; }
        public object EventData { get; set; }
    }

    public class fromurl
    {

        public string url { get; set; }
        public string type { get; set; }
    }
    public class design
    {


        public string body { get; set; }

        public List<fromurl> urls { get; set; }




    }
}
