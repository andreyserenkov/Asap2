using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class KP_BLOB : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public KP_BLOB(Location location,string identNum1, string num1, string identNum2, string num2) : base(location)
        {
            var r = new Dictionary<string, string>();
            r[identNum1] = num1;
            r[identNum2] = num2;
            this.bufferOffset = r["BUFFER_OFFSET"];
            this.sourceId = r["SOURCE_ID"];
        }

        [Element(1, IsArgument = true)]
        public string bufferOffset { get; private set; }
        [Element(2, IsArgument = true)]
        public string sourceId { get; private set; }

    }
}
