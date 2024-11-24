using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class PGM : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public PGM(Location location) : base(location)
        {

        }

        public List<SECTOR> sector = new List<SECTOR>();
    }
}
