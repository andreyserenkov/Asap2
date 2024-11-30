using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class TIME_DEF : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public TIME_DEF(Location location) : base(location)
        {

        }

        public List<KWP_TIMING> kwp_timing = new List<KWP_TIMING>();
        public List<USDTP_TIMING> usdtp_timing = new List<USDTP_TIMING>();

    }
}
