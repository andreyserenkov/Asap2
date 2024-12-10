using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CAL_PARAM_GROUP : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>


        //        public CHECKSUM(Location location, string ChecksumName, string LongIdentifier, Type type) : base(location)
        //        {
        //        }

        public CAL_PARAM_GROUP(Location location) : base(location)
        {
        }

        public CAL_PARAM_GROUP(Location location, string s1, string s2, string s3, decimal d1, string s4, decimal d2, string s5, string s6, decimal d3, decimal d4, decimal d5, decimal d6) : this(location)
        {
            S1 = s1;
            S2 = s2;
            S3 = s3;
            D1 = d1;
            S4 = s4;
            D2 = d2;
            S5 = s5;
            S6 = s6;
            D3 = d3;
            D4 = d4;
            D5 = d5;
            D6 = d6;
        }

        public string S1 { get; }
        public string S2 { get; }
        public string S3 { get; }
        public decimal D1 { get; }
        public string S4 { get; }
        public decimal D2 { get; }
        public string S5 { get; }
        public string S6 { get; }
        public decimal D3 { get; }
        public decimal D4 { get; }
        public decimal D5 { get; }
        public decimal D6 { get; }
    }
}
