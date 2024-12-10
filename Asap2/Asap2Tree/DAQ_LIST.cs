using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asap2
{
    [Base()]
    public class DAQ_LIST : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DAQ_LIST(Location location, decimal listNumber, string daq_list_type, decimal maxOdt, decimal maxOdtEntries, decimal firstPid, decimal? eventFixed = null) : base(location)
        {
            this.listNumber = listNumber;
            this.daq_list_type = daq_list_type;
            this.maxOdt = maxOdt;
            this.maxOdtEntries = maxOdtEntries;
            this.firstPid = firstPid;
            this.eventFixed = eventFixed;

        }
        [Element(1, IsArgument = true)]

        public decimal listNumber { get; private set; }
        [Element(2, IsArgument = true)]
        public string daq_list_type { get; private set; }

        [Element(3, IsArgument = true)]
        public decimal maxOdt { get; private set; }
        [Element(4, IsArgument = true)]
        public decimal maxOdtEntries { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal firstPid { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal? eventFixed { get; private set; }
    }
}
