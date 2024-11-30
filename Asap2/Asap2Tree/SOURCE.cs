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
        public SOURCE(Location location, string daqName, decimal periodUnitCSE, decimal repetitionRate, string physicalLayer, string measurementMode, decimal blockModeLocalId, decimal maxNoOfSignals , decimal maxNoOfBytes, decimal canId, decimal rasterId) : base(location)
        {
            this.daqName = daqName;
            this.periodUnitCSE = periodUnitCSE;
            this.repetitionRate = repetitionRate;
            this.physicalLayer = physicalLayer;
            this.measurementMode = measurementMode;
            this.blockModeLocalId = blockModeLocalId;
            this.maxNoOfSignals = maxNoOfSignals;
            this.maxNoOfBytes = maxNoOfBytes;
            this.canId = canId;
            this.rasterId = rasterId;
        }
        public SOURCE(Location location, string daqName, decimal periodUnitCSE, decimal repetitionRate, decimal qpBlobVersion, decimal hardwareTrigger, string triggerType, decimal rasterPriority, string assigmentMeasurement, decimal indirectFlag, decimal displayTableMaxBytes, decimal addressDisplayTable, decimal addressDisplayTableValues, decimal maxSizeOfBypassReceiveTable, decimal addressOfBypassTable, decimal addressOfBypassTableValues, decimal worstCaseRasterTime, decimal maxReadVars, decimal maxWriteVars) : base(location)
        {
            this.daqName = daqName;
            this.periodUnitCSE = periodUnitCSE;
            this.repetitionRate = repetitionRate;
            this.qpBlobVersion = qpBlobVersion;
            this.hardwareTrigger = hardwareTrigger;
            this.triggerType = triggerType;
            this.rasterPriority = rasterPriority;
            this.assigmentMeasurement = assigmentMeasurement;
            this.indirectFlag = indirectFlag;
            this.displayTableMaxBytes = displayTableMaxBytes;
            this.addressDisplayTable = addressDisplayTable;
            this.addressDisplayTableValues = addressDisplayTableValues;
            this.maxSizeOfBypassReceiveTable = maxSizeOfBypassReceiveTable;
            this.addressOfBypassTable = addressOfBypassTable;
            this.addressOfBypassTableValues = addressOfBypassTableValues;
            this.worstCaseRasterTime = worstCaseRasterTime;
            this.maxReadVars = maxReadVars;
            this.maxWriteVars = maxWriteVars;
        }



        [Element(1, IsArgument = true)]
        public string daqName { get; private set; }

        [Element(2, IsArgument = true)]
        public decimal periodUnitCSE { get; private set; }

        [Element(3, IsArgument = true)]
        public decimal repetitionRate { get; private set; }

        [Element(4, IsArgument = false)]
        public QP_BLOB qp_blob { get; set; }
        public decimal qpBlobVersion { get; private set; }
        public decimal hardwareTrigger { get; private set; }
        public string triggerType { get; private set; }
        public decimal rasterPriority { get; private set; }
        public string assigmentMeasurement { get; private set; }
        public decimal indirectFlag { get; private set; }
        public decimal displayTableMaxBytes { get; private set; }
        public decimal addressDisplayTable { get; private set; }
        public decimal addressDisplayTableValues { get; private set; }
        public decimal maxSizeOfBypassReceiveTable { get; private set; }
        public decimal addressOfBypassTable { get; private set; }
        public decimal addressOfBypassTableValues { get; private set; }
        public decimal worstCaseRasterTime { get; private set; }
        public decimal maxReadVars { get; private set; }
        public decimal maxWriteVars { get; private set; }

        public string physicalLayer { get; private set; }
        public string measurementMode { get; private set; }
        public decimal blockModeLocalId { get; private set; }
        public decimal maxNoOfSignals { get; private set; }
        public decimal maxNoOfBytes { get; private set; }
        public decimal canId { get; private set; }
        public decimal rasterId { get; private set; }
    }
}
