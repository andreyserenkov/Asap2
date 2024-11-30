using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class KWP_TIMING : Asap2Base
    {

        /// <summary>
        /// Characteristic types 
        /// </summary>

        public KWP_TIMING(Location location, decimal p1Max, decimal p2Min, decimal p2Max, decimal p3Min, decimal p3Max, decimal p4Min) : base(location)
        {
            this.p1Max = p1Max;
            this.p2Min = p2Min;
            this.p2Max = p2Max;
            this.p3Min = p3Min;
            this.p3Max = p3Max;
            this.p4Min = p4Min;
        }
        [Element(1, IsArgument = true)]
        public decimal p1Max { get; private set; }
        [Element(2, IsArgument = true)]
        public decimal p2Min { get; private set; }
        [Element(3, IsArgument = true)]
        public decimal p2Max { get; private set; }
        [Element(4, IsArgument = true)]
        public decimal p3Min { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal p3Max { get; private set; }
        [Element(6, IsArgument = true)]
        public decimal p4Min { get; private set; }

    }
}
