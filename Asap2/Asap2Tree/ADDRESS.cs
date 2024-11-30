using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class ADDRESS : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public ADDRESS(Location location, decimal canIdEcu, decimal canIdInca, decimal extendedAddressEcu, decimal extendedAddressInca) : base(location)
        {
            this.canIdEcu = canIdEcu;
            this.canIdInca = canIdInca;
            this.extendedAddressEcu = extendedAddressEcu;
            this.extendedAddressInca = extendedAddressInca;
        }

        [Element(1, IsArgument = true, Comment = " canIdEcu           ")]
        public decimal canIdEcu { get; private set; }
        [Element(2, IsArgument = true, Comment = " canIdInca           ")]
        public decimal canIdInca { get; private set; }

        [Element(3, IsArgument = true, Comment = " extendedAddressEcu           ")]
        public decimal extendedAddressEcu { get; private set; }

        [Element(4, IsArgument = true, Comment = " extendedAddressInca           ")]
        public decimal extendedAddressInca { get; private set; }

    }
}
