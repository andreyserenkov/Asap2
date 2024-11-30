using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class COPY : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public COPY(Location location, string modeCopyFlashToRAM, decimal diagModeCopyFlashToRam) : base(location)
        {
            this.modeCopyFlashToRAM = modeCopyFlashToRAM;
            this.diagModeCopyFlashToRam = diagModeCopyFlashToRam;
        }

        [Element(1, IsArgument = true, Comment = " modeCopyFlashToRAM           ")]
        public string modeCopyFlashToRAM { get; private set; }
        [Element(2, IsArgument = true, Comment = " diagModeCopyFlashToRam           ")]
        public decimal diagModeCopyFlashToRam { get; private set; }

    }
}
