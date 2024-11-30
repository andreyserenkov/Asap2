using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class DIAG_BAUD : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public DIAG_BAUD(Location location, decimal baudRate, decimal diagMode, decimal bdPara) : base(location)
        {
            this.baudRate = baudRate;
            this.diagMode = diagMode;
            this.bdPara = bdPara;
        }

        [Element(1, IsArgument = true, Comment = " baudRate           ")]
        public decimal baudRate { get; private set; }
        [Element(2, IsArgument = true, Comment = " diagMode           ")]
        public decimal diagMode { get; private set; }
        [Element(2, IsArgument = true, Comment = " bdPara           ")]
        public decimal bdPara { get; private set; }

    }
}
