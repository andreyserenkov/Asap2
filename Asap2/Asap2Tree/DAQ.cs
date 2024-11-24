using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DAQ : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DAQ(Location location) : base(location)
        {

        }
        public TIMESTAMP_SUPPORTED timestamp_supported { get; set; }
        public DAQ_LIST daq_list { get; set; }

        public List<EVENT> events = new List<EVENT>();

    }
}
