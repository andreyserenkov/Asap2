using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class K_LINE : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public K_LINE(Location location, string ecuStimulationMode, decimal ecuAddressInKLine, decimal testerAddress) : base(location)
        {
            this.ecuStimulationMode = ecuStimulationMode;
            this.ecuAddressInKLine = ecuAddressInKLine;
            this.testerAddress = testerAddress;
        }

        [Element(1, IsArgument = true, Comment = " ecuStimulationMode           ")]
        public string ecuStimulationMode { get; private set; }
        [Element(2, IsArgument = true, Comment = " ecuAddressInKLine           ")]
        public decimal ecuAddressInKLine { get; private set; }

        [Element(3, IsArgument = true, Comment = " testerAddress           ")]
        public decimal testerAddress { get; private set; }

    }
}
