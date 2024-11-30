using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DATA_ACCESS : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DATA_ACCESS(Location location, UInt64 flashAddress, UInt64 ramAddress, UInt64 dataRead, UInt64 codeVerify, UInt64 codeRead, UInt64 loadMode) : base(location)
        {
            this.flashAddress = flashAddress;
            this.ramAddress = ramAddress;
            this.dataRead = dataRead;
            this.codeVerify = codeVerify;
            this.codeRead = codeRead;
            this.loadMode = loadMode;
        }

        [Element(1, IsArgument = true, Comment = " flashAddress           ")]
        public UInt64 flashAddress { get; private set; }
        [Element(2, IsArgument = true, Comment = " ramAddress           ")]
        public UInt64 ramAddress { get; private set; }

        [Element(3, IsArgument = true, Comment = " dataRead           ")]
        public UInt64 dataRead { get; private set; }
        [Element(4, IsArgument = true, Comment = " codeVerify           ")]
        public UInt64 codeVerify { get; private set; }
        [Element(5, IsArgument = true, Comment = " codeRead           ")]
        public UInt64 codeRead { get; private set; }

        [Element(6, IsArgument = true, Comment = " loadMode           ")]
        public UInt64 loadMode { get; private set; }

        public ADDRESS address { get; set; }
        public NETWORK_LIMITS network_limits { get; set; }

    }
}
