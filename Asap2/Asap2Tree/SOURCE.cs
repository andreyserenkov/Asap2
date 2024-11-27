using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class SOURCE : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public SOURCE(Location location, string daqName, decimal periodUnitCSE, decimal repetitionRate) : base(location)
        {
            this.daqName = daqName;
            this.periodUnitCSE = periodUnitCSE;
            this.repetitionRate = repetitionRate;
        }
        [Element(1, IsArgument = true)]
        public string daqName { get; private set; }

        [Element(2, IsArgument = true)]
        public decimal periodUnitCSE { get; private set; }

        [Element(3, IsArgument = true)]
        public decimal repetitionRate { get; private set; }

        [Element(4, IsArgument = false)]
        public QP_BLOB qp_blob { get; set; }

    }
}
