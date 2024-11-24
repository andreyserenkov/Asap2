using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class SEGMENT : Asap2Base
    {
        public SEGMENT(Location location, decimal num1, decimal num2, decimal num3, decimal num4, decimal num5) : base(location)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.num5 = num5;

        }
        [Element(1, IsArgument = true)]
        public decimal num1;
        [Element(2, IsArgument = true)]
        public decimal num2;
        [Element(3, IsArgument = true)]
        public decimal num3;
        [Element(4, IsArgument = true)]
        public decimal num4;
        [Element(5, IsArgument = true)]
        public decimal num5;
        [Element(6, IsArgument = false, Name = "CHECKSUM", Comment = "Checksum for SEGMENT")]
        public CHECKSUM checksum;
        [Element(7, IsArgument = false, Name = "PAGE", Comment = "Page for SEGMENT")]
        public PAGE page;
        

    }
}
