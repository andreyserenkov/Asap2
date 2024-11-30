using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class USDTP_TIMING : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public USDTP_TIMING(Location location, decimal as1, decimal bs, decimal cr) : base(location)
        {
            this.as1 = as1;
            this.bs = bs;
            this.cr = cr;
        }

        [Element(1, IsArgument = true)]
        public decimal as1 { get; private set; }
        [Element(2, IsArgument = true)]
        public decimal bs { get; private set; }
        [Element(3, IsArgument = true)]
        public decimal cr { get; private set; }

    }
}
