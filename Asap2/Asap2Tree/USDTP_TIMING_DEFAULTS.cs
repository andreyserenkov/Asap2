using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class USDTP_TIMING_DEFAULTS : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public USDTP_TIMING_DEFAULTS(Location location, decimal as1, decimal bs, decimal cr) : base(location)
        {
            this.as1 = as1;
            this.bs = bs;
            this.cr = cr;
        }
        public USDTP_TIMING_DEFAULTS(Location location, decimal as1, decimal bs, decimal cr, decimal p2Min, decimal p2Max, decimal p3Min, decimal p3Max) : base(location)
        {
            this.as1 = as1;
            this.bs = bs;
            this.cr = cr;
            this.p2Min = p2Min;
            this.p2Max = p2Max;
            this.p3Min = p3Min;
            this.p3Max = p3Max;
        }

        [Element(1, IsArgument = true)]
        public decimal as1 { get; private set; }
        [Element(2, IsArgument = true)]
        public decimal bs { get; private set; }
        [Element(3, IsArgument = true)]
        public decimal cr { get; private set; }
        [Element(4, IsArgument = true)]
        public decimal p2Min { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal p2Max { get; private set; }
        [Element(6, IsArgument = true)]
        public decimal p3Min { get; private set; }
        [Element(7, IsArgument = true)]
        public decimal p3Max { get; private set; }

    }
}
