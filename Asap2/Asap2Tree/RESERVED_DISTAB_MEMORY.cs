using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Asap2
{
    [Base()]
    public class RESERVED_DISTAB_MEMORY : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public RESERVED_DISTAB_MEMORY(Location location, decimal startAddr, decimal length, string loc, string application, string usage, decimal mirror1, decimal mirror2, decimal mirror3, decimal mirror4, decimal mirror5) : base(location)
        {
            this.startAddr = startAddr;
            this.length = length;
            this.loc = loc;
            this.application = application;
            this.usage = usage;
            this.mirror1 = mirror1;
            this.mirror2 = mirror2;
            this.mirror3 = mirror3;
            this.mirror4 = mirror4;
            this.mirror5 = mirror5;
        }

        public decimal startAddr { get; private set; }
        public decimal length { get; private set; }
        public string loc { get; private set; }
        public string application { get; private set; }
        public string usage { get; private set; }
        public decimal mirror1 { get; private set; }
        public decimal mirror2 { get; private set; }
        public decimal mirror3 { get; private set; }
        public decimal mirror4 { get; private set; }
        public decimal mirror5 { get; private set; }

    }
}
