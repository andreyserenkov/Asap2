using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    // TODO: Implement saving attributes
    [Base()]
    public class PROTOCOL_LAYER : Asap2Base
    {
        public PROTOCOL_LAYER(Location location) : base(location)
        {
        }

        public PROTOCOL_LAYER(Location location, decimal d1, decimal d2, decimal d3, decimal d4, decimal d5, decimal d6, decimal d7, decimal d8, decimal d9, decimal d10, List<string> iDENTIFIER_list, string SEED_AND_KEY_EXTERNAL_FUNCTION = null) : this(location)
        {
            this.D1 = d1;
            this.D2 = d2;
            this.D3 = d3;
            this.D4 = d4;
            this.D5 = d5;
            this.D6 = d6;
            this.D7 = d7;
            this.D8 = d8;
            this.D9 = d9;
            this.D10 = d10;
            this.IDENTIFIER_list = iDENTIFIER_list;
            this.SEED_AND_KEY_EXTERNAL_FUNCTION = SEED_AND_KEY_EXTERNAL_FUNCTION;
        }

        public List<string> optional_cmd = new List<string>();

        public decimal D1 { get; }
        public decimal D2 { get; }
        public decimal D3 { get; }
        public decimal D4 { get; }
        public decimal D5 { get; }
        public decimal D6 { get; }
        public decimal D7 { get; }
        public decimal D8 { get; }
        public decimal D9 { get; }
        public decimal D10 { get; }
        public string SEED_AND_KEY_EXTERNAL_FUNCTION { get; private set; }
        public List<string> IDENTIFIER_list { get; }
    }
}
