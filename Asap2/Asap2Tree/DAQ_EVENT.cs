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

        [Element(1, IsArgument = true, Name = "EVENTID")]
        public decimal eventid { get; private set; }
    }
}
