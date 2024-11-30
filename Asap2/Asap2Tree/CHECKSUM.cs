using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class CHECKSUM : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public CHECKSUM(Location location, string checksumName, decimal maxBlockSize, string externalFunction) : base(location)
        {
            this.checksumName = checksumName;
            this.maxBlockSize = maxBlockSize;
            this.externalFunction = externalFunction;
        }
        public CHECKSUM(Location location, decimal checksumType, decimal onlyAtActivePage, decimal locRoutineIdChecksum, string resultDeliveredBy, decimal rncResult) : base(location)
        {
            this.checksumType = checksumType;
            this.onlyAtActivePage = onlyAtActivePage;
            this.locRoutineIdChecksum = locRoutineIdChecksum;
            this.resultDeliveredBy = resultDeliveredBy;
            this.rncResult = rncResult;
        }

        [Element(1, IsArgument = true, Comment = " ChecksumName           ")]
        public string checksumName { get; private set; }
        [Element(2, IsArgument = true, Comment = " MaxBlockSize           ")]
        public decimal maxBlockSize { get; private set; }

        [Element(3, IsArgument = true, Comment = " ExternalFunction           ")]
        public string externalFunction { get; private set; }

        [Element(4, IsArgument = true, Comment = " checksumType           ")]
        public decimal checksumType { get; private set; }
        [Element(5, IsArgument = true, Comment = " onlyAtActivePage           ")]
        public decimal onlyAtActivePage { get; private set; }
        [Element(6, IsArgument = true, Comment = " locRoutineIdChecksum           ")]
        public decimal locRoutineIdChecksum { get; private set; }
        [Element(7, IsArgument = true, Comment = " resultDeliveredBy           ")]
        public string resultDeliveredBy { get; private set; }
        [Element(8, IsArgument = true, Comment = " rncResult           ")]
        public decimal rncResult { get; private set; }
    }
}
