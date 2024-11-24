using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class XCP_ON_CAN : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>


        //        public CHECKSUM(Location location, string ChecksumName, string LongIdentifier, Type type) : base(location)
        //        {
        //        }

        public XCP_ON_CAN(Location location) : base(location)
        {
        }
    }
}