using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DEFINED_PAGES : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DEFINED_PAGES(Location location, UInt64 pageNumber, string pageName, UInt64 addressExt, UInt64 baseAddress, UInt64 pageLength, List<string> identifiers) : base(location)
        {
            this.pageNumber = pageNumber;
            this.pageName = pageName;
            this.addressExt = addressExt;
            this.baseAddress = baseAddress;
            this.pageLength = pageLength;
            this.identifiers = identifiers;
        }
        public UInt64 pageNumber { get; set; }
        public string pageName { get; set; }

        public UInt64 addressExt { get; set; }
        public UInt64 baseAddress { get; set; }
        public UInt64 pageLength { get; set; }

        public IList<string> identifiers = new List<string>();
    }
}
