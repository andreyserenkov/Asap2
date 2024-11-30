using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DISTAB_CFG : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DISTAB_CFG(Location location, decimal distapType, decimal distapDataType, decimal byteOrder, decimal triggerSegmentAddr, decimal triggerConfiguration, string triggerMode) : base(location)
        {
            this.distapType = distapType;
            this.distapDataType = distapDataType;
            this.byteOrder = byteOrder;
            this.triggerSegmentAddr = triggerSegmentAddr;
            this.triggerConfiguration = triggerConfiguration;
            this.triggerMode = triggerMode;  
        }
        public decimal distapType { get; private set; }
        public decimal distapDataType { get; private set; }
        public decimal byteOrder { get; private set; }
        public decimal triggerSegmentAddr { get; private set; }
        public decimal triggerConfiguration { get; private set; }
        public string triggerMode { get; private set; }

    }
}
