using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class EVENT : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public EVENT(Location location,string ms1, string ms2, decimal num1, string typ, decimal num2, decimal num3, decimal num4, decimal num5) : base(location)
        {
            this.ms1 = ms1;
            this.ms2 = ms2;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.typ = typ;
            this.num5 = num5;
        }

        public string ms1 { get; private set; }
        public string ms2 { get; private set; }
        public decimal num1 { get; private set; }
        public decimal num2 { get; private set; }
        public decimal num3 { get; private set; }
        public decimal num4 { get; private set; }
        public string typ { get; private set; }
        public decimal num5 { get; private set; }


    }
}
