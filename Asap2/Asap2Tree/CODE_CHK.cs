using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CODE_CHK : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public CODE_CHK(Location location, decimal prgData, decimal prgDataLength, decimal prgExram, decimal prgExramLength, string errorBehaviour) : base(location)
        {
            this.prgData = prgData;
            this.prgDataLength = prgDataLength;
            this.prgExram = prgExram;
            this.prgExramLength = prgExramLength;
            this.errorBehaviour = errorBehaviour;  
        }
        public decimal prgData { get; private set; }
        public decimal prgDataLength { get; private set; }
        public decimal prgExram { get; private set; }
        public decimal prgExramLength { get; private set; }
        public string errorBehaviour { get; private set; }

    }
}
