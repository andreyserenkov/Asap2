using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class TP_BLOB : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public TP_BLOB(Location location, UInt64 bypassVersion, UInt64 blobVersion) : base(location)
        {
            this.byPassVersion = bypassVersion;
            this.blobVersion = blobVersion;
        }

        public TP_BLOB(Location location, UInt64 cppVersion, UInt64 blobVersion, UInt64 canMessageIdTransmit, UInt64 canMessageIdReceive, UInt64 logicalccpAddress, decimal byteOrder) : base(location)
        {
            this.cppVersion = cppVersion;
            this.blobVersion = blobVersion;
            this.canMessageIdTransmit = canMessageIdTransmit;
            this.canMessageIdReceive = canMessageIdReceive;
            this.logicalccpAddress = logicalccpAddress;
            this.byteOrder = byteOrder;
        }

        [Element(1, IsArgument = true, Comment = " Num1           ")]
        public UInt64 byPassVersion { get; private set; }

        [Element(2, IsArgument = true, Comment = "CCP Version, High Byte: Version Low Byte : subversion (dec.)")]
        public UInt64 cppVersion { get; private set; }

        [Element(3, IsArgument = true, Comment = "Blob-Version, High Byte: Version Low Byte : subversion (dec.)")]
        public UInt64 blobVersion { get; private set; }
        
        [Element(4, IsArgument = true, Comment = "CAN-Message ID for 'Transmitting to ECU (CRM)' Bit31 = 1: extended Identifier Bit31 = 0: standard Identifier")]
        public UInt64 canMessageIdTransmit { get; private set; }
        
        [Element(5, IsArgument = true, Comment = "CAN-Message ID for 'Receiving from ECU (DTM)' Bit31 = 1: extended Identifier Bit31 = 0: standard Identifier")]
        public UInt64 canMessageIdReceive { get; private set; }
        
        [Element(6, IsArgument = true, Comment = "Logical CCP-Address of the (station address)")]
        public UInt64 logicalccpAddress { get; private set; }
        
        [Element(7, IsArgument = true, Comment = " Byte order of Multiple-byte-items 1 = high Byte first, 2 = low byte first")]
        public decimal byteOrder { get; private set; }

    }
}
