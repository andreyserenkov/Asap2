using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class NETWORK_LIMITS : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public NETWORK_LIMITS(Location location, decimal wftMax, decimal xdlMax) : base(location)
        {
            this.wftMax = wftMax;
            this.xdlMax = xdlMax;
        }

        [Element(1, IsArgument = true, Comment = " wftMax           ")]
        public decimal wftMax { get; private set; }
        [Element(2, IsArgument = true, Comment = " xdlMax           ")]
        public decimal xdlMax { get; private set; }

    }
}
