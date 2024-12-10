using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DAQ_EVENT : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>


        //        public CHECKSUM(Location location, string ChecksumName, string LongIdentifier, Type type) : base(location)
        //        {
        //        }

        public DAQ_EVENT(Location location, decimal eventid) : base(location)
        {
            this.eventid = eventid;
        }

        public DAQ_EVENT(Location location, string eventType) : base(location)
        {
            this.eventType = eventType;
        }

        [Element(1, IsArgument = true, Name = "EVENTID")]
        public decimal eventid { get; private set; }

        [Element(3, IsArgument = true, Name = "EVENT_TYPE")]
        public string eventType { get; private set; }

        public List<EVENT> events = new List<EVENT>();
        public DEFAULT_EVENT_LIST default_event_list { get; set; }
    }
}
