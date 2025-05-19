using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class TYPEDEF_MEASUREMENT : Asap2Base
    {
        public TYPEDEF_MEASUREMENT(Location location) : base(location)
        {
        }

        /// <summary>
        /// Characteristic types 
        /// </summary>

        public TYPEDEF_MEASUREMENT(Location location, string MeasurementByte, string something, string byteType, string compuMethod, decimal b1, decimal b2, decimal b3, decimal b4) : base(location)
        {
            this.MeasurementByte = MeasurementByte;
            this.Something = something;
        }

        [Element(1, IsArgument = true, Comment = " MeasurementByte           ")]
        public string MeasurementByte { get; private set; }
        [Element(1, IsArgument = true, Comment = " Something           ")]
        public string Something { get; private set; }

        public UInt64? bit_mask;
    }

}
