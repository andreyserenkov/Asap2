using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    public class DEFAULT_EVENT_LIST : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DEFAULT_EVENT_LIST(Location location) : base(location)
        {

        }

        public List<decimal> events = new List<decimal>();

    }
}
