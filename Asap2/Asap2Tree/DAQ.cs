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

        public DAQ(Location location, string s, decimal d1, decimal d2, decimal d3, List<string> iDENTIFIER_list1, decimal d4, List<string> iDENTIFIER_list2) : this(location)
        {
            S = s;
            D1 = d1;
            D2 = d2;
            D3 = d3;
            IDENTIFIER_list1 = iDENTIFIER_list1;
            D4 = d4;
            IDENTIFIER_list2 = iDENTIFIER_list2;
        }

        public TIMESTAMP_SUPPORTED timestamp_supported { get; set; }
        public DAQ_LIST daq_list { get; set; }
        public string S { get; }
        public decimal D1 { get; }
        public decimal D2 { get; }
        public decimal D3 { get; }
        public List<string> IDENTIFIER_list1 { get; }
        public decimal D4 { get; }
        public List<string> IDENTIFIER_list2 { get; }

        public List<EVENT> events = new List<EVENT>();

    }
}
