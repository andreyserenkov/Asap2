using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CHECKSUM : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public CHECKSUM(Location location, string checksumName, decimal maxBlockSize, string externalFunction) : base(location)
        {
            this.checksumName = checksumName;
            this.maxBlockSize = maxBlockSize;
            this.externalFunction = externalFunction;
        }

        [Element(1, IsArgument = true, Comment = " ChecksumName           ")]
        public string checksumName { get; private set; }
        [Element(2, IsArgument = true, Comment = " MaxBlockSize           ")]
        public decimal maxBlockSize { get; private set; }

        [Element(3, IsArgument = true, Comment = " ExternalFunction           ")]
        public string externalFunction { get; private set; }

    }
}
