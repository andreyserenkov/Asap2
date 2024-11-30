using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class ETK_CFG : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public ETK_CFG(Location location, decimal num1, decimal num2, decimal num3, decimal num4, decimal num5, decimal num6, decimal num7) : base(location)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.num5 = num5;
            this.num6 = num6;
            this.num7 = num7;
        }
        public decimal num1 { get; private set; }
        public decimal num2 { get; private set; }
        public decimal num3 { get; private set; }
        public decimal num4 { get; private set; }
        public decimal num5 { get; private set; }
        public decimal num6 { get; private set; }
        public decimal num7 { get; private set; }

    }
}
