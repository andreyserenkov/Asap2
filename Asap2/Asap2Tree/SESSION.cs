
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class SESSION : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public SESSION(Location location, string s1, decimal num1) : base(location)
        {
            this.s1 = s1;
            this.num1 = num1;
        }

        [Element(1, IsArgument = true)]
        public string s1 { get; private set; }
        [Element(2, IsArgument = true)]
        public decimal num1 { get; private set; }
    }
}

