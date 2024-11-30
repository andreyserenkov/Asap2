using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CHECKSUM_PARAM : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public CHECKSUM_PARAM(Location location, decimal algorythm, decimal limit, string checksumCalculation) : base(location)
        {
            this.algorythm = algorythm;
            this.limit = limit;
            this.checksumCalculation = checksumCalculation;
        }

        [Element(1, IsArgument = true, Comment = " Algorythm           ")]
        public decimal algorythm { get; private set; }
        [Element(2, IsArgument = true, Comment = " Limit           ")]
        public decimal limit { get; private set; }

        [Element(3, IsArgument = true, Comment = " ChecksumCalculation           ")]
        public string checksumCalculation { get; private set; }

    }
}
