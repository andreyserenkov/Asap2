using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class PAGE_SWITCH : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public PAGE_SWITCH(Location location, string pageSwitch, decimal s, decimal g, decimal p1, decimal p2) : base(location)
        {
            this.pageSwitch = pageSwitch;
            this.s = s;
            this.g = g;
            this.p1 = p1;
            this.p2 = p2;
        }
        
        public string pageSwitch { get; private set; }
        public decimal s { get; private set; }
        public decimal g { get; private set; }
        public decimal p1 { get; private set; }
        public decimal p2 { get; private set; }


    }
}
