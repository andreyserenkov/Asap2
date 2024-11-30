using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class TransportProtocolVersion : Asap2Base
    {
        public TransportProtocolVersion(Location location, string item) : base(location)
        {
            this.item = item;
        }

        [Element(1, IsArgument = true, Name = "item")]
        public string item { get; private set; }
    }
}
