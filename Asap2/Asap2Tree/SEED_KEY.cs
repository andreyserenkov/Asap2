using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class SEED_KEY : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public SEED_KEY(Location location, string cal, string daq, string pgm) : base(location)
        {
            this.cal = cal;
            this.daq = daq;
            this.pgm = pgm;
        }
        [Element(1, IsArgument = true)]
        public string cal { get; private set; }
        [Element(2, IsArgument = true)]
        public string daq { get; private set; }
        [Element(3, IsArgument = true)]
        public string pgm { get; private set; }

    }
}
