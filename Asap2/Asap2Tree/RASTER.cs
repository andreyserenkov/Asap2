
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class RASTER : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public RASTER(Location location, string eventName, string eventShortName, decimal eventNumber, decimal scalingUnitCSE, decimal sampleRate) : base(location)
        {
            this.eventName = eventName;
            this.eventShortName = eventShortName;
            this.eventNumber = eventNumber;
            this.scalingUnitCSE = scalingUnitCSE;
            this.sampleRate = sampleRate;
        }

        [Element(1, IsArgument = true)]
        public string eventName { get; private set; }
        [Element(2, IsArgument = true)]
        public string eventShortName { get; private set; }
        [Element(3, IsArgument = true)]
        public decimal eventNumber { get; private set; }
        [Element(4, IsArgument = true)]
        public decimal scalingUnitCSE { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal sampleRate { get; private set; }
    }
}

