using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class FLASH : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public FLASH(Location location, string modeCopyRAMToFlash, decimal locRoutineIdFlashing, string resultDeliveredBy, decimal copyFrame, decimal rncResult1, decimal rncResult2, decimal rncResult3) : base(location)
        {
            this.modeCopyRAMToFlash = modeCopyRAMToFlash;
            this.locRoutineIdFlashing = locRoutineIdFlashing;
            this.resultDeliveredBy = resultDeliveredBy;
            this.copyFrame = copyFrame;
            this.rncResult1 = rncResult1;
            this.rncResult2 = rncResult2;
            this.rncResult3 = rncResult3;
        }

        [Element(1, IsArgument = true, Comment = " modeCopyRAMToFlash           ")]
        public string modeCopyRAMToFlash { get; private set; }
        [Element(2, IsArgument = true, Comment = " locRoutineIdFlashing           ")]
        public decimal locRoutineIdFlashing { get; private set; }

        [Element(3, IsArgument = true, Comment = " resultDeliveredBy           ")]
        public string resultDeliveredBy { get; private set; }
        [Element(4, IsArgument = true, Comment = " copyFrame           ")]
        public decimal copyFrame { get; private set; }
        [Element(5, IsArgument = true, Comment = " rncResult1           ")]
        public decimal rncResult1 { get; private set; }

        [Element(6, IsArgument = true, Comment = " rncResult2           ")]
        public decimal rncResult2 { get; private set; }

        [Element(7, IsArgument = true, Comment = " rncResult3           ")]
        public decimal rncResult3 { get; private set; }

    }
}
