using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CAN : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public CAN(Location location, UInt64 baudRate, UInt64 sampleRate, UInt64 samplesPerBit, UInt64 btlCycles, UInt64 sjw, UInt64 syncEdge) : base(location)
        {
            this.baudRate = baudRate;
            this.sampleRate = sampleRate;
            this.samplesPerBit = samplesPerBit;
            this.btlCycles = btlCycles;
            this.sjw = sjw;
            this.syncEdge = syncEdge;
        }

        [Element(1, IsArgument = true, Comment = " baudRate           ")]
        public UInt64 baudRate { get; private set; }
        [Element(2, IsArgument = true, Comment = " sampleRate           ")]
        public UInt64 sampleRate { get; private set; }

        [Element(3, IsArgument = true, Comment = " samplesPerBit           ")]
        public UInt64 samplesPerBit { get; private set; }
        [Element(4, IsArgument = true, Comment = " btlCycles           ")]
        public UInt64 btlCycles { get; private set; }
        [Element(5, IsArgument = true, Comment = " sjw           ")]
        public UInt64 sjw { get; private set; }

        [Element(6, IsArgument = true, Comment = " syncEdge           ")]
        public UInt64 syncEdge { get; private set; }

        public ADDRESS address { get; set; }
        public NETWORK_LIMITS network_limits { get; set; }
        public TransportProtocolVersion transportProtocolVersion { get; set; }

    }
}
